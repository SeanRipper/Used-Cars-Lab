using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _Used__Cars_Lab
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //this sets all my variables to default
        public Car()
        {

        }
        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        //ToString comes from the objects class and all classes have it
        //however by default, without overriding it, ToString returns the type of object
        //and not its contents, but if we override it then we customize it

        //so any time an object would be turned into a string, its ToString method gets called
        //which can be handy specifically for printing out the object
        public override string ToString()
        {
            string output = $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}";
            return output;
        }
        public static void ListCars()
        {
            
        }
    }
}
