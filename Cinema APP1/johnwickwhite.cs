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
    public partial class johnwickwhite : Form
    {
        private string Emailinput;
        private string membership;
        public johnwickwhite(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hompagewhite home = new hompagewhite(Emailinput, membership);
            home.Show();
            this.Hide();
        }
    }
}
