using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public interface IStudent
    {
        List<string> TestsTaken();
        void TakeTest(ITestpaper paper, string[] answers);
    }
}
