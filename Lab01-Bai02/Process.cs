using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai02
{
    internal class Process
    {
        static void Main(string[] agrs)
        {
            List<Person> ds = new List<Person>();
            Person ps;

            int slNguoi;
            Console.Write("Nhap so luong con nguoi: ");
            slNguoi = Int32.Parse(Console.ReadLine());

            int chon;
            for (int i = 0; i < slNguoi; i++)
            {
                do
                {
                    Console.WriteLine("1. Them Hoc Sinh");
                    Console.WriteLine("2. Them Giao Vien");
                    Console.Write("Lua Chon Cua Ban: ");

                    chon = Int32.Parse(Console.ReadLine());

                    if (chon != 1 && chon != 2)
                    {
                        Console.WriteLine("Hay nhap lai!");
                    }
                    switch (chon)
                    {
                        case 1:
                            ps = new Student();
                            Console.WriteLine("-NHAP SINH VIEN-");
                            ps.Input();
                            ds.Add(ps);
                            break;
                        case 2:
                            ps = new Teacher();
                            Console.WriteLine("-NHAP GIAO VIEN-");
                            ps.Input();
                            ds.Add(ps);
                            break;
                    }
                } while (chon != 1 && chon != 2);
            }

            Console.WriteLine("\n--DANH SACH--");
            foreach (var item in ds)
            {
                item.Output();
            }

            // Cau 2.1 Sinh Vien and CNTT

            List<Student> listSV = new List<Student>();
            foreach (Person item in ds)
            {
                if (item.GetType() == typeof(Student))
                {
                    listSV.Add((Student)item);
                }
            }

            List<Student> listSVCNTT = listSV.Where(p => p.Faculty == "CNTT").ToList(); ;
            Console.WriteLine("\n--DANH SACH SINH VIEN CONG NGHE THONG TIN");
            if (listSVCNTT.Count() == 0)
            {
                Console.WriteLine("\nKHONG TIM THAY!");
            }
            else
            {
                foreach (Student item in listSVCNTT)
                {
                    item.Output();
                }
            }
            // Cau 2.2 TB < 5 va CNTT

            List<Student> listTBNho5CNTT = listSVCNTT.Where(p => p.AvgScore < 5).ToList();
            Console.WriteLine("\n--DANH SACH SINH VIEN CONG NGHE THONG TIN TB < 5");
            if (listTBNho5CNTT.Count() == 0)
            {
                Console.WriteLine("\nKHONG TIM THAY!");
            }
            else
            {
                foreach (Student item in listTBNho5CNTT)
                {
                    item.Output();
                }
            }

            // Cau 1.3

            List<Teacher> listTeacher = new List<Teacher>();

            foreach (var item in ds)
            {
                if (item.GetType() == typeof(Teacher))
                {
                    listTeacher.Add((Teacher)item);
                }
            }

            List<Teacher> listTeacherQ9 = listTeacher.Where(p => p.DiaChia == "Quan 9").ToList();
            Console.WriteLine("\n--DANH SACH GIANG VIEN QUAN 9");
            if (listTeacherQ9.Count() == 0)
            {
                Console.WriteLine("\nKHONG TIM THAY!");
            }
            else
            {
                foreach (Teacher item in listTeacherQ9)
                {
                    item.Output();
                }
            }

            // Cau 1.4
            var listID = (from i in listTeacher where i.StudentID == "CHN060286" select i).ToList();
            Console.WriteLine("\n--THONG TIN GIANG VIEN CHN060286");
            if(listID.Count() == 0)
            {
                Console.WriteLine("\nKHONG TIM THAY!");
            }
            else 
            {
                foreach (Teacher item in listID)
                {
                    item.Output();
                }
            }
            
            // Cau 1.5
            float avgMax = listSVCNTT.Max(p => p.AvgScore);
            List<Student> listMaxAvg = listSVCNTT.Where(p => p.AvgScore == avgMax).ToList();
            Console.WriteLine("\n--DANH SACH SINH VIEN CO DIEM CAO NHAT");
            if (listMaxAvg.Count() == 0)
            {
                Console.WriteLine("\n--KHONG CO SINH VIEN NAO!");
            }
            else {
                foreach (Student item in listMaxAvg)
                {
                    item.Output();
                }
            }
            
        }
    }
}