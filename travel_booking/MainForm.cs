using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        private ComboBox destinationFrom;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox destinationTo;
        private Label label4;
        private Label Exit;
        private PictureBox pictureBox1;
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-T970S8AB\KEDAR;Initial Catalog=travelbooking;Integrated Security=True");
        public MainForm()
        {
            InitializeComponent();
            GeneratePanels();

        }

        void GeneratePanels()
        {
            userContrMain = new UserContrMain();
            //userContrLogin = new UserContrLogin();
            //userContrRegister = new UserContrRegister();
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
            this.destinationFrom = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::travel_booking.Properties.Resources.travelIcon;
            this.pictureBox1.Location = new System.Drawing.Point(320, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userContrRegister
            // 
            this.userContrRegister.BackColor = System.Drawing.Color.Black;
            this.userContrRegister.Location = new System.Drawing.Point(-12, 729);
            this.userContrRegister.Name = "userContrRegister";
            this.userContrRegister.Size = new System.Drawing.Size(886, 760);
            this.userContrRegister.TabIndex = 2;
            this.userContrRegister.Load += new System.EventHandler(this.UserContrRegister_Load);
            // 
            // userContrLogin
            // 
            this.userContrLogin.BackColor = System.Drawing.Color.Black;
            this.userContrLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userContrLogin.Location = new System.Drawing.Point(64, 708);
            this.userContrLogin.Name = "userContrLogin";
            this.userContrLogin.Size = new System.Drawing.Size(886, 760);
            this.userContrLogin.TabIndex = 1;
            // 
            // destinationFrom
            // 
            this.destinationFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationFrom.FormattingEnabled = true;
            this.destinationFrom.Location = new System.Drawing.Point(10, 235);
            this.destinationFrom.Name = "destinationFrom";
            this.destinationFrom.Size = new System.Drawing.Size(201, 28);
            this.destinationFrom.TabIndex = 3;
            this.destinationFrom.SelectedIndexChanged += new System.EventHandler(this.destinationFrom_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2.Location = new System.Drawing.Point(657, 235);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.Color.Orange;
            this.label.Location = new System.Drawing.Point(269, 140);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(268, 31);
            this.label.TabIndex = 6;
            this.label.Text = "TRAVEL BOOKING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(220, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "DATE FROM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(685, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "DATE TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(29, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "TRAVEL FROM";
            // 
            // destinationTo
            // 
            this.destinationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationTo.FormattingEnabled = true;
            this.destinationTo.Location = new System.Drawing.Point(397, 235);
            this.destinationTo.Name = "destinationTo";
            this.destinationTo.Size = new System.Drawing.Size(241, 28);
            this.destinationTo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(421, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "TRAVEL TO";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit.ForeColor = System.Drawing.Color.Green;
            this.Exit.Location = new System.Drawing.Point(347, 676);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(68, 29);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "EXIT";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(886, 760);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destinationTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.destinationFrom);
            this.Controls.Add(this.userContrRegister);
            this.Controls.Add(this.userContrLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UserContrRegister_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            destinationFrom.Items.Clear();


        }
        private void destinationFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

   
        }
    }
}