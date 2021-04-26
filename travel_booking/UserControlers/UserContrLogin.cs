using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_booking.UserControlers;
using System.Data.SqlClient;


namespace travel_booking
{
    public partial class UserContrLogin : UserControl
    {

     
        public delegate void LoginAction();
        public event LoginAction OnUserLogin;
        UserContrRegister userContrRegister;
       

        public UserContrLogin()
        {
            InitializeComponent();
            
        }

        public void setUserContrRegister(UserContrRegister userContrRegister)
        {
            this.userContrRegister = userContrRegister;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-T970S8AB\KEDAR;Initial Catalog=travelbooking;Integrated Security=True");
            string query = "Select * from tblUser Where Email = ' " + txtEmail.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            bool loginSuccess = true;

            if (loginSuccess)
                this.Hide();
            else
                MessageBox.Show("Email or/and Password is/are invalid. Please try again");
        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {

            //UserContrRegister userContrRegister = new UserContrRegister();
            //UserContrMain userContrMain = new UserContrMain();
            this.Hide();
            //userContrMain.Show();
            userContrRegister.Show();
            userContrRegister.BringToFront();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearAll_Click(object sender, EventArgs e)
        {

        }
    }

   
}