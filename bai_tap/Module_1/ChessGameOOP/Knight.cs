using ChessGameOOP;
class Knight : Chess {
        public Knight(bool isWhite, int order)
        {
            if (isWhite == true)
            {
                this.Name = "K";
            }
            else
            {
                this.Name = "Black Knight";
            }
            this.isWhite = isWhite;
            this.order = order;
        }
    }