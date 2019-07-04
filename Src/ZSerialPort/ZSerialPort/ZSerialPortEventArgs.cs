using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZSerialPort
{
    /// <summary>
    /// 自定义串口事件委托函数
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ZSerialPortEventHandler(Object sender, ZSerialPortEventArgs e);

    /// <summary>
    /// 自定义串口传递参数
    /// </summary>
    public class ZSerialPortEventArgs : EventArgs
    {
        public bool isOpend = false;
        public Byte[] receivedBytes = null;
    }
}
