namespace Egyptian_Football_League
{
    partial class GoalsData
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
            this.Goals_Num = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // Goals_Num
            // 
            this.Goals_Num.AutoSize = true;
            this.Goals_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goals_Num.Location = new System.Drawing.Point(246, 9);
            this.Goals_Num.Name = "Goals_Num";
            this.Goals_Num.Size = new System.Drawing.Size(49, 16);
            this.Goals_Num.TabIndex = 18;
            this.Goals_Num.Text = "Goals";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(71, 9);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(98, 16);
            this.PlayerName.TabIndex = 17;
            this.PlayerName.Text = "Player Name";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 36);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // GoalsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Goals_Num);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(150, 3, 3, 3);
            this.Name = "GoalsData";
            this.Size = new System.Drawing.Size(326, 36);
            this.Load += new System.EventHandler(this.GoalsData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Goals_Num;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Splitter splitter1;
    }
}
