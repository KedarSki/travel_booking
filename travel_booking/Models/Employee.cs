using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_booking.Models
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, int yearOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Login = $"{firstName}.{lastName}.{yearOfBirth}";
            Password = "112233";
            LoggedIn = false;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public string FullName
        {
            get
            {
                if (FirstName != null && LastName != null)
                   return $"{FirstName} {LastName}";
                else
                    return "";
            }
        }


    }
}
    
