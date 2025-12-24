using System;
using System.IO;
using System.Windows.Forms;

namespace Cinema_APP1
{
    public partial class hompagewhite : Form
    {
        private string Emailinput;
        private string membership;
        public hompagewhite(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void hompagewhite_Load(object sender, EventArgs e)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "trailer2.mp4");

            // Prevent writing the file again if it's already created
            if (!File.Exists(tempPath))
            {
                File.WriteAllBytes(tempPath, Properties.Resources.trailer2);
            }

            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.enableContextMenu = false;
            axWindowsMediaPlayer1.URL = tempPath;
            axWindowsMediaPlayer1.Ctlcontrols.stop(); // prevent auto-play
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        public void StopAndDisposeVideo()
        {
            try
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying ||
                    axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }

                axWindowsMediaPlayer1.close(); // releases the file
                axWindowsMediaPlayer1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping video: " + ex.Message);
            }
        }

 
        

      

        private void Lightmodebutton_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Hompageblack homepageForm = new Hompageblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Hompageblack homepageForm = new Hompageblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        

        private void Filmbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already on the Film page.");
        }

         

        private void Cinemabutton_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Cinemawhite homepageForm = new Cinemawhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void Experiencebutton_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Experiencewhite homepageForm = new Experiencewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

   

        private void Familybutton_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Familywhite homepageForm = new Familywhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {

            StopAndDisposeVideo();
            Dashboard familybook = new Dashboard(Emailinput, membership);
            familybook.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            wurawhite wurawhite = new wurawhite(Emailinput, membership);
            wurawhite.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            elixirwhite elixirwhite = new elixirwhite(Emailinput, membership);
            elixirwhite.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            thegooddoctor thegooddoctor = new thegooddoctor(Emailinput, membership);
            thegooddoctor.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {StopAndDisposeVideo();
            johnwickwhite movie = new johnwickwhite(Emailinput, membership);
            movie.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {StopAndDisposeVideo();
            notimetodiewhite notimetodiewhite = new notimetodiewhite(Emailinput, membership); 
            notimetodiewhite.Show(); 
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {StopAndDisposeVideo(); 
            kungfupandawhite movie = new kungfupandawhite(Emailinput, membership);
            movie.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}