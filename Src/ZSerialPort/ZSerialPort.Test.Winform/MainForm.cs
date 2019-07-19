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
            if (!e.IsOpend)
            {
                BtnOpen.Text = "Open";
            }

            TslComStatus.Text = CmbPortName.Text + ": " + "Closed";
        }

        public void ComReceiveDataEvent(object sender, ZSerialPortEventArgs e)
        {
            TxtReceivedData.AppendText(System.Text.Encoding.Default.GetString(e.ReceivedBytes));
            var rxCountArr = TslRxCount.Text.Split(':');
            int.TryParse(rxCountArr[1].Trim(), out int count);
            count += 1;
            TslRxCount.Text = "Rx: " + count;
        }

        public void OpenComEvent(object sender, ZSerialPortEventArgs e)
        {
            if (e.IsOpend)
            {
                BtnOpen.Text = "Close";
            }

            TslComStatus.Text = CmbPortName.Text + ": " + "Opened";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 初始化
            CmbPortName.Items.AddRange(_controller.GetPortNames());
            if (CmbPortName.Items != null && CmbPortName.Items.Count > 0)
            {
                CmbPortName.SelectedIndex = 0;
            }
            if (CmbBaudRate.Items != null && CmbBaudRate.Items.Count > 0)
            {
                CmbBaudRate.SelectedIndex = 0;
            }
            if (CmbDataBits.Items != null && CmbDataBits.Items.Count > 0)
            {
                CmbDataBits.SelectedIndex = 0;
            }
            if (CmbStopBits.Items != null && CmbStopBits.Items.Count > 0)
            {
                CmbStopBits.SelectedIndex = 0;
            }
            if (CmbParity.Items != null && CmbParity.Items.Count > 0)
            {
                CmbParity.SelectedIndex = 0;
            }

            RdoString.Checked = true;

            TxtAutoSendSpanTime.Text = "100";

            TslComStatus.Text = "Unknow";
            TslRxCount.Text = "Unknow";
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

        private void BtnSend_Click(object sender, EventArgs e)
        {
            _controller.Send(TxtSendData.Text);
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
            TxtSendData.Text = DgvCollectionContent.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
