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
    
    public partial class InsertName : Form
    {
        
        
        public InsertName()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                VProzzle.nama = txtName.Text.ToString();
             }
            else
            {
                VProzzle.nama = "Anonymous";
            }

            

            MessageBox.Show("Welcome back "+ VProzzle.nama +" !");
            Close();

        }

        private void InsertName_Load(object sender, EventArgs e)
        {
            
            //VP.Show();
            //VP.Activate();
            //this.Hide();
        }

    }
}
