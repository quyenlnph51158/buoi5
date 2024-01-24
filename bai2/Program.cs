using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int chon;
            giay hGiay=new giay();

            

            do
            {
                
                Console.WriteLine("\n---------------------------");
                Console.WriteLine("Cua hang ban giay NET101 ");
                Console.WriteLine("1. Them mot doi giay ");
                Console.WriteLine("2. Danh sach giay ");
                Console.WriteLine("3. Mua giay");
                Console.WriteLine("4. thoat ");
                Console.WriteLine("---------------------------");
                Console.WriteLine("moi ban chon chuc nang ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Them mot doi giay");
                        hGiay.kho();
                        
                        break;
                    case 2:
                        Console.WriteLine("Danh sach giay ");
                        hGiay.ds();
                       

                        
                        break;
                    case 3:
                        Console.WriteLine("Mua giay ");
                        hGiay.hangtonkho();
                        break;
                    case 4:
                        Console.WriteLine("thoat !!!");
                        break;
                    default: Console.WriteLine("khong co chuc nang nay moi chon lai!!!");
                        
                        break;
                }
            } while (chon!=4);
            Console.ReadKey();
        }
    }
}
