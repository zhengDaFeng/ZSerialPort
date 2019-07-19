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

        public IController(IView view)
        {
            this._view = view;
            view.SetController(this);
            //_model.ZSerialPortCloseEvent += new ZSerialPortEventHandler(view.CloseComEvent);
            //_model.ZSerialPortOpenEvent += new ZSerialPortEventHandler(view.OpenComEvent);
            //_model.ZSerialPortReceiveEvent += new ZSerialPortEventHandler(view.ComReceiveDataEvent);
        }
    }
}
