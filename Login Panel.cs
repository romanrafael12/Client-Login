using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }

       



        #region Log in Button
      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\RAC\source\repos\Client Login\bin\Debug\LoginDB.mdf");
            SqlDataAdapter sda = new SqlDataAdapter("Select username From tblLogin  where UserName = '" + emlog.Text + "' and Password = '" + passlog.Text + " ' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1) 
            {

                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
                MessageBox.Show("Login Successful");
            }

            else

            {
                MessageBox.Show("Username/Password is incorrect. Please try again");
            }
        }
        #endregion

        private void emlog_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Hide();
             Register forma = new Register();
             forma.Show();           

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Register forma = new Register();
            forma.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
