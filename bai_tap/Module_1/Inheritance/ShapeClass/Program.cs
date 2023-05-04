
class Program{
static void Main(string[] args)

        {

            Shape shape = new Shape();

            Console.WriteLine(shape);

            shape = new Shape("red", false);

            Console.WriteLine(shape);

            Console.WriteLine("Hello World!");
            Circle circle = new Circle();

                Console.WriteLine(circle);

                circle = new Circle(3.5);

                Console.WriteLine(circle);

                circle = new Circle(3.5, "indigo", false);

                Console.WriteLine(circle);
            Rectangle rectangle = new Rectangle();

            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.3, 5.8);

            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.5, 3.8, "orange", true);

            Console.WriteLine(rectangle);
             Square square = new Square();

                Console.WriteLine(square);

                square = new Square(2.3);
                square.HowToColor();
                

                Console.WriteLine(square);

                square = new Square(5.8, "yellow", true);

                Console.WriteLine(square);


                ComperableCircle[] circles = new ComperableCircle[3];
            circles[0] = new ComperableCircle(3.6);
            circles[1] = new ComperableCircle();
            circles[2] = new ComperableCircle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle c in circles)
            {
                Console.WriteLine(c);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle c in circles)
            {
                Console.WriteLine(c);
            }
        }
}