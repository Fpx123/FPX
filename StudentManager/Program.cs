using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Program
    {
        static Student[] studentList;
        static void Main(string[] args)
        {
            //nhập tổng số sinh viên
            int numOfStudent;
            Console.Write("Num of Student=");
            try
            {
                
                numOfStudent = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid Input Number Of Student-{0}", ex.Message);
                Console.ReadLine();
                return;
            }
            //Tạo danh sách sinh vvie6n
            InputstudentList(numOfStudent);
            OutputStudent();
            Console.ReadLine();
        }
        /// <summary>
        /// hàm xuất danh sách sinh viên
        /// </summary>
        private static void OutputStudent()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine("Student ID={0}", student.StudentID);
                Console.WriteLine("Student FullName={0}", student.FullName);
                Console.WriteLine("Student Mark={0}", student.Mark);
                Console.WriteLine("Student Falculty={0}", student.Falculty);

            }
        }

        private static void InputstudentList(int numOfStudent)
        {
            //Tạo mảng lưu danh sách sinh viên
            studentList = new Student[numOfStudent];
            Student student;

            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.Write("StudentID=");
                student.StudentID = int.Parse(Console.ReadLine());

                Console.Write("StudenFullname=");
                student.FullName = Console.ReadLine();

                Console.Write("StudentMark=");
                student.Mark = float.Parse(Console.ReadLine());

                Console.Write("StudentFaculty=");
                student.Falculty = Console.ReadLine();

                //Lưu đốii tuộng vào danh sách
            }
        }
    }
}
