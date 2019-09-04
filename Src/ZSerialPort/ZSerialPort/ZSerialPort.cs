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

        Object _dataReceivedLock = new Object();

        public ZSerialPort()
        {
            _serialPort = new SerialPort();
        }

        /// <summary>
        /// 关闭端口连接，将 System.IO.Ports.SerialPort.IsOpen 属性设置为 false，并释放内部 System.IO.Stream 对象
        /// </summary>
        public void Close()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.DataReceived -= SerialPort_DataReceived;
                try
                {
                    _serialPort.Close();
                }
                catch (Exception)
                {
                    throw;
                }

                if (ZSerialPortCloseEvent != null)
                {
                    ZSerialPortEventArgs args = new ZSerialPortEventArgs();
                    args.IsOpend = false;
                    ZSerialPortCloseEvent.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// 打开一个新的串行端口连接。
        /// </summary>
        public void Open(ZSerialPortParams @params)
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.PortName = @params.PortName;
                _serialPort.BaudRate = @params.BaudRate;
                _serialPort.Parity = @params.Parity;
                _serialPort.DataBits = @params.DataBits;
                _serialPort.StopBits = @params.StopBits;
                _serialPort.DataReceived += SerialPort_DataReceived;
                try
                {
                    _serialPort.Open();
                }
                catch (Exception)
                {
                    throw;
                }
                
                if (ZSerialPortOpenEvent != null)
                {
                    ZSerialPortEventArgs args = new ZSerialPortEventArgs();
                    args.IsOpend = true;
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

            //Thread Safety
            lock (_dataReceivedLock)
            {
                Int32 len = _serialPort.BytesToRead;
                Byte[] data = new Byte[len];
                try
                {
                    _serialPort.Read(data, 0, len);
                }
                catch (Exception)
                {
                    throw;
                }
                if (ZSerialPortReceiveEvent != null)
                {
                    ZSerialPortEventArgs args = new ZSerialPortEventArgs();
                    args.ReceivedBytes = data;
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
        /// 发送指定字符串，并在超时时间内一直读取直到缓冲区出现指定的字符串
        /// </summary>
        /// <param name="data">发送的字符串</param>
        /// <param name="key">读取结束标志</param>
        /// <param name="timeout">超时时间</param>
        /// <returns>读取的完整字符串</returns>
        public string WriteReadTo(string data, string key, int timeout)
        {
            var result = "";
            byte[] buffer  = new byte[64];

            if (!_serialPort.IsOpen)
            {
                return "Port is closed!";
            }

            try
            {
                _serialPort.DataReceived -= SerialPort_DataReceived;

                // 设置读超时
                _serialPort.ReadTimeout = timeout;
                // 写
                _serialPort.Write(data);
                // 读
                result = _serialPort.ReadTo(key);
                result += key;

                _serialPort.DataReceived += SerialPort_DataReceived;

                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public byte[] WriteReadTo(byte[] data, byte[] key, int timeout)
        {
            var result = "";
            byte[] buffer = new byte[64];

            if (!_serialPort.IsOpen)
            {
                return Encoding.Default.GetBytes("Port is closed!");
            }

            try
            {
                _serialPort.DataReceived -= SerialPort_DataReceived;

                // 设置读超时
                _serialPort.ReadTimeout = timeout;
                // 写
                _serialPort.Write(data, 0, data.Length);
                // 读
                result = _serialPort.ReadTo(Encoding.Default.GetString(key));
                result += key;

                _serialPort.DataReceived += SerialPort_DataReceived;

                return Encoding.Default.GetBytes(result);
            }
            catch (Exception ex)
            {
                return Encoding.Default.GetBytes(ex.Message);
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
