using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai02
{
    internal class Student : Person
    {
        private float avgScore;
        private string faculty;

        public float AvgScore
        {
            get { return avgScore; }
            set { avgScore = value; }
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Student()
        {

        }

        public Student(string studentID, string fullname, float avgScore, string faculty)
            : base(studentID, fullname)
        {
            this.AvgScore = avgScore;
            this.Faculty = faculty;
        }

        public override void Input()
        {
            base.Input();
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhap diem TB: ");
            this.avgScore = float.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            this.faculty = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("AvgScore: {0} | Faculty: {1}\n", avgScore, faculty);
        }
    }
}
