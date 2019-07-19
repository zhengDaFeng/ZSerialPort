using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZSerialPort;

namespace ZSerialPort.Test.Winform
{
    public class IController
    {
        ZSerialPort _model;
        IView _view;

        System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        string _autoSendData = "";

        public IController(IView view)
        {
            _model = new ZSerialPort();
            _model.ZSerialPortCloseEvent += new ZSerialPortEventHandler(view.CloseComEvent);
            _model.ZSerialPortOpenEvent += new ZSerialPortEventHandler(view.OpenComEvent);
            _model.ZSerialPortReceiveEvent += new ZSerialPortEventHandler(view.ComReceiveDataEvent);
            this._view = view;
            view.SetController(this);

            _timer.Tick += _timer_Tick;
        }

        public void Close()
        {
            _model.Close();
        }

        public void Open(string portName, string baudRate, string dataBits, string stopBits, string parity)
        {
            int.TryParse(baudRate, out int br);
            int.TryParse(dataBits, out int db);
            System.IO.Ports.StopBits sb = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), stopBits);
            System.IO.Ports.Parity p = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), parity);
            ZSerialPortParams @params = new ZSerialPortParams(portName, br, p, db, sb);
            _model.Open(@params);
        }

        public string[] GetPortNames()
        {
            return _model.GetPortNames();
        }

        public bool Send(string data)
        {
            return _model.Write(data);
        }

        public void AutoSend(bool enabled, string data, int interval)
        {
            _autoSendData = data;

            _timer.Interval = interval;
            _timer.Enabled = enabled;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            Send(_autoSendData);
        }
    }
}
