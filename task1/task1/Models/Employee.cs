using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    internal class Employee
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            _id++;
            Id = _id;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nSalary: {Salary}");
        }
    }
}
