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

namespace  Atma.Math.Generated.Vec3
{
    [TestFixture]
    public class FloatVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new float3(-2.5f);
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
            }
            {
                var v = new float3(-8.5f, -3.5f, -8f);
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-8f, v.z);
            }
            {
                var v = new float3(new float2(-3.5f, 7f));
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var v = new float3(new float3(-8.5f, 2f, -3f));
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-3f, v.z);
            }
            {
                var v = new float3(new float4(1f, -8f, 0.5f, 6f));
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(0.5f, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new float3(-8.5f, 0f, -5.5f);
            Assert.AreEqual(-8.5f, v[0]);
            Assert.AreEqual(0f, v[1]);
            Assert.AreEqual(-5.5f, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            
            v[2] = 0f;
            Assert.AreEqual(0f, v[2]);
            v[1] = 1f;
            Assert.AreEqual(1f, v[1]);
            v[0] = 2f;
            Assert.AreEqual(2f, v[0]);
            v[0] = 3f;
            Assert.AreEqual(3f, v[0]);
            v[2] = 4f;
            Assert.AreEqual(4f, v[2]);
            v[0] = 5f;
            Assert.AreEqual(5f, v[0]);
            v[2] = 6f;
            Assert.AreEqual(6f, v[2]);
            v[0] = 7f;
            Assert.AreEqual(7f, v[0]);
            v[2] = 8f;
            Assert.AreEqual(8f, v[2]);
            v[2] = 9f;
            Assert.AreEqual(9f, v[2]);
            v[2] = -1f;
            Assert.AreEqual(-1f, v[2]);
            v[1] = -2f;
            Assert.AreEqual(-2f, v[1]);
            v[2] = -3f;
            Assert.AreEqual(-3f, v[2]);
            v[1] = -4f;
            Assert.AreEqual(-4f, v[1]);
            v[1] = -5f;
            Assert.AreEqual(-5f, v[1]);
            v[0] = -6f;
            Assert.AreEqual(-6f, v[0]);
            v[1] = -7f;
            Assert.AreEqual(-7f, v[1]);
            v[0] = -8f;
            Assert.AreEqual(-8f, v[0]);
            v[1] = -9f;
            Assert.AreEqual(-9f, v[1]);
            v[2] = -9.5f;
            Assert.AreEqual(-9.5f, v[2]);
            v[1] = -8.5f;
            Assert.AreEqual(-8.5f, v[1]);
            v[1] = -7.5f;
            Assert.AreEqual(-7.5f, v[1]);
            v[0] = -6.5f;
            Assert.AreEqual(-6.5f, v[0]);
            v[1] = -5.5f;
            Assert.AreEqual(-5.5f, v[1]);
            v[2] = -4.5f;
            Assert.AreEqual(-4.5f, v[2]);
            v[0] = -3.5f;
            Assert.AreEqual(-3.5f, v[0]);
            v[2] = -2.5f;
            Assert.AreEqual(-2.5f, v[2]);
            v[2] = -1.5f;
            Assert.AreEqual(-1.5f, v[2]);
            v[2] = -0.5f;
            Assert.AreEqual(-0.5f, v[2]);
            v[1] = 0.5f;
            Assert.AreEqual(0.5f, v[1]);
            v[1] = 1.5f;
            Assert.AreEqual(1.5f, v[1]);
            v[1] = 2.5f;
            Assert.AreEqual(2.5f, v[1]);
            v[2] = 3.5f;
            Assert.AreEqual(3.5f, v[2]);
            v[0] = 4.5f;
            Assert.AreEqual(4.5f, v[0]);
            v[0] = 5.5f;
            Assert.AreEqual(5.5f, v[0]);
            v[1] = 6.5f;
            Assert.AreEqual(6.5f, v[1]);
            v[1] = 7.5f;
            Assert.AreEqual(7.5f, v[1]);
            v[1] = 8.5f;
            Assert.AreEqual(8.5f, v[1]);
            v[1] = 9.5f;
            Assert.AreEqual(9.5f, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new float3(-6.5f, 6.5f, 1.5f);
            var vals = v.Values;
            Assert.AreEqual(-6.5f, vals[0]);
            Assert.AreEqual(6.5f, vals[1]);
            Assert.AreEqual(1.5f, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0f, float3.Zero.x);
            Assert.AreEqual(0f, float3.Zero.y);
            Assert.AreEqual(0f, float3.Zero.z);
            
            Assert.AreEqual(1f, float3.Ones.x);
            Assert.AreEqual(1f, float3.Ones.y);
            Assert.AreEqual(1f, float3.Ones.z);
            
            Assert.AreEqual(1f, float3.UnitX.x);
            Assert.AreEqual(0f, float3.UnitX.y);
            Assert.AreEqual(0f, float3.UnitX.z);
            
            Assert.AreEqual(0f, float3.UnitY.x);
            Assert.AreEqual(1f, float3.UnitY.y);
            Assert.AreEqual(0f, float3.UnitY.z);
            
            Assert.AreEqual(0f, float3.UnitZ.x);
            Assert.AreEqual(0f, float3.UnitZ.y);
            Assert.AreEqual(1f, float3.UnitZ.z);
            
            Assert.AreEqual(float.MaxValue, float3.MaxValue.x);
            Assert.AreEqual(float.MaxValue, float3.MaxValue.y);
            Assert.AreEqual(float.MaxValue, float3.MaxValue.z);
            
            Assert.AreEqual(float.MinValue, float3.MinValue.x);
            Assert.AreEqual(float.MinValue, float3.MinValue.y);
            Assert.AreEqual(float.MinValue, float3.MinValue.z);
            
            Assert.AreEqual(float.Epsilon, float3.Epsilon.x);
            Assert.AreEqual(float.Epsilon, float3.Epsilon.y);
            Assert.AreEqual(float.Epsilon, float3.Epsilon.z);
            
            Assert.AreEqual(float.NaN, float3.NaN.x);
            Assert.AreEqual(float.NaN, float3.NaN.y);
            Assert.AreEqual(float.NaN, float3.NaN.z);
            
            Assert.AreEqual(float.NegativeInfinity, float3.NegativeInfinity.x);
            Assert.AreEqual(float.NegativeInfinity, float3.NegativeInfinity.y);
            Assert.AreEqual(float.NegativeInfinity, float3.NegativeInfinity.z);
            
            Assert.AreEqual(float.PositiveInfinity, float3.PositiveInfinity.x);
            Assert.AreEqual(float.PositiveInfinity, float3.PositiveInfinity.y);
            Assert.AreEqual(float.PositiveInfinity, float3.PositiveInfinity.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new float3(-7.5f, -2.5f, -2.5f);
            var v2 = new float3(-7.5f, -2.5f, -2.5f);
            var v3 = new float3(-2.5f, -2.5f, -7.5f);
            Assert.That(v1 == new float3(v1));
            Assert.That(v2 == new float3(v2));
            Assert.That(v3 == new float3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new float3(2f, 7.5f, -8.5f);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = float3.Parse(s0);
            var v1 = float3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = float3.TryParse(s0, out v0);
            var b1 = float3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = float3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = float3.TryParse("", out v0);
            Assert.False(b0);
            b0 = float3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { float3.Parse(null); });
            Assert.Throws<FormatException>(() => { float3.Parse(""); });
            Assert.Throws<FormatException>(() => { float3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = float3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = float3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = float3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new float3(0f, -4.5f, 4.5f);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<float3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new float3(1f, -1f, 6.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(-8.5f, -0.5f, 0.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(7f, -3f, -9.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(1.5f, -6.5f, -6.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(-8f, -1.5f, -7f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(-0.5f, -3.5f, -5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(1.5f, -1.5f, -2.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(3.5f, 2.5f, 8.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(5.5f, 1f, 6.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float3(-9.5f, 6f, -1.5f);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new float3(-0.5f, 7.5f, 4f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(-8f, -2f, 9f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(0f, -7f, -1f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(3f, -3f, -5.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(-2.5f, -3f, 9.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(-5.5f, 6f, 9f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(1f, -1f, 5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(6f, 2f, -8.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(-4f, -4.5f, 3.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float3(8.5f, -8.5f, -1.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new float3(-7.5f, -2f, 2f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(-0.5f, 6f, -9.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(5.5f, -4.5f, 9f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(-8.5f, 9.5f, 9f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(4.5f, -4f, 2.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(-9.5f, 3f, 4.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(2.5f, -7f, 8.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(9.5f, 9f, 5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(-6f, 8f, -4f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float3(5.5f, -4.5f, -4.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new float3(9f, -5.5f, -3f);
                var v1 = new float3(4f, -7.5f, -9f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(-1.5f, -4f, 2.5f);
                var v1 = new float3(5f, -2.5f, 4.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(4.5f, 7.5f, -3f);
                var v1 = new float3(-7.5f, -2.5f, 7f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(-8.5f, -6f, 9f);
                var v1 = new float3(-4.5f, 0f, 3.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(-2.5f, -5.5f, -7.5f);
                var v1 = new float3(-2f, -7.5f, -1.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(3.5f, -7.5f, 8.5f);
                var v1 = new float3(-8.5f, 5.5f, -2f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(-6.5f, -8f, 6.5f);
                var v1 = new float3(-7f, 2.5f, 2f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(-2f, 7f, 1.5f);
                var v1 = new float3(9f, 5.5f, -0.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(-5f, -9f, -8f);
                var v1 = new float3(-6f, -7.5f, 2f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float3(-6.5f, -4.5f, -5.5f);
                var v1 = new float3(-9f, -8f, 8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new float3(-6f, -3f, -5f);
                var v1 = new float3(-2f, 8f, 6f);
                var v2 = new float3(-7.5f, -7.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(-9.5f, 5.5f, 5f);
                var v1 = new float3(2f, -2.5f, 2.5f);
                var v2 = new float3(-8.5f, -9f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(0f, 1f, -5f);
                var v1 = new float3(4f, 7.5f, -3f);
                var v2 = new float3(-1.5f, 0f, 6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(-3f, 8f, 8.5f);
                var v1 = new float3(1f, 5f, 4f);
                var v2 = new float3(5f, -1.5f, 3f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(8.5f, 2.5f, -6.5f);
                var v1 = new float3(-1.5f, 7f, 7f);
                var v2 = new float3(1f, 1f, 5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(-7f, -4.5f, 2f);
                var v1 = new float3(-4f, -1f, 0.5f);
                var v2 = new float3(7f, -8f, 0.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(-4.5f, -2f, -5f);
                var v1 = new float3(2f, -6.5f, 7f);
                var v2 = new float3(9f, 9f, -3f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(-5.5f, -9f, 0.5f);
                var v1 = new float3(1f, 6.5f, 9.5f);
                var v2 = new float3(-0.5f, -7.5f, -3.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(9.5f, -2f, 4.5f);
                var v1 = new float3(7f, 2f, 6.5f);
                var v2 = new float3(6f, -2f, -6f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float3(4.5f, 8.5f, 7.5f);
                var v1 = new float3(8f, 3.5f, -2.5f);
                var v2 = new float3(-5f, -8.5f, -6f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new float3(-3f, 7f, -8f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(-7.5f, 7f, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(8f, 3f, -4f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(0f, 7.5f, -9.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(2f, 1.5f, -3f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(-1f, 2f, 7.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(6f, 8f, 2.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(3f, -9.5f, -1.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(7f, -1f, -6f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float3(4.5f, -1f, -2.5f);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new float3(7f, -6.5f, -5.5f);
                var v1 = new float3(4f, -8f, -4.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(-2.5f, 2f, 6.5f);
                var v1 = new float3(8f, 6f, 6.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(-9f, 1.5f, -4f);
                var v1 = new float3(-9.5f, -8f, -1.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(2f, 8f, -9.5f);
                var v1 = new float3(-8.5f, -4f, -2.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(6.5f, -4f, -2.5f);
                var v1 = new float3(1.5f, -2.5f, -3.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(-1.5f, 9.5f, -6.5f);
                var v1 = new float3(6f, -1f, 6.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(-3.5f, 8.5f, -9f);
                var v1 = new float3(2.5f, -2f, -9.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(1f, -3f, 8.5f);
                var v1 = new float3(5.5f, -2f, -7.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(-7.5f, 5f, -1.5f);
                var v1 = new float3(0f, -2f, -7f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float3(-6f, -2.5f, 9f);
                var v1 = new float3(6.5f, 7f, 3f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new float3(5f, -2f, 6f);
                var v1 = new float3(9f, -0.5f, 0f);
                var v2 = new float3(2f, 7.5f, 0f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(7.5f, -5f, -2.5f);
                var v1 = new float3(3f, 3.5f, -0.5f);
                var v2 = new float3(-0.5f, 9f, -9f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(-1.5f, -8f, 7.5f);
                var v1 = new float3(-4.5f, 4f, 6f);
                var v2 = new float3(1.5f, -1f, -1f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(0.5f, 2.5f, 2f);
                var v1 = new float3(5f, -9.5f, -3f);
                var v2 = new float3(2f, 9.5f, 6.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(-5.5f, -2f, -6.5f);
                var v1 = new float3(9.5f, 7f, -9.5f);
                var v2 = new float3(1.5f, 2.5f, 0f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(-8f, -6f, 9f);
                var v1 = new float3(-2f, -9f, -4.5f);
                var v2 = new float3(7.5f, -2f, -2.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(-1f, -8.5f, 6f);
                var v1 = new float3(9.5f, -9f, -9f);
                var v2 = new float3(0.5f, -3f, 5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(7.5f, 1.5f, 5.5f);
                var v1 = new float3(-5f, 0f, 3.5f);
                var v2 = new float3(3.5f, 5f, 8.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(6.5f, -1.5f, -1f);
                var v1 = new float3(-7f, 4.5f, -3f);
                var v2 = new float3(6f, -4f, 4.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float3(0f, -8f, -3f);
                var v1 = new float3(-7f, 7f, 7f);
                var v2 = new float3(-4.5f, 1.5f, -9f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new float3(-3f, 1.5f, 7f);
                var v1 = new float3(4.5f, 3f, -1.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(-2f, -9.5f, -3f);
                var v1 = new float3(5f, -1f, -8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(-8f, -6.5f, 2f);
                var v1 = new float3(-5.5f, -8f, -9.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(-7f, 7f, 7f);
                var v1 = new float3(0.5f, 9f, -8f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(-7f, -4.5f, -5.5f);
                var v1 = new float3(3.5f, -8.5f, -7f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(-5.5f, 4.5f, 8f);
                var v1 = new float3(-7.5f, -6.5f, 2.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(6.5f, -9.5f, -8.5f);
                var v1 = new float3(8f, -0.5f, 9.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(-7.5f, 3.5f, -7f);
                var v1 = new float3(2f, -7f, 0f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(4.5f, 8f, 6f);
                var v1 = new float3(9.5f, -6.5f, -1.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float3(-3.5f, -7.5f, -7.5f);
                var v1 = new float3(0.5f, -8f, -8f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new float3(8.5f, 7f, -7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(-9f, 3f, -9.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(-9f, 5f, 1f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(-4.5f, -6f, 4f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(0f, -2f, 3f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(4f, -5f, -3f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(1f, -2f, -3.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(-4.5f, 2.5f, 2f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(-9f, 3f, 8f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float3(2.5f, 8f, 9f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new float3(5.5f, 1f, -8f);
                var v1 = new float3(-9f, -8f, 6f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(4f, -6.5f, 8f);
                var v1 = new float3(8.5f, -5.5f, 8f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(1f, 1f, 7f);
                var v1 = new float3(-2.5f, 6.5f, 9f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(6f, 5.5f, 5.5f);
                var v1 = new float3(7f, -3.5f, 8.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(2.5f, -5f, -2f);
                var v1 = new float3(-6.5f, 2f, 9.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(-4f, -1.5f, 5f);
                var v1 = new float3(2f, -6f, 2.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(-3.5f, 2.5f, -1.5f);
                var v1 = new float3(-8f, 9.5f, -2.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(6f, 4f, 9f);
                var v1 = new float3(2.5f, 9f, 8f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(-1.5f, 1.5f, -3.5f);
                var v1 = new float3(5f, 1.5f, -2f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new float3(-6f, -2.5f, -5f);
                var v1 = new float3(-9f, -2.5f, 3f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(665563139);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.Random(random, 3, 6);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(434248205);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomUniform(random, -1, 0);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            Assert.AreEqual(avg.z, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(438970992);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.Random(random, 2, 4);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            Assert.AreEqual(avg.z, 3, 1.0);
            
            Assert.AreEqual(variance.x, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.3333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(533281766);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomUniform(random, 3, 4);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            Assert.AreEqual(avg.z, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1637792459);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.Random(random, -4, -2);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3, 1.0);
            Assert.AreEqual(avg.y, -3, 1.0);
            Assert.AreEqual(avg.z, -3, 1.0);
            
            Assert.AreEqual(variance.x, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.3333333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(2076117352);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomNormal(random, -1.8396271205691748f, 7.944609903704659f);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.8396271205691748, 1.0);
            Assert.AreEqual(avg.y, -1.8396271205691748, 1.0);
            Assert.AreEqual(avg.z, -1.8396271205691748, 1.0);
            
            Assert.AreEqual(variance.x, 7.944609903704659, 3.0);
            Assert.AreEqual(variance.y, 7.944609903704659, 3.0);
            Assert.AreEqual(variance.z, 7.944609903704659, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(498049023);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomGaussian(random, 0.7897443747100161f, 9.334673913817236f);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.7897443747100161, 1.0);
            Assert.AreEqual(avg.y, 0.7897443747100161, 1.0);
            Assert.AreEqual(avg.z, 0.7897443747100161, 1.0);
            
            Assert.AreEqual(variance.x, 9.334673913817236, 3.0);
            Assert.AreEqual(variance.y, 9.334673913817236, 3.0);
            Assert.AreEqual(variance.z, 9.334673913817236, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(957660188);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomNormal(random, 0.27954863304251276f, 4.820964245507943f);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.27954863304251276, 1.0);
            Assert.AreEqual(avg.y, 0.27954863304251276, 1.0);
            Assert.AreEqual(avg.z, 0.27954863304251276, 1.0);
            
            Assert.AreEqual(variance.x, 4.820964245507943, 3.0);
            Assert.AreEqual(variance.y, 4.820964245507943, 3.0);
            Assert.AreEqual(variance.z, 4.820964245507943, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(288608346);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomGaussian(random, 1.1255405857812337f, 3.448184646409091f);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.1255405857812337, 1.0);
            Assert.AreEqual(avg.y, 1.1255405857812337, 1.0);
            Assert.AreEqual(avg.z, 1.1255405857812337, 1.0);
            
            Assert.AreEqual(variance.x, 3.448184646409091, 3.0);
            Assert.AreEqual(variance.y, 3.448184646409091, 3.0);
            Assert.AreEqual(variance.z, 3.448184646409091, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1693207645);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomNormal(random, -0.7780878221514111f, 6.023586544219212f);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.7780878221514111, 1.0);
            Assert.AreEqual(avg.y, -0.7780878221514111, 1.0);
            Assert.AreEqual(avg.z, -0.7780878221514111, 1.0);
            
            Assert.AreEqual(variance.x, 6.023586544219212, 3.0);
            Assert.AreEqual(variance.y, 6.023586544219212, 3.0);
            Assert.AreEqual(variance.z, 6.023586544219212, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(1237327052);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(1901445408);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(1628430905);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(690794620);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(1169718155);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

    }
}
