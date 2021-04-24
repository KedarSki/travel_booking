using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace travel_booking
{
    public partial class UserContrRegister : UserControl
    {
        string connectionString = @"Data Source=LAPTOP-T970S8AB\KEDAR;Initial Catalog=travelbooking;Integrated Security=True";
        public UserContrRegister()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UserAdd", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"You have been registered!. You can now log in");

            }

            
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDateOfBirth.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            
        }
    }
}
