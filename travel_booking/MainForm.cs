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
using travel_booking.UserControlers;

namespace travel_booking
{
    public partial class MainForm : Form
    {
        UserContrMain userContrMain;
        UserContrRegister userContrRegister;
        UserContrLogin userContrLogin;
        private ComboBox destinationFrom;
        private DateTimePicker departDate;
        private DateTimePicker returnDate;
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
            userContrRegister.SetUserContrLogin(userContrLogin);
            userContrLogin.SetUserContrRegister(userContrRegister);
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

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Destinations]", connection);
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
            this.departDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
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
            this.userContrRegister = new travel_booking.UserContrRegister();
            this.userContrLogin = new travel_booking.UserContrLogin();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultNumeric)).BeginInit();
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
            this.destinationFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationFrom.FormattingEnabled = true;
            this.destinationFrom.Location = new System.Drawing.Point(10, 226);
            this.destinationFrom.Name = "destinationFrom";
            this.destinationFrom.Size = new System.Drawing.Size(169, 24);
            this.destinationFrom.TabIndex = 3;
            this.destinationFrom.SelectedIndexChanged += new System.EventHandler(this.DestinationFrom_SelectedIndexChanged);
            // 
            // departDate
            // 
            this.departDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.departDate.Location = new System.Drawing.Point(201, 228);
            this.departDate.Name = "departDate";
            this.departDate.Size = new System.Drawing.Size(169, 22);
            this.departDate.TabIndex = 4;
            // 
            // returnDate
            // 
            this.returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnDate.Location = new System.Drawing.Point(612, 230);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(174, 22);
            this.returnDate.TabIndex = 5;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(215, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Depart Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(636, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Return Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(38, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Travel From";
            // 
            // destinationTo
            // 
            this.destinationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationTo.FormattingEnabled = true;
            this.destinationTo.Location = new System.Drawing.Point(394, 228);
            this.destinationTo.Name = "destinationTo";
            this.destinationTo.Size = new System.Drawing.Size(199, 24);
            this.destinationTo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(420, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Travel To";
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
            this.submitt.Location = new System.Drawing.Point(320, 415);
            this.submitt.Name = "submitt";
            this.submitt.Size = new System.Drawing.Size(142, 64);
            this.submitt.TabIndex = 15;
            this.submitt.Text = "Submitt";
            this.submitt.UseVisualStyleBackColor = false;
            this.submitt.Click += new System.EventHandler(this.Submitt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(38, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Children";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(214, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adults";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalPrice.Location = new System.Drawing.Point(394, 292);
            this.TotalPrice.Multiline = true;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(174, 34);
            this.TotalPrice.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(406, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
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
            this.sum.Location = new System.Drawing.Point(593, 296);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(174, 34);
            this.sum.TabIndex = 23;
            this.sum.Text = "Show Total";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // childrenNumeric
            // 
            this.childrenNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.childrenNumeric.Location = new System.Drawing.Point(10, 304);
            this.childrenNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.childrenNumeric.Name = "childrenNumeric";
            this.childrenNumeric.Size = new System.Drawing.Size(169, 22);
            this.childrenNumeric.TabIndex = 24;
            this.childrenNumeric.ThousandsSeparator = true;
            // 
            // adultNumeric
            // 
            this.adultNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adultNumeric.Location = new System.Drawing.Point(201, 304);
            this.adultNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.adultNumeric.Name = "adultNumeric";
            this.adultNumeric.Size = new System.Drawing.Size(169, 22);
            this.adultNumeric.TabIndex = 25;
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
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(945, 720);
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
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.departDate);
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

        


        private void Submitt_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-T970S8AB\KEDAR;Initial Catalog=travelbooking;Integrated Security=True"))
            {
                try
                {

                    using (var cmd = new SqlCommand("INSERT INTO Orders (DestFrom, DestTo, DateFrom, DateTo, Price) VALUES (@DestFrom,@DestTo,@DateFrom,@DateTo, @Price)"))
                    {

                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@DestFrom", destinationFrom.GetItemText(destinationFrom.SelectedItem));
                        cmd.Parameters.AddWithValue("@DestTo", destinationTo.GetItemText(destinationTo.SelectedItem));
                        cmd.Parameters.AddWithValue("@DateFrom", departDate.Value.Date);
                        cmd.Parameters.AddWithValue("@DateTo", returnDate.Value.Date);
                        cmd.Parameters.AddWithValue("@Price", TotalPrice.Text.Trim());

                        con.Open();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Record inserted");
                        }
                        else
                        {
                            MessageBox.Show("Record failed");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during insert: " + ex.Message);
                }

  
            }

        }

        private void Sum_Click(object sender, EventArgs e)
        {

            decimal totalAdult,totalChild, adults, children, priceAdult, priceChild;


            adults = adultNumeric.Value;
            children = childrenNumeric.Value;
            priceAdult = 100;
            priceChild = 50;
            totalAdult = adults * priceAdult;
            totalChild = children * priceChild;
            TotalPrice.Text = (totalAdult + totalChild).ToString("$" + "0.00");

            if (destinationFrom.SelectedIndex == -1 || destinationTo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a your departures and destination");
                return;
            }

            if (departDate.Value >= returnDate.Value)
                MessageBox.Show("Please choose return date later than departure date");
            if (destinationFrom.SelectedIndex == destinationTo.SelectedIndex)
                MessageBox.Show("Please choose different destination than departures");
        }

      

        private void DataSum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DestinationFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            
        }


    }
}