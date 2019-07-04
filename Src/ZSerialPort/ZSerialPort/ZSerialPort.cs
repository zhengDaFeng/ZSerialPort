using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace ZSerialPort
{
    public class ZSerialPort
    {
        /// <summary>
        /// 自定义串口接收数据事件
        /// </summary>
        public event ZSerialPortEventHandler ZSerialPortReceiveEvent = null;
        /// <summary>
        /// 自定义串口打开事件
        /// </summary>
        public event ZSerialPortEventHandler ZSerialPortOpenEvent = null;
        /// <summary>
        /// 自定义串口关闭事件
        /// </summary>
        public event ZSerialPortEventHandler ZSerialPortCloseEvent = null;

        SerialPort _serialPort;
        
        public ZSerialPort(ZSerialPortParams @params)
        {
            _serialPort = new SerialPort(@params.PortName, @params.BaudRate, @params.Parity, @params.DataBits, @params.StopBits);
        }
        
        /// <summary>
        /// 关闭端口连接，将 System.IO.Ports.SerialPort.IsOpen 属性设置为 false，并释放内部 System.IO.Stream 对象
        /// </summary>
        public void Close()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                _serialPort.DataReceived -= SerialPort_DataReceived;

                if (ZSerialPortCloseEvent != null)
                {
                    ZSerialPortEventArgs args = new ZSerialPortEventArgs();
                    args.isOpend = false;
                    ZSerialPortCloseEvent.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// 打开一个新的串行端口连接。
        /// </summary>
        public void Open()
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
                _serialPort.DataReceived += SerialPort_DataReceived;
                
                if (ZSerialPortOpenEvent != null)
                {
                    ZSerialPortEventArgs args = new ZSerialPortEventArgs();
                    args.isOpend = true;
                    ZSerialPortOpenEvent.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// 表示将处理 System.IO.Ports.SerialPort 对象的数据接收事件的方法。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (e.EventType == SerialData.Eof)
                return;

            Int32 len = _serialPort.BytesToRead;
            Byte[] data = new Byte[len];
            Int32 read = _serialPort.Read(data, 0, len);
            if (read > 0)
            {
                ZSerialPortEventArgs args = new ZSerialPortEventArgs();
                args.receivedBytes = data;
                if (ZSerialPortReceiveEvent != null)
                {
                    ZSerialPortReceiveEvent.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// 将指定的字符串写入串行端口。
        /// </summary>
        /// <param name="data">输出字符串。</param>
        /// <returns>操作成功与否</returns>
        public bool Write(string data)
        {
            if (!_serialPort.IsOpen)
            {
                return false;
            }

            try
            {
                _serialPort.Write(data);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 使用缓冲区的数据将指定数量的字节写入串行端口。
        /// </summary>
        /// <param name="data">包含要写入端口的数据的字节数组。</param>
        /// <returns>操作成功与否</returns>
        public bool Write(Byte[] data)
        {
            if (!_serialPort.IsOpen)
            {
                return false;
            }

            try
            {
                _serialPort.Write(data, 0, data.Length);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 将指定的字符串和 System.IO.Ports.SerialPort.NewLine 值写入输出缓冲区。
        /// </summary>
        /// <param name="data">写入输出缓冲区的字符串。</param>
        public void WriteLine(string data)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.WriteLine(data);
            }
        }

        /// <summary>
        /// 一直读取到输入缓冲区中的 System.IO.Ports.SerialPort.NewLine 值。
        /// </summary>
        /// <param name="data">输入缓冲区中直到首次出现 System.IO.Ports.SerialPort.NewLine 值的内容。</param>
        public void ReadLine(ref string data)
        {
            if (_serialPort.IsOpen)
            {
                data = _serialPort.ReadLine();
            }
        }

        /// <summary>
        /// 获取当前计算机的串行端口名称数组。
        /// </summary>
        /// <returns>当前计算机的串行端口名称数组。</returns>
        public static string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }
    }
}
