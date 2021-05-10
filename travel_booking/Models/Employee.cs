﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_booking.Models
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = "112233";
            LoggedIn = false;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
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
    
