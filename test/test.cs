using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bai2
{
    internal class giay
    {
        ArrayList hangGiay = new ArrayList() ;
        

        public string giayID { get; set; }
        public string tenGiay { get; set; }
        public string thuongHIeu { get; set; }
        public string mauSac { get; set; }
        public int size { get; set; }
        public float gia { get; set; }
        public int tonKho { get; set; }

        public giay(string giayID, string tenGiay, string thuongHIeu, string mauSac, int size, float gia, int tonKho)
        {
            giayID = giayID;
            tenGiay = tenGiay;
            thuongHIeu = thuongHIeu;
            mauSac = mauSac;
            size = size;
            gia = gia;
            tonKho = tonKho;
        }
        public giay()
        {

        }
        public void kho()
        {
            Console.Write("ten giay: ");
            tenGiay = Console.ReadLine();
            Console.Write("ID giay: ");
            giayID = Console.ReadLine();
            Console.Write("thuong hieu: ");
            thuongHIeu = Console.ReadLine();
            Console.Write("mau sac:  ");
            mauSac = Console.ReadLine();
            Console.Write("size: ");
            size = int.Parse(Console.ReadLine());
            Console.Write("gia: ");
            gia = float.Parse(Console.ReadLine());
            Console.Write("ton kho: ");
            tonKho = int.Parse(Console.ReadLine());
            hangGiay.Add(giayID);
            hangGiay.Add(tenGiay);
            hangGiay.Add(thuongHIeu);
            hangGiay.Add(mauSac);
            hangGiay.Add(size);
            hangGiay.Add(gia);
            hangGiay.Add(tonKho);



        }
        public void ds()
        {
            foreach(var i in hangGiay)
            {
                Console.WriteLine(i);
            }
        }
        public int hangtonkho()
        {
            int n;
            int hang;
            Console.Write("nhap n");
            n = int.Parse(Console.ReadLine());

            hang = tonKho - n;
            hangGiay.Add((int)hang);

            return 0;
        }

    }
}
