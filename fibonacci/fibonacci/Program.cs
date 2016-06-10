using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(10));
            Console.ReadKey();
        }

        static int fibonacci(int x)
        {
            if (x == 1 || x == 2)
            {
                return 1;
            }

            return fibonacci(x - 1) + fibonacci(x - 2);
        }
    }
}
