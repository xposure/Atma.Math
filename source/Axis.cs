using System;
using System.Collections.Generic;
using System.Text;

namespace Atma.Math
{
    public struct Axis
    {
        public float2 normal;
        public float2 unit;
        public float2 edge;

        public readonly static Axis Zero = new Axis(float2.Zero, float2.Zero, float2.Zero);

        public Axis(float2 n, float2 u, float2 e)
        {
            this.normal = n;
            this.unit = u;
            this.edge = e;
        }

        public override string ToString()
        {
            return string.Format("N:{0}, U:{1}, E:{2}", normal, unit, edge);
        }
    }
}