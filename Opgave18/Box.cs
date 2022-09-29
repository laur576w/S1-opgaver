using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave18 {
    internal class Box  {
        public int Length { get; }
        public int Width { get; }
        public int Height { get; }
        
        public Box(int width, int height, int length) {
            Console.WriteLine("width = " + width);
            Console.WriteLine("height = " + height);
            Console.WriteLine("length = " + length);
        }
    }
}
