namespace Egyptian_Football_League
{
    partial class Team
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.TeamID = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TeamName = new System.Windows.Forms.Label();
            this.Coach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CoachUpd = new System.Windows.Forms.TextBox();
            this.TName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Snow;
            this.Delete.Location = new System.Drawing.Point(345, 7);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 30);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(62)))), ((int)(((byte)(48)))));
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Snow;
            this.Edit.Location = new System.Drawing.Point(427, 7);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(76, 30);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // TeamID
            // 
            this.TeamID.AutoSize = true;
            this.TeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamID.Location = new System.Drawing.Point(27, 13);
            this.TeamID.Name = "TeamID";
            this.TeamID.Size = new System.Drawing.Size(19, 20);
            this.TeamID.TabIndex = 2;
            this.TeamID.Text = "1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 46);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(106, 15);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(56, 16);
            this.TeamName.TabIndex = 4;
            this.TeamName.Text = "Al Ahly";
            // 
            // Coach
            // 
            this.Coach.AutoSize = true;
            this.Coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coach.Location = new System.Drawing.Point(230, 15);
            this.Coach.Name = "Coach";
            this.Coach.Size = new System.Drawing.Size(65, 16);
            this.Coach.TabIndex = 5;
            this.Coach.Text = "Hossam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CoachUpd);
            this.panel1.Controls.Add(this.TName);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Location = new System.Drawing.Point(52, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 45);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CoachUpd
            // 
            this.CoachUpd.Location = new System.Drawing.Point(215, 12);
            this.CoachUpd.Name = "CoachUpd";
            this.CoachUpd.Size = new System.Drawing.Size(100, 20);
            this.CoachUpd.TabIndex = 4;
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(71, 12);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(100, 20);
            this.TName.TabIndex = 3;
            this.TName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(62)))), ((int)(((byte)(48)))));
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Snow;
            this.Save.Location = new System.Drawing.Point(374, 7);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(76, 30);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Coach);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.TeamID);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.Name = "Team";
            this.Size = new System.Drawing.Size(517, 46);
            this.Load += new System.EventHandler(this.Team_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label TeamID;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label Coach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CoachUpd;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Button Save;
    }
}
