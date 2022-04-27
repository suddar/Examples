using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Basics.Encapsulation
{
    public class Employee
    {
        // Employee Name
        private string _name;
        // 
        public DateTime DayOfBirth;
        //
        private int _phone;

        public string Name { get => _name; internal set => _name = value; }
        public int Phone { get => _phone; set => _phone = value; }

        public void ChangeEmployeeName(string name)
        {
            Name = name;
        }
    }
}
