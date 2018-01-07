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
    public partial class PlayersInFixture : Form
    {
        public PlayersInFixture()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=League Football Management System;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("PlayersInFixture", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AwayTeamName", TeamName.Text);
                cmd.Parameters.AddWithValue("@FixtureId", Int32.Parse(FixID.Text));
                SqlDataReader reader = cmd.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    FixturePlayers P = new FixturePlayers();
                    P.Player_Name = (string)reader["fname"] + " " + (string)reader["lname"];
                    P.Squad_Num = (string)reader["squad_num"].ToString();
                    flowLayoutPanel1.Controls.Add(P);
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
            this.Close();
        }
    }
}
