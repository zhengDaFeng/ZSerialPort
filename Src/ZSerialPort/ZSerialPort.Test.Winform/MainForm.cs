using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZSerialPort;

namespace ZSerialPort.Test.Winform
{
    public interface IView
    {
        void SetController(IController controller);
        //Open serial port event
        void OpenComEvent(Object sender, ZSerialPortEventArgs e);
        //Close serial port event
        void CloseComEvent(Object sender, ZSerialPortEventArgs e);
        //Serial port receive data event
        void ComReceiveDataEvent(Object sender, ZSerialPortEventArgs e);
    }
    public partial class MainForm : Form, IView
    {
        IController _controller;

        public MainForm()
        {
            InitializeComponent();

            ovalshape1.CenterColor = System.Drawing.Color.White;
            ovalshape1.SurroundColor = System.Drawing.Color.Green;
            ovalshape1.DarkColor = System.Drawing.Color.Gray;
            ovalshape1.TwinkleTime = 10;
            ovalshape1.TwinkleTime = 0;
        }

        public void CloseComEvent(object sender, ZSerialPortEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ComReceiveDataEvent(object sender, ZSerialPortEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OpenComEvent(object sender, ZSerialPortEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void SetController(IController controller)
        {
            this._controller = controller;
        }
    }
}
