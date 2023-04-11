namespace SnakeGame
{
    class Program
    {
        static void Write(int row, int col, string content)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(content);
        }

        static void DrawBorder(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Write(i, j, "═");;
                    }
                }
                else
                {
                    Write(i, 0, "║");
                    Write(i, width, "║");
                }
            }
        }
        
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; // đặt màu cho rắn
            Console.BackgroundColor = ConsoleColor.Black; // đặt màu cho mồi
            Console.Clear();
            int width = 40;
            int height = 20;
            DrawBorder(width, height);
            

            bool isOver = false;
            int x = 2;
            int y = 2;
            int[] X= new int[15];
            int[] Y= new int[15];
            X[0] =2;
            Y[0] =2;
            int PointX = 10;
            int PointY = 10;
            int SnakeBody=3;
            int score = 0;
            
            while (!isOver)
            {
                
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.CursorVisible = false;
                Write(y,x," ");
                
                Write(PointY,PointX,"@");
                if(Y[0] == PointY && X[0] == PointX){
                    score++;
                    SnakeBody++;
                    // Write(PointY, PointX, " ");
                    Random rnd = new Random();
                    PointX = rnd.Next(2,18);
                    PointY = rnd.Next(2,18);
                }
                for(int i = SnakeBody;i>1;i--){
                    X[i-1] = X[i-2];
                    Y[i-1] =Y[i-2];
                    Console.Clear();
                    Write(PointY,PointX,"@");
                }
                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        Y[0]++;               
                        break;
                    case ConsoleKey.UpArrow:
                        Y[0]--;
                        break;
                    case ConsoleKey.LeftArrow:
                        X[0]--;
                        break;
                    case ConsoleKey.RightArrow:
                        X[0]++;
                        break;
                    case ConsoleKey.Escape:
                        isOver = true;
                        break;
                }
                
                for(int i=0; i<= SnakeBody-1; i++){
                    Write(Y[i], X[i], "#");
                }
                
                for (int i = 1; i < SnakeBody; i++)
                {
                    if (X[0] == X[i] && Y[0] == Y[i])
                    {
                        isOver = true;
                    }
                }
                if( 39<X[0] ||X[0] <1 || 18 < Y[0] || Y[0]< 1){
                    isOver = true;
                }

                Write(23, 23,"score: " +score.ToString());
                
                
                DrawBorder(width, height);
                
            }

            Console.WriteLine("Ket thuc tro choi!");
        }
    }
    
}
