﻿using System;
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

    public void setUserContrLogin(UserContrLogin userContrLogin)
    {
        this.userContrLogin = userContrLogin;
    }

private void RegisterButton_Click(object sender, EventArgs e)
{
    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
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

        bool registerSuccess = true;

        if (registerSuccess)
            OnUserRegister?.Invoke();
        else
            MessageBox.Show("Provided details do not match to requirements. Please check the detail and try again.");

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
