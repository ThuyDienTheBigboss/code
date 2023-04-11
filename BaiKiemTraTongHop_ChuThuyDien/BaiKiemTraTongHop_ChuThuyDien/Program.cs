

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTraTongHop_ChuThuyDien
{
    internal class Program
    {
        //thong tin Sach 
       public  class Sach
        {
            public string Tensach;
            public string Tentacgia;
            public int Sotrang;
            public string Nhasaxuat;
            public int Dongia;


            public Sach()
            {
            }
            public Sach(string Tensach, string Tentacgia, int Sotrang, string Nhasanxuat, int Dongia)
            {
                this.Tensach = Tensach;
                this.Tentacgia = Tentacgia;
                this.Nhasaxuat = Nhasanxuat;
                this.Sotrang = Sotrang;
                this.Dongia = Dongia;
            }
            public void NhapSach()
            {
                Console.WriteLine("Nhap Ten sach :");
                Tensach = Console.ReadLine();
                Console.WriteLine(" Nhap Ten ten gia:");
                Tentacgia = Console.ReadLine();
                Console.WriteLine("Nhap So trang sach:");
                Sotrang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Nha san xuat sach:");
                Nhasaxuat = Console.ReadLine();
                Console.WriteLine("Nhap Don gia:");
                Dongia = int.Parse(Console.ReadLine());

            }
            public void HienThiThongTinSach()
            {
                Console.WriteLine("Ten sach " + Tensach);
                Console.WriteLine("Ten tac gia:" + Tentacgia);
                Console.WriteLine("So trang :" + Sotrang);
                Console.WriteLine("Nha san xuat" + Nhasaxuat);
                Console.WriteLine("Don gia " + Dongia);
            }

            public static void KhachHang()
            {

            }


            //Thong tin Bao
            class Bao
            {
                public string Tenbao;
                public int Ngayra;
                public string Coquanphathang;
                public int Dongia;
                public Bao() { }
                public Bao(string Tenbao, int Ngayra, string Coquanphathang, int Dongia)
                {
                    this.Tenbao = Tenbao;
                    this.Ngayra = Ngayra;
                    this.Coquanphathang = Coquanphathang;
                    this.Dongia = Dongia;
                }
                public void NhapBao()
                {
                    Console.WriteLine(" Nhap Ten Bao ");
                    Tenbao = Console.ReadLine();
                    Console.WriteLine("Nhap Ngay ra:");
                    Ngayra = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap ten co quan phat hang:");
                    Coquanphathang = Console.ReadLine();
                    Console.WriteLine("Nhap don gia:");
                    Dongia = int.Parse(Console.ReadLine());
                }
                public void HienThiThongTinBao()
                {
                    Console.WriteLine("Ten bao " + Tenbao);
                    Console.WriteLine("Ngay ra:" + Ngayra);
                    Console.WriteLine("Co quan phat hang :" + Coquanphathang);
                    Console.WriteLine("Don gia " + Dongia);

                }
            }
            //Thong tin Tap Chi
            class TapChi
            {
                public string Tentapchi;
                public int Sotapchi;
                public int Ngayra;
                public int Dongia;
                public TapChi() { }
                public TapChi(string Tentapchi, int Sotapchi, int Ngayra, int Dongia)
                {
                    this.Tentapchi = Tentapchi;
                    this.Sotapchi = Sotapchi;
                    this.Ngayra = Ngayra;
                    this.Dongia = Dongia;
                }
                public void NhapTapChi()
                {
                    Console.WriteLine(" Nhap ten tap chi: ");
                    Tentapchi = Console.ReadLine();
                    Console.WriteLine("Nhap so tap chi:");
                    Sotapchi = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap ngay ra:");
                    Ngayra = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap don gia:");
                    Dongia = int.Parse(Console.ReadLine());
                }
                public void HienThiThongTinTapChi()
                {
                    Console.WriteLine("Ten tap chi " + Tentapchi);
                    Console.WriteLine("So Tap chi:" + Sotapchi);
                    Console.WriteLine("Ngay ra  :" + Ngayra);
                    Console.WriteLine("Don gia " + Dongia);
                }
                public class Khachhang
                {
                    public string Hoten;
                    public string Diachi;
                    public string Email;
                    public int Sodienthoai;
                    public int SoluongdatSach = 0;
                    public int SoluongdatBao = 0;
                    public int SoluongdatTapchi = 0;
                    public int Tienphaithanhtoan;


                    public void NhapKhachHang()
                    {
                        Console.WriteLine("Nhap ho ten");
                        Hoten = Console.ReadLine();
                        Console.WriteLine("Nhap dia chi :");
                        Diachi = Console.ReadLine();
                        Console.WriteLine("Nhap email:");
                        Email = (Console.ReadLine());
                        Console.WriteLine("Nhap so dien thoai :");
                        Sodienthoai = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so luong dat sach :");
                        SoluongdatSach = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so luong dat bao:");
                        SoluongdatBao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhao so luong dat tap chi:");
                        SoluongdatTapchi = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap tien thanh toan");
                        Tienphaithanhtoan = int.Parse(Console.ReadLine());
                    }
                    public void XuatKhachHang()
                    {
                        Console.WriteLine("Ho ten: {0}", Hoten);
                        Console.WriteLine("Dia chi: {0}", Diachi);
                        Console.WriteLine("Email: {0}", Email);
                        Console.WriteLine("SDT: {0}", Sodienthoai);
                        Console.WriteLine("So luong dat sach: {0}", SoluongdatSach);
                        Console.WriteLine("So luong dat bao: {0}", SoluongdatBao);
                        Console.WriteLine("So luong dat tap chi: {0}", SoluongdatTapchi);
                    }

                    public static void Main(string[] args)
                    {
                        Sach s = new Sach();
                        Bao b = new Bao();
                        TapChi tc = new TapChi();
                        int choie = 0;
                        int n = 0;
                        Khachhang []kh = new Khachhang[n];
                        do
                        {
                            Console.WriteLine("\n------MENU----------");
                            Console.WriteLine("1. Nhap sach");
                            Console.WriteLine("2. Nhap bao");
                            Console.WriteLine("3. Nhap tap chi");
                            Console.WriteLine("4. Xuat sach");
                            Console.WriteLine("5. Xuat bao");
                            Console.WriteLine("6. Xuat tap chi");
                            Console.WriteLine("7. Nhap thong tin khach hang");
                            Console.WriteLine("8. Xuat thong tin khach hang");
                            Console.WriteLine("9. Thoat chuong trinh! ");
                            Console.WriteLine("\nNhap lua chon");
                    
                        switch (choie)
                        {
                                case 1:
                                    s.NhapSach();
                                    break;
                                case 2:
                                    b.NhapBao();
                                    break;
                                case 3:
                                    tc.NhapTapChi();
                                    break;
                                    case 4:
                                    s.HienThiThongTinSach();
                                    break;
                                    case 5: 
                                    b.HienThiThongTinBao();
                                    break;
                                    case 6:
                                    tc.HienThiThongTinTapChi();
                                    break;
                                    case 7:
                                    Console.WriteLine("\nNhap so luong khach hang :");
                                    n=int .Parse(Console.ReadLine());
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.WriteLine("\nNhap khach hang {0}", i);
                                        Khachhang[i]=new Khachhang();
                                        Khachhang[i]
                                    }

                        }
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}j
          

              

        
        
