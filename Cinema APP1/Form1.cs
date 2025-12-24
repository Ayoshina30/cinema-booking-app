using System;
using System.IO;
using System.Windows.Forms;

namespace Cinema_APP1
{
    public partial class Hompageblack : Form
    {
        private string Emailinput;
        private string membership;

        public Hompageblack(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Hompageblack_Load(object sender, EventArgs e)
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

        

        private void Experiencebutton_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Experienceblack homepageForm = new Experienceblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void Familybutton_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Familyblack secondForm = new Familyblack(Emailinput, membership);
            secondForm.FormClosed += (s, args) => this.Close();
            secondForm.Show();
            this.Hide();
        }

        private void Lightmodebutton_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            hompagewhite homepageForm = new hompagewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            hompagewhite homepageForm = new hompagewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        

        private void Cinemabutton_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Cinemablack homepageForm = new Cinemablack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void Filmbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already on the Film page.");
        }

        // Optional placeholders
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void signinbutton_Click(object sender, EventArgs e) {

            Dashboard hub = new Dashboard(Emailinput, membership);
            hub.Show();
            this.Hide();
        }
        private void Hompageblack_FormClosing(object sender, FormClosingEventArgs e) { }

        
   

  
        


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            wurablack movie = new wurablack(Emailinput, membership);
            movie.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            elixirblack movie = new elixirblack(Emailinput, membership);
            movie.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            gooddoctorblack thegooddoctor = new gooddoctorblack(Emailinput, membership);
            thegooddoctor.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            Johwickblack movie = new Johwickblack(Emailinput, membership);
            movie.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            notimetodieblack movie = new notimetodieblack(Emailinput, membership);
            movie.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            StopAndDisposeVideo();
            kungfupandablack movie = new kungfupandablack(Emailinput, membership);
            movie.Show();
            this.Hide();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
