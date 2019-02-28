using System;

namespace FirstTask
{
    public class Vector2D : Point2D
    {
        public int Length {get; private set;}
        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
            Length = 2;
        }
        public Vector2D Add(Vector2D vectorB)
        {
            return new Vector2D(X + vectorB.X, Y + vectorB.Y);
        }
        public int DotProduct(Vector2D vectorB)
        {
            return (X*vectorB.X)+(Y*vectorB.Y);
        }

        public override string ToString()
        {
            return $"[{X},{Y}]";
        }
    }
}
