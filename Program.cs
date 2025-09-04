using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program<T>
    {
        private string name;
        private string description;
        private T salary;

        public Program(string name,string description, T salary)
        {
            this.name = name;
            this.description = description;
            this.salary = salary;
        }
        public void printDetails()
        {
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"description: {description}");
            Console.WriteLine($"salary: {salary}");
        }
        static void Main(string[] args)
        {
            Program<double> b1= new Program<double>("noor","it",5000.0);
            b1.printDetails();
        }
    }
}
