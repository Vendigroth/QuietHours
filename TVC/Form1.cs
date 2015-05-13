using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TVC
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.NotifyIcon notifyIcon;

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        
        private bool muted;
        private bool enabled;
        private DateTime offTime;
        private DateTime onTime;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        public Form1()
        {
            InitializeComponent();
            Timer MyTimer = new Timer();
            MyTimer.Interval = (1 * 1000);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
            lblTime.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
       
            if(!enabled){
                return;
            }

            int now = (DateTime.Now.Hour * 100) + DateTime.Now.Minute;
            int off = (offTime.Hour * 100) + offTime.Minute;
            int on = (onTime.Hour * 100) + onTime.Minute;
            // next day case
            if (offTime > onTime)
            {
                if (now >= on && now <= off)
                {
                    // Between on and off. unmute. 
                    UnMute();
                }
                else if ((now >= off && now <= 2300) ||
                         (now >= 0000 && now <= on))
                {
                    // off - midnight or midnight - on. mute
                    Mute();
                }
            }
            else{
                if (now >= off && now < on)
                {
                    // Between off and on. unmute.
                    Mute();
                }
                else
                {
                    UnMute();
                }
                
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }


        private void Mute()
        {
            
            //Really a hack way to do it, but up/down makes sure its muted due to mute being a toggle
            if (!muted) //to avoid constant mute/unmute hops
            {
                btnToggle.Text = "UnMute"; 
                muted = true;
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_UP);
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_DOWN);
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_MUTE);
            }
        }

        private void UnMute()
        {
            if (muted)
            {
                btnToggle.Text = "Mute";
                muted = false;
                // Also a bit of a crude way to do it.
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_UP);
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_DOWN);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Click += new System.EventHandler(Restore);
            notifyIcon1.Icon = SystemIcons.WinLogo;
            
            enabled  = Properties.Settings.Default.Enabled;
            offTime = Properties.Settings.Default.OffTime;
            onTime = Properties.Settings.Default.OnTime;

            dtMuteTime.Value = offTime;
            dtUnMuteTime.Value = onTime;
            cbEnable.Checked = enabled;

            if (enabled)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
              
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            enabled = false;
            cbEnable.Checked = false;

            if (muted)
            {
                UnMute();
            }
            else
            {
                Mute();
            }
        }


        private void SaveSettings()
        {
            Properties.Settings.Default.Enabled = enabled;
            Properties.Settings.Default.OffTime = offTime;
            Properties.Settings.Default.OnTime = onTime;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            enabled = Properties.Settings.Default.Enabled;
            offTime = Properties.Settings.Default.OffTime;
            onTime = Properties.Settings.Default.OnTime;

            dtMuteTime.Value = offTime;
            dtUnMuteTime.Value = onTime;
            cbEnable.Checked = enabled;
        }

        private void cbEnable_CheckedChanged(object sender, EventArgs e)
        {
            enabled = cbEnable.Checked;
        }

        private void dtMuteTime_ValueChanged(object sender, EventArgs e)
        {
            offTime = dtMuteTime.Value;
        }

        private void dtUnMuteTime_ValueChanged(object sender, EventArgs e)
        {
            onTime = dtUnMuteTime.Value;
        }

        //Handle window 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                SaveSettings();
            }
            base.OnFormClosing(e);
        }
        private void Restore(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void Minimize()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x112 && m.WParam.ToInt32() == 0xf020)
            {
                Minimize();
                return;        
            }
            base.WndProc(ref m);
        }
    }
}
