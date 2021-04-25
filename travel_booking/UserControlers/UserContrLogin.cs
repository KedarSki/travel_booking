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

namespace travel_booking
{
public partial class UserContrLogin : UserControl
{



internal Action<object, EventArgs> OnUserLogin;
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

}

private void ClearAll_Click(object sender, EventArgs e)
{

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

    private void TxtEmail_TextChanged(object sender, EventArgs e)
    {

    }
   
    
  }

   
}