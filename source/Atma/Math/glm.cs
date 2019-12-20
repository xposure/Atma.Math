using System.Runtime.InteropServices;

namespace Atma.Math
{
    public static partial class glm
    {
        public const float PI = 3.1415926535897931f;

        [StructLayout(LayoutKind.Explicit, Size = sizeof(float))]
        struct FloatIntUnion
        {
            [FieldOffset(0)]
            public float f;
            [FieldOffset(0)]
            public uint i;

        }

        public unsafe static float FastAbs(float x)
        {
            var u = stackalloc FloatIntUnion[1];
            u->f = x;
            u->i = (u->i & 0x7fffffff);
            return u->f;

        }
    }
}