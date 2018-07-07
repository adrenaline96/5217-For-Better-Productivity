using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace _5217_For_Better_Productivity
{
    public partial class UI : MaterialForm
    {
        public int time = 0;
        public int cycles = 0;
        private static readonly Random rand = new Random();
        System.Media.SoundPlayer work = new System.Media.SoundPlayer("work.wav");
        System.Media.SoundPlayer pause = new System.Media.SoundPlayer("pause.wav");
        public UI()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            lblTimer.ForeColor = Color.FromArgb(0x37474F);
            lblMessage.ForeColor = Color.FromArgb(0x37474F);
            lblCycles.ForeColor = Color.FromArgb(0x37474F);
            lblCyclesTxt.ForeColor = Color.FromArgb(0x37474F);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            time++;
            lblTimer.Text = time.ToString();

            if(time == 52 && lblMessage.Text == "minutes of work")
            {
                time = 0;
                lblMessage.Text = "minutes of pause";

                if (chkSounds.Checked == true)
                {
                    pause.Play();
                }
                lblTimer.Text = time.ToString();

                if (iconTray.Visible == true)
                {
                    iconTray.BalloonTipText = "Have a break.";
                    iconTray.BalloonTipTitle = "5217 For Better Productivity";
                    iconTray.ShowBalloonTip(500);
                }

                lblTimer.ForeColor = Color.FromArgb(0x1565C0);
                lblMessage.ForeColor = Color.FromArgb(0x1565C0);
            }

            if(time == 17 && lblMessage.Text == "minutes of pause")
            {
                time = 0;
                lblMessage.Text = "minutes of work";

                if (chkSounds.Checked == true)
                {
                    work.Play();
                }

                lblTimer.Text = time.ToString();

                if (iconTray.Visible == true)
                {
                    iconTray.BalloonTipText = "Get back to work.";
                    iconTray.BalloonTipTitle = "5217 For Better Productivity";
                    iconTray.ShowBalloonTip(500);
                }

                    cycles++;
                lblCycles.Text = cycles.ToString();

                lblTimer.ForeColor = Color.FromArgb(0x37474F);
                lblMessage.ForeColor = Color.FromArgb(0x37474F);
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            chkSounds.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            lblTimer.ForeColor = Color.FromArgb(0x37474F);
            lblMessage.ForeColor = Color.FromArgb(0x37474F);
            lblMessage.Text = "minutes of work";
            time = 0;

            lblTimer.Text = "0";

            chkSounds.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTimer.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists("cycles.txt"))
            {
                using (StreamWriter sw = File.AppendText("cycles.txt"))
                {
                    sw.WriteLine(DateTime.Today.ToString("d") + " - "+lblCycles.Text + " cycles.");
                    
                }
            }
        }

        private void btnTray_Click(object sender, EventArgs e)
        {
            iconTray.Visible = true;
            iconTray.BalloonTipText = "I'm here!";
            iconTray.BalloonTipTitle = "5217 For Better Productivity";
            iconTray.ShowBalloonTip(500);

            this.Hide();
        }

        private void iconTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            iconTray.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please visit the page of the project: https://github.com/adrenaline96", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
