using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Egyptian_Football_League
{
    public partial class Goals : Form
    {
        public Goals()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=League Football Management System;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("GetGoals", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fixture_Id ", Int32.Parse( FixID.Text));
                SqlDataReader reader = cmd.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    GoalsData goal = new GoalsData();
                   goal.PName  = (string)reader["fname"] + " "+(string)reader["lname"];
                   goal.NGoals = (string)reader["goals"].ToString();
                    flowLayoutPanel1.Controls.Add(goal);
                }

                reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
    }
}

