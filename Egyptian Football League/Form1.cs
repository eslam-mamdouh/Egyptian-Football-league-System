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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=League Football Management System;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from Team", con);

                SqlDataReader reader = cmd.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    Team New_Team = new Team();
                    New_Team.Id = (int)reader["team_id"];
                    New_Team.Team_Name = (string)reader["team_name"];
                    New_Team.Team_Coach = (string)reader["coach"];
                    flowLayoutPanel1.Controls.Add(New_Team);
                }

                reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (checked_Add.Text.ToString() == "Team")
                {
                    this.Hide();
                    AddTeam t = new AddTeam();
                    t.ShowDialog();
                }

                if (checked_Add.Text.ToString() == "Player")
                {
                    this.Hide();
                    AddPlayer p = new AddPlayer();
                    p.ShowDialog();
                }

                if (checked_Add.Text.ToString() == "Competition")
                {
                    this.Hide();
                    Competition C = new Competition();
                    C.ShowDialog();
                }

                if (checked_Add.Text.ToString() == "Fixture")
                {
                    this.Hide();
                    AddFixture f = new AddFixture();
                    f.ShowDialog();
                }

                if (checked_Add.Text.ToString() == "Position")
                {
                    this.Hide();
                    AddPosition f = new AddPosition();
                    f.ShowDialog();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Display_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (CheckedDisplay.Text.ToString() == "Goals")
                {
                    this.Hide();
                    Goals t = new Goals();
                    t.ShowDialog();
                }

                if (CheckedDisplay.Text.ToString() == "Player")
                {
                    this.Hide();
                    PlayersInFixture f = new PlayersInFixture();
                    f.Show();
                }


                if (CheckedDisplay.Text.ToString() == "Fixture")
                {
                    this.Hide();
                    DisFixture f = new DisFixture();
                    f.ShowDialog();

                }

                if (CheckedDisplay.Text.ToString() == "Position")
                {
                    this.Hide();
                    DisplayPosition f = new DisplayPosition();
                    f.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckedDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
