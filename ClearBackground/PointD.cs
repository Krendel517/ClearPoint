namespace ClearBackground
{
    public struct PointD
    {
        public static readonly PointD Empty;

        private double x;

        private double y;

        public bool IsEmpty
        {
            get
            {
                if (x == 0f)
                {
                    return y == 0f;
                }

                return false;
            }
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public PointD(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
