 class Program{
    static void Main(string[] args){
        int choice =-1;
            do{
                
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the rectangle");
                Console.WriteLine("2. Draw the square triangle");
                Console.WriteLine("3. Draw the isosceles tritangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                var input = Console.ReadLine();
                choice = Int32.Parse(input);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 2:
                        
                        Console.WriteLine("1. Draw the top-left");
                        Console.WriteLine("2. Draw the top-right");
                        Console.WriteLine("3. Draw the bottom-left");
                        Console.WriteLine("4. Draw the bottom-right");
                        Console.WriteLine("0. Exit");
                        Console.WriteLine("Enter your choice: ");
                        choice = Int32.Parse(Console.ReadLine());
                        switch(choice){
                            case 1:
                                int x, y, z;
                                for (x = 5; x >= 1; x--){
                                    for (y = 1; y <= x; y++){
                                      Console.Write("*");  
                                    }
                                    Console.WriteLine();
                                
                                }
                                break;
                            case 2:
                                
                                for (x = 5; x >= 1; x--){
                                    for (y = 5; y > x; y--){
                                      Console.Write(" ");  
                                    }
                                    for (z = 1; z <=x; z++){
                                        Console.Write("*");
                                    }
                                    Console.WriteLine();
                                
                                }
                                break;
                            
                            case 3:
                                for (x = 1; x <= 6; x++){
                                    for (y = 1; y <= x; y++){
                                      Console.Write("*");  
                                    }
                                    Console.WriteLine();
                                
                                }
                                break;
                            case 4:
                                for (x = 6; x >=1; x--){
                                    for (y = 1; y <= x; y++){
                                      Console.Write(" ");  
                                    }
                                    for(z =6;z >=x;z--){
                                        Console.WriteLine("*");
                                    }
                                    Console.WriteLine();
                                
                                }
                                break;    
                        }
                            

                        break;
                        
                            
                    
                    case 3:
                        int i, j, k;
                        for (i = 5; i >= 1; i--){
                            for (j = 5; j > i; j--){
                                Console.Write(" ");
                            }
                            for (k = 1; k < (i * 2); k++){
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
                }while(choice != 0 );
        }
            }
 
