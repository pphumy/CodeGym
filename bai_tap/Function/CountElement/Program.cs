namespace CountElement
{
    class Program{
        public static int Count(string str,char key)
        {
        int count = 0;
        foreach (char currentChar in str)
        {
            if(currentChar == key){
                count++;
            }
        }
        return count;
    }
        public static void Main(String[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Enter a char to check: ");
            char k = Console.ReadLine()[0];
            if(Count(str, k)==0){
                Console.WriteLine("Character not appeat in the string");  
            }else{
                Console.WriteLine($"{k} appear {Count(str,k)} times");  
            }
        }

        
    }
    }





