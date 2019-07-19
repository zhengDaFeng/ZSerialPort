namespace ZSerialPort.Test.Winform
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CmbPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBaudRate = new System.Windows.Forms.ComboBox();
            this.CmbDataBits = new System.Windows.Forms.ComboBox();
            this.CmbStopBits = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TslComStatus = new System.Windows.Forms.ToolStripLabel();
            this.TslRxCount = new System.Windows.Forms.ToolStripLabel();
            this.CmbParity = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtReceivedData = new System.Windows.Forms.TextBox();
            this.RdoString = new System.Windows.Forms.RadioButton();
            this.RdoHex = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSendData = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.DgvCollectionContent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtAutoSendSpanTime = new System.Windows.Forms.TextBox();
            this.ChkAutoSend = new System.Windows.Forms.CheckBox();
            this.ChkAddCRC = new System.Windows.Forms.CheckBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCollectionContent)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.CmbPortName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CmbBaudRate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CmbDataBits, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CmbStopBits, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.CmbParity, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.RdoString, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.RdoHex, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.TxtSendData, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.BtnSend, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.DgvCollectionContent, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.TxtAutoSendSpanTime, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.ChkAutoSend, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ChkAddCRC, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.BtnOpen, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CmbPortName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CmbPortName, 2);
            this.CmbPortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPortName.FormattingEnabled = true;
            this.CmbPortName.Location = new System.Drawing.Point(115, 39);
            this.CmbPortName.Name = "CmbPortName";
            this.CmbPortName.Size = new System.Drawing.Size(132, 26);
            this.CmbPortName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Bits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stop Bits:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parity:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbBaudRate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CmbBaudRate, 2);
            this.CmbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBaudRate.FormattingEnabled = true;
            this.CmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.CmbBaudRate.Location = new System.Drawing.Point(115, 71);
            this.CmbBaudRate.Name = "CmbBaudRate";
            this.CmbBaudRate.Size = new System.Drawing.Size(132, 26);
            this.CmbBaudRate.TabIndex = 6;
            // 
            // CmbDataBits
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CmbDataBits, 2);
            this.CmbDataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDataBits.FormattingEnabled = true;
            this.CmbDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.CmbDataBits.Location = new System.Drawing.Point(115, 103);
            this.CmbDataBits.Name = "CmbDataBits";
            this.CmbDataBits.Size = new System.Drawing.Size(132, 26);
            this.CmbDataBits.TabIndex = 7;
            // 
            // CmbStopBits
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CmbStopBits, 2);
            this.CmbStopBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStopBits.FormattingEnabled = true;
            this.CmbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CmbStopBits.Location = new System.Drawing.Point(115, 135);
            this.CmbStopBits.Name = "CmbStopBits";
            this.CmbStopBits.Size = new System.Drawing.Size(132, 26);
            this.CmbStopBits.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 5);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslComStatus,
            this.TslRxCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 530);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 38);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TslComStatus
            // 
            this.TslComStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TslComStatus.Image = ((System.Drawing.Image)(resources.GetObject("TslComStatus.Image")));
            this.TslComStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TslComStatus.Name = "TslComStatus";
            this.TslComStatus.Size = new System.Drawing.Size(133, 33);
            this.TslComStatus.Text = "COM1: Closed";
            // 
            // TslRxCount
            // 
            this.TslRxCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TslRxCount.Image = ((System.Drawing.Image)(resources.GetObject("TslRxCount.Image")));
            this.TslRxCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TslRxCount.Name = "TslRxCount";
            this.TslRxCount.Size = new System.Drawing.Size(51, 24);
            this.TslRxCount.Text = "Rx: 0";
            // 
            // CmbParity
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CmbParity, 2);
            this.CmbParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbParity.FormattingEnabled = true;
            this.CmbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CmbParity.Location = new System.Drawing.Point(115, 167);
            this.CmbParity.Name = "CmbParity";
            this.CmbParity.Size = new System.Drawing.Size(132, 26);
            this.CmbParity.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 5);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 36);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.TxtReceivedData);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(253, 39);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 6);
            this.groupBox1.Size = new System.Drawing.Size(760, 188);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received:";
            // 
            // TxtReceivedData
            // 
            this.TxtReceivedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtReceivedData.Location = new System.Drawing.Point(3, 24);
            this.TxtReceivedData.Multiline = true;
            this.TxtReceivedData.Name = "TxtReceivedData";
            this.TxtReceivedData.ReadOnly = true;
            this.TxtReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtReceivedData.Size = new System.Drawing.Size(754, 161);
            this.TxtReceivedData.TabIndex = 0;
            // 
            // RdoString
            // 
            this.RdoString.AutoSize = true;
            this.RdoString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoString.Enabled = false;
            this.RdoString.Location = new System.Drawing.Point(3, 233);
            this.RdoString.Name = "RdoString";
            this.RdoString.Size = new System.Drawing.Size(106, 22);
            this.RdoString.TabIndex = 14;
            this.RdoString.TabStop = true;
            this.RdoString.Text = "String";
            this.RdoString.UseVisualStyleBackColor = true;
            // 
            // RdoHex
            // 
            this.RdoHex.AutoSize = true;
            this.RdoHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoHex.Enabled = false;
            this.RdoHex.Location = new System.Drawing.Point(115, 233);
            this.RdoHex.Name = "RdoHex";
            this.RdoHex.Size = new System.Drawing.Size(100, 22);
            this.RdoHex.TabIndex = 15;
            this.RdoHex.TabStop = true;
            this.RdoHex.Text = "Hex";
            this.RdoHex.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(221, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "ms";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtSendData
            // 
            this.TxtSendData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSendData.Location = new System.Drawing.Point(253, 233);
            this.TxtSendData.Multiline = true;
            this.TxtSendData.Name = "TxtSendData";
            this.tableLayoutPanel1.SetRowSpan(this.TxtSendData, 2);
            this.TxtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtSendData.Size = new System.Drawing.Size(680, 57);
            this.TxtSendData.TabIndex = 20;
            // 
            // BtnSend
            // 
            this.BtnSend.AutoSize = true;
            this.BtnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSend.Location = new System.Drawing.Point(939, 261);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(74, 29);
            this.BtnSend.TabIndex = 21;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // DgvCollectionContent
            // 
            this.DgvCollectionContent.AllowUserToOrderColumns = true;
            this.DgvCollectionContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCollectionContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.tableLayoutPanel1.SetColumnSpan(this.DgvCollectionContent, 2);
            this.DgvCollectionContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCollectionContent.Location = new System.Drawing.Point(253, 296);
            this.DgvCollectionContent.MultiSelect = false;
            this.DgvCollectionContent.Name = "DgvCollectionContent";
            this.DgvCollectionContent.RowHeadersVisible = false;
            this.DgvCollectionContent.RowHeadersWidth = 62;
            this.tableLayoutPanel1.SetRowSpan(this.DgvCollectionContent, 2);
            this.DgvCollectionContent.RowTemplate.Height = 30;
            this.DgvCollectionContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCollectionContent.Size = new System.Drawing.Size(760, 231);
            this.DgvCollectionContent.TabIndex = 22;
            this.DgvCollectionContent.DoubleClick += new System.EventHandler(this.DgvCollectionContent_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Content";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // TxtAutoSendSpanTime
            // 
            this.TxtAutoSendSpanTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAutoSendSpanTime.Location = new System.Drawing.Point(115, 261);
            this.TxtAutoSendSpanTime.Name = "TxtAutoSendSpanTime";
            this.TxtAutoSendSpanTime.Size = new System.Drawing.Size(100, 28);
            this.TxtAutoSendSpanTime.TabIndex = 17;
            // 
            // ChkAutoSend
            // 
            this.ChkAutoSend.AutoSize = true;
            this.ChkAutoSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkAutoSend.Location = new System.Drawing.Point(3, 261);
            this.ChkAutoSend.Name = "ChkAutoSend";
            this.ChkAutoSend.Size = new System.Drawing.Size(106, 29);
            this.ChkAutoSend.TabIndex = 16;
            this.ChkAutoSend.Text = "AutoSend";
            this.ChkAutoSend.UseVisualStyleBackColor = true;
            this.ChkAutoSend.CheckedChanged += new System.EventHandler(this.ChkAutoSend_CheckedChanged);
            // 
            // ChkAddCRC
            // 
            this.ChkAddCRC.AutoSize = true;
            this.ChkAddCRC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkAddCRC.Enabled = false;
            this.ChkAddCRC.Location = new System.Drawing.Point(3, 296);
            this.ChkAddCRC.Name = "ChkAddCRC";
            this.ChkAddCRC.Size = new System.Drawing.Size(106, 22);
            this.ChkAddCRC.TabIndex = 19;
            this.ChkAddCRC.Text = "Add CRC";
            this.ChkAddCRC.UseVisualStyleBackColor = true;
            // 
            // BtnOpen
            // 
            this.BtnOpen.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnOpen, 2);
            this.BtnOpen.Location = new System.Drawing.Point(115, 199);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(132, 28);
            this.BtnOpen.TabIndex = 12;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Zdfffg\'s Com Assist";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCollectionContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CmbPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBaudRate;
        private System.Windows.Forms.ComboBox CmbDataBits;
        private System.Windows.Forms.ComboBox CmbStopBits;
        private System.Windows.Forms.ComboBox CmbParity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtReceivedData;
        private System.Windows.Forms.RadioButton RdoString;
        private System.Windows.Forms.RadioButton RdoHex;
        private System.Windows.Forms.CheckBox ChkAutoSend;
        private System.Windows.Forms.TextBox TxtAutoSendSpanTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChkAddCRC;
        private System.Windows.Forms.TextBox TxtSendData;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.DataGridView DgvCollectionContent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel TslComStatus;
        private System.Windows.Forms.ToolStripLabel TslRxCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

