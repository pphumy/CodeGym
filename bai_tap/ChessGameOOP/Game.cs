using ChessGameOOP;
class Game : Chess
    {
        public static void SetPosition(Chess[] chessPieces)
{
            int whiteRow = 0;
            int blackRow = 7;

            // Set position for white pieces
            for (int i = 0; i < 16; i++)
            {
                if (chessPieces[i] is Pawn)
                {
                    chessPieces[i].X = i % 8;
                    chessPieces[i].Y = whiteRow + 1;
                }
                else
                {
                    chessPieces[i].X = i % 8;
                    chessPieces[i].Y = whiteRow;
                }
            }

            // Set position for black pieces
            for (int i = 16; i < 32; i++)
            {
                if (chessPieces[i] is Pawn)
                {
                    chessPieces[i].X = i % 8;
                    chessPieces[i].Y = blackRow - 1;
                }
                else
                {
                    chessPieces[i].X = i % 8;
                    chessPieces[i].Y = blackRow;
                }
            }
        

    }

    }