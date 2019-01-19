namespace VProzzleFix
{
    partial class Options
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
            this.BGMusic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PBMusic = new System.Windows.Forms.PictureBox();
            this.lbMusic = new System.Windows.Forms.Label();
            this.PBBackOption = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BGMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBackOption)).BeginInit();
            this.SuspendLayout();
            // 
            // BGMusic
            // 
            this.BGMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGMusic.Image = global::VProzzleFix.Properties.Resources.BGChoice;
            this.BGMusic.Location = new System.Drawing.Point(0, 0);
            this.BGMusic.Name = "BGMusic";
            this.BGMusic.Size = new System.Drawing.Size(804, 605);
            this.BGMusic.TabIndex = 0;
            this.BGMusic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Music";
            // 
            // PBMusic
            // 
            this.PBMusic.BackColor = System.Drawing.Color.Green;
            this.PBMusic.Location = new System.Drawing.Point(639, 69);
            this.PBMusic.Name = "PBMusic";
            this.PBMusic.Size = new System.Drawing.Size(100, 37);
            this.PBMusic.TabIndex = 2;
            this.PBMusic.TabStop = false;
            this.PBMusic.Click += new System.EventHandler(this.PBMusic_Click);
            // 
            // lbMusic
            // 
            this.lbMusic.AutoSize = true;
            this.lbMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusic.Location = new System.Drawing.Point(672, 79);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(36, 24);
            this.lbMusic.TabIndex = 3;
            this.lbMusic.Text = "On";
            // 
            // PBBackOption
            // 
            this.PBBackOption.Image = global::VProzzleFix.Properties.Resources.BACK;
            this.PBBackOption.Location = new System.Drawing.Point(44, 534);
            this.PBBackOption.Name = "PBBackOption";
            this.PBBackOption.Size = new System.Drawing.Size(192, 65);
            this.PBBackOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBackOption.TabIndex = 4;
            this.PBBackOption.TabStop = false;
            this.PBBackOption.Click += new System.EventHandler(this.PBBackOption_Click);
            this.PBBackOption.MouseEnter += new System.EventHandler(this.PBBackOption_MouseEnter);
            this.PBBackOption.MouseLeave += new System.EventHandler(this.PBBackOption_MouseLeave);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 605);
            this.Controls.Add(this.PBBackOption);
            this.Controls.Add(this.lbMusic);
            this.Controls.Add(this.PBMusic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BGMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBackOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BGMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBMusic;
        private System.Windows.Forms.Label lbMusic;
        private System.Windows.Forms.PictureBox PBBackOption;
    }
}