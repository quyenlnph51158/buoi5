using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhap
{
    internal class nhap1
    {
        internal class sanPham
        {

            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public float DonGia { get; set; }
            public int SoLuong { get; set; }


            public sanPham()
            {
                // constructor không có tham số
            }

            public sanPham(string maSanPham, string tenSanPham, double donGia, int soLuong)
            {
                MaSanPham = maSanPham;
                TenSanPham = tenSanPham;
                DonGia = DonGia;
                SoLuong = soLuong;
            }
            public float tinhTien()
            {
                return DonGia * SoLuong;
            }
            public void xuatCoSan()
            {

                MaSanPham = "PH51152";
                TenSanPham = "mi tom";
                DonGia = 30;
                SoLuong = 30;
                Console.WriteLine("ma san pham:{0} \nten san pham {1} \ndon gia {2} \nso luong{3} \n thanh tien:{4}", MaSanPham, TenSanPham, DonGia, SoLuong, tinhTien());
            }
            public void nhap()
            {
                Console.Write("nhap ma san pham: ");
                MaSanPham = Console.ReadLine();
                Console.Write("nhap ten san pham: ");
                TenSanPham = Console.ReadLine();
                Console.Write("nhap don gia: ");
                DonGia = float.Parse(Console.ReadLine());
                Console.Write("nhap so luong: ");
                SoLuong = int.Parse(Console.ReadLine());
            }
            public void Xuat()
            {
                Console.WriteLine("ma san phan la:{0} \n ten san pham la :{1} \n don gia la: {2} \n so luong la : {3} \n thanh tien {4} ", MaSanPham, TenSanPham, DonGia, SoLuong);
            }
        }
    }
}

