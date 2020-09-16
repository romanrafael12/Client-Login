using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Developer Rafael Roman 
namespace Client_Login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        #region btnregistro

        private async void registerbtn_Click(object sender, EventArgs e)//Is the register button
        {

            if (string.IsNullOrEmpty(txtem.Text))
            {
                MessageBox.Show("Please enter your email and password"); //show error in case the person don't wrote anything
                
                return;

            }





            IUserRepository repository = new UserRepository();

            bool result = await repository.Insert(new User() { UserName = txtem.Text, Password = txtpass.Text }); 

            if (result)
            {
                MessageBox.Show("You have successfully register");
            }
            else
            {
                MessageBox.Show("Error");

            }
            #endregion
        }
        #region close

        private void canlab_Click(object sender, EventArgs e)
        {

            this.Close();

        }

  
        #endregion

        private void label4_Click_1(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Close();
        }
    }
}
