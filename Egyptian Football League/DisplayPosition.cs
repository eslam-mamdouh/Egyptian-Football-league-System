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
    public partial class DisplayPosition : Form
    {
        public DisplayPosition()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void DisplayPosition_Load(object sender, EventArgs e)
        {
           
        }

        private void Display_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=League Football Management System;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("GetPosition", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TeamName", TeamName.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    DisPosition Pos = new DisPosition();
                    Pos.Player_Name = (string)reader["fname"] + " "+(string)reader["lname"];
                    Pos.Position = (string)reader["pos_name"];
                    flowLayoutPanel1.Controls.Add(Pos);
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
