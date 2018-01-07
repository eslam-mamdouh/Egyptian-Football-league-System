using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egyptian_Football_League
{
    public partial class ObFixture : UserControl
    {
        public int id;
        public string date;
        public string time;
        public ObFixture()
        {
            InitializeComponent();
        }

        private void ObFixture_Load(object sender, EventArgs e)
        {
            TxtID.Text = this.id.ToString();
            TxtDate.Text = this.date;
            TxtTime.Text = this.time;
        }
    }
}
