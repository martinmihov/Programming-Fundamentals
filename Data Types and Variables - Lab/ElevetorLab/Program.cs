using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevetorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courses = persons / elevatorCapacity;

            if (persons % elevatorCapacity == 0)
            {
                Console.WriteLine(courses);
            }
            else if(elevatorCapacity >= persons)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(courses + 1);
            }
        }
    }
}
