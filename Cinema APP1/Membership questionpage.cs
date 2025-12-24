using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cinema_APP1
{
    public partial class Membership_questionpage : Form
    {
        private string Firstname;
        private string Lastname;
        private string Email;
        private string Password;
        private string SelectedMembership = "";

        public Membership_questionpage(string Firstname, string Lastname, string Email, string Password)
        {
            InitializeComponent();
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Password = Password;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ultimatebutton_Click(object sender, EventArgs e)
        {
            SelectedMembership = "ShinAs Ultimate";
            SaveUserAndContinue();
        }

        private void guestbutton_Click(object sender, EventArgs e)
        {
            SelectedMembership = "Guest";
            SaveUserAndContinue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedMembership = "ShinAs Extras";
            SaveUserAndContinue();
        }

        private void SaveUserAndContinue()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.csv");
            string userData = $"{Firstname},{Lastname},{Email},{Password},{SelectedMembership}";

            File.AppendAllText(filePath, userData + Environment.NewLine);

            MessageBox.Show("Registration Successful");

            Sign_In_page signIn = new Sign_In_page();
            this.Hide();
            signIn.FormClosed += (s, args) => this.Close(); // Close membership form when sign-in is done
            signIn.ShowDialog();

        }

        private void Membership_questionpage_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void extrabutton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                SelectedMembership = "ShinAs Extras";
                SaveUserAndContinue();
            }

        private void Discoverbtn1_Click(object sender, EventArgs e)
        {
            SelectedMembership = "ShinAs Ultimate";
            SaveUserAndContinue();
        }

        private void guestbutton_Click_1(object sender, EventArgs e)
        {
            SelectedMembership = "Guest";
            SaveUserAndContinue();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sign_In_page signIn = new Sign_In_page();
            this.Hide();
            signIn.FormClosed += (s, args) => this.Close(); // Close membership form when sign-in is done
            signIn.ShowDialog();
        }
    }
}