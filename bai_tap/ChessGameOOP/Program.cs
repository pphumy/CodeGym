using System;
namespace ChessGameOOP
{
   public class Chess {
       public int X, Y;
        public string Name;
        public bool isWhite;
        public int order;
    };

    class program { 
        public static void Main( string [] args)
        {
           
            Chess[] chessPieces = new Chess[32];
            chessPieces[0] = new Rook(true,1);
            chessPieces[1] = new Knight(true,2);
            chessPieces[2] = new Bishop(true,3);
            chessPieces[3] = new Queen(true,4);
            chessPieces[4] = new King(true,5);
            chessPieces[5] = new Bishop(true,6);
            chessPieces[6] = new Knight(true,7);
            chessPieces[7] = new Rook(true,8);
            for (int i = 8; i < 16; i++)
            {
                chessPieces[i] = new Pawn(true,i-7);
            }
            
            chessPieces[24] = new Rook(false,24);
            chessPieces[25] = new Knight(false, 25);
            chessPieces[26] = new Bishop(false, 26);
            chessPieces[27] = new Queen(false, 27);
            chessPieces[28] = new King(false, 28);
            chessPieces[29] = new Bishop(false, 29);
            chessPieces[30] = new Knight(false, 30);
            chessPieces[31] = new Rook(false, 31);
            for (int i = 16; i < 24; i++)
            {
                chessPieces[i] = new Pawn(false,i-15);
            }
            Game.SetPosition(chessPieces);
            Chess[,] chessBoard = new Chess[8, 8];


            for (int i = 0; i < chessPieces.Length; i++)
            {
                int x = chessPieces[i].X;
                int y = chessPieces[i].Y;
                chessBoard[x, y] = chessPieces[i];
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chessBoard[i, j] == null)
                    {
                        Console.Write("[] ");
                    }
                    else
                    {
                        Console.Write(chessBoard[i, j].Name[0] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }


    }

