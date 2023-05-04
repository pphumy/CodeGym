public  class Circle{
       public  double Radius { get; set; }
       public  string Color { get; set; }
        public Circle(double radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
            
        }
        public virtual string Tostring() {
            return $"Circle with radius {Radius}, color {Color}";


        }
        public double AreaOfCircle ()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }