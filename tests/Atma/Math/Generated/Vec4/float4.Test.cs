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
using Atma.Math;

// ReSharper disable InconsistentNaming

namespace  Atma.Math.Generated.Vec4
{
    [TestFixture]
    public class FloatVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new float4(4.5f);
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var v = new float4(8f, -1.5f, -7f, 6.5f);
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var v = new float4(new float2(-7.5f, -1.5f));
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var v = new float4(new float3(-1.5f, 7.5f, -8.5f));
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var v = new float4(new float4(4f, 0f, -7.5f, -4.5f));
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new float4(5.5f, 5.5f, -9.5f, 7.5f);
            Assert.AreEqual(5.5f, v[0]);
            Assert.AreEqual(5.5f, v[1]);
            Assert.AreEqual(-9.5f, v[2]);
            Assert.AreEqual(7.5f, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            
            v[3] = 0f;
            Assert.AreEqual(0f, v[3]);
            v[1] = 1f;
            Assert.AreEqual(1f, v[1]);
            v[2] = 2f;
            Assert.AreEqual(2f, v[2]);
            v[0] = 3f;
            Assert.AreEqual(3f, v[0]);
            v[2] = 4f;
            Assert.AreEqual(4f, v[2]);
            v[1] = 5f;
            Assert.AreEqual(5f, v[1]);
            v[1] = 6f;
            Assert.AreEqual(6f, v[1]);
            v[3] = 7f;
            Assert.AreEqual(7f, v[3]);
            v[1] = 8f;
            Assert.AreEqual(8f, v[1]);
            v[3] = 9f;
            Assert.AreEqual(9f, v[3]);
            v[1] = -1f;
            Assert.AreEqual(-1f, v[1]);
            v[2] = -2f;
            Assert.AreEqual(-2f, v[2]);
            v[1] = -3f;
            Assert.AreEqual(-3f, v[1]);
            v[1] = -4f;
            Assert.AreEqual(-4f, v[1]);
            v[1] = -5f;
            Assert.AreEqual(-5f, v[1]);
            v[2] = -6f;
            Assert.AreEqual(-6f, v[2]);
            v[1] = -7f;
            Assert.AreEqual(-7f, v[1]);
            v[3] = -8f;
            Assert.AreEqual(-8f, v[3]);
            v[2] = -9f;
            Assert.AreEqual(-9f, v[2]);
            v[1] = -9.5f;
            Assert.AreEqual(-9.5f, v[1]);
            v[2] = -8.5f;
            Assert.AreEqual(-8.5f, v[2]);
            v[3] = -7.5f;
            Assert.AreEqual(-7.5f, v[3]);
            v[2] = -6.5f;
            Assert.AreEqual(-6.5f, v[2]);
            v[1] = -5.5f;
            Assert.AreEqual(-5.5f, v[1]);
            v[2] = -4.5f;
            Assert.AreEqual(-4.5f, v[2]);
            v[0] = -3.5f;
            Assert.AreEqual(-3.5f, v[0]);
            v[2] = -2.5f;
            Assert.AreEqual(-2.5f, v[2]);
            v[0] = -1.5f;
            Assert.AreEqual(-1.5f, v[0]);
            v[1] = -0.5f;
            Assert.AreEqual(-0.5f, v[1]);
            v[2] = 0.5f;
            Assert.AreEqual(0.5f, v[2]);
            v[2] = 1.5f;
            Assert.AreEqual(1.5f, v[2]);
            v[3] = 2.5f;
            Assert.AreEqual(2.5f, v[3]);
            v[0] = 3.5f;
            Assert.AreEqual(3.5f, v[0]);
            v[0] = 4.5f;
            Assert.AreEqual(4.5f, v[0]);
            v[0] = 5.5f;
            Assert.AreEqual(5.5f, v[0]);
            v[1] = 6.5f;
            Assert.AreEqual(6.5f, v[1]);
            v[1] = 7.5f;
            Assert.AreEqual(7.5f, v[1]);
            v[3] = 8.5f;
            Assert.AreEqual(8.5f, v[3]);
            v[3] = 9.5f;
            Assert.AreEqual(9.5f, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new float4(-6f, 9.5f, -6f, 8f);
            var vals = v.Values;
            Assert.AreEqual(-6f, vals[0]);
            Assert.AreEqual(9.5f, vals[1]);
            Assert.AreEqual(-6f, vals[2]);
            Assert.AreEqual(8f, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0f, float4.Zero.x);
            Assert.AreEqual(0f, float4.Zero.y);
            Assert.AreEqual(0f, float4.Zero.z);
            Assert.AreEqual(0f, float4.Zero.w);
            
            Assert.AreEqual(1f, float4.Ones.x);
            Assert.AreEqual(1f, float4.Ones.y);
            Assert.AreEqual(1f, float4.Ones.z);
            Assert.AreEqual(1f, float4.Ones.w);
            
            Assert.AreEqual(1f, float4.UnitX.x);
            Assert.AreEqual(0f, float4.UnitX.y);
            Assert.AreEqual(0f, float4.UnitX.z);
            Assert.AreEqual(0f, float4.UnitX.w);
            
            Assert.AreEqual(0f, float4.UnitY.x);
            Assert.AreEqual(1f, float4.UnitY.y);
            Assert.AreEqual(0f, float4.UnitY.z);
            Assert.AreEqual(0f, float4.UnitY.w);
            
            Assert.AreEqual(0f, float4.UnitZ.x);
            Assert.AreEqual(0f, float4.UnitZ.y);
            Assert.AreEqual(1f, float4.UnitZ.z);
            Assert.AreEqual(0f, float4.UnitZ.w);
            
            Assert.AreEqual(0f, float4.UnitW.x);
            Assert.AreEqual(0f, float4.UnitW.y);
            Assert.AreEqual(0f, float4.UnitW.z);
            Assert.AreEqual(1f, float4.UnitW.w);
            
            Assert.AreEqual(float.MaxValue, float4.MaxValue.x);
            Assert.AreEqual(float.MaxValue, float4.MaxValue.y);
            Assert.AreEqual(float.MaxValue, float4.MaxValue.z);
            Assert.AreEqual(float.MaxValue, float4.MaxValue.w);
            
            Assert.AreEqual(float.MinValue, float4.MinValue.x);
            Assert.AreEqual(float.MinValue, float4.MinValue.y);
            Assert.AreEqual(float.MinValue, float4.MinValue.z);
            Assert.AreEqual(float.MinValue, float4.MinValue.w);
            
            Assert.AreEqual(float.Epsilon, float4.Epsilon.x);
            Assert.AreEqual(float.Epsilon, float4.Epsilon.y);
            Assert.AreEqual(float.Epsilon, float4.Epsilon.z);
            Assert.AreEqual(float.Epsilon, float4.Epsilon.w);
            
            Assert.AreEqual(float.NaN, float4.NaN.x);
            Assert.AreEqual(float.NaN, float4.NaN.y);
            Assert.AreEqual(float.NaN, float4.NaN.z);
            Assert.AreEqual(float.NaN, float4.NaN.w);
            
            Assert.AreEqual(float.NegativeInfinity, float4.NegativeInfinity.x);
            Assert.AreEqual(float.NegativeInfinity, float4.NegativeInfinity.y);
            Assert.AreEqual(float.NegativeInfinity, float4.NegativeInfinity.z);
            Assert.AreEqual(float.NegativeInfinity, float4.NegativeInfinity.w);
            
            Assert.AreEqual(float.PositiveInfinity, float4.PositiveInfinity.x);
            Assert.AreEqual(float.PositiveInfinity, float4.PositiveInfinity.y);
            Assert.AreEqual(float.PositiveInfinity, float4.PositiveInfinity.z);
            Assert.AreEqual(float.PositiveInfinity, float4.PositiveInfinity.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new float4(0.5f, 8f, -2f, -7.5f);
            var v2 = new float4(0.5f, 8f, -2f, -7.5f);
            var v3 = new float4(-7.5f, -2f, 8f, 0.5f);
            Assert.That(v1 == new float4(v1));
            Assert.That(v2 == new float4(v2));
            Assert.That(v3 == new float4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new float4(5.5f, 8.5f, 1.5f, -5f);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = float4.Parse(s0);
            var v1 = float4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = float4.TryParse(s0, out v0);
            var b1 = float4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = float4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = float4.TryParse("", out v0);
            Assert.False(b0);
            b0 = float4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { float4.Parse(null); });
            Assert.Throws<FormatException>(() => { float4.Parse(""); });
            Assert.Throws<FormatException>(() => { float4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = float4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = float4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = float4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new float4(-2f, 6.5f, 5f, 9.5f);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<float4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new float4(2.5f, -1.5f, -3f, -9.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(-6f, -1.5f, 9f, -6f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(-5.5f, -5.5f, 7.5f, -1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(6f, 1.5f, 4.5f, -3.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(-8f, -1.5f, -1.5f, 7.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(8.5f, -4.5f, -9f, -0.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(0f, 0.5f, 5f, 4.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(-7.5f, 7f, 2.5f, -3f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(-3.5f, -5f, -9.5f, -3.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float4(-1.5f, 6.5f, 0.5f, -8f);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new float4(7f, -4f, -7f, 4f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(5.5f, -4f, -9.5f, 0.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(3.5f, -7f, 1f, -8f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(-9.5f, 4f, 2.5f, -6.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(3.5f, 2f, 3.5f, 8f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(-6f, 5f, 6f, -6.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(-8f, 6.5f, 5f, -3f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(-4.5f, 8f, 0.5f, 6f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(3.5f, 2.5f, 5.5f, 0f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float4(9.5f, 2f, -1f, -7.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new float4(-9.5f, -6f, -2f, -6f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(2f, -3.5f, -3f, -3f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(1.5f, 5f, 5f, -3f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(-5f, 8f, 1.5f, -0.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(5f, 9.5f, -6f, 8f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(-0.5f, 7.5f, -5.5f, 7.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(-8.5f, -1f, 3.5f, -8.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(-8.5f, -7.5f, 7.5f, -4f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(6f, 1f, 0f, 2f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float4(9f, 9.5f, 2f, 5.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new float4(0.5f, -3.5f, -4f, 0f);
                var v1 = new float4(7f, -2f, -2.5f, 4f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(-8.5f, -0.5f, -2f, 9f);
                var v1 = new float4(-8.5f, -7.5f, -6.5f, -5.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(-5.5f, -5.5f, -5f, -7.5f);
                var v1 = new float4(-3f, 8.5f, 5.5f, -3f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(-1.5f, 6.5f, -6.5f, 4f);
                var v1 = new float4(-8.5f, 6.5f, 1.5f, 9f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(4f, 8.5f, 3.5f, 8f);
                var v1 = new float4(-2.5f, -3.5f, 0.5f, 3f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(-8.5f, -3.5f, 2f, 5.5f);
                var v1 = new float4(-7f, 4f, -9.5f, -7.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(6.5f, 6.5f, -1.5f, -5f);
                var v1 = new float4(0.5f, -5.5f, 1.5f, 2.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(1.5f, 1f, -3f, -1f);
                var v1 = new float4(-1.5f, -6.5f, -5.5f, -4.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(8.5f, 1f, 4f, -6.5f);
                var v1 = new float4(-1.5f, -5f, 7.5f, 8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float4(4.5f, -2f, 0f, -3.5f);
                var v1 = new float4(5.5f, 9.5f, 5.5f, -6.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new float4(-4f, -6f, -5f, -1f);
                var v1 = new float4(7f, 5f, 3.5f, -4f);
                var v2 = new float4(-8.5f, -8.5f, -4f, 8f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(-3f, 4.5f, 4.5f, 1f);
                var v1 = new float4(8.5f, 1.5f, 7f, 7.5f);
                var v2 = new float4(5.5f, 8.5f, -4f, -6f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(-8.5f, -0.5f, 3.5f, -9f);
                var v1 = new float4(8.5f, -3f, -0.5f, 7f);
                var v2 = new float4(-7f, -7f, 2f, 6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(-8f, -4.5f, 8f, 0f);
                var v1 = new float4(-5.5f, 4.5f, 6f, -9f);
                var v2 = new float4(-0.5f, 3f, 8.5f, -2f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(-7.5f, 0.5f, 6.5f, -9.5f);
                var v1 = new float4(-1.5f, -2f, -4f, -6f);
                var v2 = new float4(1f, 8.5f, 0.5f, -8f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(-3f, -4f, -6f, 8f);
                var v1 = new float4(1.5f, 5f, 1.5f, 5.5f);
                var v2 = new float4(2.5f, 8.5f, -6.5f, -4f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(-6.5f, 6f, -4f, 0f);
                var v1 = new float4(1.5f, 5.5f, -3.5f, -8f);
                var v2 = new float4(1.5f, -8.5f, 7.5f, 8f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(-7f, 8f, -9.5f, 5f);
                var v1 = new float4(3f, -2.5f, 4.5f, -9.5f);
                var v2 = new float4(4.5f, 0.5f, -2.5f, 9f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(-9f, 8.5f, -2.5f, -5.5f);
                var v1 = new float4(-2f, 3f, -9f, -6.5f);
                var v2 = new float4(6f, -6.5f, 7.5f, -8.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float4(7.5f, -4f, -5.5f, 6f);
                var v1 = new float4(-2f, -3f, -2.5f, 1.5f);
                var v2 = new float4(-7f, 6f, 2.5f, -7.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new float4(-1.5f, -6f, -7.5f, 3f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(8f, -7.5f, -2f, -6f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(-5.5f, -7f, -2f, 3.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(-7.5f, 5.5f, -4f, -5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(-4f, -2.5f, 7f, 2f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(7f, 7f, 4f, 4f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(-2.5f, 8f, -9f, -2f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(2f, 2.5f, -7f, -7f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(-9.5f, -5.5f, 0f, 7f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float4(-8.5f, 4.5f, 6f, 2.5f);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new float4(-9.5f, -3f, 7f, 9.5f);
                var v1 = new float4(-2f, 0.5f, -7f, 5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(-5f, 8f, -9f, -8f);
                var v1 = new float4(7f, 8.5f, -6f, -4.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(-1f, -5.5f, 0f, -3f);
                var v1 = new float4(2f, 5f, 7.5f, -9.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(-5.5f, -3.5f, -6.5f, 7f);
                var v1 = new float4(4.5f, -3f, -0.5f, -8f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(3.5f, 1.5f, -0.5f, -0.5f);
                var v1 = new float4(5.5f, -8.5f, 6f, 0f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(9f, -2f, -4f, -9.5f);
                var v1 = new float4(7f, -7f, 0f, 6.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(-6.5f, 4f, 0f, 7f);
                var v1 = new float4(-2.5f, 3f, 5f, -5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(-6f, -1.5f, -5f, -4.5f);
                var v1 = new float4(7f, 8f, -2f, 1f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(-9f, 0f, -5.5f, -7f);
                var v1 = new float4(8f, -3.5f, 0.5f, 0.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float4(-7f, 0f, 3f, 1.5f);
                var v1 = new float4(1.5f, -7f, -3f, 7f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new float4(2f, 5.5f, 3f, -9.5f);
                var v1 = new float4(7f, -1f, -3f, 1f);
                var v2 = new float4(7f, 3f, 5f, 6f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(5f, -0.5f, 7.5f, -1f);
                var v1 = new float4(-8f, 2.5f, -2f, -7f);
                var v2 = new float4(3.5f, -2f, 7f, 1f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(7f, 5.5f, -1f, 9.5f);
                var v1 = new float4(2.5f, 0.5f, 5f, 4.5f);
                var v2 = new float4(7f, -5.5f, 8.5f, 4f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(-9.5f, 0.5f, -4f, 6.5f);
                var v1 = new float4(1.5f, -0.5f, 6.5f, -8f);
                var v2 = new float4(4.5f, 0f, -1f, -8f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(-5.5f, 4.5f, -4.5f, 2f);
                var v1 = new float4(-6f, 6.5f, -4f, 0.5f);
                var v2 = new float4(-2.5f, 1f, -3f, -2f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(0f, -3f, 8f, -8f);
                var v1 = new float4(7.5f, -1f, 8.5f, -8.5f);
                var v2 = new float4(1.5f, 2.5f, 0.5f, -2.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(-8f, -6f, -4.5f, 3f);
                var v1 = new float4(-6f, 0.5f, 6f, 6f);
                var v2 = new float4(-4.5f, 3.5f, -6f, 8.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(4f, 3f, -8f, -1f);
                var v1 = new float4(9f, 7f, -7f, -9f);
                var v2 = new float4(-8f, 2f, 6.5f, -9f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(-9.5f, -9f, -9.5f, -5.5f);
                var v1 = new float4(1f, -0.5f, -3.5f, 1.5f);
                var v2 = new float4(4f, 8.5f, -5.5f, 0f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float4(-1f, 9f, -4f, 6.5f);
                var v1 = new float4(4.5f, 5f, -3.5f, 7f);
                var v2 = new float4(7.5f, 9f, -3f, 4.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new float4(0f, 0.5f, -8.5f, 1f);
                var v1 = new float4(-1.5f, -2.5f, -8.5f, -4.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(-9.5f, -1f, 6f, -6f);
                var v1 = new float4(-4f, 1.5f, -3f, -3.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(8.5f, 6.5f, -7.5f, -2f);
                var v1 = new float4(5f, -6.5f, 7f, 6f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(-9.5f, 3.5f, -5f, -3f);
                var v1 = new float4(-9f, -4f, -7f, -3f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(5f, -6f, 8.5f, 1.5f);
                var v1 = new float4(-5f, -1f, 8f, -9f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(-4.5f, -7f, -6f, 7.5f);
                var v1 = new float4(-1.5f, 2f, 8f, -5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(-0.5f, -6.5f, 1f, -8.5f);
                var v1 = new float4(0f, -8.5f, -0.5f, -8f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(-7.5f, -5f, -7.5f, 5.5f);
                var v1 = new float4(-2f, 7f, 5f, 6f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(4.5f, 4.5f, -1f, 7.5f);
                var v1 = new float4(3.5f, -8.5f, -2f, -1.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float4(-1.5f, 3f, -2.5f, -0.5f);
                var v1 = new float4(6f, -1f, -8f, -8f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new float4(-5f, 8f, 6f, -7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(-8.5f, -3f, 6.5f, 2.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(-4f, -2f, -7f, -7f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(9.5f, -9.5f, -9f, 3.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(9f, 9f, -2f, 4.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(9f, 0f, 8.5f, 3f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(-3.5f, 8.5f, 0.5f, 7f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(-6f, -0.5f, -9f, -6f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(4f, 2f, -1.5f, 1.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float4(5f, 5.5f, -1f, 2f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1661430541);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.Random(random, 3, 6);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            Assert.AreEqual(avg.w, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(116059207);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomUniform(random, -3, -2);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2.5, 1.0);
            Assert.AreEqual(avg.y, -2.5, 1.0);
            Assert.AreEqual(avg.z, -2.5, 1.0);
            Assert.AreEqual(avg.w, -2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(67449209);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.Random(random, 1, 2);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            Assert.AreEqual(avg.z, 1.5, 1.0);
            Assert.AreEqual(avg.w, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1839727823);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomUniform(random, -1, 0);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            Assert.AreEqual(avg.z, -0.5, 1.0);
            Assert.AreEqual(avg.w, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1538274078);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.Random(random, -2, 0);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            Assert.AreEqual(avg.z, -1, 1.0);
            Assert.AreEqual(avg.w, -1, 1.0);
            
            Assert.AreEqual(variance.x, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.3333333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(409693774);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomNormal(random, -0.5249517851159684f, 4.945405202426671f);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5249517851159684, 1.0);
            Assert.AreEqual(avg.y, -0.5249517851159684, 1.0);
            Assert.AreEqual(avg.z, -0.5249517851159684, 1.0);
            Assert.AreEqual(avg.w, -0.5249517851159684, 1.0);
            
            Assert.AreEqual(variance.x, 4.945405202426671, 3.0);
            Assert.AreEqual(variance.y, 4.945405202426671, 3.0);
            Assert.AreEqual(variance.z, 4.945405202426671, 3.0);
            Assert.AreEqual(variance.w, 4.945405202426671, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(504342982);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomGaussian(random, -1.7319831399861645f, 4.376693169761772f);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.7319831399861645, 1.0);
            Assert.AreEqual(avg.y, -1.7319831399861645, 1.0);
            Assert.AreEqual(avg.z, -1.7319831399861645, 1.0);
            Assert.AreEqual(avg.w, -1.7319831399861645, 1.0);
            
            Assert.AreEqual(variance.x, 4.376693169761772, 3.0);
            Assert.AreEqual(variance.y, 4.376693169761772, 3.0);
            Assert.AreEqual(variance.z, 4.376693169761772, 3.0);
            Assert.AreEqual(variance.w, 4.376693169761772, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(176955691);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomNormal(random, 0.808186727952299f, 7.653956589127871f);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.808186727952299, 1.0);
            Assert.AreEqual(avg.y, 0.808186727952299, 1.0);
            Assert.AreEqual(avg.z, 0.808186727952299, 1.0);
            Assert.AreEqual(avg.w, 0.808186727952299, 1.0);
            
            Assert.AreEqual(variance.x, 7.653956589127871, 3.0);
            Assert.AreEqual(variance.y, 7.653956589127871, 3.0);
            Assert.AreEqual(variance.z, 7.653956589127871, 3.0);
            Assert.AreEqual(variance.w, 7.653956589127871, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(155403862);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomGaussian(random, 0.25609387003634776f, 1.494744430060845f);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.25609387003634776, 1.0);
            Assert.AreEqual(avg.y, 0.25609387003634776, 1.0);
            Assert.AreEqual(avg.z, 0.25609387003634776, 1.0);
            Assert.AreEqual(avg.w, 0.25609387003634776, 1.0);
            
            Assert.AreEqual(variance.x, 1.494744430060845, 3.0);
            Assert.AreEqual(variance.y, 1.494744430060845, 3.0);
            Assert.AreEqual(variance.z, 1.494744430060845, 3.0);
            Assert.AreEqual(variance.w, 1.494744430060845, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1512393467);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomNormal(random, 1.5869951637401223f, 3.8043119776082746f);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5869951637401223, 1.0);
            Assert.AreEqual(avg.y, 1.5869951637401223, 1.0);
            Assert.AreEqual(avg.z, 1.5869951637401223, 1.0);
            Assert.AreEqual(avg.w, 1.5869951637401223, 1.0);
            
            Assert.AreEqual(variance.x, 3.8043119776082746, 3.0);
            Assert.AreEqual(variance.y, 3.8043119776082746, 3.0);
            Assert.AreEqual(variance.z, 3.8043119776082746, 3.0);
            Assert.AreEqual(variance.w, 3.8043119776082746, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(1150339682);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(1247026887);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(1341911474);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(310946967);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(721999215);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

    }
}
