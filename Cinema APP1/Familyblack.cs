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
using AxWMPLib;

namespace Cinema_APP1
{
    public partial class Familyblack : Form
    {
        private string Emailinput;
        private string membership;
        public Familyblack(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadDPage();
        }

        private void Familyblack_Load(object sender, EventArgs e)
        {
            
            string tempPath = Path.Combine(Path.GetTempPath(), "trailer1.mp4");
            File.WriteAllBytes(tempPath, Properties.Resources.trailer1);

            axWindowsMediaPlayer2.uiMode = "none";
            axWindowsMediaPlayer2.enableContextMenu = false;
            axWindowsMediaPlayer2.stretchToFit = true; axWindowsMediaPlayer2.Parent = panel1;
            axWindowsMediaPlayer2.Dock = DockStyle.Fill;
                    
            axWindowsMediaPlayer2.URL = tempPath;
            axWindowsMediaPlayer2.Ctlcontrols.stop(); // Start pause
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }
        private void Hompageblack_Resize(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Width = this.ClientSize.Width;
            axWindowsMediaPlayer2.Height = this.ClientSize.Height;
        }

        private void LoadDPage()
        {
            if (membership.Trim().ToLower() == "guest")
            {
                familybookbtn1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                familybookbtn1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
        }
        public void StopandDisposevideo()
        {
            try
            {
                if (axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying || axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPaused) ;
                {
                    axWindowsMediaPlayer2.Ctlcontrols.stop();
                }
                axWindowsMediaPlayer2.close();
                axWindowsMediaPlayer2.Dispose();

            }
            catch(Exception ex) { 
            MessageBox.Show("couldn't close file " + ex.Message);
            }
        }
  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Hompageblack homepageForm = new Hompageblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void Filmbutton_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Hompageblack homepageForm = new Hompageblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

      

        private void Cinemabutton_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Cinemablack homepageForm = new Cinemablack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void Experiencebutton_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Experienceblack homepageForm = new Experienceblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void Familybutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you're on family page");
        }

        private void Lightmodebutton_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Familywhite secondForm = new Familywhite(Emailinput, membership);
            secondForm.FormClosed -= (s, args) => this.Close();
            secondForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Familywhite secondForm = new Familywhite(Emailinput, membership);
            secondForm.FormClosed -= (s, args) => this.Close();
            secondForm.Show();
            this.Hide();
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void signinbutton_Click(object sender, EventArgs e)
        {

            StopandDisposevideo();
            Dashboard familybook = new Dashboard(Emailinput, membership);
            familybook.Show();
            this.Hide();
        }

        private void familybookbtn1_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Dashboard familybook = new Dashboard(Emailinput, membership);
            familybook.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Dashboard familybook = new Dashboard(Emailinput, membership);
            familybook.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Dashboard familybook = new Dashboard(Emailinput, membership);
            familybook.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

