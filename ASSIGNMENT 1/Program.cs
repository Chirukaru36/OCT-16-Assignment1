using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Smartphone> smartphones = new List<Smartphone>();
        
            smartphones.Add(new Smartphone { IMEINumber = "12345", Name = "iPhone 12", Model = "A14 Bionic", Price = 799.99 });
            smartphones.Add(new Smartphone { IMEINumber = "67890", Name = "Samsung Galaxy S21", Model = "Exynos 2100", Price = 899.99 });
            smartphones.Add(new Smartphone { IMEINumber = "13579", Name = "Google Pixel 5", Model = "Snapdragon 765G", Price = 699.99 });
            smartphones.Add(new Smartphone { IMEINumber = "24680", Name = "OnePlus 9", Model = "Snapdragon 888", Price = 749.99 });
            smartphones.Add(new Smartphone { IMEINumber = "98765", Name = "Xiaomi Mi 11", Model = "Snapdragon 888", Price = 699.99 });
        

            Console.WriteLine("Before sorting:");
            foreach (var phone in smartphones)
            {
                Console.WriteLine($"{phone.Name} - {phone.Model}");
            }

            smartphones.Sort();

            Console.WriteLine("\nAfter sorting by name using IComparable:");
            foreach (var phone in smartphones)
            {
                Console.WriteLine($"{phone.Name} ,{phone.Model}");
            }

            smartphones.Sort(new SmartphoneNameComparer());

            Console.WriteLine("\nAfter sorting by name using IComparer:");
            foreach (var phone in smartphones)
            {
                Console.WriteLine($"{phone.Name} ,{phone.Model}");
            }

            Console.ReadLine();
        }
    }
}

