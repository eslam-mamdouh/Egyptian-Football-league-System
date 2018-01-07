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
    public partial class FixturePlayers : UserControl
    {
        public string Player_Name;
        public string Squad_Num;
        public FixturePlayers()
        {
            InitializeComponent();
        }

        private void FixturePlayers_Load(object sender, EventArgs e)
        {
            PlayerName.Text = this.Player_Name;
            SquadNum.Text = this.Squad_Num;   
        }
    }
}
