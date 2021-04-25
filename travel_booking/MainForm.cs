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


        UserContrMain userContrMain;
        UserContrRegister userContrRegister;
        UserContrLogin userContrLogin;
        private PictureBox pictureBox1;



        public MainForm()
        {
            InitializeComponent();
            GeneratePanels();

        }

        void GeneratePanels()
        {
            userContrMain = new UserContrMain();
            userContrLogin = new UserContrLogin();
            userContrRegister = new UserContrRegister();
            userContrRegister.setUserContrLogin(userContrLogin);
            userContrLogin.setUserContrRegister(userContrRegister);
            userContrRegister.OnUserRegister += UserContrRegister_OnUserRegister;
            userContrLogin.OnUserLogin += UserContrRegister_Load;
            userContrMain.SetBounds(0, 0, 886, 760);
            userContrRegister.SetBounds(0, 0, 886, 760);
            userContrLogin.SetBounds(0, 0, 886, 760);
            this.Controls.Add(userContrMain);
            this.Controls.Add(userContrRegister);
            this.Controls.Add(userContrLogin);
            userContrRegister.BringToFront();
        }

        private void UserContrRegister_OnUserRegister()
        {
            userContrMain.BringToFront();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userContrRegister = new travel_booking.UserContrRegister();
            this.userContrLogin = new travel_booking.UserContrLogin();
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
            // userContrRegister
            // 
            this.userContrRegister.BackColor = System.Drawing.Color.Black;
            this.userContrRegister.Location = new System.Drawing.Point(-2, 0);
            this.userContrRegister.Name = "userContrRegister";
            this.userContrRegister.Size = new System.Drawing.Size(886, 760);
            this.userContrRegister.TabIndex = 2;
            this.userContrRegister.Load += new System.EventHandler(this.UserContrRegister_Load);
            // 
            // userContrLogin
            // 
            this.userContrLogin.BackColor = System.Drawing.Color.Black;
            this.userContrLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userContrLogin.Location = new System.Drawing.Point(-2, 0);
            this.userContrLogin.Name = "userContrLogin";
            this.userContrLogin.Size = new System.Drawing.Size(886, 760);
            this.userContrLogin.TabIndex = 1;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(886, 760);
            this.Controls.Add(this.userContrRegister);
            this.Controls.Add(this.userContrLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void UserContrRegister_Load(object sender, EventArgs e)
        {

        }


    }
}