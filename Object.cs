using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W._12._08
{
    public class Object
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public Object(string name, double size)
        {
            Name = name;
            Size = size;
        }
        public override string ToString()
        {
            return $"Name: {Name},Size: {Size}";
        }
    }
}

