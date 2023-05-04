using ChessGameOOP;
class Pawn : Chess {
        public Pawn(bool isWhite, int order)
        {
            if (isWhite == true)
            {
                this.Name = "P";
            }
            else
            {
                this.Name = "Black Pawn";
            }
            this.isWhite = isWhite;
            this.order = order;
        }
    }