using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakticheskayaRabotaDelegati
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People
            {
                Name = "Малика",
                City = "Астана"
            };
            people.Propertychanged += (sender, cl) => Console.WriteLine($"{sender} обновил свойства класса {cl.Name}");
            people.City = "АСТАНА";
            Console.Read();
        }
    }
}
