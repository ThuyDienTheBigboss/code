using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test
    {
        public class Sach
        {
            public string tenSach;
            public string tenTacGia;
            public int soTrang;
            public string nxb;
            public int donGiaSach;

            public void NhapSach()
            {
                Console.WriteLine("\nNhap ten sach: ");
                tenSach = Console.ReadLine();
                Console.WriteLine("Nhap ten tac gia: ");
                tenTacGia = Console.ReadLine();
                Console.WriteLine("Nhap so trang: ");
                soTrang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten NXB: ");
                nxb = Console.ReadLine();
                Console.WriteLine("Nhap don gia sach: ");
                donGiaSach = int.Parse(Console.ReadLine());
            }

            public void XuatSach()
            {
                Console.WriteLine("Ten sach: {0}", tenSach);
                Console.WriteLine("Ten tac gia: {0}", tenTacGia);
                Console.WriteLine("So trang: {0}", soTrang);
                Console.WriteLine("Ten NXB: {0}", nxb);
                Console.WriteLine("Don gia sach: {0}", donGiaSach);
            }
        }

        public class Bao
        {
            public string tenBao;
            public int ngayRaBao;
            public string coQuanPhatHanh;
            public int donGiaBao;

            public void NhapBao()
            {
                Console.WriteLine("\nNhap ten bao: ");
                tenBao = Console.ReadLine();
                Console.WriteLine("Nhap ngay ra bao: ");
                ngayRaBao = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten co quan phat hanh: ");
                coQuanPhatHanh = Console.ReadLine();
                Console.WriteLine("Nhap don gia bao: ");
                donGiaBao = int.Parse(Console.ReadLine());
            }

            public void XuatBao()
            {
                Console.WriteLine("Ten bao: {0}", tenBao);
                Console.WriteLine("Ngay ra bao: {0}", ngayRaBao);
                Console.WriteLine("Ten co quan phat hanh: {0}", coQuanPhatHanh);
                Console.WriteLine("Don gia bao: {0}", donGiaBao);
            }
        }

        public class TapChi
        {
            public string tenTapChi;
            public int soTapChi;
            public int ngayRaTapChi;
            public int donGiaTapChi;

            public void NhapTapChi()
            {
                Console.WriteLine("\nNhap tap chi: ");
                tenTapChi = Console.ReadLine();
                Console.WriteLine("Nhap so tap chi: ");
                soTapChi = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ngay ra tap chi: ");
                ngayRaTapChi = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap don gia tap chi: ");
                donGiaTapChi = int.Parse(Console.ReadLine());
            }

            public void XuatTapChi()
            {
                Console.WriteLine("Ten tap chi: {0}", tenTapChi);
                Console.WriteLine("So tap chi: {0}", soTapChi);
                Console.WriteLine("Ngay ra tap chi: {0}", ngayRaTapChi);
                Console.WriteLine("Don gia tap chi: {0}", donGiaTapChi);
            }
        }

        public class KhachHang
        {
            public string hoTen;
            public string diaChi;
            public string email;
            public int sdt;
            public int soLuongDatSach = 0;
            public int soLuongDatBao = 0;
            public int soLuongDatTapChi = 0;
            public int tienPhaiThanhToan = 0;

            public void NhapKhachHang()
            {
                Console.WriteLine("Nhap ho ten: ");
                hoTen = Console.ReadLine();
                Console.WriteLine("Nhap dia chi: ");
                diaChi = Console.ReadLine();
                Console.WriteLine("Nhap email: ");
                email = Console.ReadLine();
                Console.WriteLine("Nhap sdt: ");
                sdt = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so luong dat sach: ");
                soLuongDatSach = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so luong dat bao: ");
                soLuongDatBao = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so luong dat tap chi: ");
                soLuongDatTapChi = int.Parse(Console.ReadLine());
            }

            public void XuatKhachHang()
            {
                Console.WriteLine("Ho ten: {0}", hoTen);
                Console.WriteLine("Dia chi: {0}", diaChi);
                Console.WriteLine("Email: {0}", email);
                Console.WriteLine("SDT: {0}", sdt);
                Console.WriteLine("So luong dat sach: {0}", soLuongDatSach);
                Console.WriteLine("So luong dat bao: {0}", soLuongDatBao);
                Console.WriteLine("So luong dat tap chi: {0}", soLuongDatTapChi);
            }
        }

        static void Main(String[] args)
        {
            Sach sach = new Sach();
            Bao bao = new Bao();
            TapChi tapChi = new TapChi();
            int choice = 0;
            int n = 0;
            KhachHang[] khachHang = new KhachHang[n];
            do
            {
                Console.WriteLine("\n--------------------MENU--------------------");
                Console.WriteLine("1. Nhap sach");
                Console.WriteLine("2. Nhap bao");
                Console.WriteLine("3. Nhap tap chi");
                Console.WriteLine("4. Xuat sach");
                Console.WriteLine("5. Xuat bao");
                Console.WriteLine("6. Xuat tap chi");
                Console.WriteLine("7. Nhap thong tin khach hang");
                Console.WriteLine("8. Xuat thong tin khach hang");
                Console.WriteLine("9. Thoat chuong trinh! ");

                Console.WriteLine("\nNhap lua chon: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        sach.NhapSach();
                        break;

                    case 2:
                        bao.NhapBao();
                        break;

                    case 3:
                        tapChi.NhapTapChi();
                        break;

                    case 4:
                        sach.XuatSach();
                        break;

                    case 5:
                        bao.XuatBao();
                        break;

                    case 6:
                        tapChi.XuatTapChi();
                        break;

                    case 7:
                        Console.WriteLine("\nNhap so luong khach hang: ");
                        n = int.Parse(Console.ReadLine());
                        khachHang = new KhachHang[n];

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("\nNhap khach hang {0}", i);
                            khachHang[i] = new KhachHang();
                            khachHang[i].NhapKhachHang();
                        }
                        break;
                
                    case 8:
                        Console.WriteLine("\n\n-------DANH SACH KHACH HANG-------");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("\nKhach hang {0}", i);
                            khachHang[i].XuatKhachHang();
                            if (khachHang[i].soLuongDatSach != 0)
                            {
                                Console.WriteLine("\n--Thong tin sach da dat--");
                                sach.XuatSach();
                            }
                            else
                            {
                                Console.WriteLine("\n--Ko dat sach--");
                            }
                            if (khachHang[i].soLuongDatBao != 0)
                            {
                                Console.WriteLine("\n--Thong tin bao da dat--");
                                bao.XuatBao();
                            }
                            else
                            {
                                Console.WriteLine("\n--Ko dat bao--");
                            }
                            if (khachHang[i].soLuongDatTapChi != 0)
                            {
                                Console.WriteLine("\n--Thong tin tap chi da dat--");
                                tapChi.XuatTapChi();
                            }
                            else
                            {
                                Console.WriteLine("\n--Ko dat tap chi--");
                            }
                            Console.WriteLine("\nTien phai thanh toan: {0}", ThanhTien(khachHang, i, sach, bao, tapChi));
                        }
                        break;

                    case 9:
                        return;
                }
            } while (choice != 8);
        }

        public static int ThanhTien(KhachHang[] khachHangs, int i, Sach sach, Bao bao, TapChi tapChi)
        {
            khachHangs[i].tienPhaiThanhToan = (sach.donGiaSach * khachHangs[i].soLuongDatSach) + (bao.donGiaBao * khachHangs[i].soLuongDatBao) + (tapChi.donGiaTapChi * khachHangs[i].soLuongDatTapChi);
            return khachHangs[i].tienPhaiThanhToan;
        }
    }
}