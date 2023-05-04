using ChessGameOOP;
class Queen : Chess {
        public Queen(bool isWhite, int order)
        {
            if (isWhite == true)
            {
                this.Name = "Q";
            }
            else
            {
                this.Name = "Black Queen";
            }
            this.isWhite = isWhite;
            this.order = order;
        }
    }