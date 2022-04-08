using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Starting program execution */

            /* School name */
            Console.WriteLine("Enter School Name:");
            Console.WriteLine("Welcome to " + Console.ReadLine() + " Management System");
            Console.WriteLine("---------------------------------------------------------\n");

            /* Menu options */
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Add marks for student");
            Console.WriteLine("3. Show student progress card");
            Console.WriteLine("Press 'x' to exit\n");

            Console.WriteLine("Please provide valid input for menu options :");
            
            var studentRecord = new Student_Record();
            
            /* operations on menu options */
            while(true)
            {
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        /* Add student */
                        Console.WriteLine("Enter Student Roll Number :");
                        var rollToAddStudent = Console.ReadLine();
                        Console.WriteLine("Enter Student Name :");
                        var name = Console.ReadLine();
                        var student = new Student(rollToAddStudent, name);
                        studentRecord.AddStudent(student);

                        break;

                    case "2":
                        /* Add marks for existing students */
                        Console.WriteLine("Enter Student Roll Number :");
                        var rollForMarks = Console.ReadLine();
                        Student isStudent = studentRecord.FindStudentRecord(rollForMarks);
                        if (isStudent == null)
                        {
                            Console.WriteLine($"No student found with roll number {rollForMarks}");
                        }
                        else
                        {
                            Console.WriteLine("Enter Marks Scored in Telugu :");
                            isStudent.Telugu = Int16.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Marks Scored in Hindi :");
                            isStudent.Hindi = Int16.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Marks Scored in English :");
                            isStudent.English = Int16.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Marks Scored in Maths :");
                            isStudent.Maths = Int16.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Marks Scored in Science :");
                            isStudent.Science = Int16.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Marks Scored in Social :");
                            isStudent.Social = Int16.Parse(Console.ReadLine());

                            Console.WriteLine("Student marks are added successfully");
                        }

                        break;

                    case "3":
                        /* Find and show student's progress */
                        Console.WriteLine("Enter Student Roll Number :");
                        var rollToFindDetails = Console.ReadLine();
                        Student studentDetailsFound = studentRecord.FindStudentRecord(rollToFindDetails);
                        if (studentDetailsFound == null)
                        {
                            Console.WriteLine($"No student found with roll number {rollToFindDetails}");
                        }
                        else
                        {
                            int sum = 0;
                            Console.WriteLine($"Student Roll Number : {studentDetailsFound.Roll}");
                            Console.WriteLine($"Student Name : {studentDetailsFound.Name}");
                            Console.WriteLine("Student Marks");

                            Console.WriteLine("----------------");

                            Console.WriteLine($"Telugu : {studentDetailsFound.Telugu}");
                            sum+=studentDetailsFound.Telugu;

                            Console.WriteLine($"Hindi : {studentDetailsFound.Hindi}");
                            sum += studentDetailsFound.Hindi;

                            Console.WriteLine($"English : {studentDetailsFound.English}");
                            sum += studentDetailsFound.English;

                            Console.WriteLine($"Maths : {studentDetailsFound.Maths}");
                            sum += studentDetailsFound.Maths;

                            Console.WriteLine($"Science : {studentDetailsFound.Science}");
                            sum += studentDetailsFound.Science;

                            Console.WriteLine($"Social : {studentDetailsFound.Social}");
                            sum += studentDetailsFound.Social;

                            Console.WriteLine("----------------\n");

                            Console.WriteLine($"TotalMarks : {sum}");
                            double percentage = (double)((100 * Convert.ToDouble(sum) / 600));
           
                            
                            Console.WriteLine($"Percentage : {System.Math.Round(percentage, 2)}");


                        }
                        break;

                    case "x":
                        return;
                    default:
                        Console.WriteLine("Please provide valid input");
                        break;
                }
                Console.WriteLine("Press any key to continue");
            }
            
            
        }
    }
}
