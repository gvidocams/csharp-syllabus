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
}
