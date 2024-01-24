using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nhap.nhap1;

namespace nhap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sanPham sp = new sanPham();
            sp.xuatCoSan();
            sp.nhap();
            sp.Xuat();
            Console.ReadLine();
        }
    }
}
