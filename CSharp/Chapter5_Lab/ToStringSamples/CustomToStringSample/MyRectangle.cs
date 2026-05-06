using System;
using System.Collections.Generic;
using System.Text;

namespace CustomToStringSample
{
    internal class MyRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override string ToString()
        {
            return $"Width={Width}, Height={Height}";
        }
    }
}
