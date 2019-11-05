using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using Intrinsic.Math.Swizzle;

// ReSharper disable InconsistentNaming

namespace  Intrinsic.Math.Swizzle.Generated.Swizzle
{
    [TestFixture]
    public class FloatSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new float2(-5.5f, 2f);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
            }
            {
                var ov = new float2(0f, 6f);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new float2(4.5f, 8f);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new float2(5.5f, -3f);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new float2(-2f, 0f);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new float2(-4f, -4f);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new float2(7.5f, 6.5f);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new float2(2f, 5.5f);
                var v = ov.swizzle.xy;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(5.5f, v.y);
            }
            {
                var ov = new float2(6f, 7.5f);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(6f, v.z);
            }
            {
                var ov = new float2(-7.5f, -2.5f);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new float2(5f, 6.5f);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new float2(7f, 8.5f);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
            }
            {
                var ov = new float2(5.5f, 1.5f);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new float2(-1.5f, 1f);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new float2(-3.5f, -5f);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
            }
            {
                var ov = new float2(5.5f, -3f);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var ov = new float2(9f, -8.5f);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new float2(5.5f, 4.5f);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new float2(2.5f, 7f);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(7f, v.z);
            }
            {
                var ov = new float2(-4f, -4f);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new float2(8f, 3f);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new float2(-8.5f, 9.5f);
                var v = ov.swizzle.yy;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
            }
            {
                var ov = new float2(0f, -9f);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new float2(-5.5f, -9.5f);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new float2(-4f, -9.5f);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new float2(2f, -6.5f);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
            }
            {
                var ov = new float2(0.5f, -5f);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new float2(8f, -2.5f);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new float2(1f, -3.5f);
                var v = ov.swizzle.rr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
            }
            {
                var ov = new float2(2.5f, 7.5f);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
            }
            {
                var ov = new float2(3.5f, -6.5f);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new float2(3.5f, -2.5f);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new float2(-8f, 3f);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(3f, v.z);
            }
            {
                var ov = new float2(-4f, 8f);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new float2(4.5f, -6f);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new float2(8f, 6f);
                var v = ov.swizzle.rg;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(6f, v.y);
            }
            {
                var ov = new float2(-8f, 7.5f);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-8f, v.z);
            }
            {
                var ov = new float2(-5.5f, 8.5f);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new float2(8.5f, 3f);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new float2(1.5f, 0.5f);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
            }
            {
                var ov = new float2(6f, -7.5f);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new float2(4f, -5f);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new float2(6.5f, -4.5f);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
            }
            {
                var ov = new float2(-3.5f, 4f);
                var v = ov.swizzle.grr;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
            }
            {
                var ov = new float2(-9.5f, 8.5f);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new float2(-3f, 5.5f);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new float2(9f, -6f);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new float2(8.5f, -4f);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new float2(3f, 7f);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new float2(-1f, -7.5f);
                var v = ov.swizzle.gg;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
            }
            {
                var ov = new float2(-5.5f, 1f);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-5.5f, v.z);
            }
            {
                var ov = new float2(-4.5f, -0.5f);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new float2(-2f, -6f);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new float2(-9f, 1.5f);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
            }
            {
                var ov = new float2(6f, 0.5f);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new float2(3.5f, 8.5f);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new float2(5f, 5.5f);
                var v1 = new float2(-8f, -8.5f);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8f, v0.x);
                Assert.AreEqual(-8.5f, v0.y);
            
                Assert.AreEqual(5f, v2.x);
                Assert.AreEqual(5.5f, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new float2(-3.5f, 2.5f);
                var v1 = 6f;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6f, v0.x);
                Assert.AreEqual(2.5f, v0.y);
            
                Assert.AreEqual(-3.5f, v2);
            }
            {
                var v0 = new float2(-8.5f, -6.5f);
                var v1 = -2.5f;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8.5f, v0.x);
                Assert.AreEqual(-2.5f, v0.y);
            
                Assert.AreEqual(-6.5f, v2);
            }
            {
                var v0 = new float2(-8f, -2.5f);
                var v1 = new float2(7f, -9f);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7f, v0.x);
                Assert.AreEqual(-9f, v0.y);
            
                Assert.AreEqual(-8f, v2.x);
                Assert.AreEqual(-2.5f, v2.y);
            }
        }

    }
}
