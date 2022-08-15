using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zada4a 1 Classes More Exercises
            //int n = int.Parse(Console.ReadLine());
            //List<Employee> employ = new List<Employee>();
            //for (int i = 0; i < n; i++)
            //{
            //    string[] data = Console.ReadLine().Split(' ').ToArray();
            //    Employee currEmploye = new Employee()
            //    {
            //        Name = data[0],
            //        Salary = Double.Parse(data[1]),
            //        Department = data[2]
            //    };
            //    employ.Add(currEmploye);
            //}

            //List<string> departments = new List<string>();
            //foreach (var empl in employ.OrderBy(d => d.Department))
            //{
            //    if (!departments.Contains(empl.Department))
            //    {
            //        departments.Add(empl.Department);
            //    }
            //}
            //string depHAS = "";
            //double maxAverage = -1;
            //foreach (String item in departments)
            //{
            //    double aver = employ.Where(x => x.Department == item).Average(c => c.Salary);
            //    if (aver > maxAverage)
            //    {
            //        depHAS = item;
            //        maxAverage = aver;
            //    }
            //}
            //Console.WriteLine($"Highest Average Salary: {depHAS}");
            //foreach (Employee employee in employ.Where(d => d.Department == depHAS).OrderByDescending(x => x.Salary))
            //{
            //    Console.WriteLine($"{employee.Name} { employee.Salary:f2}");
            //}
        }
    }
    //class Employee
    //{
    //    public string Name { get; set; }
    //    public double Salary { get; set; }
    //    public string Department { get; set; }
    //}
}
