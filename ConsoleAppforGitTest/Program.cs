using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppforGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = (a + b);
            Console.WriteLine($"Changed the pgm{c}");
        }
    }
}
