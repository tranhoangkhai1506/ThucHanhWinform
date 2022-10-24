using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai04
{
    internal class ChungCu : KhuDat
    {
        private int tang;

        public ChungCu()
        {
        }

        public ChungCu(string diaDiem, float giaBan, double dienTich, int tang)
            : base(diaDiem, giaBan, dienTich)
        {
            this.Tang = tang;
        }

        public int Tang { get => tang; set => tang = value; }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Tang:  ");
            tang = Int32.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Tang: {0} |", tang);
        }
    }
}
