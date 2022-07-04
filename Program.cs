using System;

namespace Relationship
{
    class Program
    {   
        static void Main(string[] args)
        {

            Console.WriteLine("------Enter the Designation------");
            Console.WriteLine(" ' Engineer ' / ' Manager ' / ' Analyst '");
            string designation = Console.ReadLine().ToUpper().Trim();

            // initialize the required object
            switch (designation)
            {
                case "ENGINEER":
                    {
                        Employees employe = new Engineer();
                        employe.setDesignation(designation);
                        employe.CalculateSalary();
                        employe.showSalary();
                        break;
                    }

                case "MANAGER":
                    {
                        Employees employe = new Manager();
                        employe.setDesignation(designation);
                        employe.CalculateSalary();
                        employe.showSalary();
                        break;

                    }
                case "ANALYST":
                    {
                        Employees employe = new Analyst();
                        employe.setDesignation(designation);
                        employe.CalculateSalary();
                        employe.showSalary();
                        break;

                    }

            }
        }
    }
}

