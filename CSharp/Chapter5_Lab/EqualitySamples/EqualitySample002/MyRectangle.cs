using System;
using System.Collections.Generic;
using System.Text;

namespace EqualitySample002
{
    internal class MyRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override bool Equals(object? obj)
        {
            if(obj is MyRectangle other)
            {
                return this.Width == other.Width && this.Height == other.Height;
            }
            return false;
        }
    }
}
