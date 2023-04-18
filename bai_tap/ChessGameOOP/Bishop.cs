using ChessGameOOP;

class Bishop : Chess {
        public Bishop(bool isWhite, int order)
        {
            if (isWhite == true)
            {
                this.Name = "B";
            }
            else
            {
                this.Name = "Black Bishop";
            }
            this.isWhite = isWhite;
            this.order = order;
        }
    }
