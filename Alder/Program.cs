using System;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

      

            if (age < 3)

            {

                Console.WriteLine(userName + ", du må gå med ble");

            }

            else if (age < 15)

            {

                Console.WriteLine(userName + ", du må ingenting");

            }

            else if (age < 18)

            {

                Console.WriteLine(userName + ", du må drikke");

            }

            else

            {

                Console.WriteLine(userName + ", du må stemme og køre bil");

            }

            Console.ReadKey();
        }
    }
}
