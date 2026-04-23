using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator03
{
    internal class Calculator
    {
        private int _x;
        private int _y;

        public int X
        {
            get => _x; //區塊主體存取子寫法：get { return _x; }
            set => _x = value; //區塊主體存取子寫法：set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Add()
        {
            return X + Y;
        }

        public int Subtract()
        {
            return X - Y;
        }
    }
}
