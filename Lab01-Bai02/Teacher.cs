using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai02
{
    internal class Teacher : Person
    {
        private string diaChia;

        public Teacher()
        {

        }
        public Teacher(string studentID, string fullName, string diaChia)
            : base(studentID, fullName)
        {
            this.diaChia = diaChia;
        }

        public string DiaChia { get => diaChia; set => diaChia = value; }

        public override void Input()
        {
            base.Input();
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhap dia chi: ");
            this.DiaChia = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Address: {0} |\n", diaChia);
        }
    }
}
