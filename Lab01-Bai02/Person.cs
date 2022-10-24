using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai02
{
    internal class Person
    {
        private string studentID;
        private string fullName;
        public Person()
        {

        }
        public Person(string studentID, string fullName)
        {
            this.studentID = studentID;
            this.FullName = fullName;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }


        public virtual void Input()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhap studentID: ");
            this.studentID = Console.ReadLine();
            Console.Write("Nhap ten: ");
            this.fullName = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("ID: {0} | FullName: {1} |", studentID, fullName);
        }
    }
}
