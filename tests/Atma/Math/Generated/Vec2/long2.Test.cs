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
                var v = new long2(1);
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
            }
            {
                var v = new long2(3L, 5L);
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var v = new long2(new long2(-7L, -7L));
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
            }
            {
                var v = new long2(new long3(-3L, 6L, 6L));
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(6L, v.y);
            }
            {
                var v = new long2(new long4(2L, 5L, -6L, -7L));
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(5L, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new long2(-8L, -3L);
            Assert.AreEqual(-8L, v[0]);
            Assert.AreEqual(-3L, v[1]);
            
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
            
            v[0] = 0;
            Assert.AreEqual(0, v[0]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
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
            v[0] = 8L;
            Assert.AreEqual(8L, v[0]);
            v[0] = 9L;
            Assert.AreEqual(9L, v[0]);
            v[1] = -1L;
            Assert.AreEqual(-1L, v[1]);
            v[0] = -2L;
            Assert.AreEqual(-2L, v[0]);
            v[1] = -3L;
            Assert.AreEqual(-3L, v[1]);
            v[0] = -4L;
            Assert.AreEqual(-4L, v[0]);
            v[0] = -5L;
            Assert.AreEqual(-5L, v[0]);
            v[0] = -6L;
            Assert.AreEqual(-6L, v[0]);
            v[1] = -7L;
            Assert.AreEqual(-7L, v[1]);
            v[1] = -8L;
            Assert.AreEqual(-8L, v[1]);
            v[0] = -9L;
            Assert.AreEqual(-9L, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new long2(9L, -3L);
            var vals = v.Values;
            Assert.AreEqual(9L, vals[0]);
            Assert.AreEqual(-3L, vals[1]);
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
            var v1 = new long2(9L, -8L);
            var v2 = new long2(9L, -8L);
            var v3 = new long2(-8L, 9L);
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
            var v = new long2(0, -3L);
            
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
            var v0 = new long2(7L, 5L);
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
                var v0 = new long2(0, 5L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(7L, -2L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(7L, -3L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(-3L, 5L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(-8L, 4L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(2L, -6L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(4L, 4L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(-6L, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(0, -8L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long2(1, -3L);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new long2(6L, -3L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(3L, -4L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(-6L, 2L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(-7L, 3L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(2L, -9L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(6L, -5L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(-9L, -2L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(5L, 2L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(9L, 0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long2(-6L, 1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new long2(-1L, 5L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(4L, 8L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-8L, -7L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(0, -9L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(3L, 9L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-3L, 2L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-6L, -2L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(8L, 4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(-2L, 8L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long2(1, -8L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new long2(5L, -6L);
                var v1 = new long2(-5L, -1L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(2L, 3L);
                var v1 = new long2(-8L, -1L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(-1L, -5L);
                var v1 = new long2(9L, 5L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(-5L, -5L);
                var v1 = new long2(3L, 0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(2L, 4L);
                var v1 = new long2(6L, 7L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(3L, -4L);
                var v1 = new long2(4L, 1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(-2L, -6L);
                var v1 = new long2(-4L, -7L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(7L, -5L);
                var v1 = new long2(-6L, -8L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(4L, 6L);
                var v1 = new long2(3L, 6L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long2(-3L, 6L);
                var v1 = new long2(5L, -1L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new long2(-6L, -9L);
                var v1 = new long2(0, -3L);
                var v2 = new long2(8L, -3L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(7L, -6L);
                var v1 = new long2(6L, -5L);
                var v2 = new long2(5L, 5L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(0, -4L);
                var v1 = new long2(-8L, 1);
                var v2 = new long2(7L, 9L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(-1L, 2L);
                var v1 = new long2(6L, 2L);
                var v2 = new long2(9L, 1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(-9L, 7L);
                var v1 = new long2(4L, 5L);
                var v2 = new long2(-4L, 6L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(5L, -8L);
                var v1 = new long2(3L, 3L);
                var v2 = new long2(3L, -5L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(-9L, -7L);
                var v1 = new long2(-4L, 7L);
                var v2 = new long2(6L, 9L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(3L, 9L);
                var v1 = new long2(7L, 9L);
                var v2 = new long2(5L, -6L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(-8L, 0);
                var v1 = new long2(-1L, -6L);
                var v2 = new long2(-3L, 4L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long2(8L, -3L);
                var v1 = new long2(8L, -8L);
                var v2 = new long2(-4L, 0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new long2(-5L, -6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(1, -9L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(7L, 2L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(0, 6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(2L, 5L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(6L, -3L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(0, -6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(7L, -6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(-9L, -7L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long2(-4L, 5L);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new long2(-7L, -9L);
                var v1 = new long2(-4L, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(-3L, -5L);
                var v1 = new long2(3L, -1L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(9L, -6L);
                var v1 = new long2(9L, 8L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(3L, 3L);
                var v1 = new long2(-8L, 5L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(4L, -2L);
                var v1 = new long2(-6L, 2L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(7L, -3L);
                var v1 = new long2(7L, 5L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(7L, -2L);
                var v1 = new long2(-2L, -7L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(8L, -5L);
                var v1 = new long2(3L, -4L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(-5L, -6L);
                var v1 = new long2(3L, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long2(0, 2L);
                var v1 = new long2(8L, -1L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new long2(-4L, -3L);
                var v1 = new long2(9L, -7L);
                var v2 = new long2(9L, -1L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(4L, -3L);
                var v1 = new long2(4L, -4L);
                var v2 = new long2(-9L, -1L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(2L, -6L);
                var v1 = new long2(-2L, 3L);
                var v2 = new long2(6L, -1L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(3L, 7L);
                var v1 = new long2(-8L, -2L);
                var v2 = new long2(-1L, 7L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(9L, -7L);
                var v1 = new long2(-9L, -6L);
                var v2 = new long2(5L, -3L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-8L, -5L);
                var v1 = new long2(4L, 0);
                var v2 = new long2(9L, 4L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-1L, 4L);
                var v1 = new long2(8L, 6L);
                var v2 = new long2(-9L, 3L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-3L, 6L);
                var v1 = new long2(-5L, 6L);
                var v2 = new long2(-4L, 9L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(-4L, -4L);
                var v1 = new long2(-6L, 6L);
                var v2 = new long2(1, 3L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long2(8L, 2L);
                var v1 = new long2(1, 2L);
                var v2 = new long2(6L, -3L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new long2(-1L, 5L);
                var v1 = new long2(-9L, 6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-6L, -3L);
                var v1 = new long2(1, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-5L, -8L);
                var v1 = new long2(1, 4L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(7L, -8L);
                var v1 = new long2(-3L, 5L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(2L, -8L);
                var v1 = new long2(2L, -6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-6L, 0);
                var v1 = new long2(3L, 2L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(0, 7L);
                var v1 = new long2(-5L, 2L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-6L, -5L);
                var v1 = new long2(-5L, -6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(-5L, -5L);
                var v1 = new long2(-7L, 5L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long2(9L, 8L);
                var v1 = new long2(9L, -6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new long2(-8L, 1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-3L, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-1L, 1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(3L, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-4L, 2L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-2L, -9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(3L, -3L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-9L, 9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(4L, -2L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long2(-7L, 7L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1913881134);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.Random(random, 4, 6);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1436624892);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomUniform(random, 2, 5);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1877370439);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.Random(random, 0, 5);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1337591331);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomUniform(random, 1, 3);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(233080638);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.Random(random, -4, 1);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(2094080072);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 1.2097438246522767);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.2097438246522767, 1.0);
            Assert.AreEqual(avg.y, 1.2097438246522767, 1.0);
            
            Assert.AreEqual(variance.x, 1.2097438246522767, 3.0);
            Assert.AreEqual(variance.y, 1.2097438246522767, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(1518290883);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 2.7467499544130405);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.7467499544130405, 1.0);
            Assert.AreEqual(avg.y, 2.7467499544130405, 1.0);
            
            Assert.AreEqual(variance.x, 2.7467499544130405, 3.0);
            Assert.AreEqual(variance.y, 2.7467499544130405, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(304723139);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 3.0750638253870717);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.0750638253870717, 1.0);
            Assert.AreEqual(avg.y, 3.0750638253870717, 1.0);
            
            Assert.AreEqual(variance.x, 3.0750638253870717, 3.0);
            Assert.AreEqual(variance.y, 3.0750638253870717, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(45176425);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 2.2261736158869105);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.2261736158869105, 1.0);
            Assert.AreEqual(avg.y, 2.2261736158869105, 1.0);
            
            Assert.AreEqual(variance.x, 2.2261736158869105, 3.0);
            Assert.AreEqual(variance.y, 2.2261736158869105, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(2003883125);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long2.RandomPoisson(random, 1.175962243078259);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.175962243078259, 1.0);
            Assert.AreEqual(avg.y, 1.175962243078259, 1.0);
            
            Assert.AreEqual(variance.x, 1.175962243078259, 3.0);
            Assert.AreEqual(variance.y, 1.175962243078259, 3.0);
        }

    }
}
