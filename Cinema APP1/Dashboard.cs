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

namespace Cinema_APP1
{
    public partial class Dashboard : Form
    {
        string username;
        string Membershiptype;
        public Dashboard(string Emailinput, string Membership)
        {
            InitializeComponent();
            username = Emailinput;
            Membershiptype = Membership;
            usernamelabel.Text = $"{Emailinput}";
            Membershiplabel.Text = $"{Membership}";
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadDashboard(); // Call a method to update the UI based on user info
        }
        private void LoadDashboard()
        {
            if (Membershiptype.Trim().ToLower() == "guest")
            {
                FAMILYMOVIES.Visible = false;

                // Move the PastBookingPanel up to fill the space left by FAMILYMOVIES
                panel11.Top = FAMILYMOVIES.Top;

                // Show info label
                familylabel.Visible = true;
                familylabel.Text = "UPGRADE MEMBERSHIP TO ACCESS FAMILY MOVIES";
                familylabel.Left = (this.ClientSize.Width - familylabel.Width) / 2;
                familylabel.Top = panel11.Top - 30; // optional, place above panel
            }
            else
            {
                FAMILYMOVIES.Visible = true;

                // Move PastBookingPanel back below FAMILYMOVIES
                panel11.Top = FAMILYMOVIES.Bottom + 10;

                familylabel.Visible = true;
            }

            dataGridView1.Visible = false;
        }







        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bookbutton_Click(object sender, EventArgs e)
        {

            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void bookbutton3_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void bookbutton4_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void bookbutton1_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void bookbutton5_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void bookbutton2_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            booking_page bookinpage = new booking_page(username, Membershiptype);
            bookinpage.Show();
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Sign_In_page hompageblack = new Sign_In_page();
            hompageblack.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Hompageblack hompageblack = new Hompageblack(username, Membershiptype);
            hompageblack.Show();
            this.Close();
        }

        private void viewbookingbutton_Click(object sender, EventArgs e)
        {

            LoadPastBookings();
            dataGridView1.Visible = true;
        }
        private void LoadPastBookings()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Updated columns
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("Membership", "Membership");
            dataGridView1.Columns.Add("Movie", "Movie");
            dataGridView1.Columns.Add("Seat", "Seat");
            dataGridView1.Columns.Add("AdultTickets", "Adult Tickets");
            dataGridView1.Columns.Add("ChildTickets", "Child Tickets");
            dataGridView1.Columns.Add("Total", "Total");

            if (File.Exists("booking_history.csv"))
            {
                string[] bookings = File.ReadAllLines("booking_history.csv");
                foreach (string line in bookings)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 7 && parts[0] == username)
                    {
                        // Explicitly map each field
                        dataGridView1.Rows.Add(
                            parts[0], // Username
                            parts[1], // Membership
                            parts[2], // Movie
                            parts[3], // Seat No.X
                            parts[4], // X Adults
                            parts[5], // Y Children
                            parts[6]  // Total
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("No booking history found.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hompageblack hompageblack = new Hompageblack(username, Membershiptype);
            hompageblack.Show();
            this.Hide();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private bool isDarkMode = false;

       

        private void toggleModeButtom_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                // Light mode
                Color bg = Color.FromArgb(242, 235, 250);
                this.BackColor = bg;
                this.ForeColor = Color.Black;
                ApplyTheme(this.Controls, Color.Black, bg);
            }
            else
            {
                // Dark mode
                Color bg = Color.FromArgb(15, 5, 20);
                this.BackColor = bg;
                this.ForeColor = SystemColors.ControlLight;
                ApplyTheme(this.Controls, SystemColors.ControlLight, bg);
            }

            isDarkMode = !isDarkMode;
        }

        private void ApplyTheme(Control.ControlCollection controls, Color textColor, Color bgColor)
        {
            foreach (Control ctrl in controls)
            {
                ctrl.ForeColor = textColor;

                if (ctrl is Button)
                {
                    // Keep button BackColor unchanged
                    // Just update ForeColor (already done)
                }
                else if (ctrl is Label || ctrl is Panel || ctrl is GroupBox || ctrl is FlowLayoutPanel)
                {
                    ctrl.BackColor = Color.Transparent;
                }
                else
                {
                    ctrl.BackColor = bgColor;
                }

                if (ctrl.HasChildren)
                {
                    ApplyTheme(ctrl.Controls, textColor, bgColor);
                }
            }
        }

    }
}
    
   



