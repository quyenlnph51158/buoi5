using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD19303_BanGiay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add(5);

            //int index = arrayList.IndexOf(3);
            //arrayList.RemoveAt(index);
            //arrayList.Insert(index, 10);
        }

        static void Menu()
        {
            ArrayList danhSachGiay = new ArrayList();
            int luaChon = 0;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Cua hang ban giay NET101");
                Console.WriteLine("1. Them moi mot doi Giay");
                Console.WriteLine("2. Danh sach Giay");
                Console.WriteLine("3. Mua Giay");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("------------------------");
                Console.Write("Xin moi lua chon: ");
                //luaChon = int.Parse(Console.ReadLine());
                bool test = int.TryParse(Console.ReadLine(), out luaChon);

                if (test == true)
                {
                    switch (luaChon)
                    {
                        case 1:
                            ChucNang1(danhSachGiay);
                            break;
                        case 2:
                            ChucNang2(danhSachGiay);
                            break;
                        case 3:
                            ChucNang3(danhSachGiay);
                            break;
                        default:
                            Console.WriteLine("Xin hay chon tu 1-4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Chi duoc nhap int!");
                }

            } while (luaChon != 4);
            Console.WriteLine();
        }

        static void ChucNang1(ArrayList arrayList)
        {
            Giay giay = new Giay();
            Console.Write("Giay ID: ");
            giay.GiayID = int.Parse(Console.ReadLine());
            Console.Write("Ten Giay: ");
            giay.TenGiay = Console.ReadLine();
            Console.Write("Thuong Hieu: ");
            giay.ThuongHieu = Console.ReadLine();
            Console.Write("Size: ");
            giay.Size = int.Parse(Console.ReadLine());
            Console.Write("Mau Sac: ");
            giay.MauSac = Console.ReadLine();
            Console.Write("Gia: ");
            giay.Gia = double.Parse(Console.ReadLine());
            Console.Write("Ton Kho: ");
            giay.TonKho = int.Parse(Console.ReadLine());

            arrayList.Add(giay);
        }

        static void ChucNang2(ArrayList arrayList)
        {
            foreach (Giay giay in arrayList)
            {
                Console.WriteLine($"{giay.GiayID}\t{giay.TenGiay}\t{giay.ThuongHieu}\t" +
                    $"{giay.Size}\t{giay.MauSac}\t{giay.Gia}\t{giay.TonKho}");
            }
        }

        static void ChucNang3(ArrayList arrayList)
        {
            Console.Write("Ban muon mua doi giay nao: ");
            int idMua = int.Parse(Console.ReadLine());
            Console.Write("Ban muon bao nhieu doi: ");
            int soLuongMua = int.Parse(Console.ReadLine());

            Giay giayDuocChon = new Giay();
            int indexChon = -1;
            foreach (Giay giay in arrayList)
            {
                if (giay.GiayID == idMua)
                {
                    indexChon = arrayList.IndexOf(giay);
                    giayDuocChon = giay;
                    break;
                }
            }

            if (giayDuocChon.TonKho >= soLuongMua)
            {
                Console.WriteLine($"Mua thanh cong {soLuongMua} doi giay {idMua}");
                giayDuocChon.TonKho = giayDuocChon.TonKho - soLuongMua;
                arrayList.RemoveAt(indexChon);
                arrayList.Insert(indexChon, giayDuocChon);
            }
            else
            {

            }
            {
                Console.WriteLine("Khong du so luong!");
            }
        }
    }
}
