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
using System.Configuration;


namespace Diary
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["diary"].ConnectionString);
            //string q = "INSERT INTO events(name,title,date,text,picture)" + " VALUES ('" + name.Text + "','" + title.Text + "','" + "random data" + "','" + "test" + "','" + "test" + "')";

            string q = "INSERT INTO events(name,title,date,text,picture)" + " VALUES ('" + name.Text + "','" + title.Text + "','" + date.Text + "','" + text.Text + "','" + picture.Text + "' )";

            SqlCommand cm = new SqlCommand(q, c);

          //  MessageBox.Show("name ios " + c);


            c.Open();


            try
            {
                cm.ExecuteNonQuery();
                c.Close();
                MessageBox.Show(" Added Successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show(" Error !");

                throw;
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
