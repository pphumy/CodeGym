using ChessGameOOP;

class King : Chess {
        public King(bool isWhite, int order)
        {
            
            this.isWhite = isWhite;
            this.order = order;
            if (isWhite == true)
            {
                this.Name = "K";
            }
            else
            {
                this.Name = "Black King";
            }
        }
    
    }