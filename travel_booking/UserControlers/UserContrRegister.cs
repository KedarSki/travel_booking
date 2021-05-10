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
using travel_booking.UserControlers;
using System.Text.RegularExpressions;

namespace travel_booking
    {
    public partial class UserContrRegister : UserControl

    {

    public delegate void RegisterAction();
    UserContrLogin userContrLogin;
    public event RegisterAction OnUserRegister;
    readonly string connectionString = @"Data Source=LAPTOP-T970S8AB\KEDAR;Initial Catalog=travelbooking;Integrated Security=True";

    public UserContrRegister()  
    {
        InitializeComponent();
    }

    public void SetUserContrLogin(UserContrLogin userContrLogin)
    {
        this.userContrLogin = userContrLogin;
    }

private void RegisterButton_Click(object sender, EventArgs e)
{
    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
    {

        sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UserAdd", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
        sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
        sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
        sqlCommand.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text.Trim());
        sqlCommand.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
        sqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
        sqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("Confirm passoword is not identical to password you have provided.");
                    txtConfirmPassword.Focus();
                }
                    

                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Please enter First Name");
                    txtFirstName.Focus();
                }
                else if (txtLastName.Text == "")
                {
                    MessageBox.Show("Please enter First Name");
                    txtLastName.Focus();
                }
                else if (txtDateOfBirth.Text == "")
                {
                    MessageBox.Show("Please enter Date Of Birth");
                    txtDateOfBirth.Focus();
                }

                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please enter Phone number");
                    txtPhone.Focus();
                }

                else if (txtEmail.Text == "" && txtEmail.Text != "@")
                {
                    MessageBox.Show("Please enter Email Address");
                    txtEmail.Focus();
                }

                else if(txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter Password");
                        txtPassword.Focus();
                }

                else
                {
                    OnUserRegister?.Invoke();
                    this.Hide();
                    //userContrMain.Show();
                    userContrLogin.Show();
                    userContrLogin.BringToFront();
                }

        sqlCommand.ExecuteNonQuery();

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
        txtConfirmPassword.Text = "";

        

    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        //UserContrLogin userContrLogin = new UserContrLogin();
        //UserContrMain userContrMain = new UserContrMain();
        this.Hide();
        //userContrMain.Show();
        userContrLogin.Show();
        userContrLogin.BringToFront();

    }

    private void Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    }
 }
