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
    public partial class DisFixture : Form
    {
        private Label Comp_Nam;
        private Button Display;
        private TextBox TeamName;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label TxtDate;
        private TextBox FixID;
        private Label TxtTime;
        private TextBox textBox1;
    
        public DisFixture()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisFixture));
            this.Comp_Nam = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Button();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtDate = new System.Windows.Forms.Label();
            this.FixID = new System.Windows.Forms.TextBox();
            this.TxtTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Comp_Nam
            // 
            this.Comp_Nam.AutoSize = true;
            this.Comp_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comp_Nam.Location = new System.Drawing.Point(106, 44);
            this.Comp_Nam.Name = "Comp_Nam";
            this.Comp_Nam.Size = new System.Drawing.Size(135, 16);
            this.Comp_Nam.TabIndex = 31;
            this.Comp_Nam.Text = "Competition Name";
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(62)))), ((int)(((byte)(48)))));
            this.Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(436, 67);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(83, 30);
            this.Display.TabIndex = 30;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // TeamName
            // 
            this.TeamName.Location = new System.Drawing.Point(251, 43);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(154, 20);
            this.TeamName.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 30);
            this.panel1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Display The Players at a Fixture Played";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImage = global::Egyptian_Football_League.Properties.Resources.bg1;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 145);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(678, 300);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // TxtDate
            // 
            this.TxtDate.AutoSize = true;
            this.TxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(106, 74);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(133, 16);
            this.TxtDate.TabIndex = 34;
            this.TxtDate.Text = "Date                      :";
            // 
            // FixID
            // 
            this.FixID.Location = new System.Drawing.Point(251, 73);
            this.FixID.Name = "FixID";
            this.FixID.Size = new System.Drawing.Size(154, 20);
            this.FixID.TabIndex = 33;
            // 
            // TxtTime
            // 
            this.TxtTime.AutoSize = true;
            this.TxtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTime.Location = new System.Drawing.Point(106, 100);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(131, 16);
            this.TxtTime.TabIndex = 36;
            this.TxtTime.Text = "Time                     :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 35;
            // 
            // DisFixture
            // 
            this.BackgroundImage = global::Egyptian_Football_League.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(678, 442);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Comp_Nam);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.FixID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisFixture";
            this.Load += new System.EventHandler(this.DisFixture_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DisFixture_Load(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=League Football Management System;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("GetFixurePlayed", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CompetitionName", Comp_Nam.Text);
                cmd.Parameters.AddWithValue("@Date ",TxtDate.Text);
                cmd.Parameters.AddWithValue("@Time ",TxtTime.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    ObFixture fix = new ObFixture();
                    fix.id = (int)reader["fixture_id"];
                    fix.date = (string)reader["date"].ToString();
                    fix.time = (string)reader["time"].ToString();
                    flowLayoutPanel1.Controls.Add(fix);
                }

                reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
