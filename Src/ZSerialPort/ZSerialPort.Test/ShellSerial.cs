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
            ZSerialPortParams zSerialPortParams = new ZSerialPortParams("com2", 9600);
            ZSerialPort zSerialPort = new ZSerialPort(zSerialPortParams);
            zSerialPort.ZSerialPortReceiveEvent += (sender, e) =>
            {
                string result = System.Text.Encoding.Default.GetString(e.receivedBytes);
                Console.WriteLine("Received data: " + result);
            };
            zSerialPort.Open();
            while(true)
            {
                string data = Console.ReadLine();
                if (data == "quit")
                {
                    break;
                }
                zSerialPort.Write(data + Environment.NewLine);
                Console.WriteLine("Sent data: " + data);
            }
            zSerialPort.Close();
        }
    }
}
