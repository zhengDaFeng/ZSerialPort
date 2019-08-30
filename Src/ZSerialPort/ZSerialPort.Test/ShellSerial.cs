using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZSerialPort.Test
{
    class ShellSerial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************先写后读方法测试开始********************");
            Test_WriteReadTo();
        }

        static void Test_WriteReadTo()
        {
            ZSerialPortParams zSerialPortParams1 = new ZSerialPortParams("com1", 9600);
            ZSerialPort zSerialPort1 = new ZSerialPort();
            zSerialPort1.ZSerialPortReceiveEvent += (sender, e) =>
            {
                //string result = System.Text.Encoding.Default.GetString(e.ReceivedBytes);
                //Console.Write("COM1 RX: " + result);
            };
            zSerialPort1.Open(zSerialPortParams1);
            Console.WriteLine("打开COM1");
            ZSerialPortParams zSerialPortParams2 = new ZSerialPortParams("com2", 9600);
            ZSerialPort zSerialPort2 = new ZSerialPort();
            zSerialPort2.ZSerialPortReceiveEvent += (sender, e) =>
            {
                string result = System.Text.Encoding.Default.GetString(e.ReceivedBytes);
                //Console.Write("COM2 RX: " + result);
                //Console.Write("COM2 TX: " + result);
                System.Threading.Thread.Sleep(10);
                zSerialPort2.Write(result);
            };
            zSerialPort2.Open(zSerialPortParams2);
            Console.WriteLine("打开COM2");
            Console.WriteLine();

            System.Threading.Thread.Sleep(1000);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(DateTime.Now.ToString("HH:mm:ss.fff") + " COM1 TX: F1" + System.Environment.NewLine);
                var result = zSerialPort1.WriteReadTo("F1\r\n", "\r\n", 1000);
                Console.Write(DateTime.Now.ToString("HH:mm:ss.fff") + " COM1 RX: " + result);
                Console.WriteLine();
            }

            zSerialPort1.Close();
            zSerialPort2.Close();
            Console.WriteLine("关闭COM1");
            Console.WriteLine("关闭COM2");
            Console.ReadLine();
        }
    }
}
