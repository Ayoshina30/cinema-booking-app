using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_APP1
{
    public partial class Cinemablack : Form
    {
        private string Emailinput;
        private string membership;
        public Cinemablack(string emailinput , string membership)
        {
            InitializeComponent();
            Emailinput= emailinput; ;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Familybutton_Click(object sender, EventArgs e)
        {
            Familyblack secondForm = new Familyblack(Emailinput, membership);
            secondForm.FormClosed -= (s, args) => this.Close();
            secondForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Filmbutton_Click(object sender, EventArgs e)
        {
            Hompageblack homepageForm = new Hompageblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void Cinemabutton_Click(object sender, EventArgs e)
        {
            Cinemablack homepageForm = new Cinemablack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void Experiencebutton_Click(object sender, EventArgs e)
        {
            Experienceblack homepageForm = new Experienceblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void Lightmodebutton_Click(object sender, EventArgs e)
        {
            Cinemawhite homepageForm = new Cinemawhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cinemawhite homepageForm = new Cinemawhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
          
            Dashboard familybook = new Dashboard(Emailinput, membership);
            familybook.Show();
            this.Hide();
        }

        private void Cinemablack_Load(object sender, EventArgs e)
        {

        }
    }
}
