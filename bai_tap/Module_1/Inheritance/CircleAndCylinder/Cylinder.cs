public class Cylinder : Circle
    {
       public double height { get; set; }
       

        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }

      

        public double Cylindricalvolume()
        {

            return AreaOfCircle() * height;
        }

        public override string Tostring()
        {
            return $"Cylinder with radius {Radius}, height {height}, and color {Color}";

        }
    }