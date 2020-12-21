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

namespace Diary
{

    public partial class Log_In : Form

    {
        public string con = "Data Source=.;Initial Catalog=diary;Integrated Security=True";
        
        public Log_In()
        {
            InitializeComponent();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
           
               if (conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connected");
                this.Hide();
                frmMain ss = new frmMain();
                ss.Show();

            }
         /*   
           this.Hide();
            frmMain ss = new frmMain();
            ss.Show();*/

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox.Checked)
            {
                Password.UseSystemPasswordChar = true;

              
            }
            else
            {
                Password.UseSystemPasswordChar = false;
            }
        }
    }
}
