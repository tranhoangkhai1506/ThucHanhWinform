using Lab01_Bai01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        private static List<Student> NhapDSSinhVien()
        {
            List<Student> listStudent = new List<Student>();
            Console.Write("Nhap so luong Sinh Vien: ");
            int slSinhVien = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Danh Sach Sinh Vien");
            for (int i = 0; i < slSinhVien; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                Student sv = new Student();
                sv.Input();
                listStudent.Add(sv);
            }
            {

            }
            return listStudent;
        }

        private static void XuatDSSinhVien(List<Student> liststudent)
        {
            foreach (var item in liststudent)
            {
                item.Output();
            }
        }
        static void Main(string[] args)
        {
            List<Student> dssv = NhapDSSinhVien();
            Console.WriteLine("\n___DANH SACH SINH VIEN___");
            XuatDSSinhVien(dssv);
            Console.ReadKey();

            // Cau 1.1

            List<Student> listCNTT = dssv.Where(p => p.Faculty == "CNTT").ToList();
            Console.WriteLine("\n- DANH SACH SINH VIEN CNTT");
            XuatDSSinhVien(listCNTT);

            // Cau 1.2

            List<Student> listSTLon5 = dssv.Where(p => p.AvgScore >= 5).ToList();
            Console.WriteLine("\n-----DANH SACH SINH VIEN CO DIEM TB >= 5-----");
            XuatDSSinhVien(listSTLon5);

            // Cau 1.3

            List<Student> OrderByListAVG = dssv.OrderBy(p => p.AvgScore).ToList();
            Console.WriteLine("\n-----DANH SACH SINH VIEN DA SAP XEP-----");
            XuatDSSinhVien(OrderByListAVG);

            // Cau 1.4

            List<Student> listLon5CNTT = dssv.Where(p => p.AvgScore >= 5 && p.Faculty == "CNTT").ToList();
            Console.WriteLine("\n-----DANH SACH SINH VIEN AVG >= 5 and CNTT-----");
            XuatDSSinhVien(listLon5CNTT);

            // Cau 1.5

            var max = dssv.Max(p => p.AvgScore);

            List<Student> listMaxCNTT = listCNTT.Where(p => p.AvgScore == max).ToList();
            Console.WriteLine("\n-----DANH SACH SINH VIEN MAX AVG CNTT-----");
            XuatDSSinhVien(listMaxCNTT);
        }
    }
}