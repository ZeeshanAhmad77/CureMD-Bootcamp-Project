using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship
{
    public class Engineer : Employees
    {
        public override void CalculateSalary()
        {
            this.setFuelAllownce(100);
            this.setMedicalAllownce(500);
            this.setGrossSalary(this.getFuelAllownce() + this.getMedicalAllownce() + this.getBaseSallary());


        }

    }
}
