using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student = new Student("12-21822-2","Hossain, Md. Arif", "CSE", "arif_sk@outlook.com",3.30);
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Department);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.CGPA);
            Employee emp = new Employee {
                Id = "18-82247-1",
                Name = "John Smith",
                Email = "john@gmail.com",
                Address = "Dream Street, London, UK",
                Salary = "5000 Pounds"
            };
            Console.WriteLine(emp.Name == ""?"No Name Found":emp.Name);
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add(10,10));
            Console.WriteLine(cal.Sub(12,20));
            Console.ReadKey();
        }
       
    }
}
