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

namespace travel_booking
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetEmployees();
            GetCustomers();
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(1, "Kamil", "Nowak", "kamil.nowak@eagletravel.pl", 1988),
                new Employee(2, "Patryk", "Henrykowski", "patryk.henrykowski@eagletravel.pl", 2000),
                new Employee(3, "Halina", "Frąckowiak", "halina.frackowiak@eagletravel.pl", 1995)


            };
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}


