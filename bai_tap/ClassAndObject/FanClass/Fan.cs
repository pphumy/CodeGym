    public enum FanSpeed
    {
        SLOW ,// means 1
        MEDIUM ,// 2
        FAST //3
    }
public class Fan
    {
    
        private int speed = 1;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private bool isOn = false; // Changed the variable name to isOn for clarity
        public bool IsOn // Changed the property name to IsOn for clarity
        {
            get { return isOn; }
            set { isOn = value; }
        }

        private double radius = 5;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        private string color = "blue";
        public string Color // Changed the return type to string, and the property name to Color for clarity
        {
            get { return color; }
            set { color = value; }
        }

        public Fan()// default constructor
    {
        speed = 1;
        isOn = false;
        radius = 5;
        color = "blue";
    }
    public Fan(int speed, bool isOn, double radius, string color)
        {
            this.speed = speed;
            this.isOn = isOn;
            this.radius = radius;
            this.color = color;
        }
    public override string ToString() // Changed the return type to string
        {
           if (isOn)
            {
                return $"Fan is on, speed: {speed} color: {color}, radius: {radius}";
            }
            else
            {
                return $"Fan is off, speed: {speed} color: {color}, radius: {radius}";
            }
        }
    }
