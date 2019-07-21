using System;
using System.IO.Ports;

namespace ZSerialPort
{
    /// <summary>
    /// 用于存储端口名称、波特率、奇偶校验位、数据位和停止位，供 ZSerialPort 实例化使用。
    /// </summary>
    public class ZSerialPortParams
    {
        private readonly String _portName;
        private readonly Int32 _baudRate;
        private readonly Int32 _dataBits;
        private readonly StopBits _stopBits;
        private readonly Parity _parity;

        /// <summary>
        /// Instantiates.
        /// </summary>
        /// <param name="portName">the port name</param>
        /// <param name="baudRate">the baud rate</param>
        public ZSerialPortParams(String portName, Int32 baudRate)
            : this(portName, baudRate, Parity.None, 8, StopBits.One)
        { }

        /// <summary>
        /// Instantiates.
        /// </summary>
        /// <param name="portName">the port name</param>
        /// <param name="baudRate">the baud rate</param>
        /// <param name="parity">the <see cref="Parity"/></param>
        /// <param name="dataBits">the data bits</param>
        /// <param name="stopBits">the <see cref="StopBits"/></param>
        public ZSerialPortParams(String portName, Int32 baudRate,
            Parity parity, Int32 dataBits, StopBits stopBits)
        {
            _portName = portName;
            _baudRate = baudRate;
            _parity = parity;
            _dataBits = dataBits;
            _stopBits = stopBits;
        }

        public ZSerialPortParams(String portName, String baudRate)
            : this(portName, baudRate, "8", "One", "None")
        { }

        public ZSerialPortParams(String portName, String baudRate,
            String dataBits, String stopBits, String parity)
        {
            _portName = portName;
            if (!int.TryParse(baudRate, out _baudRate))
            {
                throw new Exception("Param baudRate cannot parse to int!");
            }
            if (!int.TryParse(dataBits, out _dataBits))
            {
                throw new Exception("Param dataBits cannot parse to int!");
            }
            if (!Enum.TryParse<StopBits>(stopBits, out _stopBits))
            {
                throw new Exception("Param stopBits cannot parse to enum!");
            }
            if (!Enum.TryParse<Parity>(parity, out _parity))
            {
                throw new Exception("Param parity cannot parse to enum!");
            }
        }

        /// <summary>
        /// Gets the serial port name.
        /// </summary>
        public String PortName
        {
            get { return _portName; }
        }

        /// <summary>
        /// Gets the baud rate.
        /// </summary>
        public Int32 BaudRate
        {
            get { return _baudRate; }
        }

        /// <summary>
        /// Gets the parity.
        /// </summary>
        public Parity Parity
        {
            get { return _parity; }
        }

        /// <summary>
        /// Gets the data bits.
        /// </summary>
        public Int32 DataBits
        {
            get { return _dataBits; }
        }

        /// <summary>
        /// Gets the stop bits.
        /// </summary>
        public StopBits StopBits
        {
            get { return _stopBits; }
        }
    }
}
