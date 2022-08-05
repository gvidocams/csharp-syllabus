using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public interface ITestpaper
    {
        string Subject();
        string[] MarkScheme();
        int PassMark();
    }
    public class Testpaper : ITestpaper
    {
        string subject;
        string[] markScheme;
        string passMark;

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            this.subject = subject;
            this.markScheme = markScheme;
            this.passMark = passMark;
        }

        public string Subject()
        {
            return subject;
        }

        public string[] MarkScheme()
        {
            return markScheme;
        }

        public int PassMark()
        {
            return Convert.ToInt32(passMark.Replace("%", ""));
        }
    }
}
