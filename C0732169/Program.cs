using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732169
{

    class Program


    {
        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Mary", 3.8, 20);
            StudentInformation _John = new StudentInformation("John", 2.0, 10);
            StudentInformation _Mark = new StudentInformation("Mark", 0.2, 3);
            StudentInformation _Steve = new StudentInformation("Steve", 2.9, 20);
        }
    }

    class StudentInformation
    {
        public string Name;
        public string StudentNumber;
        public double GPA;
        public int Attendance;
        public StudentInformation(string aName, double cGPA, int dAttandence)
        {

            Name = aName;
            GPA = cGPA;
            Attendance = dAttandence;

        }


    }

}