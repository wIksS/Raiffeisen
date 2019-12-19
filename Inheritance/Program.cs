using System;
using Classes_OOP;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Customer customer = new Customer();
            Employee employee = new Employee();
            Manager manager = new Manager();
            Student st = new Student();
            st.Read();
            st.Print();
        }
    }

    class Human
    {
        public string Name { get; set; }

        public bool IsMale { get; set; }
    }


    class Employee : Human
    {
        public int EmNumber { get; set; }
    }

    class Manager : Employee
    {
        public int ManagingCount { get; set; }
    }

    class Customer : Human
    {
        public string IBAN { get; set; }
    }

}
