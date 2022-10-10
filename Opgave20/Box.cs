using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Opgave20 {
    internal class Box  {
        public int Length { get; }
        public int Width { get; }
        public int Height { get; }
        
        public Box(int height, int length, int width) {
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
            Console.WriteLine(); 
        }
        public int CalcVolume() {
            int volu = Height * Width * Length;
            return volu;
        }

        public void CalcSurface() {
            double surfa = 2 * Height * Length + 2 * Height * Width + 2 * Length * Width;
            Console.WriteLine($"Surface: {surfa}");
        }
    }
    
}
