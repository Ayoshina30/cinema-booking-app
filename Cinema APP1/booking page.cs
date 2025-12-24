using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cinema_APP1
{
    public partial class booking_page : Form
    {
        private List<Button> selectedSeats = new List<Button>();

        private string Membershiptype;
        private string Username;
        private const decimal adultTicketPrice = 15.00m;
        private const decimal childTicketPrice = 10.00m;
        private const decimal memberDiscount = 0.20m;

        public booking_page(string username, string membershiptype)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Username = username;
            Membershiptype = membershiptype;
            SetupMovieAccess();
            UpdateTotalCost();
        }


        private void SetupMovieAccess()
        {
            if (Membershiptype == "Guest")
            {
                Familybox.Visible = false;
                label4.Visible = false; // Hide the label too
            }
            else
            {
                Familybox.Visible = true;
                label4.Visible = true;
            }
        }


        private void UpdateTotalCost()
        {
            int adultCount = (int)numericUpDownAdult.Value;
            int childCount = (int)numericUpDownChilld.Value;

            decimal total = (adultCount * adultTicketPrice) + (childCount * childTicketPrice);
            if (Membershiptype != "Guest")
            {
                total -= total * memberDiscount;
            }

            totallabel.Text = $"Total: £{total:F2}";
        }

        private void numericUpDownAdult_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void numericUpDownChilld_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            // Get selected movies individually
            string selectedFamilyMovie = null;
            string selectedTopMovie = null;

            if (Familybox.Visible && Familybox.SelectedItem != null)
                selectedFamilyMovie = Familybox.SelectedItem.ToString();

            if (Topmoviebox.SelectedItem != null)
                selectedTopMovie = Topmoviebox.SelectedItem.ToString();

            // Combine selected movies into a list
            List<string> selectedMovies = new List<string>();

            if (!string.IsNullOrEmpty(selectedTopMovie))
                selectedMovies.Add(selectedTopMovie);

            if (!string.IsNullOrEmpty(selectedFamilyMovie))
                selectedMovies.Add(selectedFamilyMovie);

            // Join movies into one string separated by semicolon
            string moviesCombined = string.Join(";", selectedMovies);

            // Your existing validation can check if at least one movie is selected
            if (selectedMovies.Count == 0 || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select at least one movie and fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // rest of your code here — create booking record using moviesCombined
            string seatList = string.Join(", ", selectedSeats.Select(s => s.Name));

            int adultCount = (int)numericUpDownAdult.Value;
            int childCount = (int)numericUpDownChilld.Value;
            decimal total = (adultCount * adultTicketPrice) + (childCount * childTicketPrice);
            if (adultCount == 0 && childCount == 0)
            {
                MessageBox.Show("Please select at least one adult or child ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (Membershiptype != "Guest")
            {
                total -= total * memberDiscount;
            }

            string bookingRecord = $"{Username},{Membershiptype},{moviesCombined},{seatList},{adultCount},{childCount},£{total:F2}";

            File.AppendAllText("booking_history.csv", bookingRecord + Environment.NewLine);

            MessageBox.Show("Booking confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dashboard dashboard = new Dashboard(Username, Membershiptype);
            dashboard.Show();
            this.Close();
        }

        private List<string> GetBookedSeats()
        {
            List<string> bookedSeats = new List<string>();

            if (File.Exists("booking_history.csv"))
            {
                var lines = File.ReadAllLines("booking_history.csv");

                foreach (var line in lines)
                {
                    var columns = line.Split(',');

                    if (columns.Length >= 4)
                    {
                        string seatsColumn = columns[3]; // seat info is 4th column (index 3)
                        var seats = seatsColumn.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var seat in seats)
                        {
                            bookedSeats.Add(seat.Trim());
                        }
                    }
                }
            }

            return bookedSeats;
        }

 

        private bool IsSeatName(string name)
        {
            // Checks if the name starts with a letter followed by a number, like A1, B2, etc.
            return name.Length >= 2 && char.IsLetter(name[0]) && char.IsDigit(name[1]);
        }

        private void booking_page_Load(object sender, EventArgs e)
        {
            var bookedSeats = GetBookedSeats();

            foreach (Control control in seatpanel.Controls)
            {
                if (control is Button seatButton && IsSeatName(seatButton.Name))
                {
                    seatButton.Click += SeatButton_Click;
                    seatButton.BackColor = Color.LightGray;

                    if (bookedSeats.Contains(seatButton.Name))
                    {
                        seatButton.BackColor = Color.Red;
                        seatButton.Enabled = false; // user can’t click it
                    }
                }
            }
        }
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedSeat = sender as Button;

            // If clicked seat is already selected, deselect it
            if (clickedSeat.BackColor == Color.Green)
            {
                clickedSeat.BackColor = Color.LightGray;
                selectedSeats.Clear();
                textBox1.Text = "";
                return;
            }

            // If another seat is already selected, deselect it first
            foreach (var seat in selectedSeats)
            {
                seat.BackColor = Color.LightGray;
            }
            selectedSeats.Clear();

            // Select the new seat
            clickedSeat.BackColor = Color.Green;
            selectedSeats.Add(clickedSeat);

            // Show selected seat in textbox
            textBox1.Text = clickedSeat.Name;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(Username, Membershiptype);
            dashboard.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void seatlabel_Click(object sender, EventArgs e)
        {

        }

        private void seatpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
