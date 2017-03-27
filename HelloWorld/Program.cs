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
            Console.WriteLine(string.Format("This is what you typed : '{0}'", data));
            Console.ReadLine();
        }
    }
}
