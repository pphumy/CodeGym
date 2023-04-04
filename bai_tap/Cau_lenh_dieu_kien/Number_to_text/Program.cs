using System;
namespace Number_to_text{
    class Program{
        static void Main(string[] args){
            Console.Write("number:" );
            var input = Console.ReadLine();
            int num = Convert.ToInt16(input);
            if (0< num && num <10) {
                switch(num){
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("night");
                        break;                       
                } 
            }else if(10<= num && num <20){
                num = num%10;
                switch(num){
                    case 0:
                        Console.WriteLine("ten");
                        break;
                    case 1:
                        Console.WriteLine("eleven");
                        break;
                    case 2:
                        Console.WriteLine("twelve");
                        break;
                    case 3:
                        Console.WriteLine("thirteen");
                        break;
                    case 4:
                        Console.WriteLine("fourteen");
                        break;
                    case 5:
                        Console.WriteLine("fifteen");
                        break;
                    case 6:
                        Console.WriteLine("sixteen");
                        break;
                    case 7:
                        Console.WriteLine("seventeen");
                        break;
                    case 8:
                        Console.WriteLine("eighteen");
                        break;
                    case 9:
                        Console.WriteLine("nighteen");
                        break;                       
                } 
            }else if(20 <=num && num<100){
                int tenDigit = (int)( Math.Floor((double)num / 10.0));
                switch(tenDigit){
                    case 2:
                        Console.Write("twenty");
                        break;
                    case 3:
                        Console.Write("thirdty");
                        break;
                    case 4:
                        Console.Write("fourty");
                        break;
                    case 5:
                        Console.Write("fifty");
                        break;
                    case 6:
                        Console.Write("sixty");
                        break;
                    case 7:
                        Console.Write("seventy");
                        break;
                    case 8:
                        Console.Write("eighty");
                        break;
                    case 9:
                        Console.Write("nighty");
                        break;
                    default:{
                        Console.WriteLine("error");
                        break;
                    }                   
                } 
                num = num%10;
                switch(num){
                    case 1:
                        Console.Write(" one");
                        break;
                    case 2:
                        Console.Write(" two");
                        break;
                    case 3:
                        Console.Write(" three");
                        break;
                    case 4:
                        Console.Write(" four");
                        break;
                    case 5:
                        Console.Write(" five");
                        break;
                    case 6:
                        Console.Write(" six");
                        break;
                    case 7:
                        Console.Write(" seven");
                        break;
                    case 8:
                        Console.Write(" eight");
                        break;
                    case 9:
                        Console.Write(" night");
                        break;                       
                }
            }else{
                int hundredDigit = (int)( Math.Floor((double)num / 100.0));
                switch(hundredDigit){
                    case 1:
                        Console.Write("one hundred");
                        break;
                    case 2:
                        Console.Write("two hundred");
                        break;
                    case 3:
                        Console.Write("three hundred");
                        break;
                    case 4:
                        Console.Write("four hundred");
                        break;
                    case 5:
                        Console.Write("five hundred");
                        break;
                    case 6:
                        Console.Write("six hundred");
                        break;
                    case 7:
                        Console.Write("seven hundred");
                        break;
                    case 8:
                        Console.Write("eigh hundred");
                        break;
                    case 9:
                        Console.Write("night hundred");
                        break;
                    default:{
                        Console.WriteLine("error");
                        break;
                    }                   
                }
                int tenDigit= num%100;
                if(tenDigit>=20){
                    int temp = (int)( Math.Floor((double)tenDigit / 10.0));
                    switch(temp){
                        case 2:
                            Console.Write(" twenty");
                            break;
                        case 3:
                            Console.Write(" thirdty");
                            break;
                        case 4:
                            Console.Write(" fourty");
                            break;
                        case 5:
                            Console.Write(" fifty");
                            break;
                        case 6:
                            Console.Write(" sixty");
                            break;
                        case 7:
                            Console.Write(" seventy");
                            break;
                        case 8:
                            Console.Write(" eighty");
                            break;
                        case 9:
                            Console.Write(" nighty");
                            break;
                        default:{
                            Console.WriteLine(" error");
                            break;
                        }                   
                } 
                }
                if(10<= tenDigit && tenDigit <20){
                    num = num%10;
                switch(num){
                    case 0:
                        Console.WriteLine("ten");
                        break;
                    case 1:
                        Console.WriteLine("eleven");
                        break;
                    case 2:
                        Console.WriteLine("twelve");
                        break;
                    case 3:
                        Console.WriteLine("thirteen");
                        break;
                    case 4:
                        Console.WriteLine("fourteen");
                        break;
                    case 5:
                        Console.WriteLine("fifteen");
                        break;
                    case 6:
                        Console.WriteLine("sixteen");
                        break;
                    case 7:
                        Console.WriteLine("seventeen");
                        break;
                    case 8:
                        Console.WriteLine("eighteen");
                        break;
                    case 9:
                        Console.WriteLine("nighteen");
                        break;                       
                } 
                }else{
                    num = num%10;
                switch(num){
                    case 1:
                        Console.Write(" one");
                        break;
                    case 2:
                        Console.Write(" two");
                        break;
                    case 3:
                        Console.Write(" three");
                        break;
                    case 4:
                        Console.Write(" four");
                        break;
                    case 5:
                        Console.Write(" five");
                        break;
                    case 6:
                        Console.Write(" six");
                        break;
                    case 7:
                        Console.Write(" seven");
                        break;
                    case 8:
                        Console.Write(" eight");
                        break;
                    case 9:
                        Console.Write(" night");
                        break;                       
                }
                }
                 
            }
            
        }
    }
}
