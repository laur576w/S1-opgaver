using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Opgave18 {
    internal class Box  {
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }
        
        public Box(double width, double height, double length) {
            Length = length;
            Width = width;
            Height = height;
        }
        public void PrintInfo() {
            Console.WriteLine($"{Width}x{Height}x{Length}");
        }
    }
    
}
