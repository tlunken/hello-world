using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var data = Console.ReadLine();
            Console.WriteLine("This is what you typed : {0}", data);
            // This is just to wait for user input before terminating
            Console.ReadLine();

            // This is just going to be a a proof of concept
            List<string> values = new List<string>();
            foreach (string s in values)
                Console.WriteLine("Value : {0}", s);
        }
    }
}
