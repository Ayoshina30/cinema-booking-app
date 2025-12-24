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
    public partial class Experienceblack : Form
    {
        private string Emailinput;
        private string membership;
        public Experienceblack(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hompageblack homepageForm = new Hompageblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form

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

        private void Familybutton_Click(object sender, EventArgs e)
        {
            Familyblack secondForm = new Familyblack(Emailinput, membership);
            secondForm.FormClosed -= (s, args) => this.Close();
            secondForm.Show();
            this.Hide();
        }

        private void Lightmodebutton_Click(object sender, EventArgs e)
        {
            Experiencewhite homepageForm = new Experiencewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current for
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Experiencewhite homepageForm = new Experiencewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current for
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {

            Dashboard familybook = new Dashboard(Emailinput, membership);
            familybook.Show();
            this.Hide();
            
        }

        private void Experienceblack_Load(object sender, EventArgs e)
        {

        }
    }
}
