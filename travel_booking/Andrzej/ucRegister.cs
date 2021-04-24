using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travel_booking.Andrzej
{
    public partial class ucRegister : UserControl
    {
        public delegate void RegisterAction();
        public event RegisterAction OnUserRegister;

        public ucRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // procedura logowania / rejestrcji
            
            bool loginSuccess = true;

            // jeżeli udana to:
            if (loginSuccess)
                OnUserRegister?.Invoke();
            // jeżeli nie to wyswietlamy tutaj jakiś label o nieudanym haśle etc ......
        }
    }
}
