using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public SanPham(string maSanPham, string tenSanPham, int donGia, int soLuong)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public SanPham()
        {
            
        }
        public float tinhTien()
        {
            return DonGia * SoLuong;
        }
        public void hangCoSan()
        {
            TenSanPham = "keoNgot";
            MaSanPham = "s555";
            DonGia = 32000;
            SoLuong = 50;
            Console.WriteLine("san pham: {0} \nco ma san pham: {1} \nco gia:{2}/1sp \ncon {3} san pham trong kho \nthanh tien: {4} ",TenSanPham,MaSanPham,DonGia,SoLuong,tinhTien());
        }
        public void nhap ()
        {
            Console.WriteLine("nhap ten san pham can tim: ");
            TenSanPham=Console.ReadLine();
            Console.WriteLine("nhap ma san pham can tim: ");
            MaSanPham = Console.ReadLine();
            
        }
        public void xuat()
        {
            Console.WriteLine($"san pham: {TenSanPham} \nma san pham: {MaSanPham}\n con {SoLuong} trong kho\nco gia {DonGia}/sanpham");
        }
    }

}
