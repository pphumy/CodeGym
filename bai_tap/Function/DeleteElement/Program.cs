namespace DeleteElement
{
    class Program{
        public static int[] Delete(int k, int[] arr)
        {
            bool found = false;
            int[] newArr = new int[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k )
                {
                    found = true;
                }
                else
                {
                    newArr[j] = arr[i];
                    j++;
                    
                }
            }
            if (found)
            {
                Console.WriteLine("Done ");
                return newArr;
            }
            else
            {
                Console.WriteLine("Not Found {0} trong mang", k);
                return arr;
            }
        }

                public static void Main(String[] args)
        {
            Console.WriteLine("Enter Lenght of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
           
            for (int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine("Enter number {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        
            
            Console.Write("Enter number to delete : " );
            int k= Convert.ToInt32(Console.ReadLine());

            arr = Delete(k, arr);
            Console.WriteLine("New Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        
        
    }
}



