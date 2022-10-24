using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai04
{
    internal class NhaPho : KhuDat
    {
        private int namXayDung;
        private int soTang;

        public NhaPho()
        {
                
        }

        public NhaPho(string diaDiem, float giaBan, double dienTich, int namXayDung, int soTang)
            : base(diaDiem, giaBan, dienTich)
        {
            this.NamXayDung = namXayDung;
            this.SoTang = soTang;
        }

        public int NamXayDung { get => namXayDung; set => namXayDung = value; }
        public int SoTang { get => soTang; set => soTang = value; }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Nam Xay:  ");
            namXayDung = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap So Tang:  ");
            soTang = Int32.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Nam Xay Dung: {0} | So Tang: {1}(Vnd) |", namXayDung, soTang);
        }
    }
}
