namespace Egyptian_Football_League
{
    partial class ObFixture
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
            this.TxtDate = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TxtTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDate
            // 
            this.TxtDate.AutoSize = true;
            this.TxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(168, 9);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(41, 16);
            this.TxtDate.TabIndex = 15;
            this.TxtDate.Text = "Date";
            // 
            // TxtID
            // 
            this.TxtID.AutoSize = true;
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(66, 9);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(16, 16);
            this.TxtID.TabIndex = 14;
            this.TxtID.Text = "1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 36);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // TxtTime
            // 
            this.TxtTime.AutoSize = true;
            this.TxtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTime.Location = new System.Drawing.Point(326, 9);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(43, 16);
            this.TxtTime.TabIndex = 16;
            this.TxtTime.Text = "Time";
            // 
            // ObFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.splitter1);
            this.Name = "ObFixture";
            this.Size = new System.Drawing.Size(420, 36);
            this.Load += new System.EventHandler(this.ObFixture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtDate;
        private System.Windows.Forms.Label TxtID;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label TxtTime;
    }
}
