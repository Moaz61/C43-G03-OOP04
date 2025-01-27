using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass5OOP.Interfaces;

namespace Ass5OOP.Classes
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length * Width;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"\nRectangle Length: {Length}, Width: {Width}, Area: {Area}");
        }
    }
}
