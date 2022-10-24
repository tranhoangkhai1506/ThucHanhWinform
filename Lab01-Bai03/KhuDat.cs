using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab01_Bai03
{
    internal class KhuDat
    {
        private string diaDiem;
        private float giaBan;
        private double dienTich;

        public KhuDat()
        {

        }

        public KhuDat(string diaDiem, float giaBan, double dienTich)
        {
            this.DiaDiem = diaDiem;
            this.GiaBan = giaBan;
            this.DienTich = dienTich;
        }

        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public float GiaBan { get => giaBan; set => giaBan = value; }
        public double DienTich { get => dienTich; set => dienTich = value; }

        public void Input() {
            Console.Write("Nhap Dia Diem:  ");
            diaDiem = Console.ReadLine();
            Console.Write("Nhap Gia Ban(VND):  ");
            giaBan = float.Parse(Console.ReadLine());
            Console.Write("Nhap Dien Tich(m^2):  ");
            dienTich = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("Dia Diem: {0} | Gia Ban: {1}(Vnd) | Dien Tich: {2}(m^2)", DiaDiem, GiaBan, DienTich);
        }      
    }
}
