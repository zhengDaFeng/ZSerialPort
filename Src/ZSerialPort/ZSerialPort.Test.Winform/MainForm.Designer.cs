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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GrpReceived = new System.Windows.Forms.GroupBox();
            this.BtnClearReceived = new System.Windows.Forms.Button();
            this.TxtReceivedData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSendData = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.DgvCollectionContent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtAutoSendSpanTime = new System.Windows.Forms.TextBox();
            this.ChkAutoSend = new System.Windows.Forms.CheckBox();
            this.GrpSend = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdoString = new System.Windows.Forms.RadioButton();
            this.RdoHex = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmbPortName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbParity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbStopBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbDataBits = new System.Windows.Forms.ComboBox();
            this.CmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.PtbFlag = new System.Windows.Forms.PictureBox();
            this.GrpReceived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCollectionContent)).BeginInit();
            this.GrpSend.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpReceived
            // 
            this.GrpReceived.Controls.Add(this.BtnClearReceived);
            this.GrpReceived.Controls.Add(this.TxtReceivedData);
            this.GrpReceived.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpReceived.Location = new System.Drawing.Point(214, 12);
            this.GrpReceived.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpReceived.Name = "GrpReceived";
            this.GrpReceived.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpReceived.Size = new System.Drawing.Size(394, 192);
            this.GrpReceived.TabIndex = 13;
            this.GrpReceived.TabStop = false;
            this.GrpReceived.Text = "Received";
            // 
            // BtnClearReceived
            // 
            this.BtnClearReceived.AutoSize = true;
            this.BtnClearReceived.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClearReceived.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearReceived.Location = new System.Drawing.Point(287, 161);
            this.BtnClearReceived.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnClearReceived.Name = "BtnClearReceived";
            this.BtnClearReceived.Size = new System.Drawing.Size(99, 25);
            this.BtnClearReceived.TabIndex = 23;
            this.BtnClearReceived.Text = "Clear";
            this.BtnClearReceived.UseVisualStyleBackColor = false;
            this.BtnClearReceived.Click += new System.EventHandler(this.BtnClearReceived_Click);
            // 
            // TxtReceivedData
            // 
            this.TxtReceivedData.Location = new System.Drawing.Point(8, 20);
            this.TxtReceivedData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtReceivedData.Multiline = true;
            this.TxtReceivedData.Name = "TxtReceivedData";
            this.TxtReceivedData.ReadOnly = true;
            this.TxtReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtReceivedData.Size = new System.Drawing.Size(378, 135);
            this.TxtReceivedData.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "ms";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtSendData
            // 
            this.TxtSendData.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSendData.Location = new System.Drawing.Point(7, 20);
            this.TxtSendData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSendData.Multiline = true;
            this.TxtSendData.Name = "TxtSendData";
            this.TxtSendData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtSendData.Size = new System.Drawing.Size(379, 76);
            this.TxtSendData.TabIndex = 20;
            // 
            // BtnSend
            // 
            this.BtnSend.AutoSize = true;
            this.BtnSend.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(287, 102);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(99, 25);
            this.BtnSend.TabIndex = 21;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // DgvCollectionContent
            // 
            this.DgvCollectionContent.AllowUserToOrderColumns = true;
            this.DgvCollectionContent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvCollectionContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCollectionContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DgvCollectionContent.Enabled = false;
            this.DgvCollectionContent.GridColor = System.Drawing.SystemColors.Control;
            this.DgvCollectionContent.Location = new System.Drawing.Point(12, 349);
            this.DgvCollectionContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvCollectionContent.MultiSelect = false;
            this.DgvCollectionContent.Name = "DgvCollectionContent";
            this.DgvCollectionContent.RowHeadersVisible = false;
            this.DgvCollectionContent.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCollectionContent.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCollectionContent.RowTemplate.Height = 30;
            this.DgvCollectionContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCollectionContent.Size = new System.Drawing.Size(596, 208);
            this.DgvCollectionContent.TabIndex = 22;
            this.DgvCollectionContent.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCollectionContent_CellEndEdit);
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
            this.TxtAutoSendSpanTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutoSendSpanTime.Location = new System.Drawing.Point(8, 104);
            this.TxtAutoSendSpanTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAutoSendSpanTime.Name = "TxtAutoSendSpanTime";
            this.TxtAutoSendSpanTime.Size = new System.Drawing.Size(54, 21);
            this.TxtAutoSendSpanTime.TabIndex = 17;
            // 
            // ChkAutoSend
            // 
            this.ChkAutoSend.AutoSize = true;
            this.ChkAutoSend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAutoSend.Location = new System.Drawing.Point(95, 106);
            this.ChkAutoSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkAutoSend.Name = "ChkAutoSend";
            this.ChkAutoSend.Size = new System.Drawing.Size(79, 19);
            this.ChkAutoSend.TabIndex = 16;
            this.ChkAutoSend.Text = "AutoSend";
            this.ChkAutoSend.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ChkAutoSend.UseVisualStyleBackColor = true;
            this.ChkAutoSend.CheckedChanged += new System.EventHandler(this.ChkAutoSend_CheckedChanged);
            // 
            // GrpSend
            // 
            this.GrpSend.Controls.Add(this.TxtSendData);
            this.GrpSend.Controls.Add(this.ChkAutoSend);
            this.GrpSend.Controls.Add(this.BtnSend);
            this.GrpSend.Controls.Add(this.TxtAutoSendSpanTime);
            this.GrpSend.Controls.Add(this.label6);
            this.GrpSend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpSend.Location = new System.Drawing.Point(214, 210);
            this.GrpSend.Name = "GrpSend";
            this.GrpSend.Size = new System.Drawing.Size(394, 133);
            this.GrpSend.TabIndex = 23;
            this.GrpSend.TabStop = false;
            this.GrpSend.Text = "Send";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdoString);
            this.groupBox3.Controls.Add(this.RdoHex);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 133);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // RdoString
            // 
            this.RdoString.AutoSize = true;
            this.RdoString.Enabled = false;
            this.RdoString.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoString.Location = new System.Drawing.Point(10, 20);
            this.RdoString.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RdoString.Name = "RdoString";
            this.RdoString.Size = new System.Drawing.Size(57, 19);
            this.RdoString.TabIndex = 14;
            this.RdoString.TabStop = true;
            this.RdoString.Text = "String";
            this.RdoString.UseVisualStyleBackColor = true;
            // 
            // RdoHex
            // 
            this.RdoHex.AutoSize = true;
            this.RdoHex.Enabled = false;
            this.RdoHex.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoHex.Location = new System.Drawing.Point(75, 20);
            this.RdoHex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RdoHex.Name = "RdoHex";
            this.RdoHex.Size = new System.Drawing.Size(46, 19);
            this.RdoHex.TabIndex = 15;
            this.RdoHex.TabStop = true;
            this.RdoHex.Text = "Hex";
            this.RdoHex.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PtbFlag);
            this.groupBox4.Controls.Add(this.CmbPortName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.CmbParity);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.CmbStopBits);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.CmbDataBits);
            this.groupBox4.Controls.Add(this.CmbBaudRate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.BtnOpen);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 192);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // CmbPortName
            // 
            this.CmbPortName.BackColor = System.Drawing.SystemColors.Control;
            this.CmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPortName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPortName.FormattingEnabled = true;
            this.CmbPortName.Location = new System.Drawing.Point(84, 14);
            this.CmbPortName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbPortName.Name = "CmbPortName";
            this.CmbPortName.Size = new System.Drawing.Size(99, 23);
            this.CmbPortName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Stop Bits:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Port Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbParity
            // 
            this.CmbParity.BackColor = System.Drawing.SystemColors.Control;
            this.CmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbParity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbParity.FormattingEnabled = true;
            this.CmbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CmbParity.Location = new System.Drawing.Point(84, 130);
            this.CmbParity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbParity.Name = "CmbParity";
            this.CmbParity.Size = new System.Drawing.Size(99, 23);
            this.CmbParity.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Baud Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbStopBits
            // 
            this.CmbStopBits.BackColor = System.Drawing.SystemColors.Control;
            this.CmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStopBits.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbStopBits.FormattingEnabled = true;
            this.CmbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CmbStopBits.Location = new System.Drawing.Point(84, 101);
            this.CmbStopBits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbStopBits.Name = "CmbStopBits";
            this.CmbStopBits.Size = new System.Drawing.Size(99, 23);
            this.CmbStopBits.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data Bits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbDataBits
            // 
            this.CmbDataBits.BackColor = System.Drawing.SystemColors.Control;
            this.CmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDataBits.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDataBits.FormattingEnabled = true;
            this.CmbDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.CmbDataBits.Location = new System.Drawing.Point(84, 72);
            this.CmbDataBits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbDataBits.Name = "CmbDataBits";
            this.CmbDataBits.Size = new System.Drawing.Size(99, 23);
            this.CmbDataBits.TabIndex = 20;
            // 
            // CmbBaudRate
            // 
            this.CmbBaudRate.BackColor = System.Drawing.SystemColors.Control;
            this.CmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBaudRate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBaudRate.FormattingEnabled = true;
            this.CmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.CmbBaudRate.Location = new System.Drawing.Point(84, 43);
            this.CmbBaudRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbBaudRate.Name = "CmbBaudRate";
            this.CmbBaudRate.Size = new System.Drawing.Size(99, 23);
            this.CmbBaudRate.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Parity:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnOpen
            // 
            this.BtnOpen.AutoSize = true;
            this.BtnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOpen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpen.Location = new System.Drawing.Point(84, 159);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(99, 25);
            this.BtnOpen.TabIndex = 23;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // PtbFlag
            // 
            this.PtbFlag.Location = new System.Drawing.Point(54, 159);
            this.PtbFlag.Name = "PtbFlag";
            this.PtbFlag.Size = new System.Drawing.Size(22, 25);
            this.PtbFlag.TabIndex = 24;
            this.PtbFlag.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrpSend);
            this.Controls.Add(this.GrpReceived);
            this.Controls.Add(this.DgvCollectionContent);
            this.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Zdfffg\'s Com Assist";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GrpReceived.ResumeLayout(false);
            this.GrpReceived.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCollectionContent)).EndInit();
            this.GrpSend.ResumeLayout(false);
            this.GrpSend.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpReceived;
        private System.Windows.Forms.TextBox TxtReceivedData;
        private System.Windows.Forms.CheckBox ChkAutoSend;
        private System.Windows.Forms.TextBox TxtAutoSendSpanTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSendData;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.DataGridView DgvCollectionContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button BtnClearReceived;
        private System.Windows.Forms.GroupBox GrpSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdoString;
        private System.Windows.Forms.RadioButton RdoHex;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CmbPortName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbParity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbDataBits;
        private System.Windows.Forms.ComboBox CmbBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.PictureBox PtbFlag;
    }
}

