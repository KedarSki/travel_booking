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

            GetEmployees();
            GetCustomers();
        }

    

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(1, "Kamil", "Nowak", "kamil.nowak@travelbooking.com", 1988),
                new Employee(2, "Patryk", "Henrykowski", "patryk.henrykowski@travelbooking.com", 2000),
                new Employee(3, "Halina", "Frąckowiak", "halina.frackowiak@travelbooking.com", 1995)


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


