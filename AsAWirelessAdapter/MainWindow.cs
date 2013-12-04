using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AsAWirelessAdapter
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// 名稱:As A Wireless Adapter
        /// 版本:1.12.04.2013
        /// 作者:Jing (獨夜)
        /// 網站:http://single9.net
        /// 簡介與原理:
        ///     先前在找如何將筆電當作一個無線網路分享器/基地台的時候，發現最
        ///     好用的方式是透過netsh下去設定，問題是每次要開都要打指令，這顯
        ///     得非常的麻煩與難用，所以我才想要寫一個這樣的小工具出來。
        ///     
        ///     這個程式利用的原理很簡單，僅僅是將指令轉化成為圖形化的介面而已，
        ///     目的是為了簡化那些繁瑣的筆電轉換成為無線網路交換器的開啟過程。
        ///     
        /// </summary>
        Boolean runable = false, firstMinimize = true;
        String temp;
        // 定義 netsh
        ProcessStartInfo pstart = new ProcessStartInfo("netsh.exe");
        //宣告NotifyIcon


        public MainWindow()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            /* ----- 設定SSID與密碼 ----- */
            String ssidName = ssidNameBox.Text, Pwd = PasswdBox.Text;
            /* ---------- 判斷 ---------- */
            if (ssidName == "" || Pwd == "") errorMsg("SSID或密碼沒有輸入，請輸入。");
            else if (Pwd.Length < 8) errorMsg("密碼至少需要8個字。");
            else if (Pwd.Length > 64) errorMsg("您的密碼太長，密碼長度不可超過64個字。");
            else runable = true;
            /* -------- 判斷結束 -------- */
            if (runable)
            {
                // 定義無線網路
                iniNetsh("wlan set hostednetwork mode=allow ssid=" + ssidName + " key=" + Pwd);
                // 啟動服務指令
                iniNetsh("wlan start hostednetwork");
                // 啟動按鈕變更為停用
                OKbtn.Enabled = false;
                // 停止按鈕變更為啟用
                StopBtn.Enabled = true;
            }
            /* ------ 儲存SSID與PWD等設定 ------ */
            if(chbSave.Checked)
                Properties.Settings.Default.Save();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            // 停止服務指令
            iniNetsh("wlan stop hostednetwork");
            // 可執行狀態變更為停止，用以重新驗證
            runable = false;
            // 啟動按鈕狀態變更為可用
            OKbtn.Enabled = true;
            // 停止按鈕狀態變更為停用
            StopBtn.Enabled = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            StopBtn.Enabled = false;
            // 檢查Hosted網路狀態
            checkHostednetworkStatus();

            //建立NotifyIcon
            this.notifyIcon1.Text = "AsAWirelessAdapter";
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && ckBMiniToT.Checked)
            {
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
                if (firstMinimize)
                {
                    notifyIcon1.ShowBalloonTip(2000);
                    firstMinimize = false;
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                showWindow();
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            showWindow();
        }

        private void showWindow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            checkHostednetworkStatus();
        }

        private void checkHostednetworkStatus()
        {
            // 定義與執行 netsh
            iniNetsh("wlan show hostednetwork");
        }
        /// <summary>
        /// 定義netsh的函式
        /// iniNetsh(String command);
        /// Simple usage:
        /// iniNetsh("wlan show hostednetwork");
        /// </summary>
        private void iniNetsh(String command)
        {
            pstart.Arguments = command;             // 定義指令
            pstart.CreateNoWindow = true;           // 不顯示執行視窗
            pstart.RedirectStandardOutput = true;   // 標準輸出啟用
            pstart.RedirectStandardInput = true;    // 標準輸入啟用
            pstart.UseShellExecute = false;
            // 執行 netsh
            Process p = Process.Start(pstart);
            // 串流讀取
            StreamReader reader = p.StandardOutput;
            // 顯示狀態
            while ((temp = reader.ReadLine()) != null)
            {
                if (temp != "") StatusBox.Text = temp;
                // 狀態顯示區自動往下捲動
                // StatusBox.Select(StatusBox.Text.Length, 0);
                // StatusBox.ScrollToCaret(); 
            }
            p.WaitForExit();                // 等待 netsh 關閉
            p.Close();                      // 關閉 netsh
            reader.Close();                 // 關閉串流
        }

        private void errorMsg(String msg)
        {
            MessageBox.Show(msg, "錯誤!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void single9Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://single9.net");
        }

        private void PasswdBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OKbtn_Click(sender, e);
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var closeAlert =
                    MessageBox.Show("你確定要關閉嗎?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeAlert == DialogResult.Yes)
            {
                StopBtn_Click(sender, e);

                if (!chbSave.Checked)
                    Properties.Settings.Default.Reset();
                else
                    Properties.Settings.Default.Save();

                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            checkHostednetworkStatus();
        }
    }
}
