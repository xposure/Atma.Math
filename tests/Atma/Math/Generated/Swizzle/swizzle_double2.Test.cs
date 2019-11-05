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
using Atma.Math.Swizzle;

// ReSharper disable InconsistentNaming

namespace  Atma.Math.Swizzle.Generated.Swizzle
{
    [TestFixture]
    public class DoubleSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new double2(-2.5d, -2d);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
            }
            {
                var ov = new double2(-3.5d, -4d);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new double2(7.5d, 1.5d);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new double2(5d, -0.5d);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(5d, v.y);
                Assert.AreEqual(5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new double2(-6.5d, -2.5d);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var ov = new double2(8d, 4d);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(4d, v.z);
                Assert.AreEqual(8d, v.w);
            }
            {
                var ov = new double2(0.0, -6d);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-6d, v.z);
                Assert.AreEqual(-6d, v.w);
            }
            {
                var ov = new double2(-9d, 5d);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-9d, v.x);
                Assert.AreEqual(5d, v.y);
            }
            {
                var ov = new double2(-2d, 0.5d);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-2d, v.z);
            }
            {
                var ov = new double2(-5d, 8.5d);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(-5d, v.w);
            }
            {
                var ov = new double2(8.5d, 8d);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8d, v.w);
            }
            {
                var ov = new double2(-1.5d, 8d);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8d, v.z);
            }
            {
                var ov = new double2(-6d, -1d);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1d, v.z);
                Assert.AreEqual(-6d, v.w);
            }
            {
                var ov = new double2(9d, 7d);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(7d, v.w);
            }
            {
                var ov = new double2(6d, -2d);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(6d, v.y);
            }
            {
                var ov = new double2(-8d, 4.5d);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(-8d, v.z);
            }
            {
                var ov = new double2(8d, 9d);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8d, v.z);
                Assert.AreEqual(8d, v.w);
            }
            {
                var ov = new double2(7.5d, 4d);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(4d, v.w);
            }
            {
                var ov = new double2(6d, -8d);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-8d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(-8d, v.z);
            }
            {
                var ov = new double2(-4d, -5d);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(-4d, v.w);
            }
            {
                var ov = new double2(-4.5d, 9d);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(9d, v.z);
                Assert.AreEqual(9d, v.w);
            }
            {
                var ov = new double2(8.5d, -4d);
                var v = ov.swizzle.yy;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(-4d, v.y);
            }
            {
                var ov = new double2(-3.5d, 3d);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new double2(7d, 1.5d);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(7d, v.w);
            }
            {
                var ov = new double2(-3d, -7d);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(-7d, v.y);
                Assert.AreEqual(-3d, v.z);
                Assert.AreEqual(-7d, v.w);
            }
            {
                var ov = new double2(9.5d, 8d);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8d, v.z);
            }
            {
                var ov = new double2(-7d, -8.5d);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(-7d, v.w);
            }
            {
                var ov = new double2(8.5d, -9d);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-9d, v.x);
                Assert.AreEqual(-9d, v.y);
                Assert.AreEqual(-9d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new double2(4d, 8.5d);
                var v = ov.swizzle.rr;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
            }
            {
                var ov = new double2(4d, 7.5d);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(4d, v.z);
            }
            {
                var ov = new double2(6d, -9.5d);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(6d, v.w);
            }
            {
                var ov = new double2(-2d, 5d);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(5d, v.w);
            }
            {
                var ov = new double2(4d, -2.5d);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var ov = new double2(-6d, -2d);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-6d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(-6d, v.w);
            }
            {
                var ov = new double2(4.5d, -3.5d);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new double2(1.0, 4d);
                var v = ov.swizzle.rg;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(4d, v.y);
            }
            {
                var ov = new double2(7d, -6.5d);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(7d, v.z);
            }
            {
                var ov = new double2(3d, 3.5d);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(3d, v.w);
            }
            {
                var ov = new double2(0.5d, -2.5d);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new double2(7.5d, 4d);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(4d, v.z);
            }
            {
                var ov = new double2(7.5d, 5d);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(5d, v.y);
                Assert.AreEqual(5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new double2(9d, -2d);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var ov = new double2(1.0, 4.5d);
                var v = ov.swizzle.gr;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(1.0, v.y);
            }
            {
                var ov = new double2(-1d, 9.5d);
                var v = ov.swizzle.grr;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1d, v.z);
            }
            {
                var ov = new double2(-1d, -2.5d);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1d, v.z);
                Assert.AreEqual(-1d, v.w);
            }
            {
                var ov = new double2(3d, 2.5d);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new double2(0.0, -8.5d);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-8.5d, v.z);
            }
            {
                var ov = new double2(-5d, 7.5d);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(-5d, v.w);
            }
            {
                var ov = new double2(5.5d, -9d);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-9d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-9d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new double2(5.5d, 6d);
                var v = ov.swizzle.gg;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(6d, v.y);
            }
            {
                var ov = new double2(9d, -4d);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(9d, v.z);
            }
            {
                var ov = new double2(-0.5d, 8d);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new double2(-7.5d, -9d);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-9d, v.x);
                Assert.AreEqual(-9d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new double2(-1.5d, 0.5d);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
            }
            {
                var ov = new double2(0.0, -2.5d);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new double2(-1.5d, -8d);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-8d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(-8d, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new double2(7.5d, 8d);
                var v1 = new double2(-5d, 0.5d);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5d, v0.x);
                Assert.AreEqual(0.5d, v0.y);
            
                Assert.AreEqual(7.5d, v2.x);
                Assert.AreEqual(8d, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new double2(1.0, -0.5d);
                var v1 = 9.5d;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9.5d, v0.x);
                Assert.AreEqual(-0.5d, v0.y);
            
                Assert.AreEqual(1.0, v2);
            }
            {
                var v0 = new double2(-6.5d, 2.5d);
                var v1 = -9.5d;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-6.5d, v0.x);
                Assert.AreEqual(-9.5d, v0.y);
            
                Assert.AreEqual(2.5d, v2);
            }
            {
                var v0 = new double2(2d, 4.5d);
                var v1 = new double2(6.5d, -8d);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6.5d, v0.x);
                Assert.AreEqual(-8d, v0.y);
            
                Assert.AreEqual(2d, v2.x);
                Assert.AreEqual(4.5d, v2.y);
            }
        }

    }
}
