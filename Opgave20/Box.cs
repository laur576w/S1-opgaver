using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Opgave20 {
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
            Console.WriteLine( $"width: {Width}\n" +
                $"height: {Height}\n" +
                $"length: {Length}");
            CalcVolume();
            CalcSurface();
        }
        public void CalcVolume() {
            double volu = Height * Width * Length;
            Console.WriteLine($"Volume: {volu}");
        }

        public void CalcSurface() {
            double surfa = 2 * Height * Length + 2 * Height * Width + 2 * Length * Width;
            Console.WriteLine($"Surface: {surfa}");
        }
    }
    
}
