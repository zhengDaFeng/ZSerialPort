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
        }

        public void SetController(IController controller)
        {
            this._controller = controller;
        }

        public void CloseComEvent(object sender, ZSerialPortEventArgs e)
        {
            UpdateUI_Open_Close(e.IsOpend);
        }

        public void OpenComEvent(object sender, ZSerialPortEventArgs e)
        {
            UpdateUI_Open_Close(e.IsOpend);
        }

        public void ComReceiveDataEvent(object sender, ZSerialPortEventArgs e)
        {
            var data = System.Text.Encoding.Default.GetString(e.ReceivedBytes);

            Action<string> actionDelegate = (x) =>
            {
                UpdateUI_DataReceived(x);
            };

            this.TxtReceivedData.BeginInvoke(actionDelegate, data);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateUI_Init();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (BtnOpen.Text == "Open")
            {
                _controller.Open(CmbPortName.Text, CmbBaudRate.Text, CmbDataBits.Text, CmbStopBits.Text, CmbParity.Text);
            }
            else
            {
                _controller.Close();
            }
        }

        private void BtnClearReceived_Click(object sender, EventArgs e)
        {
            TxtReceivedData.ResetText();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            _controller.Send(TxtSendData.Text);
            UpdateUI_SendData();
        }

        private void ChkAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutoSend.Checked)
            {
                TxtSendData.Enabled = false;
                BtnSend.Enabled = false;
            }
            else
            {
                TxtSendData.Enabled = true;
                BtnSend.Enabled = true;
            }

            if (int.TryParse(TxtAutoSendSpanTime.Text, out int span))
            {
                if (span > 0)
                {
                    _controller.AutoSend(ChkAutoSend.Checked, TxtSendData.Text, span);
                }
                else
                {
                    TxtAutoSendSpanTime.Text = "100";
                    MessageBox.Show("Cannot be less than or equal to 0!");
                }
            }
            else
            {
                TxtAutoSendSpanTime.Text = "100";
                MessageBox.Show("Must be a numeric type!");
            }
        }

        private void DgvCollectionContent_DoubleClick(object sender, EventArgs e)
        {
            if (DgvCollectionContent.SelectedRows[0].Cells[0].Value != null)
            {
                TxtSendData.Text = DgvCollectionContent.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void DgvCollectionContent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateUI_Init()
        {
            UpdateUI_PortParamsInit();
            UpdateUI_Open_Close(false);

            RdoString.Checked = true;

            TxtAutoSendSpanTime.Text = "100";
        }

        private void UpdateUI_PortParamsInit()
        {
            UpdateUI_Ports();

            var baudRates = new string[] { "9600", "19200", "115200" };
            var dataBits = new string[] { "7", "8" };
            var stopBits = new string[] { "One", "Two" };
            var parities = new string[] { "None", "Odd", "Even", "Mark", "Space" };

            CmbBaudRate.Items.AddRange(baudRates);
            CmbDataBits.Items.Clear();
            CmbDataBits.Items.AddRange(dataBits);
            CmbStopBits.Items.Clear();
            CmbStopBits.Items.AddRange(stopBits);
            CmbParity.Items.Clear();
            CmbParity.Items.AddRange(parities);

            CmbBaudRate.SelectedIndex = 0;
            CmbDataBits.SelectedIndex = 1;
            CmbStopBits.SelectedIndex = 0;
            CmbParity.SelectedIndex = 0;
        }

        private void UpdateUI_Ports()
        {
            var ports = _controller.GetPortNames();
            CmbPortName.Items.Clear();
            CmbPortName.Items.AddRange(ports);
            if (CmbPortName.Items.Count > 0)
            {
                CmbPortName.SelectedIndex = 0;
            }
        }

        private void UpdateUI_Open_Close(bool isOpened)
        {
            // 修复 GDI+ 刷新问题
            Bitmap bmp = new Bitmap(PtbFlag.Width, PtbFlag.Height);
            PtbFlag.BackgroundImage = bmp;

            Graphics g;
            Brush brush;

            g = Graphics.FromImage(bmp);

            if (isOpened)
            {
                BtnOpen.Text = "Close";

                brush = new SolidBrush(Color.Green);
            }
            else
            {
                BtnOpen.Text = "Open";

                brush = new SolidBrush(Color.Red);
            }

            g.FillEllipse(brush, 3, 3, PtbFlag.Width - 6, PtbFlag.Height - 6);

            CmbPortName.Enabled = !isOpened;
            CmbBaudRate.Enabled = !isOpened;
            CmbDataBits.Enabled = !isOpened;
            CmbStopBits.Enabled = !isOpened;
            CmbParity.Enabled = !isOpened;

            ChkAutoSend.Enabled = isOpened;
            BtnSend.Enabled = isOpened;
        }

        private void UpdateUI_DataReceived(string data)
        {
            GrpReceived.Text = "Received (" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + ")";
            this.TxtReceivedData.AppendText(data);
        }

        private void UpdateUI_SendData()
        {
            GrpSend.Text = "Send (" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + ")";
        }
    }
}
