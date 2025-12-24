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
    public partial class Experiencewhite : Form
    {
        private string Emailinput;
        private string membership;
        public Experiencewhite(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Experienceblack homepageForm = new Experienceblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current for
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Lightmodebutton_Click(object sender, EventArgs e)
        {
            Experienceblack homepageForm = new Experienceblack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current for
        }

        private void Familybutton_Click(object sender, EventArgs e)
        {

            Familywhite homepageForm = new Familywhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void Cinemabutton_Click(object sender, EventArgs e)
        {
            Cinemawhite homepageForm = new Cinemawhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void Experiencebutton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("you're already on this page");
        }

     

        private void Filmbutton_Click(object sender, EventArgs e)
        {
            hompagewhite homepageForm = new hompagewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            
            Dashboard familybook = new Dashboard(Emailinput, membership);
            familybook.Show();
            this.Hide();
        }

        private void Experiencewhite_Load(object sender, EventArgs e)
        {

        }
    }
}
