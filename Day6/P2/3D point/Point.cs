namespace _3D_point
{
    public class Point(int x, int y, int z) : IComparable,ICloneable
    {
        public Point(int a) : this(a,a,a){}


        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }
         
        public int Xpos { set { x = value; } get { return x; } }
        public int Ypos { set { y = value; } get { return y; } }
        public int Zpos { set { z = value; } get { return z; } }


        
        public static bool operator ==(Point a, Point b)
        {
            if (a is null && b is null) return true;
            if (a is null || b is null) return false;
            return a.Xpos == b.Xpos && a.Ypos == b.Ypos && a.Zpos == b.Zpos;
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }
        public override bool Equals(object? obj)
        {
            /*   if (obj is Point other)
               {
                   return this == other;
               }
               return false;*/

            Point p = obj as Point;
            if (p == null) return false;
            if (this.GetType() != p.GetType()) return false;
            if (object.ReferenceEquals(this,p)) return true;
            return p == this;
        }
        public static implicit operator string(Point P) {
            return P.ToString(); 
        }
        public int CompareTo(object? obj)
        {
            if ((obj is Point other) && (other != null))
            {
                if (Xpos == other.Xpos)
                    return Ypos.CompareTo(other.Ypos);

                return Xpos.CompareTo(other.Xpos);
            }
            throw new ArgumentException("Object is not point");
        }

        public object Clone()
        {
            return new Point(Xpos, Ypos, Zpos);
        }
    }
}
