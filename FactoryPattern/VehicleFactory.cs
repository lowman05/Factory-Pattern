using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(string tireCount)
        {
            
            switch (tireCount.ToLower())
            {
                case "four":                    
                        
                    return new Car();
                    
                case "two":
                    
                    return new Motorcycle();
                    
                default:
                    
                    return new Car(); 
                    
            }
        }
    }
}
