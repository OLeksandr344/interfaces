using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interf3
{
    public class ElectronicDevice : IProduct
    {
        public string DeviceName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
    
        public ElectronicDevice(string deviceName, string manufacturer, decimal price)
        {
            DeviceName = deviceName;
            Manufacturer = manufacturer;
            Price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Device: {DeviceName}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Price: ${Price}");
        }
    }
    public class Smartphone : ElectronicDevice, IShoppable
    {
        
        public string OperatingSystem { get; set; }

        
        public Smartphone(string deviceName, string manufacturer, decimal price, string operatingSystem)
            : base(deviceName, manufacturer, price)
        {
            OperatingSystem = operatingSystem;
        }

        
        public void AddToCart()
        {
            Console.WriteLine($"Added {DeviceName} to the cart.");
        }
    }
    public class Laptop : ElectronicDevice, IShoppable
    {
        
        public int RAM { get; set; }

        
        public Laptop(string deviceName, string manufacturer, decimal price, int ram)
            : base(deviceName, manufacturer, price)
        {
            RAM = ram;
        }

       
        public void AddToCart()
        {
            Console.WriteLine($"Added {DeviceName} to the cart.");
        }
    }
}
