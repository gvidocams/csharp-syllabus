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

            const string TopAndBottomLine = "+------------------------------------------------------------+";

            Console.WriteLine(TopAndBottomLine);
            Console.WriteLine($"| 1 |                          {class1} |       {teacher1} |");
            Console.WriteLine($"| 2 |                          {class2} |     {teacher2} |");
            Console.WriteLine($"| 3 |                         {class3} |       {teacher3} |");
            Console.WriteLine($"| 4 |                        {class4} |      {teacher4} |");
            Console.WriteLine($"| 5 |           {class5} |      {teacher5} |");
            Console.WriteLine($"| 6 |                             {class6} |    {teacher6} |");
            Console.WriteLine($"| 7 |                        {class7} | {teacher7} |");
            Console.WriteLine($"| 8 | {class8} |       {teacher8} |");
            Console.WriteLine(TopAndBottomLine);
        }
    }
}
