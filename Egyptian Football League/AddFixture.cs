using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egyptian_Football_League
{
    public partial class AddFixture : Form
    {
        public AddFixture()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void AddFixture_Load(object sender, EventArgs e)
        {

        }

        private void Add_NTeam_Click(object sender, EventArgs e)
        {

        }
    }
}
