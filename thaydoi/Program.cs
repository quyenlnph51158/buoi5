using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thaydoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            ThayDoi(ref x);
            Console.ReadKey();
        }
        static void ThayDoi(ref int x)
        {
            x = 100;
        }
    }
    
}

