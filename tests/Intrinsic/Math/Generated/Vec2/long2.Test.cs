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
    public class LongVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new long2(-7L);
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
            }
            {
                var v = new long2(-3L, 5L);
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var v = new long2(new long2(3L, -1L));
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-1L, v.y);
            }
            {
                var v = new long2(new long3(6L, 5L, -4L));
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var v = new long2(new long4(7L, 0, 4L, 2L));
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(0, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new long2(-7L, -9L);
            Assert.AreEqual(-7L, v[0]);
            Assert.AreEqual(-9L, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[1] = 1;
            Assert.AreEqual(1, v[1]);
            v[1] = 2L;
            Assert.AreEqual(2L, v[1]);
            v[1] = 3L;
            Assert.AreEqual(3L, v[1]);
            v[0] = 4L;
            Assert.AreEqual(4L, v[0]);
            v[0] = 5L;
            Assert.AreEqual(5L, v[0]);
            v[1] = 6L;
            Assert.AreEqual(6L, v[1]);
            v[0] = 7L;
            Assert.AreEqual(7L, v[0]);
            v[1] = 8L;
            Assert.AreEqual(8L, v[1]);
            v[0] = 9L;
            Assert.AreEqual(9L, v[0]);
            v[0] = -1L;
            Assert.AreEqual(-1L, v[0]);
            v[1] = -2L;
            Assert.AreEqual(-2L, v[1]);
            v[0] = -3L;
            Assert.AreEqual(-3L, v[0]);
            v[1] = -4L;
            Assert.AreEqual(-4L, v[1]);
            v[1] = -5L;
            Assert.AreEqual(-5L, v[1]);
            v[1] = -6L;
            Assert.AreEqual(-6L, v[1]);
            v[1] = -7L;
            Assert.AreEqual(-7L, v[1]);
            v[1] = -8L;
            Assert.AreEqual(-8L, v[1]);
            v[1] = -9L;
            Assert.AreEqual(-9L, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new long2(6L, -7L);
            var vals = v.Values;
            Assert.AreEqual(6L, vals[0]);
            Assert.AreEqual(-7L, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, long2.Zero.x);
            Assert.AreEqual(0, long2.Zero.y);
            
            Assert.AreEqual(1, long2.Ones.x);
            Assert.AreEqual(1, long2.Ones.y);
            
            Assert.AreEqual(1, long2.UnitX.x);
            Assert.AreEqual(0, long2.UnitX.y);
            
            Assert.AreEqual(0, long2.UnitY.x);
            Assert.AreEqual(1, long2.UnitY.y);
            
            Assert.AreEqual(long.MaxValue, long2.MaxValue.x);
            Assert.AreEqual(long.MaxValue, long2.MaxValue.y);
            
            Assert.AreEqual(long.MinValue, long2.MinValue.x);
            Assert.AreEqual(long.MinValue, long2.MinValue.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new long2(8L, -5L);
            var v2 = new long2(8L, -5L);
            var v3 = new long2(-5L, 8L);
            Assert.That(v1 == new long2(v1));
            Assert.That(v2 == new long2(v2));
            Assert.That(v3 == new long2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new long2(-2L, -5L);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = long2.Parse(s0);
            var v1 = long2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = long2.TryParse(s0, out v0);
            var b1 = long2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = long2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = long2.TryParse("", out v0);
            Assert.False(b0);
            b0 = long2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { long2.Parse(null); });
            Assert.Throws<FormatException>(() => { long2.Parse(""); });
            Assert.Throws<FormatException>(() => { long2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = long2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = long2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = long2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new long2(8L, -9L);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<long2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new long2(7L, 5L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(2L, -1L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(-7L, 8L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(5L, -9L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(4L, -3L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(6L, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(-6L, 7L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(-8L, 5L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(0, 9L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(0, -4L);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new long2(-8L, 2L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(-9L, -2L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(-6L, -2L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(6L, 4L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(9L, 8L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(5L, 4L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(-7L, 5L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(3L, 3L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(-4L, 0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(2L, 8L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new long2(4L, 8L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-4L, 4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(7L, 3L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-4L, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-1L, 7L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(3L, -6L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-1L, 9L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-5L, -4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-4L, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-2L, 2L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new long2(4L, 8L);
                var v1 = new long2(1, -8L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(-1L, -9L);
                var v1 = new long2(5L, -9L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(2L, 3L);
                var v1 = new long2(9L, 3L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(1, 4L);
                var v1 = new long2(5L, 5L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(-3L, -9L);
                var v1 = new long2(1, -3L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(7L, 7L);
                var v1 = new long2(-9L, -2L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(-8L, 8L);
                var v1 = new long2(2L, -5L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(4L, -2L);
                var v1 = new long2(-8L, 1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(-9L, 0);
                var v1 = new long2(-3L, 9L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(4L, -8L);
                var v1 = new long2(1, -4L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new long2(-3L, -2L);
                var v1 = new long2(-7L, -5L);
                var v2 = new long2(4L, -7L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(0, -7L);
                var v1 = new long2(-7L, 9L);
                var v2 = new long2(1, 8L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(-8L, -3L);
                var v1 = new long2(8L, 8L);
                var v2 = new long2(1, -6L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(-7L, -4L);
                var v1 = new long2(3L, -4L);
                var v2 = new long2(5L, 2L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(0, -4L);
                var v1 = new long2(1, 5L);
                var v2 = new long2(3L, -9L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(2L, -4L);
                var v1 = new long2(5L, -7L);
                var v2 = new long2(4L, -2L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(5L, -3L);
                var v1 = new long2(6L, 2L);
                var v2 = new long2(3L, 0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(-4L, -3L);
                var v1 = new long2(-1L, -9L);
                var v2 = new long2(-4L, -5L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(-3L, -8L);
                var v1 = new long2(9L, -9L);
                var v2 = new long2(3L, 8L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(8L, -8L);
                var v1 = new long2(5L, -4L);
                var v2 = new long2(-5L, 9L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new long2(7L, 3L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(1, -2L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(2L, -6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(2L, -7L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(4L, 8L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(-1L, -2L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(-8L, 1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(-5L, -9L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(4L, -3L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(9L, 6L);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new long2(-6L, -1L);
                var v1 = new long2(-3L, 8L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(6L, 9L);
                var v1 = new long2(-2L, -3L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(-4L, 3L);
                var v1 = new long2(4L, -3L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(-6L, -5L);
                var v1 = new long2(-9L, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(7L, -3L);
                var v1 = new long2(-4L, 1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(7L, -8L);
                var v1 = new long2(-8L, 4L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(1, -3L);
                var v1 = new long2(-6L, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(1, -9L);
                var v1 = new long2(3L, -9L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(-4L, 4L);
                var v1 = new long2(-8L, 8L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(-4L, -1L);
                var v1 = new long2(6L, 2L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new long2(-4L, -9L);
                var v1 = new long2(-8L, 2L);
                var v2 = new long2(5L, -2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-4L, 7L);
                var v1 = new long2(2L, 8L);
                var v2 = new long2(3L, -9L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-5L, -9L);
                var v1 = new long2(-2L, 3L);
                var v2 = new long2(7L, 4L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-5L, -9L);
                var v1 = new long2(2L, 3L);
                var v2 = new long2(-5L, -5L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-4L, 2L);
                var v1 = new long2(-7L, 3L);
                var v2 = new long2(9L, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-3L, -1L);
                var v1 = new long2(5L, -6L);
                var v2 = new long2(9L, 2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(6L, 0);
                var v1 = new long2(9L, 2L);
                var v2 = new long2(-6L, -7L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-7L, 5L);
                var v1 = new long2(-5L, 8L);
                var v2 = new long2(3L, -8L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-5L, -5L);
                var v1 = new long2(-5L, -7L);
                var v2 = new long2(6L, 4L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(2L, 9L);
                var v1 = new long2(4L, 3L);
                var v2 = new long2(7L, 2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new long2(-6L, 5L);
                var v1 = new long2(-3L, 7L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-3L, 6L);
                var v1 = new long2(2L, -3L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(2L, 0);
                var v1 = new long2(-8L, -9L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(0, 1);
                var v1 = new long2(9L, 6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-7L, -2L);
                var v1 = new long2(-9L, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-4L, -5L);
                var v1 = new long2(2L, 6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(2L, -1L);
                var v1 = new long2(6L, -3L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-2L, -3L);
                var v1 = new long2(-8L, 4L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-3L, 8L);
                var v1 = new long2(7L, -6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-7L, 1);
                var v1 = new long2(5L, 2L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new long2(-6L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(5L, 9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-4L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-2L, -1L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(9L, -9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-7L, -7L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(0, -4L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(5L, 1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(3L, -8L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(8L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(2096862586);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.Random(random, -2, 1);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(312862194);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomUniform(random, 1, 6);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1543360271);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.Random(random, -2, 0);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1918565304);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomUniform(random, -1, 4);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1, 1.0);
            Assert.AreEqual(avg.y, 1, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(29892466);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.Random(random, 0, 4);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1298102534);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 2.2529202870805376);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.2529202870805376, 1.0);
            Assert.AreEqual(avg.y, 2.2529202870805376, 1.0);
            
            Assert.AreEqual(variance.x, 2.2529202870805376, 3.0);
            Assert.AreEqual(variance.y, 2.2529202870805376, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(1675547755);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 3.212123186193464);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.212123186193464, 1.0);
            Assert.AreEqual(avg.y, 3.212123186193464, 1.0);
            
            Assert.AreEqual(variance.x, 3.212123186193464, 3.0);
            Assert.AreEqual(variance.y, 3.212123186193464, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(829932481);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 2.517144226477083);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.517144226477083, 1.0);
            Assert.AreEqual(avg.y, 2.517144226477083, 1.0);
            
            Assert.AreEqual(variance.x, 2.517144226477083, 3.0);
            Assert.AreEqual(variance.y, 2.517144226477083, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1251837730);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 1.6775663700781607);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.6775663700781607, 1.0);
            Assert.AreEqual(avg.y, 1.6775663700781607, 1.0);
            
            Assert.AreEqual(variance.x, 1.6775663700781607, 3.0);
            Assert.AreEqual(variance.y, 1.6775663700781607, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(512379387);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 0.5527576920822066);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5527576920822066, 1.0);
            Assert.AreEqual(avg.y, 0.5527576920822066, 1.0);
            
            Assert.AreEqual(variance.x, 0.5527576920822066, 3.0);
            Assert.AreEqual(variance.y, 0.5527576920822066, 3.0);
        }

    }
}
