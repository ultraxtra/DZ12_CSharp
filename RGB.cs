using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;
using static System.Console;
using System.Drawing;

namespace DZ11_CSharp
{
    public delegate String RGB(Color c);
    internal class ShowRgb
    {
        public event RGB? eventGetRgb;
        public String GetRgb(Color c)
        {
            if(eventGetRgb != null)
            {
                return eventGetRgb(c);
            }
            throw new NullReferenceException();
        }
    }
}