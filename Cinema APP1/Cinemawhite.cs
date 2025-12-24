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
    public partial class Cinemawhite : Form
    {
        private string Emailinput;
        private string membership;
        public Cinemawhite(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Lightmodebutton_Click(object sender, EventArgs e)
        {
            Cinemablack homepageForm = new Cinemablack(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide(); // Hide the current form
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cinemablack homepageForm = new Cinemablack(Emailinput, membership);
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

        private void Familybutton_Click(object sender, EventArgs e)
        {
           
            Familywhite homepageForm = new Familywhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void Cinemabutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you're already on this page");
        }

        private void Experiencebutton_Click(object sender, EventArgs e)
        {
            Experiencewhite homepageForm = new Experiencewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();

        }

        private void Filmbutton_Click(object sender, EventArgs e)
        {
            hompagewhite homepageForm = new hompagewhite(Emailinput, membership);
            homepageForm.FormClosed += (s, args) => this.Close();
            homepageForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cinemawhite_Load(object sender, EventArgs e)
        {

        }
    }
}
