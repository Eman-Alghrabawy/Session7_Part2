namespace Session7_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point3D P = new Point3D(10, 10, 10);

            //Console.WriteLine(P.ToString());


            Console.WriteLine("Enter coordinates for P1:");
            Point3D P1 = ReadPoint();

            Console.WriteLine("Enter coordinates for P2:");
            Point3D P2 = ReadPoint();

         
        }

        static Point3D ReadPoint()
        {
            int x = ReadCoordinate("Enter X: ");
            int y = ReadCoordinate("Enter Y: ");
            int z = ReadCoordinate("Enter Z: ");

            return new Point3D(x, y, z);
        }

        static int ReadCoordinate(string message)
        {
            int value;

            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input! Enter an integer: ");
            }

            return value;


        }
    }
}
