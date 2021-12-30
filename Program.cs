using System;

namespace staticCons
{
    class Hcl
    {
        static Hcl()
        {
            System.Console.WriteLine("Hcl static constructor");
        }
        public Hcl()
        {
            System.Console.WriteLine("Hcl default constructor");
        }

        public Hcl(string newsPaper)
        {
            System.Console.WriteLine($"{newsPaper}");
        }
    }

    class Employee: Hcl
    {
        public Employee(string np): base(np)
        {

        }
        public static void Main()
        {
            Employee verain = new Employee("Times of India");
        }

    }
}
