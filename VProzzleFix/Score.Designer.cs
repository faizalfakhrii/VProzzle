namespace VProzzleFix
{
    partial class Score
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVScore = new System.Windows.Forms.DataGridView();
            this.lbScore = new System.Windows.Forms.Label();
            this.PBBackScore = new System.Windows.Forms.PictureBox();
            this.BGScore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBackScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGScore)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVScore
            // 
            this.DGVScore.AllowUserToAddRows = false;
            this.DGVScore.AllowUserToDeleteRows = false;
            this.DGVScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVScore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DGVScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVScore.Location = new System.Drawing.Point(40, 65);
            this.DGVScore.Name = "DGVScore";
            this.DGVScore.ReadOnly = true;
            this.DGVScore.Size = new System.Drawing.Size(717, 458);
            this.DGVScore.TabIndex = 2;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(353, 21);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(85, 31);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "Score";
            // 
            // PBBackScore
            // 
            this.PBBackScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBBackScore.Image = global::VProzzleFix.Properties.Resources.BACK;
            this.PBBackScore.Location = new System.Drawing.Point(40, 529);
            this.PBBackScore.Name = "PBBackScore";
            this.PBBackScore.Size = new System.Drawing.Size(192, 65);
            this.PBBackScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBackScore.TabIndex = 1;
            this.PBBackScore.TabStop = false;
            this.PBBackScore.Click += new System.EventHandler(this.PBBackScore_Click_1);
            this.PBBackScore.MouseEnter += new System.EventHandler(this.PBBackScore_MouseEnter_1);
            this.PBBackScore.MouseLeave += new System.EventHandler(this.PBBackScore_MouseLeave_1);
            // 
            // BGScore
            // 
            this.BGScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGScore.Image = global::VProzzleFix.Properties.Resources.BGChoice;
            this.BGScore.Location = new System.Drawing.Point(0, 0);
            this.BGScore.Name = "BGScore";
            this.BGScore.Size = new System.Drawing.Size(804, 605);
            this.BGScore.TabIndex = 0;
            this.BGScore.TabStop = false;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 605);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.DGVScore);
            this.Controls.Add(this.PBBackScore);
            this.Controls.Add(this.BGScore);
            this.MaximizeBox = false;
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBackScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BGScore;
        private System.Windows.Forms.PictureBox PBBackScore;
        private System.Windows.Forms.DataGridView DGVScore;
        private System.Windows.Forms.Label lbScore;
    }
}