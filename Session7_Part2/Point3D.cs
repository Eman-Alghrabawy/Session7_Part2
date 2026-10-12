using System;
using System.Collections.Generic;
using System.Text;

namespace Session7_Part2
{
    internal class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // Parameterless Constructor
        public Point3D() : this(0, 0, 0)
        {
        }

        // Constructor with two parameters
        public Point3D(int x, int y) : this(x, y, 0)
        {
        }

        // Constructor with three parameters
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
    }
}
