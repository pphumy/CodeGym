using ChessGameOOP;

class Rook : Chess {
        public Rook(bool isWhite, int order)
        {
           
            this.isWhite = isWhite;
            this.order = order;
            if (isWhite==true)
            {
                this.Name = "R";
            }
            else
            {
                this.Name = "Black";
            }
        }
    }