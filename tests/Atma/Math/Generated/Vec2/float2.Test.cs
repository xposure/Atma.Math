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

namespace  Atma.Math.Generated.Vec2
{
    [TestFixture]
    public class FloatVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new float2(-4.5f);
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
            }
            {
                var v = new float2(9f, -6f);
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-6f, v.y);
            }
            {
                var v = new float2(new float2(9f, 3.5f));
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(3.5f, v.y);
            }
            {
                var v = new float2(new float3(-9.5f, 8.5f, -3f));
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
            }
            {
                var v = new float2(new float4(-7f, -2.5f, -3f, 4f));
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-2.5f, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new float2(-9.5f, -1.5f);
            Assert.AreEqual(-9.5f, v[0]);
            Assert.AreEqual(-1.5f, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            
            v[0] = 0f;
            Assert.AreEqual(0f, v[0]);
            v[1] = 1f;
            Assert.AreEqual(1f, v[1]);
            v[1] = 2f;
            Assert.AreEqual(2f, v[1]);
            v[0] = 3f;
            Assert.AreEqual(3f, v[0]);
            v[1] = 4f;
            Assert.AreEqual(4f, v[1]);
            v[0] = 5f;
            Assert.AreEqual(5f, v[0]);
            v[0] = 6f;
            Assert.AreEqual(6f, v[0]);
            v[0] = 7f;
            Assert.AreEqual(7f, v[0]);
            v[1] = 8f;
            Assert.AreEqual(8f, v[1]);
            v[0] = 9f;
            Assert.AreEqual(9f, v[0]);
            v[1] = -1f;
            Assert.AreEqual(-1f, v[1]);
            v[1] = -2f;
            Assert.AreEqual(-2f, v[1]);
            v[0] = -3f;
            Assert.AreEqual(-3f, v[0]);
            v[0] = -4f;
            Assert.AreEqual(-4f, v[0]);
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
            v[0] = -9.5f;
            Assert.AreEqual(-9.5f, v[0]);
            v[0] = -8.5f;
            Assert.AreEqual(-8.5f, v[0]);
            v[0] = -7.5f;
            Assert.AreEqual(-7.5f, v[0]);
            v[1] = -6.5f;
            Assert.AreEqual(-6.5f, v[1]);
            v[0] = -5.5f;
            Assert.AreEqual(-5.5f, v[0]);
            v[1] = -4.5f;
            Assert.AreEqual(-4.5f, v[1]);
            v[1] = -3.5f;
            Assert.AreEqual(-3.5f, v[1]);
            v[1] = -2.5f;
            Assert.AreEqual(-2.5f, v[1]);
            v[0] = -1.5f;
            Assert.AreEqual(-1.5f, v[0]);
            v[1] = -0.5f;
            Assert.AreEqual(-0.5f, v[1]);
            v[0] = 0.5f;
            Assert.AreEqual(0.5f, v[0]);
            v[1] = 1.5f;
            Assert.AreEqual(1.5f, v[1]);
            v[1] = 2.5f;
            Assert.AreEqual(2.5f, v[1]);
            v[0] = 3.5f;
            Assert.AreEqual(3.5f, v[0]);
            v[0] = 4.5f;
            Assert.AreEqual(4.5f, v[0]);
            v[1] = 5.5f;
            Assert.AreEqual(5.5f, v[1]);
            v[1] = 6.5f;
            Assert.AreEqual(6.5f, v[1]);
            v[0] = 7.5f;
            Assert.AreEqual(7.5f, v[0]);
            v[0] = 8.5f;
            Assert.AreEqual(8.5f, v[0]);
            v[0] = 9.5f;
            Assert.AreEqual(9.5f, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new float2(7.5f, -5.5f);
            var vals = v.Values;
            Assert.AreEqual(7.5f, vals[0]);
            Assert.AreEqual(-5.5f, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0f, float2.Zero.x);
            Assert.AreEqual(0f, float2.Zero.y);
            
            Assert.AreEqual(1f, float2.Ones.x);
            Assert.AreEqual(1f, float2.Ones.y);
            
            Assert.AreEqual(1f, float2.UnitX.x);
            Assert.AreEqual(0f, float2.UnitX.y);
            
            Assert.AreEqual(0f, float2.UnitY.x);
            Assert.AreEqual(1f, float2.UnitY.y);
            
            Assert.AreEqual(float.MaxValue, float2.MaxValue.x);
            Assert.AreEqual(float.MaxValue, float2.MaxValue.y);
            
            Assert.AreEqual(float.MinValue, float2.MinValue.x);
            Assert.AreEqual(float.MinValue, float2.MinValue.y);
            
            Assert.AreEqual(float.Epsilon, float2.Epsilon.x);
            Assert.AreEqual(float.Epsilon, float2.Epsilon.y);
            
            Assert.AreEqual(float.NaN, float2.NaN.x);
            Assert.AreEqual(float.NaN, float2.NaN.y);
            
            Assert.AreEqual(float.NegativeInfinity, float2.NegativeInfinity.x);
            Assert.AreEqual(float.NegativeInfinity, float2.NegativeInfinity.y);
            
            Assert.AreEqual(float.PositiveInfinity, float2.PositiveInfinity.x);
            Assert.AreEqual(float.PositiveInfinity, float2.PositiveInfinity.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new float2(8.5f, 3.5f);
            var v2 = new float2(8.5f, 3.5f);
            var v3 = new float2(3.5f, 8.5f);
            Assert.That(v1 == new float2(v1));
            Assert.That(v2 == new float2(v2));
            Assert.That(v3 == new float2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new float2(-9f, -6.5f);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = float2.Parse(s0);
            var v1 = float2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = float2.TryParse(s0, out v0);
            var b1 = float2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = float2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = float2.TryParse("", out v0);
            Assert.False(b0);
            b0 = float2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { float2.Parse(null); });
            Assert.Throws<FormatException>(() => { float2.Parse(""); });
            Assert.Throws<FormatException>(() => { float2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = float2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = float2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = float2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new float2(-8.5f, 5.5f);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<float2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new float2(-9.5f, 9f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(-1f, 9f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(-6f, 2.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(3f, -3f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(-5.5f, 4.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(-4.5f, -7.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(-1f, -1.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(1f, 0f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(-5.5f, -1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new float2(8f, 6f);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new float2(2.5f, -6.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(3f, -2f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(3.5f, -3f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(-1f, 8f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(3.5f, -6.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(5.5f, -8.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(1f, 3f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(-9.5f, 5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(3f, -6f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new float2(8.5f, -5.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new float2(9.5f, 8f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(5f, 1f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(8.5f, 2f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(-6f, 0f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(4.5f, 5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(7f, 5.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(4.5f, 2f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(-2.5f, 9f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(6f, 1.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new float2(8f, -8f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new float2(8f, 9f);
                var v1 = new float2(4f, -8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(8.5f, -0.5f);
                var v1 = new float2(3.5f, 8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(6.5f, 7.5f);
                var v1 = new float2(-1.5f, 9.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(5.5f, -5.5f);
                var v1 = new float2(-8f, 7.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(-9f, 4f);
                var v1 = new float2(2f, -6.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(1f, 9f);
                var v1 = new float2(-1f, -3.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(-2.5f, -2f);
                var v1 = new float2(3.5f, -6f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(-7f, -2.5f);
                var v1 = new float2(9.5f, -4.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(6.5f, 9.5f);
                var v1 = new float2(0.5f, -6f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new float2(9.5f, 4f);
                var v1 = new float2(-2.5f, -0.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new float2(4f, 7f);
                var v1 = new float2(2.5f, -9f);
                var v2 = new float2(6.5f, -7f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(-0.5f, 4f);
                var v1 = new float2(-8.5f, 5f);
                var v2 = new float2(-2f, 9.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(-3.5f, -0.5f);
                var v1 = new float2(-3.5f, 9f);
                var v2 = new float2(1.5f, 3f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(0f, 2.5f);
                var v1 = new float2(3f, -7f);
                var v2 = new float2(2f, -7f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(5.5f, 6f);
                var v1 = new float2(-8f, -2f);
                var v2 = new float2(9.5f, -2.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(-9.5f, -8.5f);
                var v1 = new float2(4f, -7f);
                var v2 = new float2(-3f, 9.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(5.5f, -8.5f);
                var v1 = new float2(-4f, -7f);
                var v2 = new float2(-1f, 4f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(5.5f, -2f);
                var v1 = new float2(-3.5f, -1f);
                var v2 = new float2(6f, -1.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(8f, -9.5f);
                var v1 = new float2(-2f, 3.5f);
                var v2 = new float2(6.5f, -2f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new float2(4f, -1.5f);
                var v1 = new float2(5f, -5f);
                var v2 = new float2(-6.5f, 0.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new float2(7f, -3f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(0.5f, 7f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(7.5f, 7.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(2f, -7.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(0.5f, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(-1f, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(-3.5f, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(6f, -9.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(7f, -1.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new float2(3.5f, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new float2(-3f, 7.5f);
                var v1 = new float2(-5.5f, -3.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(-2.5f, 7.5f);
                var v1 = new float2(-5.5f, -5.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(7f, -7f);
                var v1 = new float2(1f, 8f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(9f, -4.5f);
                var v1 = new float2(5f, 9f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(3.5f, 7.5f);
                var v1 = new float2(8.5f, -3.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(8.5f, 0f);
                var v1 = new float2(-3.5f, 2f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(-1.5f, 3.5f);
                var v1 = new float2(-3.5f, 3.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(-9.5f, 0f);
                var v1 = new float2(2.5f, -2.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(-2.5f, -6f);
                var v1 = new float2(-0.5f, 6f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new float2(7f, -5f);
                var v1 = new float2(-8f, -4f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new float2(-1f, 1f);
                var v1 = new float2(4f, -3.5f);
                var v2 = new float2(4.5f, -6f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(6f, 7f);
                var v1 = new float2(1f, 9f);
                var v2 = new float2(2f, -5.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(4f, -2.5f);
                var v1 = new float2(4f, 5.5f);
                var v2 = new float2(1.5f, 4f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(1f, -0.5f);
                var v1 = new float2(5f, -0.5f);
                var v2 = new float2(6f, 7.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(-5.5f, 7.5f);
                var v1 = new float2(4.5f, -4.5f);
                var v2 = new float2(0.5f, 8f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(3.5f, 6f);
                var v1 = new float2(-8f, -6f);
                var v2 = new float2(-1f, 5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(-4f, 9f);
                var v1 = new float2(9f, 3.5f);
                var v2 = new float2(7.5f, -4.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(6.5f, 7f);
                var v1 = new float2(4.5f, 2.5f);
                var v2 = new float2(4.5f, 4.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(6.5f, 6.5f);
                var v1 = new float2(7f, 2.5f);
                var v2 = new float2(-1f, -4.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new float2(7f, -7.5f);
                var v1 = new float2(5.5f, 7f);
                var v2 = new float2(2f, 6.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new float2(4f, 6f);
                var v1 = new float2(4f, -4f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(-7.5f, 8f);
                var v1 = new float2(-1f, 7.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(9.5f, -6f);
                var v1 = new float2(5.5f, -6f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(1.5f, -6f);
                var v1 = new float2(-6f, -8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(7.5f, -9f);
                var v1 = new float2(-6.5f, 8f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(1f, -2f);
                var v1 = new float2(3f, 3f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(-7f, -4.5f);
                var v1 = new float2(2.5f, 9.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(4f, 8.5f);
                var v1 = new float2(3f, -2f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(0.5f, 7f);
                var v1 = new float2(2.5f, -7f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new float2(1f, -7.5f);
                var v1 = new float2(-2f, -5.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new float2(-8f, 5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(-0.5f, -7f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(-9.5f, 6.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(1.5f, 9.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(0f, -7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(2f, 6f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(6f, 8f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(0.5f, -9.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(-3.5f, 9f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new float2(-1.5f, 5.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(236467850);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.Random(random, -1, 2);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(467782784);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomUniform(random, 4, 5);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(698728900);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.Random(random, 0, 4);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            
            Assert.AreEqual(variance.x, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.3333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(368749223);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomUniform(random, 1, 5);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            
            Assert.AreEqual(variance.x, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.3333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1411722177);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.Random(random, -3, -2);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2.5, 1.0);
            Assert.AreEqual(avg.y, -2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1209066187);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomNormal(random, -0.7829248433853149f, 4.774792936991338f);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.7829248433853149, 1.0);
            Assert.AreEqual(avg.y, -0.7829248433853149, 1.0);
            
            Assert.AreEqual(variance.x, 4.774792936991338, 3.0);
            Assert.AreEqual(variance.y, 4.774792936991338, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(639650869);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomGaussian(random, 1.257362283420452f, 2.6465906308249525f);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.257362283420452, 1.0);
            Assert.AreEqual(avg.y, 1.257362283420452, 1.0);
            
            Assert.AreEqual(variance.x, 2.6465906308249525, 3.0);
            Assert.AreEqual(variance.y, 2.6465906308249525, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1027336644);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomNormal(random, 1.7675580250879555f, 7.160300327073923f);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.7675580250879555, 1.0);
            Assert.AreEqual(avg.y, 1.7675580250879555, 1.0);
            
            Assert.AreEqual(variance.x, 7.160300327073923, 3.0);
            Assert.AreEqual(variance.y, 7.160300327073923, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(849091546);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomGaussian(random, -1.7133045735365267f, 6.0892355656666854f);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.7133045735365267, 1.0);
            Assert.AreEqual(avg.y, -1.7133045735365267, 1.0);
            
            Assert.AreEqual(variance.x, 6.0892355656666854, 3.0);
            Assert.AreEqual(variance.y, 6.0892355656666854, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1591975894);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomNormal(random, -1.1748055197181206f, 5.957678000422976f);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.1748055197181206, 1.0);
            Assert.AreEqual(avg.y, -1.1748055197181206, 1.0);
            
            Assert.AreEqual(variance.x, 5.957678000422976, 3.0);
            Assert.AreEqual(variance.y, 5.957678000422976, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(1812187584);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomNormal(random);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(1383738131);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomNormal(random);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(1656752634);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomNormal(random);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(211236369);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomNormal(random);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(2115465384);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = float2.RandomNormal(random);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

    }
}
