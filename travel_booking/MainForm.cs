using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_booking.Models;
using travel_booking.UserControlers;

namespace travel_booking
{
    public partial class MainForm : Form
    {
        private Login login1;
        private UserContrRegister register1;
        private PictureBox pictureBox1;

        UserContrMain userContrMain;
        public MainForm()
        {
            InitializeComponent();
          
        }


        private List<Employee> GetEmployees()
        {
            return null;
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                    
            };
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login1 = new travel_booking.Login();
            this.register1 = new travel_booking.UserContrRegister();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::travel_booking.Properties.Resources.travelIcon;
            this.pictureBox1.Location = new System.Drawing.Point(420, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.Black;
            this.login1.Location = new System.Drawing.Point(155, 515);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(329, 486);
            this.login1.TabIndex = 1;
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.Black;
            this.register1.Location = new System.Drawing.Point(2, 12);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(980, 654);
            this.register1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(980, 670);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

    }
}


