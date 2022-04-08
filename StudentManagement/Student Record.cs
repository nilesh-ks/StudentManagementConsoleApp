using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student_Record
    {
        private List<Student> studentsList { get; set; } = new List<Student>();

        public void AddStudent(Student student)
        {
            studentsList.Add(student);
            Console.WriteLine(student.Name + " added successfully");
        }

        public Student FindStudentRecord(String roll)
        {
            var stu = studentsList.FirstOrDefault(x => x.Roll == roll);
            
            if(stu == null)
            {
                return null;
            }

            return stu;
        }

        


    }
}
