using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student
    {
        public Student(string roll, string name)
        {
            Roll = roll;
            Name = name;    
        }

        public String Roll { get; set; }
        public String Name { get; set; }

        public int Telugu { get; set; }
        public int Hindi { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }

        

        


    }
}
