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
    public class BoolSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.xx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.xy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.xz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.yx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.yy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.yz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.zx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.rr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.rg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.rb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.gr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.grr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.grg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.grb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.gg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.gb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.br;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.brr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.brg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.brb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(false, false, false);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.bg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(false, true, false);
                var v = ov.swizzle.bb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(true, false, false);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, true, true);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bool3(true, false, true);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bool3(false, false, true);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bool3(true, true, true);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bool3(true, true, false);
                var v = ov.swizzle.bbbb;
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
                var v0 = new bool3(true, false, true);
                var v1 = new bool2(false, true);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bool3(false, true, false);
                var v1 = new bool2(true, false);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bool3(true, true, false);
                var v1 = new bool2(false, true);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bool3(false, true, true);
                var v1 = new bool3(true, true, false);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(true, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new bool3(true, true, true);
                var v1 = true;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bool3(false, true, true);
                var v1 = false;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bool3(false, true, false);
                var v1 = new bool2(false, false);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool3(false, false, false);
                var v1 = true;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(false, v2);
            }
            {
                var v0 = new bool3(true, true, false);
                var v1 = new bool2(false, false);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bool3(false, true, true);
                var v1 = new bool2(false, true);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bool3(false, true, false);
                var v1 = new bool3(true, true, true);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(true, v2.y);
                Assert.AreEqual(false, v2.z);
            }
        }

    }
}
