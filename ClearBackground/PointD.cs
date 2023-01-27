using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClearBackground
{
    [Serializable]
    [ComVisible(true)]
    public struct PointD
    {
        public static readonly PointD Empty;

        private double x;

        private double y;

        [Browsable(false)]
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

        public static PointD operator +(PointD pt, Size sz)
        {
            return Add(pt, sz);
        }

        public static PointD operator -(PointD pt, Size sz)
        {
            return Subtract(pt, sz);
        }

        public static PointD operator +(PointD pt, System.Drawing.SizeF sz)
        {
            return Add(pt, sz);
        }

        public static PointD operator -(PointD pt, System.Drawing.SizeF sz)
        {
            return Subtract(pt, sz);
        }

        public static bool operator ==(PointD left, PointD right)
        {
            if (left.X == right.X)
            {
                return left.Y == right.Y;
            }

            return false;
        }

        public static bool operator !=(PointD left, PointD right)
        {
            return !(left == right);
        }

        public static PointD Add(PointD pt, Size sz)
        {
            return new PointD(pt.X + (double)sz.Width, pt.Y + (double)sz.Height);
        }

        public static PointD Subtract(PointD pt, Size sz)
        {
            return new PointD(pt.X - (double)sz.Width, pt.Y - (double)sz.Height);
        }

        public static PointD Add(PointD pt, System.Drawing.SizeF sz)
        {
            return new PointD(pt.X + sz.Width, pt.Y + sz.Height);
        }

        public static PointD Subtract(PointD pt, System.Drawing.SizeF sz)
        {
            return new PointD(pt.X - sz.Width, pt.Y - sz.Height);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PointD))
            {
                return false;
            }

            PointD pointD = (PointD)obj;
            if (pointD.X == X && pointD.Y == Y)
            {
                return pointD.GetType().Equals(GetType());
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{X={0}, Y={1}}}", new object[2] { x, y });
        }
    }

    [Serializable]
    [ComVisible(true)]
    [TypeConverter(typeof(SizeFConverter))]
    public struct SizeD
    {
        public static readonly SizeD Empty;

        private double width;

        private double height;

        [Browsable(false)]
        public bool IsEmpty
        {
            get
            {
                if (width == 0f)
                {
                    return height == 0f;
                }

                return false;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public SizeD(SizeD size)
        {
            width = size.width;
            height = size.height;
        }

        public SizeD(PointD pt)
        {
            width = pt.X;
            height = pt.Y;
        }

        public SizeD(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static SizeD operator +(SizeD sz1, SizeD sz2)
        {
            return Add(sz1, sz2);
        }

        public static SizeD operator -(SizeD sz1, SizeD sz2)
        {
            return Subtract(sz1, sz2);
        }

        public static bool operator ==(SizeD sz1, SizeD sz2)
        {
            if (sz1.Width == sz2.Width)
            {
                return sz1.Height == sz2.Height;
            }

            return false;
        }

        public static bool operator !=(SizeD sz1, SizeD sz2)
        {
            return !(sz1 == sz2);
        }

        public static explicit operator PointD(SizeD size)
        {
            return new PointD(size.Width, size.Height);
        }

        public static SizeD Add(SizeD sz1, SizeD sz2)
        {
            return new SizeD(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
        }

        public static SizeD Subtract(SizeD sz1, SizeD sz2)
        {
            return new SizeD(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is SizeD))
            {
                return false;
            }

            SizeD sizeD = (SizeD)obj;
            if (sizeD.Width == Width && sizeD.Height == Height)
            {
                return sizeD.GetType().Equals(GetType());
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public PointD ToPointD()
        {
            return (PointD)this;
        }

        public override string ToString()
        {
            return "{Width=" + width.ToString(CultureInfo.CurrentCulture) + ", Height=" + height.ToString(CultureInfo.CurrentCulture) + "}";
        }
    }
}
