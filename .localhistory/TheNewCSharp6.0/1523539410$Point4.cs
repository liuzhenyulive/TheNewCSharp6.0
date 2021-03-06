﻿
using static System.Math;

namespace TheNewCSharp6._0
{
    //表达式体属性
    public class Point4
    {
        public int X { get; }
        public int Y { get; }

        public Point4(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Dist => Sqrt(X * X + Y * Y);

        public override string ToString() => $"({X},{Y})";

        public JObject ToJson()
        {

        }
    }
}
