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

namespace VProzzleFix
{
    public partial class Score : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database=Score; user=root; password=");
        Size enter = new Size(195, 70);
        Size leave = new Size(192, 65);
        public Score()
        {
            InitializeComponent();

            lbScore.Parent = BGScore;
            lbScore.BackColor = Color.Transparent;
            PBBackScore.Parent = BGScore;
            PBBackScore.BackColor = Color.Transparent;
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
                        MessageBox.Show("Terhubung", "Info");
                    }
                    else
                    {
                        MessageBox.Show("Gagal Terhubung", "Info");
                    }
                }
            }
        }

        private void PBBackScore_Click_1(object sender, EventArgs e)
        {
            VProzzle VProzzleMain = new VProzzle();
            VProzzleMain.Show();
            this.Close();
        }

        private void PBBackScore_MouseEnter_1(object sender, EventArgs e)
        {
            PBBackScore.Size = enter;
        }

        private void PBBackScore_MouseLeave_1(object sender, EventArgs e)
        {
            PBBackScore.Size = leave;
        }

        void LoadData()
        {
            string query = "select* from TScore";
            using (con)
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    DGVScore.DataSource = data.Tables[0];
                }
            }

        }

        private void Score_Load(object sender, EventArgs e)
        {
            ConnectDB();
            LoadData();
        }
    }
}
