using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapStruct
{
    internal class Program
    {
        struct Book
        {
            public string Masach;
            public string Tentacgia;
            public string Tensach;
            public string Theloai;


        }
        public class test
        {
            static void Main(string[] args)
            {
                Book book1;
                Book book2;

                /* book 1*/
                book1.Masach = "mot";
                book1.Tentacgia = "Chu Thuy Dien";
                book1.Tensach = "Laptrinhvien";
                book1.Theloai = "cntt";
                /*book 2*/
                book2.Masach = "Hai";
                book2.Tentacgia = "Ly Thuy Anh";
                book2.Tensach = "CongChuanho";
                book2.Theloai = "Cute";
                /* book1*/
                Console.WriteLine("book1 Masach:{0}", book1.Masach);
                Console.WriteLine("Book 1 Ten tac gia : {0}", book1.Tentacgia);
                Console.WriteLine("Book 1 Ten sach : {0}", book1.Tensach);
                Console.WriteLine("Book 1 The loai: {0}", book1.Theloai);
                /*book2*/
                Console.WriteLine("Book 2 Ma sach : {0}", book2.Masach);
                Console.WriteLine("Book 2 Ten tac gia  : {0}", book2.Tentacgia);
                Console.WriteLine("Book 2 Ten sach : {0}", book2.Tensach);
                Console.WriteLine("Book 2 The loai:{0}", book2.Theloai);

                Console.ReadKey();
            }
        }
    }
}
                





