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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SSIDlabel = new System.Windows.Forms.Label();
            this.Pwdlab = new System.Windows.Forms.Label();
            this.ssidNameBox = new System.Windows.Forms.TextBox();
            this.PasswdBox = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.RichTextBox();
            this.single9Link = new System.Windows.Forms.LinkLabel();
            this.StopBtn = new System.Windows.Forms.Button();
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
            // ssidNameBox
            // 
            this.ssidNameBox.Location = new System.Drawing.Point(50, 11);
            this.ssidNameBox.Name = "ssidNameBox";
            this.ssidNameBox.Size = new System.Drawing.Size(125, 20);
            this.ssidNameBox.TabIndex = 0;
            // 
            // PasswdBox
            // 
            this.PasswdBox.Location = new System.Drawing.Point(50, 37);
            this.PasswdBox.Name = "PasswdBox";
            this.PasswdBox.Size = new System.Drawing.Size(125, 20);
            this.PasswdBox.TabIndex = 3;
            this.PasswdBox.UseSystemPasswordChar = true;
            this.PasswdBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswdBox_KeyDown);
            // 
            // OKbtn
            // 
            this.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKbtn.Location = new System.Drawing.Point(49, 65);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(60, 23);
            this.OKbtn.TabIndex = 4;
            this.OKbtn.Text = "啟動";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.AcceptsTab = true;
            this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusBox.Location = new System.Drawing.Point(181, 10);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(224, 63);
            this.StatusBox.TabIndex = 6;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "";
            // 
            // single9Link
            // 
            this.single9Link.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.single9Link.AutoSize = true;
            this.single9Link.ForeColor = System.Drawing.Color.DarkGray;
            this.single9Link.LinkArea = new System.Windows.Forms.LinkArea(11, 19);
            this.single9Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.single9Link.LinkColor = System.Drawing.Color.DarkGray;
            this.single9Link.Location = new System.Drawing.Point(305, 76);
            this.single9Link.Name = "single9Link";
            this.single9Link.Size = new System.Drawing.Size(108, 17);
            this.single9Link.TabIndex = 7;
            this.single9Link.TabStop = true;
            this.single9Link.Text = "Powered by Single.9";
            this.single9Link.UseCompatibleTextRendering = true;
            this.single9Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.single9Link_LinkClicked);
            // 
            // StopBtn
            // 
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StopBtn.Location = new System.Drawing.Point(115, 65);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(60, 23);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = " 停止";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 95);
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
            this.Load += new System.EventHandler(this.MainWindow_Load);
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
        private System.Windows.Forms.LinkLabel single9Link;
        private System.Windows.Forms.Button StopBtn;
    }
}

