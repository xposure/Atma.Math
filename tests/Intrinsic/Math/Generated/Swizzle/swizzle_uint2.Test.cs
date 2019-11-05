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
    public class UintSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new uint2(1u, 3u);
                var v = ov.swizzle.xx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var ov = new uint2(8u, 1u);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uint2(7u, 5u);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uint2(4u, 8u);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uint2(0u, 9u);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var ov = new uint2(2u, 8u);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uint2(6u, 8u);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uint2(0u, 8u);
                var v = ov.swizzle.xy;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(8u, v.y);
            }
            {
                var ov = new uint2(2u, 9u);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var ov = new uint2(3u, 6u);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uint2(3u, 4u);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uint2(5u, 7u);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uint2(8u, 2u);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uint2(2u, 4u);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uint2(8u, 8u);
                var v = ov.swizzle.yx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
            }
            {
                var ov = new uint2(2u, 7u);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var ov = new uint2(9u, 7u);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uint2(8u, 4u);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uint2(6u, 6u);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uint2(1u, 4u);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uint2(2u, 2u);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uint2(4u, 5u);
                var v = ov.swizzle.yy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
            }
            {
                var ov = new uint2(6u, 9u);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uint2(9u, 3u);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uint2(6u, 3u);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uint2(3u, 8u);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uint2(6u, 5u);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uint2(3u, 6u);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new uint2(5u, 8u);
                var v = ov.swizzle.rr;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
            }
            {
                var ov = new uint2(6u, 9u);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uint2(7u, 8u);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uint2(4u, 2u);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uint2(2u, 9u);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var ov = new uint2(2u, 7u);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uint2(6u, 2u);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uint2(2u, 1u);
                var v = ov.swizzle.rg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var ov = new uint2(4u, 9u);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uint2(3u, 9u);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uint2(1u, 6u);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uint2(1u, 5u);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
            }
            {
                var ov = new uint2(1u, 0u);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uint2(6u, 7u);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uint2(1u, 0u);
                var v = ov.swizzle.gr;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var ov = new uint2(9u, 5u);
                var v = ov.swizzle.grr;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var ov = new uint2(1u, 1u);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uint2(2u, 4u);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uint2(1u, 8u);
                var v = ov.swizzle.grg;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uint2(7u, 4u);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uint2(1u, 3u);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uint2(2u, 1u);
                var v = ov.swizzle.gg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var ov = new uint2(2u, 5u);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var ov = new uint2(0u, 5u);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uint2(6u, 2u);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uint2(7u, 0u);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var ov = new uint2(0u, 8u);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uint2(9u, 9u);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new uint2(6u, 6u);
                var v1 = new uint2(6u, 5u);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6u, v0.x);
                Assert.AreEqual(5u, v0.y);
            
                Assert.AreEqual(6u, v2.x);
                Assert.AreEqual(6u, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new uint2(1u, 0u);
                var v1 = 9u;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9u, v0.x);
                Assert.AreEqual(0u, v0.y);
            
                Assert.AreEqual(1u, v2);
            }
            {
                var v0 = new uint2(5u, 4u);
                var v1 = 9u;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(5u, v0.x);
                Assert.AreEqual(9u, v0.y);
            
                Assert.AreEqual(4u, v2);
            }
            {
                var v0 = new uint2(0u, 2u);
                var v1 = new uint2(9u, 3u);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9u, v0.x);
                Assert.AreEqual(3u, v0.y);
            
                Assert.AreEqual(0u, v2.x);
                Assert.AreEqual(2u, v2.y);
            }
        }

    }
}
