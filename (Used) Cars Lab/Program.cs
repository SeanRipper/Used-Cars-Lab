namespace _Used__Cars_Lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Car ex = new Car("Toyota", "Camry", 2009, 1500);
            //since I've overridden ToString, I can do the following:
            //Console.WriteLine(ex);
            Car a = new UsedCar("Chevy", "Nova", 1984, 800, 400000);
            Car b = new UsedCar("Honda", "Civic", 2006, 1300, 150000);
            Car c = new UsedCar("Dodge", "Calibur", 2007, 10000, 160000);
            Car d = new Car("Ford", "Tundra", 2000, 2100.00m);
            Car e = new Car("Clown", "Buggie", 1590, 10);
            Car f = new Car("Chrysler", "Corvette", 2018, 70000);
            List<Car> carsInventory = new List<Car>();
            carsInventory.Add(a);
            carsInventory.Add(b);
            carsInventory.Add(c);
            carsInventory.Add(d);
            carsInventory.Add(e);
            carsInventory.Add(f);

            int index = 0;
            foreach(Car car in carsInventory)
            {
                Console.WriteLine(index + " " + car);
                index++;
            }
            Console.WriteLine();
            Console.WriteLine("Which car would you like to buy? Please select by index");
            
            string input = Console.ReadLine();
            int pick = int.Parse(input);
            Console.WriteLine();
            Console.WriteLine("Congratulations! You just bought a " + carsInventory[pick].Year + " " + carsInventory[pick].Make+ " " + carsInventory[pick].Model + "! That will be " + carsInventory[pick].Price + " dollars please.");
            Console.WriteLine();
            Console.WriteLine("Here is the list of the remaining cars: \n");

            carsInventory.RemoveAt(pick);

            index = 0;
            foreach (Car car in carsInventory)
            {
                Console.WriteLine(index + " " + car);
                index++;
            }
            
        }
    }
}