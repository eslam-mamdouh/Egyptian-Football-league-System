using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Egyptian_Football_League
{
    public partial class Team : UserControl
    {
        public int Id;
        public string Team_Name;
        public string Team_Coach;
        public Team()
        {
          InitializeComponent();
        }

        private void Team_Load(object sender, EventArgs e)
        {
            TeamID.Text = this.Id.ToString();
            TeamName.Text = this.Team_Name;
            Coach.Text = this.Team_Coach;

            TName.Text = this.Team_Name;
            CoachUpd.Text = this.Team_Coach;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=League Football Management System;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("DeleteTeam", con);
                cmd.Parameters.AddWithValue("@TeamId", this.Id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();
                con.Close();
                this.Hide();

               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=League Football Management System;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateTeam", con);
                cmd.Parameters.AddWithValue("@TeamID", this.Id);
                cmd.Parameters.AddWithValue("@Name", TName.Text);
                cmd.Parameters.AddWithValue("@coach", CoachUpd.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteReader();
                con.Close();
                panel1.Visible = false;
                
                
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
