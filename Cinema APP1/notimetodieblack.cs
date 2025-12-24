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
    public partial class notimetodieblack : Form
    {
        private string Emailinput;
        private string membership;
        public notimetodieblack(string emailinput, string membership)
        {
            InitializeComponent();
            Emailinput = emailinput;
            this.membership = membership;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hompageblack home = new Hompageblack(Emailinput, membership);
            home.Show();
            this.Close();
        }
    }
}
