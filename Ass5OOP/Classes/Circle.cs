using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass5OOP.Interfaces;

namespace Ass5OOP.Classes
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Radius: {Radius}, Area: {Area}");
        }
    }
}
