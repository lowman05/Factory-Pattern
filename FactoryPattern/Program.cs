using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires will your vehicle have?");
            string tireCount = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(tireCount);
            vehicle.Drive();
            
        }
    }   
}
