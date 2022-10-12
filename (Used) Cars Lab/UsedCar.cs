using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Used__Cars_Lab
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        //we want to make a constructor that passes values up to the parent and 
        //adds in our additional one
        //we can use the base keyword here, but it takes a different form 

        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        public override string ToString()
        {
            return base.ToString() + " Mileage: " + Mileage;
        }
    }
}
    

