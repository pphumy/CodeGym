public class Point3D : Point2D
    {
        private float z=0.0f;

        public Point3D(float X , float Y , float Z ) : base(X, Y)
        {
            z = Z;
        }

        public float GetZ()
        {
            return z;
        }

        public void SetZ(float Z)
        {
            z=Z;
        }

        public void SetXYZ(float X, float Y, float Z)
        {
            SetXY(X, Y);
            z = Z;
        }

        public float[] GetXYZ()
        {
            return new float[] { GetX(), GetY(), z };
        }

        public override string ToString()
        {
            return string.Format("Postion of X Y Z la: ({0}, {1}, {2})", GetX(), GetY(), z);
        }
    }