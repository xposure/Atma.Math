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
    public class IntSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new int2(1, 7);
                var v = ov.swizzle.xx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
            }
            {
                var ov = new int2(-2, 8);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new int2(-2, 1);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new int2(-1, -8);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new int2(-4, -5);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new int2(9, 2);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new int2(0, -9);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new int2(-7, 6);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(6, v.y);
            }
            {
                var ov = new int2(6, -3);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new int2(-3, 4);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new int2(-3, -6);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new int2(-8, -4);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new int2(2, 4);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new int2(1, 1);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new int2(4, -9);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(4, v.y);
            }
            {
                var ov = new int2(0, 3);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new int2(7, -5);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new int2(4, 0);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new int2(5, -8);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var ov = new int2(0, -8);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new int2(-9, 2);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new int2(6, 3);
                var v = ov.swizzle.yy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var ov = new int2(5, 7);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new int2(-9, 8);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new int2(-9, -5);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new int2(0, -5);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new int2(-6, 6);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new int2(-9, 5);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new int2(-3, -6);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var ov = new int2(-6, -3);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new int2(-3, -4);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new int2(-2, -1);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new int2(-1, -4);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new int2(9, 4);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new int2(1, 9);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new int2(-4, 0);
                var v = ov.swizzle.rg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var ov = new int2(1, -3);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new int2(-2, -9);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new int2(-6, -2);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new int2(6, -7);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new int2(-6, 9);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new int2(-3, -5);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new int2(-9, -4);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-9, v.y);
            }
            {
                var ov = new int2(4, 8);
                var v = ov.swizzle.grr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new int2(2, 5);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new int2(-6, 0);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new int2(-6, -4);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new int2(8, -9);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new int2(2, 1);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new int2(-1, -2);
                var v = ov.swizzle.gg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
            }
            {
                var ov = new int2(-4, -6);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new int2(-9, 4);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new int2(0, -7);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new int2(-2, -1);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
            }
            {
                var ov = new int2(7, -9);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new int2(6, 0);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new int2(2, 9);
                var v1 = new int2(7, -1);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7, v0.x);
                Assert.AreEqual(-1, v0.y);
            
                Assert.AreEqual(2, v2.x);
                Assert.AreEqual(9, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new int2(0, -3);
                var v1 = 8;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8, v0.x);
                Assert.AreEqual(-3, v0.y);
            
                Assert.AreEqual(0, v2);
            }
            {
                var v0 = new int2(1, -7);
                var v1 = -2;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1, v0.x);
                Assert.AreEqual(-2, v0.y);
            
                Assert.AreEqual(-7, v2);
            }
            {
                var v0 = new int2(0, -1);
                var v1 = new int2(-6, 5);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-6, v0.x);
                Assert.AreEqual(5, v0.y);
            
                Assert.AreEqual(0, v2.x);
                Assert.AreEqual(-1, v2.y);
            }
        }

    }
}
