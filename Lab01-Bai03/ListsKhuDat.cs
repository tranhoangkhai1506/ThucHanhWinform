using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai03
{
    internal class ListsKhuDat
    {
        List<KhuDat> listKhuDat;

        public void NhapDanhSach()
        {
            listKhuDat = new List<KhuDat>();
            KhuDat kd;
            int slDat;
            Console.Write("Nhap so luong khu dat can them: ");
            slDat = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < slDat; i++)
            {
                Console.WriteLine("--Nhap Thong Tin Khu Dat Thu {0}", i + 1);
                kd = new KhuDat();
                kd.Input();
                listKhuDat.Add(kd);
            }
        }

        public void XuatDanhSach()
        {
            foreach (var item in listKhuDat)
            {
                item.Output();
            }
        }

        public void SapXepTangDanTheoDienTich()
        {
            List<KhuDat> listTangDan = listKhuDat.OrderBy(p => p.DienTich).ToList();
            Console.WriteLine( "\n-- DANH SACH KHU DAT DA DUOC SAP XEP");
            foreach (var item in listTangDan)
            {
                item.Output();
            }
        }

        public void XuatTheoGiaBanVaDienTich()
        {
            List<KhuDat> listGiaDienTich = listKhuDat.Where(p => p.GiaBan > 1000000000 && p.DienTich >= 60).ToList();
            Console.WriteLine("\n-- DANH SACH KHU DAT GIA TREN 1B VA DIEN TICH TREN 60m^2");
            if (listGiaDienTich.Count() == 0) { Console.WriteLine("\n-- KHONG TIM THAY"); }
            else {
                foreach (var item in listGiaDienTich)
                {
                    item.Output();
                }
            }
            
        }

        public double DonGiaTrungBinh(KhuDat khuDat)
        {
            if(khuDat.DienTich > 1000)
            {
                return khuDat.GiaBan / khuDat.DienTich;
            }
            return 0;
        }

        public void XuatTrungBinh()
        {
            Console.WriteLine("\n-- DANH SACH KHU DAT DA DUOC TINH TRUNG BINH M^2");
            foreach (var item in listKhuDat)
            {
                Console.WriteLine("Dia Diem: {0} | Gia Ban: {1}(Vnd) | Dien Tich: {2}(m^2) | Don Gia (VND/m^2): {3}", item.DiaDiem, item.GiaBan, item.DienTich, DonGiaTrungBinh(item));
            }
        }
    }
}
