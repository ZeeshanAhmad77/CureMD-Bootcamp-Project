using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship
{
    public class Employees
    {
        //private string name;
        //private int age;
        private string designation;
        private int baseSallary=1500;
        private int fuelAllownce;
        private int medicalAllownce;
        private int grossSalary;

       

       public void showSalary()
        {
            Console.WriteLine("------SALARY Calculator------");
            Console.WriteLine($"The Designation of the Employee is : {designation}");
            Console.WriteLine($"The Base Salary of the Employee is : {baseSallary}");
            Console.WriteLine($"The Fuel Allownce of the Employee is : {fuelAllownce}");
            Console.WriteLine($"The Medical Allownce of the Employee is : {medicalAllownce}");
            Console.WriteLine($"The gross sallary of the Employee is : {grossSalary}");
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("Parent class");
            grossSalary = baseSallary + medicalAllownce + fuelAllownce;


        }

        //getter and Setter Methods
        //name
        //public string getName()
        //{
        //    return name;
        //}
        //public void setName(string nam)
        //{
        //    name = nam;
        //}
        //age
        //public int getAge()
        //{
        //    return age;
        //}
        //public void setAge(int ag)
        //{
        //    age = ag;
        //}

        //designation
        public string getDesignation()
        {
            return designation;
        }
        public void setDesignation(string des)
        {
            designation = des;
        }

        //baseSalary
        public int getBaseSallary()
        {
            return baseSallary;
        }
        private void setBaseSallary(int bsal)
        {
            baseSallary = bsal;
        }
        //fuelAllownce
        public int getFuelAllownce()
        {
            return fuelAllownce;
        }
        public void setFuelAllownce(int fallow)
        {
            fuelAllownce = fallow;
        }
        //medicalAllownce
        public int getMedicalAllownce()
        {
            return medicalAllownce;
        }
        public void setMedicalAllownce(int mallow)
        {
            medicalAllownce = mallow;
        }
        //grossSalary
        public int getGrossSalary()
        {
            return grossSalary;
        }
        public void setGrossSalary(int gsal)
        {
            grossSalary = gsal;
        }

    }
}
