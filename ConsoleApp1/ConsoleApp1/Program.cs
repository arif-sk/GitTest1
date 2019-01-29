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
            Console.ReadKey();
        }
       
    }
}
