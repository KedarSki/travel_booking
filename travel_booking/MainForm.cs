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
        private Button submitt;
        private Label label5;
        private Label label6;
        private TextBox TotalPrice;
        private Label label7;
        private Label label8;
        private Button sum;
        private NumericUpDown childrenNumeric;
        private NumericUpDown adultNumeric;
        private DataGridView dataSum;
        private DataGridViewTextBoxColumn FromColumn;
        private DataGridViewTextBoxColumn ToColumn;
        private DataGridViewTextBoxColumn DateFrom;
        private DataGridViewTextBoxColumn DateTo;
        private DataGridViewTextBoxColumn ChildrenColumn;
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-T970S8AB\KEDAR;Initial Catalog=travelbooking;Integrated Security=True");
        public MainForm()
        {
            InitializeComponent();
            GeneratePanels();
            PopulateComboDestinations();
            PopulateComboDepartures();

;        }


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

        void PopulateComboDestinations()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-T970S8AB\KEDAR;Initial Catalog=travelbooking;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[tblDestinations]", connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                destinationTo.Items.Add(ds.Tables[0].Rows[i][1] + "," + ds.Tables[0].Rows[i][2]);
            }
        }

        void PopulateComboDepartures()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-T970S8AB\KEDAR;Initial Catalog=travelbooking;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Departures]", connection);
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                destinationFrom.Items.Add(ds.Tables[0].Rows[i][1] + "," + ds.Tables[0].Rows[i][2]);
            }
        }


            private void UserContrRegister_OnUserRegister()
        {
            userContrMain.BringToFront();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.submitt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.childrenNumeric = new System.Windows.Forms.NumericUpDown();
            this.adultNumeric = new System.Windows.Forms.NumericUpDown();
            this.dataSum = new System.Windows.Forms.DataGridView();
            this.userContrRegister = new travel_booking.UserContrRegister();
            this.userContrLogin = new travel_booking.UserContrLogin();
            this.FromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildrenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSum)).BeginInit();
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
            // destinationFrom
            // 
            this.destinationFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationFrom.FormattingEnabled = true;
            this.destinationFrom.Location = new System.Drawing.Point(10, 235);
            this.destinationFrom.Name = "destinationFrom";
            this.destinationFrom.Size = new System.Drawing.Size(201, 28);
            this.destinationFrom.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2.Location = new System.Drawing.Point(241, 315);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 26);
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
            this.label1.Location = new System.Drawing.Point(274, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Depart Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(265, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Return Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(29, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "From";
            // 
            // destinationTo
            // 
            this.destinationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationTo.FormattingEnabled = true;
            this.destinationTo.Location = new System.Drawing.Point(12, 317);
            this.destinationTo.Name = "destinationTo";
            this.destinationTo.Size = new System.Drawing.Size(199, 28);
            this.destinationTo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(29, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "To";
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
            // submitt
            // 
            this.submitt.BackColor = System.Drawing.Color.Green;
            this.submitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitt.ForeColor = System.Drawing.Color.Orange;
            this.submitt.Location = new System.Drawing.Point(570, 606);
            this.submitt.Name = "submitt";
            this.submitt.Size = new System.Drawing.Size(174, 34);
            this.submitt.TabIndex = 15;
            this.submitt.Text = "Submitt";
            this.submitt.UseVisualStyleBackColor = false;
            this.submitt.Click += new System.EventHandler(this.submitt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(29, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Children";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(29, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adults";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Location = new System.Drawing.Point(241, 444);
            this.TotalPrice.Multiline = true;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(174, 34);
            this.TotalPrice.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(265, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(14, 634);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(426, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "*Choose any travel for $100 for Adult and 50% discount for child";
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.Green;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum.ForeColor = System.Drawing.Color.Orange;
            this.sum.Location = new System.Drawing.Point(241, 534);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(174, 34);
            this.sum.TabIndex = 23;
            this.sum.Text = "Show Total";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // childrenNumeric
            // 
            this.childrenNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.childrenNumeric.Location = new System.Drawing.Point(17, 396);
            this.childrenNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.childrenNumeric.Name = "childrenNumeric";
            this.childrenNumeric.Size = new System.Drawing.Size(194, 26);
            this.childrenNumeric.TabIndex = 24;
            this.childrenNumeric.ThousandsSeparator = true;
            // 
            // adultNumeric
            // 
            this.adultNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adultNumeric.Location = new System.Drawing.Point(17, 461);
            this.adultNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.adultNumeric.Name = "adultNumeric";
            this.adultNumeric.Size = new System.Drawing.Size(194, 26);
            this.adultNumeric.TabIndex = 25;
            // 
            // dataSum
            // 
            this.dataSum.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FromColumn,
            this.ToColumn,
            this.DateFrom,
            this.DateTo,
            this.ChildrenColumn});
            this.dataSum.Location = new System.Drawing.Point(421, 205);
            this.dataSum.Name = "dataSum";
            this.dataSum.Size = new System.Drawing.Size(464, 395);
            this.dataSum.TabIndex = 26;
            this.dataSum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSum_CellContentClick);
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
            // FromColumn
            // 
            this.FromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FromColumn.HeaderText = "From";
            this.FromColumn.Name = "FromColumn";
            this.FromColumn.ReadOnly = true;
            this.FromColumn.Width = 55;
            // 
            // ToColumn
            // 
            this.ToColumn.HeaderText = "To";
            this.ToColumn.Name = "ToColumn";
            this.ToColumn.ReadOnly = true;
            // 
            // DateFrom
            // 
            this.DateFrom.HeaderText = "DateFrom";
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ReadOnly = true;
            // 
            // DateTo
            // 
            this.DateTo.HeaderText = "DateTo";
            this.DateTo.Name = "DateTo";
            this.DateTo.ReadOnly = true;
            // 
            // ChildrenColumn
            // 
            this.ChildrenColumn.HeaderText = "ChildrenColumn";
            this.ChildrenColumn.Name = "ChildrenColumn";
            this.ChildrenColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(886, 760);
            this.Controls.Add(this.dataSum);
            this.Controls.Add(this.adultNumeric);
            this.Controls.Add(this.childrenNumeric);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitt);
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
            ((System.ComponentModel.ISupportInitialize)(this.childrenNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSum)).EndInit();
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
          

        }   

        


        private void submitt_Click(object sender, EventArgs e)
        { 
           
        }

        private void sum_Click(object sender, EventArgs e)
        {

            decimal totalAdult,totalChild, adults, children, priceAdult, priceChild;

            adults = adultNumeric.Value;
            children = childrenNumeric.Value;
            priceAdult = 100;
            priceChild = 50;

            totalAdult = adults * priceAdult;
            totalChild = children * priceChild;
            TotalPrice.Text = (totalAdult + totalChild).ToString("$" + "0.00");

            var travel = this.destinationFrom;
            dataSum.DataSource = travel;
            dataSum.Columns["From"].Visible = true;


        }

        private void dataSum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}