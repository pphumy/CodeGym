class Program{   
        static void Main(string[] args)
        {
            Console.WriteLine("Please input file path");
            string path = Console.ReadLine();
            Console.WriteLine("File path: " + path);
            SumOfNumInFile example = new SumOfNumInFile();
            example.ReadTextFile(path);
        }
}