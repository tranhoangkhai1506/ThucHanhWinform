using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai01
{
    internal class Student
    {
            private string studentID;
            private string fullName;
            private float avgScore;
            private string faculty;

            public string StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }

            public string FullName
            {
                get { return fullName; }
                set { fullName = value; }
            }

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
            {
                this.StudentID = studentID;
                this.FullName = fullname;
                this.AvgScore = avgScore;
                this.Faculty = faculty;
            }

            public void Input()
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.Write("Nhap ID: ");
                this.studentID = Console.ReadLine();
                Console.Write("Nhap ten: ");
                this.fullName = Console.ReadLine();
                Console.Write("Nhap diem TB: ");
                this.avgScore = float.Parse(Console.ReadLine());
                Console.Write("Nhap Khoa: ");
                this.faculty = Console.ReadLine();
            }

            public void Output()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("ID: {0} | FullName: {1} | AvgScore: {2} | Faculty: {3}", studentID, fullName, avgScore, faculty);
            }

    }
}
