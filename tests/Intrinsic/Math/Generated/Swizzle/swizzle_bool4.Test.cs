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
    public class BoolSwizzleVec4Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.xxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.xxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.xxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.xxwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.xxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.xxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.xyyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.xyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.xywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.xywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.xyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.xzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.xzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.xzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.xzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.xzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.xzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.xzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.xzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.xw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.xwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.xwxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.xwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.xwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.xwxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.xwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xwyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.xwyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.xwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.xwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.xwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.xwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.xwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.xww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.xwwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.xwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.xwwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.xwww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.yx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.yxxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.yxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.yxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.yxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.yxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.yxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.yxwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.yxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.yy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.yyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.yyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.yyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.yyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.yywx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.yywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.yywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.yyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.yz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.yzxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.yzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.yzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.yzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.yzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.yzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.yzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.yzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.yw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.ywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.ywxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.ywxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.ywxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.ywxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.ywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.ywyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.ywyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.ywyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.ywyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.ywz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.ywzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.ywzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.ywzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.ywzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.yww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.ywwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.ywwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.ywwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.ywww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.zx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.zxyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.zxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.zxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.zxwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.zxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.zxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.zy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.zyxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.zyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.zyzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.zyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.zywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.zywy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.zywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.zyww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.zz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.zzyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zzzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zzwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.zzwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.zzwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.zzww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.zwxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.zwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zwxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.zwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.zwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.zwyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.zwyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zwyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.zwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.zwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.zwzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.zwzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.zwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.zwzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.zww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.zwwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.zwwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.zwwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.zwww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.wx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.wxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.wxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.wxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.wxxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.wxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.wxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.wxyw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.wxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.wxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.wxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.wxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.wxzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.wxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.wxwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wxwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.wxwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.wxww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.wy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.wyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.wyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.wyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.wyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.wyxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.wyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.wyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.wyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.wyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.wyyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.wyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.wyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.wyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.wyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.wyzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.wyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wywx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.wywy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.wywz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wyww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.wz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.wzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.wzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.wzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.wzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.wzxw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.wzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.wzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.wzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.wzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.wzyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.wzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.wzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.wzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.wzzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.wzw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wzwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.wzwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.wzwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wzww;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.ww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.wwx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.wwxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.wwxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.wwxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.wwxw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.wwy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.wwyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.wwyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wwyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.wwyw;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.wwz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.wwzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.wwzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.wwzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.wwzw;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.www;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.wwwx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.wwwy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.wwwz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.wwww;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.rr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.rrra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.rrga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.rrba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.rra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.rrar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.rrag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.rrab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.rraa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.rg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.rgra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.rgga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rgba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.rga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.rgar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.rgag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.rgab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.rgaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.rb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.rbra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rbga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.rbba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.rba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.rbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.rbag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.rbab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.rbaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.ra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.rar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.rarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.rarg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.rarb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.rara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.rag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.ragr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.ragg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.ragb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.raga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.rab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rabr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.rabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.rabb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.raba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.raa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.raar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.raag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.raab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.raaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.gr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.grr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.grra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.grg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.grga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.grb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.grba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.gra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.grar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.grag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.grab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.graa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.gg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.ggra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.ggga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.ggba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.gga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.ggar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.ggag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.ggab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.ggaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.gb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.gbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.gbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.gbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.gba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.gbar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.gbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.gbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.gbaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.ga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.gar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.garr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.garg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.garb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.gara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.gag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.gagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.gagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.gagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.gaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.gab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.gabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.gabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.gabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.gaba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.gaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.gaar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.gaag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.gaab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.gaaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.br;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.brr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.brra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.brg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.brga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.brb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.brba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.bra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.brar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.brag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.brab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.braa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.bg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.bgra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.bgga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.bgba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.bga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.bgar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.bgag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.bgab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.bgaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.bb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.bbra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.bbga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.bbba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.bba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.bbar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.bbag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.bbab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.bbaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.ba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.bar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.barr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, false);
                var v = ov.swizzle.barg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.barb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.bara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.bag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.bagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.bagg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.bagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.baga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.bab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.babr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.babg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.babb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.baba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.baa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.baar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.baag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.baab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.baaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.ar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.arr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.arrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.arrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.arrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.arra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.arg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.argr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.argg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.argb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.arga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.arb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.arbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.arbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.arbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.arba;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.ara;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.arar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.arag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.arab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.araa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.ag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.agr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.agrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.agrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.agrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.agra;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.agg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.aggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.aggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.aggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.agga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.agb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.agbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.agbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.agbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.agba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.aga;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.agar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.agag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.agab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.agaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.ab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.abr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.abrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.abrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.abrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.abra;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.abg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, false, true);
                var v = ov.swizzle.abgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.abgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.abgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, true);
                var v = ov.swizzle.abga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.abb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.abbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.abbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, true);
                var v = ov.swizzle.abbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.abba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.aba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.abar;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.abag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, true, false);
                var v = ov.swizzle.abab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.abaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.aa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.aar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, true);
                var v = ov.swizzle.aarr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, false, false);
                var v = ov.swizzle.aarg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.aarb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, true);
                var v = ov.swizzle.aara;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, false, true);
                var v = ov.swizzle.aag;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, true, false);
                var v = ov.swizzle.aagr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.aagg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.aagb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, true);
                var v = ov.swizzle.aaga;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.aab;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.aabr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.aabg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, false, true, false);
                var v = ov.swizzle.aabb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, false, false, false);
                var v = ov.swizzle.aaba;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.aaa;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool4(true, false, true, true);
                var v = ov.swizzle.aaar;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(false, true, false, false);
                var v = ov.swizzle.aaag;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.aaab;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool4(true, true, true, false);
                var v = ov.swizzle.aaaa;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new bool4(true, true, true, true);
                var v1 = new bool2(false, true);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(false, false, true, true);
                var v1 = new bool2(true, true);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(true, true, false, false);
                var v1 = new bool2(true, true);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bool4(true, false, false, true);
                var v1 = new bool3(false, false, true);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bool4(false, false, true, true);
                var v1 = new bool2(true, false);
                var v2 = v0.xw;
                v0.xw = v1;
                var v3 = v0.xw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(false, true, true, true);
                var v1 = new bool2(false, true);
                var v2 = v0.yw;
                v0.yw = v1;
                var v3 = v0.yw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(true, false, true, false);
                var v1 = new bool3(true, false, true);
                var v2 = v0.xyw;
                v0.xyw = v1;
                var v3 = v0.xyw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bool4(true, false, true, true);
                var v1 = new bool2(false, true);
                var v2 = v0.zw;
                v0.zw = v1;
                var v3 = v0.zw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(false, false, false, true);
                var v1 = new bool3(true, false, true);
                var v2 = v0.xzw;
                v0.xzw = v1;
                var v3 = v0.xzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(true, v2.z);
            }
            {
                var v0 = new bool4(true, false, false, false);
                var v1 = new bool3(true, false, false);
                var v2 = v0.yzw;
                v0.yzw = v1;
                var v3 = v0.yzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bool4(true, false, true, true);
                var v1 = new bool4(true, true, false, true);
                var v2 = v0.xyzw;
                v0.xyzw = v1;
                var v3 = v0.xyzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(true, v2.z);
                Assert.AreEqual(true, v2.w);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new bool4(true, true, true, false);
                var v1 = true;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bool4(false, true, false, false);
                var v1 = true;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bool4(true, true, false, true);
                var v1 = new bool2(false, true);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(true, true, true, false);
                var v1 = false;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bool4(false, true, true, true);
                var v1 = new bool2(false, true);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(false, false, true, false);
                var v1 = new bool2(true, false);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(false, true, true, true);
                var v1 = new bool3(false, false, true);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(true, v2.z);
            }
            {
                var v0 = new bool4(true, true, false, true);
                var v1 = false;
                var v2 = v0.a;
                v0.a = v1;
                var v3 = v0.a;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bool4(false, true, false, true);
                var v1 = new bool2(false, false);
                var v2 = v0.ra;
                v0.ra = v1;
                var v3 = v0.ra;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(false, false, true, true);
                var v1 = new bool2(true, false);
                var v2 = v0.ga;
                v0.ga = v1;
                var v3 = v0.ga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(true, false, false, false);
                var v1 = new bool3(false, true, true);
                var v2 = v0.rga;
                v0.rga = v1;
                var v3 = v0.rga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bool4(false, false, false, true);
                var v1 = new bool2(true, true);
                var v2 = v0.ba;
                v0.ba = v1;
                var v3 = v0.ba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool4(false, false, true, true);
                var v1 = new bool3(false, true, true);
                var v2 = v0.rba;
                v0.rba = v1;
                var v3 = v0.rba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(true, v2.z);
            }
            {
                var v0 = new bool4(false, true, false, false);
                var v1 = new bool3(true, false, false);
                var v2 = v0.gba;
                v0.gba = v1;
                var v3 = v0.gba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
                Assert.AreEqual(false, v0.w);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(false, v2.z);
            }
            {
                var v0 = new bool4(false, false, false, true);
                var v1 = new bool4(true, false, true, true);
                var v2 = v0.rgba;
                v0.rgba = v1;
                var v3 = v0.rgba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
                Assert.AreEqual(true, v0.w);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(false, v2.z);
                Assert.AreEqual(true, v2.w);
            }
        }

    }
}
