using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public double CGPA { get; set; }
        public Student(string id,string name,string department, string email, double cgpa)
        {
            this.Id = id;
            this.Name = name;
            this.Department = department;
            this.Email = email;
            this.CGPA = cgpa;
        }
        //write a method that will calculate your cgpa
        //write a method that will return cgpa
    }
}
