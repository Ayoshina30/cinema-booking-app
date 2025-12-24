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
    public partial class elixirwhite : Form
    {
        private string Emailinput;
        private string membership;

        public elixirwhite(string emailinput, string memberahip)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hompagewhite elixir = new hompagewhite(Emailinput, membership);
            elixir.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
