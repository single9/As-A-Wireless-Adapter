namespace AsAWirelessAdapter
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SSIDlabel = new System.Windows.Forms.Label();
            this.Pwdlab = new System.Windows.Forms.Label();
            this.OKbtn = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.RichTextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.PasswdBox = new System.Windows.Forms.TextBox();
            this.ssidNameBox = new System.Windows.Forms.TextBox();
            this.single9Link = new System.Windows.Forms.LinkLabel();
            this.tabWifiControl = new System.Windows.Forms.TabControl();
            this.tabWifiSet = new System.Windows.Forms.TabPage();
            this.chbSave = new System.Windows.Forms.CheckBox();
            this.ckBMiniToTray = new System.Windows.Forms.CheckBox();
            this.tabWifiStatus = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabWifiControl.SuspendLayout();
            this.tabWifiSet.SuspendLayout();
            this.tabWifiStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // SSIDlabel
            // 
            this.SSIDlabel.AutoSize = true;
            this.SSIDlabel.Location = new System.Drawing.Point(19, 35);
            this.SSIDlabel.Name = "SSIDlabel";
            this.SSIDlabel.Size = new System.Drawing.Size(32, 13);
            this.SSIDlabel.TabIndex = 0;
            this.SSIDlabel.Text = "SSID";
            // 
            // Pwdlab
            // 
            this.Pwdlab.AutoSize = true;
            this.Pwdlab.Location = new System.Drawing.Point(19, 60);
            this.Pwdlab.Name = "Pwdlab";
            this.Pwdlab.Size = new System.Drawing.Size(31, 13);
            this.Pwdlab.TabIndex = 1;
            this.Pwdlab.Text = "密碼";
            // 
            // OKbtn
            // 
            this.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbtn.Location = new System.Drawing.Point(166, 30);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(49, 23);
            this.OKbtn.TabIndex = 4;
            this.OKbtn.Text = "啟動";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.AcceptsTab = true;
            this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusBox.Location = new System.Drawing.Point(6, 6);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(287, 93);
            this.StatusBox.TabIndex = 6;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "";
            // 
            // StopBtn
            // 
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Location = new System.Drawing.Point(166, 54);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(49, 23);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = " 停止";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "我被縮小到這裡，方便您使用以及節省一些工作列的空間。\r\n\r\n點我兩下，就可以重新開啟控制程式囉~";
            this.notifyIcon.BalloonTipTitle = "親愛的，我在這!";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AsAWirelessAdapter";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // PasswdBox
            // 
            this.PasswdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswdBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AsAWirelessAdapter.Properties.Settings.Default, "A_PWD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswdBox.Location = new System.Drawing.Point(57, 57);
            this.PasswdBox.Name = "PasswdBox";
            this.PasswdBox.Size = new System.Drawing.Size(103, 20);
            this.PasswdBox.TabIndex = 3;
            this.PasswdBox.Text = global::AsAWirelessAdapter.Properties.Settings.Default.A_PWD;
            this.PasswdBox.UseSystemPasswordChar = true;
            this.PasswdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswdBox_KeyDown);
            // 
            // ssidNameBox
            // 
            this.ssidNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ssidNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AsAWirelessAdapter.Properties.Settings.Default, "A_SSID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ssidNameBox.Location = new System.Drawing.Point(57, 31);
            this.ssidNameBox.Name = "ssidNameBox";
            this.ssidNameBox.Size = new System.Drawing.Size(103, 20);
            this.ssidNameBox.TabIndex = 0;
            this.ssidNameBox.Text = global::AsAWirelessAdapter.Properties.Settings.Default.A_SSID;
            // 
            // single9Link
            // 
            this.single9Link.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.single9Link.AutoSize = true;
            this.single9Link.ForeColor = System.Drawing.Color.DarkGray;
            this.single9Link.LinkArea = new System.Windows.Forms.LinkArea(11, 19);
            this.single9Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.single9Link.LinkColor = System.Drawing.Color.DarkGray;
            this.single9Link.Location = new System.Drawing.Point(237, 15);
            this.single9Link.Name = "single9Link";
            this.single9Link.Size = new System.Drawing.Size(108, 17);
            this.single9Link.TabIndex = 7;
            this.single9Link.TabStop = true;
            this.single9Link.Text = "Powered by Single.9";
            this.single9Link.UseCompatibleTextRendering = true;
            this.single9Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.single9Link_LinkClicked);
            // 
            // tabWifiControl
            // 
            this.tabWifiControl.Controls.Add(this.tabWifiSet);
            this.tabWifiControl.Controls.Add(this.tabWifiStatus);
            this.tabWifiControl.Location = new System.Drawing.Point(6, 12);
            this.tabWifiControl.Name = "tabWifiControl";
            this.tabWifiControl.SelectedIndex = 0;
            this.tabWifiControl.Size = new System.Drawing.Size(341, 134);
            this.tabWifiControl.TabIndex = 13;
            // 
            // tabWifiSet
            // 
            this.tabWifiSet.BackColor = System.Drawing.SystemColors.Control;
            this.tabWifiSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabWifiSet.Controls.Add(this.chbSave);
            this.tabWifiSet.Controls.Add(this.ckBMiniToTray);
            this.tabWifiSet.Controls.Add(this.ssidNameBox);
            this.tabWifiSet.Controls.Add(this.SSIDlabel);
            this.tabWifiSet.Controls.Add(this.Pwdlab);
            this.tabWifiSet.Controls.Add(this.PasswdBox);
            this.tabWifiSet.Controls.Add(this.StopBtn);
            this.tabWifiSet.Controls.Add(this.OKbtn);
            this.tabWifiSet.Location = new System.Drawing.Point(4, 22);
            this.tabWifiSet.Name = "tabWifiSet";
            this.tabWifiSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabWifiSet.Size = new System.Drawing.Size(333, 108);
            this.tabWifiSet.TabIndex = 0;
            this.tabWifiSet.Text = "WiFi 設定";
            // 
            // chbSave
            // 
            this.chbSave.AutoSize = true;
            this.chbSave.Checked = global::AsAWirelessAdapter.Properties.Settings.Default.A_SAVE;
            this.chbSave.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AsAWirelessAdapter.Properties.Settings.Default, "A_SAVE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chbSave.ForeColor = System.Drawing.Color.DimGray;
            this.chbSave.Location = new System.Drawing.Point(221, 34);
            this.chbSave.Name = "chbSave";
            this.chbSave.Size = new System.Drawing.Size(98, 17);
            this.chbSave.TabIndex = 13;
            this.chbSave.Text = "儲存所有設定";
            this.chbSave.UseVisualStyleBackColor = true;
            // 
            // ckBMiniToTray
            // 
            this.ckBMiniToTray.AutoSize = true;
            this.ckBMiniToTray.Checked = global::AsAWirelessAdapter.Properties.Settings.Default.A_MINI;
            this.ckBMiniToTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AsAWirelessAdapter.Properties.Settings.Default, "A_MINI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ckBMiniToTray.ForeColor = System.Drawing.Color.DimGray;
            this.ckBMiniToTray.Location = new System.Drawing.Point(221, 59);
            this.ckBMiniToTray.Name = "ckBMiniToTray";
            this.ckBMiniToTray.Size = new System.Drawing.Size(98, 17);
            this.ckBMiniToTray.TabIndex = 12;
            this.ckBMiniToTray.Text = "縮小至工作列";
            this.ckBMiniToTray.UseVisualStyleBackColor = true;
            this.ckBMiniToTray.CheckedChanged += new System.EventHandler(this.ckBMiniToTray_CheckedChanged);
            // 
            // tabWifiStatus
            // 
            this.tabWifiStatus.BackColor = System.Drawing.SystemColors.Control;
            this.tabWifiStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabWifiStatus.Controls.Add(this.btnRefresh);
            this.tabWifiStatus.Controls.Add(this.StatusBox);
            this.tabWifiStatus.Location = new System.Drawing.Point(4, 22);
            this.tabWifiStatus.Name = "tabWifiStatus";
            this.tabWifiStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabWifiStatus.Size = new System.Drawing.Size(333, 108);
            this.tabWifiStatus.TabIndex = 1;
            this.tabWifiStatus.Text = "WiFi 狀態";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(299, 76);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "₪";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 156);
            this.Controls.Add(this.single9Link);
            this.Controls.Add(this.tabWifiControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "As a Wireless Adapter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.tabWifiControl.ResumeLayout(false);
            this.tabWifiSet.ResumeLayout(false);
            this.tabWifiSet.PerformLayout();
            this.tabWifiStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SSIDlabel;
        private System.Windows.Forms.Label Pwdlab;
        private System.Windows.Forms.TextBox ssidNameBox;
        private System.Windows.Forms.TextBox PasswdBox;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.RichTextBox StatusBox;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel single9Link;
        private System.Windows.Forms.TabControl tabWifiControl;
        private System.Windows.Forms.TabPage tabWifiSet;
        private System.Windows.Forms.CheckBox chbSave;
        private System.Windows.Forms.CheckBox ckBMiniToTray;
        private System.Windows.Forms.TabPage tabWifiStatus;
        private System.Windows.Forms.Button btnRefresh;
    }
}

