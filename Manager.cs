using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship
{
    public class Manager : Employees
    {

       



        public override void CalculateSalary()
        {
            this.setFuelAllownce(250);
            this.setMedicalAllownce(1000);
            this.setGrossSalary(this.getFuelAllownce() + this.getMedicalAllownce() + this.getBaseSallary());
            
            
        }
        
       


    }
}
