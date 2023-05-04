class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan((int)FanSpeed.FAST, true, 10, "yellow"); // Changed the arguments to match the constructor parameter order
            Fan fan2 = new Fan((int)FanSpeed.MEDIUM, false, 5, "blue");

            Console.WriteLine(fan1.ToString()); // Use the ToString method to print the fan status
            Console.WriteLine(fan2.ToString());
        }
    }
