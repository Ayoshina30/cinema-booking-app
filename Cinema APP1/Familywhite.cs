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
    public partial class Familywhite : Form
    {
        private string Emailinput;
        private string membership;
        public Familywhite(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            LoadDPage();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Familywhite_Load(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "trailer1.mp4");
            File.WriteAllBytes(tempPath, Properties.Resources.trailer1);

            axWindowsMediaPlayer2.uiMode = "none";
            axWindowsMediaPlayer2.enableContextMenu = false;
            axWindowsMediaPlayer2.URL = tempPath;
            axWindowsMediaPlayer2.Ctlcontrols.stop(); // Start pause
            axWindowsMediaPlayer2.Ctlcontrols.play();
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
            catch (Exception ex)
            {
                MessageBox.Show("couldn't close file " + ex.Message);
            }
        }
        private void Lightmodebutton_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Familyblack secondForm = new Familyblack(Emailinput, membership);
            secondForm.FormClosed -= (s, args) => this.Close();
            secondForm.Show();
            this.Hide();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Familyblack secondForm = new Familyblack(Emailinput, membership);
            secondForm.FormClosed -= (s, args) => this.Close();
            secondForm.Show();
            this.Hide();
        }

        private void Familybutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you're already on this page");
            
        }

        private void Cinemabutton_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Cinemawhite homepageForm = new Cinemawhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void Experiencebutton_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            Experiencewhite homepageForm = new Experiencewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

       
        

        private void Filmbutton_Click(object sender, EventArgs e)
        {
            StopandDisposevideo();
            hompagewhite homepageForm = new hompagewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

      

        private void signinbutton_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
