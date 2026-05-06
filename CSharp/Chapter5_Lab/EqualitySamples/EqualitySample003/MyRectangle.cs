using System;
using System.Collections.Generic;
using System.Text;

namespace EqualitySample003
{
    internal class MyRectangle : IEquatable<MyRectangle?>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MyRectangle);
        }

        public bool Equals(MyRectangle? other)
        {
            return other is not null &&
                   Width == other.Width &&
                   Height == other.Height;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Width, Height);
        }

        public static bool operator ==(MyRectangle? left, MyRectangle? right)
        {
            return EqualityComparer<MyRectangle>.Default.Equals(left, right);
        }

        public static bool operator !=(MyRectangle? left, MyRectangle? right)
        {
            return !(left == right);
        }
    }
}
