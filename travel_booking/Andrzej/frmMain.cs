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
    public partial class frmMain : Form
    {
        ucMain _main;
        ucRegister _register;

        public frmMain()
        {
            InitializeComponent();
            GeneratePanels();
        }

        void GeneratePanels()
        {
            _main = new ucMain();
            _register = new ucRegister();
            _register.OnUserRegister += _register_OnUserRegister;
            _main.SetBounds(0, 0, 867, 558);
            _register.SetBounds(0, 0, 867, 558);
            this.Controls.Add(_main);
            this.Controls.Add(_register);
            _register.BringToFront();
        }

        private void _register_OnUserRegister()
        {
            _main.BringToFront();
        }
    }
}
