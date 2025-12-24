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
    public partial class Sign_In_page : Form
    {
        public Sign_In_page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signuplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
         
            sign_up_page signUp = new sign_up_page();
            signUp.ShowDialog();
            // optional: show Sign In again after

        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            string Emailinput = Emailtextbox.Text.Trim();
            string Passwordinput = Passwordtextbox.Text.Trim();

            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.csv");
            if (string.IsNullOrWhiteSpace(Emailinput) || string.IsNullOrWhiteSpace(Passwordinput))
            {
                MessageBox.Show("Please enter your email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath); // Read all lines from file

                foreach (string line in lines)
                {
                    string[] paths = line.Split(','); // Split data into an array

                    // Basic structure check: email is [2], password is [3]
                    if (paths.Length < 4)
                        continue;

                    if (paths[2] == Emailinput && paths[3] == Passwordinput)
                    {
                        string firstName = paths[0];

                        // Safely get membership if available, else default to "Guest"
                        string membership = paths.Length > 4 && !string.IsNullOrWhiteSpace(paths[4])
                                            ? paths[4]
                                            : "Guest";
                        MessageBox.Show($"you're logged in successfully welcome {paths[2]}, {paths[4]}");
                        this.Hide(); // Hide the sign-in page first
                        Hompageblack dashboard = new Hompageblack(Emailinput, membership);
                        dashboard.FormClosed += (s, args) => this.Close(); // Close sign-in after dashboard closes
                        dashboard.Show();

                        return; //  EXIT after successful login
                    }
                }
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("User Login  not found! please register if you don't hav an account",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Sign_In_page_Load(object sender, EventArgs e)
        {
            // Hide the password initially
            Passwordtextbox.UseSystemPasswordChar = true;

            // Initialize checkbox text
            chkShowpassword.Text = "Show Password";
        }

        private void chkShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpassword.Checked)
            {
                // Show the password
                Passwordtextbox.UseSystemPasswordChar = false;
                chkShowpassword.Text = "Hide Password";
            }
            else
            {
                // Hide the password
                Passwordtextbox.UseSystemPasswordChar = true;
                chkShowpassword.Text = "Show Password";
            }
        }
    }

}
            
           





        

