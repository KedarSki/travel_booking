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
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(1, "Radosław", "Zamojski"),
                new Employee(2, "Patryk", "Henrykowski"),
                new Employee(3, "Halina", "Frąckowiak")

            };
        }

    }
}


