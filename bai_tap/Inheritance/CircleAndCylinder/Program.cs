public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thong tin Circle: ");
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("Color: ");
          

            string color = Console.ReadLine();
            Circle circle = new Circle(radius, color);
            Console.WriteLine(circle.ToString());
            Console.WriteLine($"Area of the circle: {circle.AreaOfCircle()}");
            Console.Write("========================================================= ");
            Console.WriteLine("Nhap thong tin Cylinder: ");
            Console.WriteLine("Height : ");
          
            double height = double.Parse(Console.ReadLine());
            Cylinder cylinder = new Cylinder( radius,  color, height);
            Console.WriteLine($"Volume of the Cyliner: {cylinder.Cylindricalvolume()}");
            
        }
    }
