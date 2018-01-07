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
    public partial class GoalsData : UserControl
    {
        public string PName;
        public string NGoals;
        public GoalsData()
        {
            InitializeComponent();
        }

        private void GoalsData_Load(object sender, EventArgs e)
        {
            PlayerName.Text = this.PName;
            Goals_Num.Text = this.NGoals;
        }
    }
}
