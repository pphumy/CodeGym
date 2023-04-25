public class Program
    {
        static void Main(string[] args)
        {
            Point2D pointxy = new Point2D(1.0f, 2.0f);
            Console.WriteLine(pointxy.ToString());
            Point3D pointxyz = new Point3D(3.0f, 4.0f, 5.0f);
            Console.WriteLine(pointxyz.ToString());
        }
    }
