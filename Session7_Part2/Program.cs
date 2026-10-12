namespace Session7_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Firstproject
            //Point3D P = new Point3D(10, 10, 10);

            //Console.WriteLine(P.ToString());


            //    Console.WriteLine("Enter coordinates for P1:");
            //    Point3D P1 = ReadPoint();

            //    Console.WriteLine("Enter coordinates for P2:");
            //    Point3D P2 = ReadPoint();


            //}

            //static Point3D ReadPoint()
            //{
            //    int x = ReadCoordinate("Enter X: ");
            //    int y = ReadCoordinate("Enter Y: ");
            //    int z = ReadCoordinate("Enter Z: ");

            //    return new Point3D(x, y, z);
            //}

            //static int ReadCoordinate(string message)
            //{
            //    int value;

            //    Console.Write(message);

            //    while (!int.TryParse(Console.ReadLine(), out value))
            //    {
            //        Console.Write("Invalid input! Enter an integer: ");
            //    }

            //    return value;

            //Point3D P1 = new Point3D(10, 20, 30);
            //Point3D P2 = new Point3D(10, 20, 30);

            //if (P1 == P2)
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");
            //No, P1 == P2 does not compare coordinates by default.It compares object references. To compare the coordinates, we need to overload the == operator in the Point3D class.

            //            Point3D[] points =
            //{
            //    new Point3D(3, 2, 1),
            //    new Point3D(1, 5, 2),
            //    new Point3D(1, 2, 3),
            //    new Point3D(2, 4, 1)
            //};

            //            Array.Sort(points);

            //            foreach (Point3D p in points)
            //            {
            //                Console.WriteLine(p);
            //            }

            //Point3D P1 = new Point3D(10, 20, 30);

            //Point3D P2 = (Point3D)P1.Clone();

            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            #endregion
            #region SecProject
            //Maths math = new Maths();

            //Console.WriteLine(math.Add(10, 5));
            //Console.WriteLine(math.Subtract(10, 5));
            //Console.WriteLine(math.Multiply(10, 5));
            //Console.WriteLine(math.Divide(10, 5));

            //Console.WriteLine(Maths.Add(10, 5));
            //Console.WriteLine(Maths.Subtract(10, 5));
            //Console.WriteLine(Maths.Multiply(10, 5));
            //Console.WriteLine(Maths.Divide(10, 5));

            #endregion

            #region ThirdProject
            //Duration d1 = new Duration(1, 30, 45);
            //Duration d2 = new Duration(1, 30, 45);

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Equals(d2));
            //Console.WriteLine(d1.GetHashCode());
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            #endregion

        }
    }
}
