using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayClassesAndTeachers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string class1 = "English III";
            string class2 = "Precalculus";
            string class3 = "Music Theory";
            string class4 = "Biotechnology";
            string class5 = "Principles of Technology I";
            string class6 = "Latin II";
            string class7 = "AP US History";
            string class8 = "Business Computer Infomation Systems";

            string teacher1 = "Ms. Lapan";
            string teacher2 = "Mrs. Gideon";
            string teacher3 = "Mr. Davis";
            string teacher4 = "Ms. Palmer";
            string teacher5 = "Ms. Garcia";
            string teacher6 = "Mrs. Barnett";
            string teacher7 = "Ms. Johannessen";
            string teacher8 = "Mr. James";

            string[,] classesAndTeachers = new string[8, 2] {
                {class1, teacher1},
                {class2, teacher2},
                {class3, teacher3},
                {class4, teacher4},
                {class5, teacher5},
                {class6, teacher6},
                {class7, teacher7},
                {class8, teacher8},
            };
            
            const string TopAndBottomLine = "+------------------------------------------------------------+";

            Console.WriteLine(TopAndBottomLine);

            for(int i = 0; i < classesAndTeachers.GetLength(0); i++)
            {
                const int ClassesRowLength = 37;
                const int TeachersRowLength = 16;

                string thisClass = classesAndTeachers[i,0];
                string thisTeacher = classesAndTeachers[i, 1];

                var classWhitespace = new String(' ', ClassesRowLength - thisClass.Length);
                var teachersWhitespace = new String(' ', TeachersRowLength - thisTeacher.Length);

                Console.WriteLine($"| {i + 1} |{classWhitespace + thisClass} |{teachersWhitespace + thisTeacher} |");
            }

            Console.WriteLine(TopAndBottomLine);
        }
    }
}
