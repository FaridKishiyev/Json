using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    internal class Department
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }

        List<Employee> Employees { get; set; }
        public Department()
        {
            _id++;
            Id = _id;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employe)
        {
            Employees.Add(employe);
            StreamWriter fw = null;
            string json = JsonConvert.SerializeObject(Employees);
            using (fw = new StreamWriter(@"C:\Users\Ferid\source\repos\task1\task1\JsonFolder\database.json"))
            {
                fw.WriteLine(json);
            }
        }

        public Employee GetEmployeeById(int id)
        {
            Department department = JsonConvert.DeserializeObject<Department>(@"C:\Users\Ferid\source\repos\task1\task1\JsonFolder\database.json");
            return department.Employees.Find(x => x.Id == id);

        }

        public List<Employee> RemoveEmployee(int id)
        {
            Department department = JsonConvert.DeserializeObject<Department>(@"C:\Users\Ferid\source\repos\task1\task1\JsonFolder\database.json");
            department.Employees.RemoveAll(x => x.Id == id);

            return Employees;
        }


    }
}
