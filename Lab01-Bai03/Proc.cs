using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai03
{
    internal class Proc
    {
        static void Main(String[] agrs)
        {
            ListsKhuDat listsKhuDat = new ListsKhuDat();
            listsKhuDat.NhapDanhSach();
            Console.WriteLine("\n-----DANH SACH KHU DAT-----");
            listsKhuDat.XuatDanhSach();
            listsKhuDat.SapXepTangDanTheoDienTich();
            listsKhuDat.XuatTheoGiaBanVaDienTich();
            listsKhuDat.XuatTrungBinh();
        }
    }
}
