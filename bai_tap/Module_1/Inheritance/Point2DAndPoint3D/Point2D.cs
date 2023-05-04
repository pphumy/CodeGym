public class Point2D{
    public float x = 0.0f;
    public float y = 0.0f;

    public Point2D(float X , float Y)
        {
            x = X;
            y = Y;
        }
    public float GetX(){
        return x;
    }
    public void SetX(float X){
        x=X;
    }
    public float GetY(){
        return y;
    }
    public void SetY(float Y){
        y=Y;
    }
    public void SetXY(float X, float Y){
        x=X;
        y=Y;
    }
    public float[] GetXY(){
        return new float[] {x ,y};
    }
     public override string ToString()
        {
            return string.Format("Position of x and y: ({0}, {1})", x, y);
        }
}