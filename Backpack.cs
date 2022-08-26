using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DZ11_CSharp
{
    internal class Backpack
    {
        public double ? Volume { get; set; }
        public string ? Color { get; set; }
        public double ? Weight { get; set; }
        public string ? Fabric { get; set; }
        public double ? Size { get; set; }
        public double ? CurrentSize { get; set; }
        public List<Object> Content { get; set; }
        public Backpack(double? volume, string? color, double? weight, string? fabric, double? size)
        {
            Volume = volume;
            Color = color;
            Weight = weight;
            Fabric = fabric;
            Size = size;
            Content = new List<Object>();
            CurrentSize = 0;
        }
        public void ShowContent()
        {
            foreach(Object item in Content)
            {
                WriteLine(item.ToString());
            }
        }
    }
}
