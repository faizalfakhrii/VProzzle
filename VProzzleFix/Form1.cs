using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Media;

namespace VProzzleFix
{
    public partial class VProzzle : Form
    {
        //BGMusic
        SoundPlayer bgmusic = new SoundPlayer();
        
        
        //Buton Hover
        Size enter = new Size(195, 70);
        Size leave = new Size(192, 65);
        
        //Cracking Image
        List<Bitmap> Gambar;

        //Player Game
        public static string nama = "Anonymous";

        //Move
        int inmoves = 0;
        int isNullSliceIndex = 0;
        
        //Path image
        string path;
        Image img;

        //ConcectDB
        MySqlConnection con = new MySqlConnection("server = localhost; database=Score; user=root; password=");

        //Time
        string time;
        int timeCs, timeSec, timeMin;
        bool Active;
        public static  bool On = true;
        public VProzzle()
        {
            InitializeComponent();
            PBTitle.Parent = PBBG;
            PBTitle.BackColor = Color.Transparent;
            PBPlay.Parent = PBBG;
            PBPlay.BackColor = Color.Transparent;
            PBScore.Parent = PBBG;
            PBScore.BackColor = Color.Transparent;
            PBOptions.Parent = PBBG;
            PBOptions.BackColor = Color.Transparent;
            PBExit.Parent = PBBG;
            PBExit.BackColor = Color.Transparent;
            PBBack.Parent = PBBGChoice;
            PBBack.BackColor = Color.Transparent;
            PBStart.Parent = PBBGChoice;
            PBStart.BackColor = Color.Transparent;
            PBBackMenu.Parent = BGPlay;
            PBBackMenu.BackColor = Color.Transparent;
            PBLogin.Parent = PBBG;
            PBLogin.BackColor = Color.Transparent;

            bgmusic.SoundLocation = "Media/bg.wav";

        }
        private void VProzzle_Load(object sender, EventArgs e)
        {
           
            if (On == true)
            {
                bgmusic.Play();
            }
            else
            {
                bgmusic.Stop();
            }
            
                
        }


        private void PBPLay_Click(object sender, EventArgs e)
        {
            PnlChoice.Visible = true;

        }

        private void PBPLay_MouseEnter(object sender, EventArgs e)
        {
            PBPlay.Size = enter;
        }

        private void PBPLay_MouseLeave(object sender, EventArgs e)
        {
            PBPlay.Size = leave;
        }

        private void PBScore_Click(object sender, EventArgs e)
        {


            Score score = new Score();
            score.Show();
            this.Hide();

        }

        private void PBScore_MouseEnter(object sender, EventArgs e)
        {
            PBScore.Size = enter;
        }

        private void PBScore_MouseLeave(object sender, EventArgs e)
        {
            PBScore.Size = leave;
        }

        private void PBOptions_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            On = options.PMusic(On);
            options.Show();
            this.Hide();
        }

        private void PBOptions_MouseEnter(object sender, EventArgs e)
        {
            PBOptions.Size = enter;
        }

        private void PBOptions_MouseLeave(object sender, EventArgs e)
        {
            PBOptions.Size = leave;
        }
        private void PBExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBExit_MouseEnter(object sender, EventArgs e)
        {
            PBExit.Size = enter;
        }

        private void PBExit_MouseLeave(object sender, EventArgs e)
        {
            PBExit.Size = leave;
        }

   

        private void PBImage1_MouseEnter(object sender, EventArgs e)
        {
            PBImage1.Size = new Size(135, 135);
        }

        private void PBImage1_MouseLeave(object sender, EventArgs e)
        {
            PBImage1.Size = new Size(128, 128);
        }

        private void PBImage1_Click(object sender, EventArgs e)
        {
            RBImage1.Checked = true;
            path = "Img/PlayImage1.png";
        }

        private void PBBack_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            PnlChoice.Visible = false;

        }

        private void PBStart_Click(object sender, EventArgs e)
        {
            Crack();
            pnlPlay.Visible = true;
            Shuffle();
            ResetTime();
            Time();
            inmoves = 0;
            lbMove.Text = Convert.ToString(inmoves);
            bgmusic.Stop();
            
        }

        private void PBStart_MouseEnter(object sender, EventArgs e)
        {
            PBStart.Size = enter;
        }

        private void PBStart_MouseLeave(object sender, EventArgs e)
        {
            PBStart.Size = leave;
        }

        private void PBBack_MouseEnter(object sender, EventArgs e)
        {
            PBBack.Size = enter;
        }

        private void PBBack_MouseLeave(object sender, EventArgs e)
        {
            PBBack.Size = leave;
        }



        private void PBImage3_Click(object sender, EventArgs e)
        {
            path = "Img/PlayImage3.png";
            RBImage3.Checked = true;
        }

        private void PBImage3_MouseEnter(object sender, EventArgs e)
        {
            PBImage3.Size = new Size(135, 135);
        }

        private void PBImage3_MouseLeave(object sender, EventArgs e)
        {
            PBImage3.Size = new Size(128, 128);
        }

        private void PBImage2_Click(object sender, EventArgs e)
        {
            path = "Img/PlayImage2.png";
            RBImage2.Checked = true;
        }

        private void PBImage2_MouseEnter(object sender, EventArgs e)
        {
            PBImage2.Size = new Size(135, 135);
        }

        private void PBImage2_MouseLeave(object sender, EventArgs e)
        {
            PBImage2.Size = new Size(128, 128);
        }

        private void PBChooseImage_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void PBChooseImage_MouseEnter(object sender, EventArgs e)
        {
            PBChooseImage.Size = new Size(200, 55);
        }

        private void PBChooseImage_MouseLeave(object sender, EventArgs e)
        {
            PBChooseImage.Size = new Size(196, 52);
        }

        private void PBShuffle_MouseEnter(object sender, EventArgs e)
        {
            PBShuffle.Size = new Size(90, 90);
        }

        private void PBShuffle_MouseLeave(object sender, EventArgs e)
        {
            PBShuffle.Size = new Size(85, 85);
        }

        private void PBUnShuffle_Click(object sender, EventArgs e)
        {
            UnShuffle();
        }

        private void PBUnShuffle_MouseEnter(object sender, EventArgs e)
        {
            PBUnShuffle.Size = new Size(90, 90);
        }

        private void PBUnShuffle_MouseLeave(object sender, EventArgs e)
        {
            PBShuffle.Size = new Size(85, 85);
        }

        private void PBShuffle_Click(object sender, EventArgs e)
        {
            Shuffle();
            ResetTime();
            Time();
            inmoves = 0;
            lbMove.Text = Convert.ToString(inmoves);


        }

        private static Image ResizeImage(Image image, Size newsize)
        {
            Image newImage = new Bitmap(newsize.Width, newsize.Height);
            using (Graphics GFX = Graphics.FromImage((Bitmap)newImage))
            {
                GFX.DrawImage(image, new Rectangle(Point.Empty, newsize));
            }
            return newImage;
        }
        void Crack()
        {
            try
            {
                img = Image.FromFile(path);

            }
            catch
            {
                if (img == null)
                {
                    MessageBox.Show("Please Choice a Image!", "Info");
                    PnlChoice.Visible = true;
                    
                }
                else
                {
                    
                }
               
            }

            Size PlaySize = new Size(450, 450);

            if(img.Size != PlaySize)
            {
                img = ResizeImage(img, PlaySize);
            }


            Image point = Image.FromFile("Img/Black.png");

            int widthThird = (int)((double)img.Width / 3.0 + 0.5);
            int heightThird = (int)((double)img.Height / 3.0 + 0.5);
            Bitmap[,] bmps = new Bitmap[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    bmps[i, j] = new Bitmap(widthThird, heightThird);
                    Graphics g = Graphics.FromImage(bmps[i, j]);
                    g.DrawImage(img, new Rectangle(0, 0, widthThird, heightThird), new Rectangle(j * widthThird, i * heightThird, widthThird, heightThird), GraphicsUnit.Pixel);
                    g.Dispose();
                }
            }


            Bitmap a1 = bmps[0, 0];
            Bitmap a2 = bmps[0, 1];
            Bitmap a3 = bmps[0, 2];
            Bitmap a4 = bmps[1, 0];
            Bitmap a5 = bmps[1, 1];
            Bitmap a6 = bmps[1, 2];
            Bitmap a7 = bmps[2, 0];
            Bitmap a8 = bmps[2, 1];
            Bitmap a9 = bmps[2, 2];
            Bitmap a10 = new Bitmap(point);

           //

            //Bitmap[] Gambar = new Bitmap[] { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 };
            Gambar = new List<Bitmap>();
            Gambar.AddRange(new Bitmap[] { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 });


            
            Size newSize = new Size(128, 128);
            Image image = ResizeImage(img, newSize);
            PBPlayPreview.Image = image;
        }

        

        void Shuffle()
        {
           
            do
            {
                int j;
                List<int> Index = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Index.Remove((j = Index[r.Next(0, Index.Count)]));
                    ((PictureBox)GBImagePlay.Controls[i]).Image = Gambar[j];
                    if (j == 9) isNullSliceIndex = i;
                    
                }
            } while (CheckWin());

        }

        void UnShuffle()
        {
            List<int> Index = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
            for (int i = 0; i < 9; i++)
            {

                ((PictureBox)GBImagePlay.Controls[i]).Image = Gambar[Index[i]];
                isNullSliceIndex = 8;
            }

        }

        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((GBImagePlay.Controls[i] as PictureBox).Image != Gambar[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }

       
      

        void Time()
        {
            Active = true;

        }

        void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Active)
            {
                timeCs++;

                if(timeCs>=100)
                {
                    timeSec++;
                    timeCs = 0;

                    if(timeSec>=60)
                    {
                        timeMin++;
                        timeSec = 0;

                    }
                }
            }
            DrawTime();
        }

        void DrawTime()
        {
            lbMS.Text = Convert.ToString(timeCs);
            lbS.Text = Convert.ToString(timeSec);
            lbM.Text = Convert.ToString(timeMin);
        }



      

        private void SWImage(object sender, EventArgs e)
        {
            int PictureBoxIndex = GBImagePlay.Controls.IndexOf(sender as Control);
            if (isNullSliceIndex != PictureBoxIndex)
            {
                List<int> FB = new List<int>(new int[] { PictureBoxIndex - 1, PictureBoxIndex - 3, PictureBoxIndex + 1, PictureBoxIndex + 3 });
                if (FB.Contains(isNullSliceIndex))
                {
                    ((PictureBox)GBImagePlay.Controls[isNullSliceIndex]).Image = ((PictureBox)GBImagePlay.Controls[PictureBoxIndex]).Image;
                    ((PictureBox)GBImagePlay.Controls[PictureBoxIndex]).Image = Gambar[9];
                    isNullSliceIndex = PictureBoxIndex;
                    lbMove.Text = Convert.ToString(++inmoves);
                    if (CheckWin())
                    {
                        // timer.Stop();
                        (GBImagePlay.Controls[0] as PictureBox).Image = Gambar[0];
                        Active = false;
                        time = Convert.ToString(timeMin + " : " + timeSec + " : " + timeCs);
                        MessageBox.Show($"Congrats " + nama + " !\nYou Win !! " +  " with Move : " + inmoves + " and Time : " + timeMin +":" + timeSec + ":" + timeCs, "Info");
                        InsertData();

                        inmoves = 0;
                        
                        Active = false;
                        


                    }


                }

            }
        }

        private void PBBackMenu_Click(object sender, EventArgs e)
        {
            PnlChoice.Visible = true;
            pnlPlay.Visible = false;
        }



        void ConnectDB()
        {
            using (con)
            {
                try { con.Open(); }
                catch
                {
                    if (con.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Server Connected", "Info");
                    }
                    else
                    {
                        MessageBox.Show("Server Disconnected", "Info");
                    }
                }
            }
        }

        private void PBLogin_Click(object sender, EventArgs e)
        {
            
            InsertName iname = new InsertName();
            iname.ShowDialog();
            ConnectDB();
        }

        private void PBLogin_MouseEnter(object sender, EventArgs e)
        {
            PBLogin.Size = new Size(155, 95);
        }

        private void PBLogin_MouseLeave(object sender, EventArgs e)
        {
            PBLogin.Size = new Size(150, 92);
        }

        void InsertData()
        {
            string move = Convert.ToString(inmoves);
            string insertQuery = "insert into TScore(Name,Move,Time) values ('"+nama+" ',' "+move+" ',' "+time+"')";
            try { con.Open(); }
            catch
            {
                if(con.State != ConnectionState.Open)
                {
                    MessageBox.Show("Server Disconnected", "Info");
                }
            }
            MySqlCommand command = new MySqlCommand(insertQuery, con);
            try
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");

                    }
                 else
                {
                    MessageBox.Show("Data Not Inserted");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            con.Close();
        }


        void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
        }
    }
}
