using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travel_booking
{
    public partial class UserContrLogin : UserControl
    {
        UserContrRegister userContrRegister;
        internal Action<object, EventArgs> OnUserLogin;

        public UserContrLogin()
        {
            InitializeComponent();
        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            userContrRegister = new UserContrRegister();
            userContrRegister.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

