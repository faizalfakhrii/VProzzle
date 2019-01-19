using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VProzzleFix
{
    public partial class Options : Form
    {

        bool Music;
        VProzzle VProzzle = new VProzzle();
        public Options()
        {
            InitializeComponent();
            lbMusic.Parent = BGMusic;
            lbMusic.BackColor = Color.Transparent;
            PBBackOption.Parent = BGMusic;
            PBBackOption.BackColor = Color.Transparent;
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void PBMusic_Click(object sender, EventArgs e)
        {
            PMusic(Music);
        }

        private void PBBackOption_Click(object sender, EventArgs e)
        {
            VProzzle vprozzle = new VProzzle();
            vprozzle.Show();
            this.Close();
        }

        private void PBBackOption_MouseEnter(object sender, EventArgs e)
        {
            PBBackOption.Size = new Size(195, 70);
        }

        private void PBBackOption_MouseLeave(object sender, EventArgs e)
        {
            PBBackOption.Size = new Size(192, 65);
        }

        public bool PMusic(bool Play)
        {
            
            if (Music== true)
            {
                PBMusic.BackColor = Color.Green;
                lbMusic.Text = "On";
                Music = false;

                Play = true;
            }
            else if (Music == false)
            {
                PBMusic.BackColor = Color.Red;
                lbMusic.Text = "Off";
                Music = true;
                Play=  false;
            }
            return Play;
        }
    }
}
