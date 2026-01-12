using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two Pet objects
            Pet myDog = new Pet();
            Pet myCat = new Pet("小謙");

            Console.WriteLine("My Dog name is " + myDog.Name);
            Console.WriteLine("My Cat name is " + myCat.Name);
            myDog.Name = "Robin";
            myCat.Name = "MM";
            Console.WriteLine("My Dog name is " + myDog.Name);
            Console.WriteLine("My Cat name is " + myCat.Name);
            Console.ReadKey();
        }
    }
}
