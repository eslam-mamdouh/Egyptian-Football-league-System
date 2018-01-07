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
    public partial class DisPosition : UserControl
    {
        public string Player_Name;
        public string Position;
        public DisPosition()
        {
            InitializeComponent();
        }

        private void CoachUpd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
        }

        private void DisPosition_Load(object sender, EventArgs e)
        {
            PlayerName.Text = this.Player_Name;
            PositionName.Text = this.Position;
        }
    }
}
