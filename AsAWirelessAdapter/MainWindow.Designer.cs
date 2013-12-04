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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chbSave = new System.Windows.Forms.CheckBox();
            this.ckBMiniToT = new System.Windows.Forms.CheckBox();
            this.PasswdBox = new System.Windows.Forms.TextBox();
            this.ssidNameBox = new System.Windows.Forms.TextBox();
            this.single9Link = new System.Windows.Forms.LinkLabel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SSIDlabel
            // 
            this.SSIDlabel.AutoSize = true;
            this.SSIDlabel.Location = new System.Drawing.Point(12, 15);
            this.SSIDlabel.Name = "SSIDlabel";
            this.SSIDlabel.Size = new System.Drawing.Size(32, 13);
            this.SSIDlabel.TabIndex = 0;
            this.SSIDlabel.Text = "SSID";
            // 
            // Pwdlab
            // 
            this.Pwdlab.AutoSize = true;
            this.Pwdlab.Location = new System.Drawing.Point(12, 40);
            this.Pwdlab.Name = "Pwdlab";
            this.Pwdlab.Size = new System.Drawing.Size(31, 13);
            this.Pwdlab.TabIndex = 1;
            this.Pwdlab.Text = "密碼";
            // 
            // OKbtn
            // 
            this.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbtn.Location = new System.Drawing.Point(49, 65);
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
            this.StatusBox.Location = new System.Drawing.Point(159, 10);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(255, 78);
            this.StatusBox.TabIndex = 6;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "";
            // 
            // StopBtn
            // 
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Location = new System.Drawing.Point(104, 65);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(49, 23);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = " 停止";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "我被縮小到這裡，方便您使用以及節省一些工作列的空間。\r\n\r\n點我兩下，就可以重新開啟控制程式囉~";
            this.notifyIcon1.BalloonTipTitle = "親愛的，我在這!";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AsAWirelessAdapter";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // chbSave
            // 
            this.chbSave.AutoSize = true;
            this.chbSave.Checked = global::AsAWirelessAdapter.Properties.Settings.Default.A_SAVE;
            this.chbSave.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AsAWirelessAdapter.Properties.Settings.Default, "A_SAVE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chbSave.ForeColor = System.Drawing.Color.DimGray;
            this.chbSave.Location = new System.Drawing.Point(309, 94);
            this.chbSave.Name = "chbSave";
            this.chbSave.Size = new System.Drawing.Size(98, 17);
            this.chbSave.TabIndex = 11;
            this.chbSave.Text = "儲存所有設定";
            this.chbSave.UseVisualStyleBackColor = true;
            // 
            // ckBMiniToT
            // 
            this.ckBMiniToT.AutoSize = true;
            this.ckBMiniToT.Checked = global::AsAWirelessAdapter.Properties.Settings.Default.A_MINI;
            this.ckBMiniToT.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AsAWirelessAdapter.Properties.Settings.Default, "A_MINI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ckBMiniToT.ForeColor = System.Drawing.Color.DimGray;
            this.ckBMiniToT.Location = new System.Drawing.Point(159, 94);
            this.ckBMiniToT.Name = "ckBMiniToT";
            this.ckBMiniToT.Size = new System.Drawing.Size(98, 17);
            this.ckBMiniToT.TabIndex = 9;
            this.ckBMiniToT.Text = "縮小至工作列";
            this.ckBMiniToT.UseVisualStyleBackColor = true;
            // 
            // PasswdBox
            // 
            this.PasswdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswdBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AsAWirelessAdapter.Properties.Settings.Default, "A_PWD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswdBox.Location = new System.Drawing.Point(50, 37);
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
            this.ssidNameBox.Location = new System.Drawing.Point(50, 11);
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
            this.single9Link.Location = new System.Drawing.Point(12, 95);
            this.single9Link.Name = "single9Link";
            this.single9Link.Size = new System.Drawing.Size(108, 17);
            this.single9Link.TabIndex = 7;
            this.single9Link.TabStop = true;
            this.single9Link.Text = "Powered by Single.9";
            this.single9Link.UseCompatibleTextRendering = true;
            this.single9Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.single9Link_LinkClicked);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(15, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "₪";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 116);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chbSave);
            this.Controls.Add(this.ckBMiniToT);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.single9Link);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.PasswdBox);
            this.Controls.Add(this.ssidNameBox);
            this.Controls.Add(this.Pwdlab);
            this.Controls.Add(this.SSIDlabel);
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
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox ckBMiniToT;
        private System.Windows.Forms.CheckBox chbSave;
        private System.Windows.Forms.LinkLabel single9Link;
        private System.Windows.Forms.Button btnRefresh;
    }
}

