using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai04
{
    internal class Proc
    {
        static void Main(String[] agrs)
        {
            List<KhuDat> ds = new List<KhuDat>();
            KhuDat kd;

            int slTT;
            Console.Write("Nhap so luong Thong Tin Can Quan Ly: ");
            slTT = Int32.Parse(Console.ReadLine());

            int chon;
            for (int i = 0; i < slTT; i++)
            {
                do
                {
                    Console.WriteLine("1. Them Khu Dat");
                    Console.WriteLine("2. Them Nha Pho");
                    Console.WriteLine("3. Them Chung Cu");
                    Console.Write("Lua Chon Cua Ban: ");

                    chon = Int32.Parse(Console.ReadLine());

                    if (chon != 1 && chon != 2 && chon != 3)
                    {
                        Console.WriteLine("Hay nhap lai!");
                    }
                    switch (chon)
                    {
                        case 1:
                            kd = new KhuDat();
                            Console.WriteLine("-NHAP KHU DAT-");
                            kd.Input();
                            ds.Add(kd);
                            break;
                        case 2:
                            kd = new NhaPho();
                            Console.WriteLine("-NHAP NHA PHO-");
                            kd.Input();
                            ds.Add(kd);
                            break;
                        case 3:
                            kd = new ChungCu();
                            Console.WriteLine("-NHAP CHUNG CU-");
                            kd.Input();
                            ds.Add(kd);
                            break;
                    }
                } while (chon != 1 && chon != 2 && chon != 3);
            }

            // Xuat list
            Console.WriteLine("\n---- DANH SACH THONG TIN QUAN LY ----");
            foreach(KhuDat i in ds)
            {
                if(i.GetType() == typeof(KhuDat))
                {
                    i.Output();
                    Console.WriteLine();
                }
                else {  i.Output(); }                
            }

            // Tong gia ban
            float tongKhuDat = 0;
            float tongChungCu = 0;
            float tongNhaPho = 0;

            foreach(KhuDat i in ds)
            {
                if(i.GetType() == typeof(KhuDat))
                {
                    tongKhuDat += i.GiaBan;
                }
                if(i.GetType() == typeof(ChungCu))
                {
                    tongChungCu += i.GiaBan;
                }
                if (i.GetType() == typeof(NhaPho))
                {
                    tongNhaPho += i.GiaBan;
                }
            }

            Console.WriteLine("\n-- Tong Gia Ban");
            Console.WriteLine("Khu Dat: {0} (Vnd)| Chung Cu: {1} (Vnd)| Nha Pho: {2} (Vnd)|", tongKhuDat, tongChungCu, tongNhaPho);


            // Xuat DT > 100m^2

            List<KhuDat> listKhuDat = ds.Where(p => (p is KhuDat) && p.DienTich > 100 || (p is NhaPho) && (p as NhaPho).DienTich > 60 && (p as NhaPho).NamXayDung >= 2020).ToList();

            Console.WriteLine("\n-- DANH SACH KHU DAT CHON LOC");
            if (listKhuDat.Count() == 0) { Console.WriteLine("\n -- KHONG TIM THAY!"); }
            else
            {
                foreach (KhuDat i in listKhuDat)
                {
                    if (i.GetType() == typeof(KhuDat))
                    {
                        i.Output();
                        Console.WriteLine();
                    }
                    else { i.Output(); }
                }
            }

            //  Find
            string diadiemTim;
            float giaTim;
            double dienTichTim;

            Console.Write("\n Nhap Dia Diem Tim: ");
            diadiemTim = Console.ReadLine();
            Console.Write("\n Nhap Gia Tim: ");
            giaTim = float.Parse( Console.ReadLine());
            Console.Write("\n Nhap Dien Tich Tim: ");
            dienTichTim = double.Parse( Console.ReadLine());


            List<KhuDat> listResult = ds.Where(p => (p is NhaPho) && p.DiaDiem.ToUpper() == diadiemTim.ToUpper() && p.GiaBan <= giaTim && p.DienTich >= dienTichTim
                                                    || (p is ChungCu) && p.DiaDiem.ToUpper() == diadiemTim.ToUpper() && p.GiaBan <= giaTim && p.DienTich >= dienTichTim).ToList();

            Console.WriteLine("\n-- KET QUA TIM KIEM");

            if (listResult.Count() == 0) { Console.WriteLine("\n -- KHONG TIM THAY!"); }
            else { 
                foreach (KhuDat i in listResult)
                {
                    if (i.GetType() == typeof(KhuDat))
                    {
                        i.Output();
                        Console.WriteLine();
                    }
                    else { i.Output(); }
                }
            }  
        }
    }
}
