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
using System.Net.NetworkInformation;

namespace Cinema_APP1
{
    public partial class sign_up_page : Form
    {
        

        public sign_up_page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void signinlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Hide();
            Sign_In_page signUp = new Sign_In_page();
            signUp.ShowDialog();
            this.Show(); // optional: show Sign In again after

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sign_up_page_Load(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string Email = Emailtextbox.Text;
                string Firstname = Firstnametextbox.Text;
                string Lastname = Lastnametextbox.Text;
                string Password = Passwordtextbox.Text;

                if (string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Lastname) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("pls fill in your details in all field provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Userdata = $"{Firstname},{Lastname},{Email},{Password},";
                MessageBox.Show("Succesful ,Now choose a Membership");

                Emailtextbox.Clear();
                Firstnametextbox.Clear();
                Lastnametextbox.Clear();
                Passwordtextbox.Clear();

                

                Membership_questionpage membershipForm = new Membership_questionpage(
                Firstname,
                Lastname,
                Email,
                Password);
                this.Hide(); // Hide the Sign-Up page
                membershipForm.FormClosed += (s, args) => this.Close(); // Close Sign-Up when membership is done
                membershipForm.ShowDialog(); //

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user data: {ex.Message}");
            }
        }
    }
}
