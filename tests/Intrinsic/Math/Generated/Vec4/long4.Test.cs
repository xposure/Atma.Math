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
using Intrinsic.Math;

// ReSharper disable InconsistentNaming

namespace  Intrinsic.Math.Generated.Vec4
{
    [TestFixture]
    public class LongVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new long4(9L);
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var v = new long4(-6L, 6L, -5L, 6L);
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var v = new long4(new long2(-9L, -9L));
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new long4(new long3(8L, 7L, 5L));
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new long4(new long4(9L, -8L, -7L, -7L));
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new long4(-1L, 9L, 2L, 5L);
            Assert.AreEqual(-1L, v[0]);
            Assert.AreEqual(9L, v[1]);
            Assert.AreEqual(2L, v[2]);
            Assert.AreEqual(5L, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[3] = 1;
            Assert.AreEqual(1, v[3]);
            v[3] = 2L;
            Assert.AreEqual(2L, v[3]);
            v[3] = 3L;
            Assert.AreEqual(3L, v[3]);
            v[0] = 4L;
            Assert.AreEqual(4L, v[0]);
            v[0] = 5L;
            Assert.AreEqual(5L, v[0]);
            v[3] = 6L;
            Assert.AreEqual(6L, v[3]);
            v[3] = 7L;
            Assert.AreEqual(7L, v[3]);
            v[3] = 8L;
            Assert.AreEqual(8L, v[3]);
            v[0] = 9L;
            Assert.AreEqual(9L, v[0]);
            v[0] = -1L;
            Assert.AreEqual(-1L, v[0]);
            v[1] = -2L;
            Assert.AreEqual(-2L, v[1]);
            v[1] = -3L;
            Assert.AreEqual(-3L, v[1]);
            v[1] = -4L;
            Assert.AreEqual(-4L, v[1]);
            v[1] = -5L;
            Assert.AreEqual(-5L, v[1]);
            v[1] = -6L;
            Assert.AreEqual(-6L, v[1]);
            v[0] = -7L;
            Assert.AreEqual(-7L, v[0]);
            v[0] = -8L;
            Assert.AreEqual(-8L, v[0]);
            v[3] = -9L;
            Assert.AreEqual(-9L, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new long4(0, -2L, 1, -2L);
            var vals = v.Values;
            Assert.AreEqual(0, vals[0]);
            Assert.AreEqual(-2L, vals[1]);
            Assert.AreEqual(1, vals[2]);
            Assert.AreEqual(-2L, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, long4.Zero.x);
            Assert.AreEqual(0, long4.Zero.y);
            Assert.AreEqual(0, long4.Zero.z);
            Assert.AreEqual(0, long4.Zero.w);
            
            Assert.AreEqual(1, long4.Ones.x);
            Assert.AreEqual(1, long4.Ones.y);
            Assert.AreEqual(1, long4.Ones.z);
            Assert.AreEqual(1, long4.Ones.w);
            
            Assert.AreEqual(1, long4.UnitX.x);
            Assert.AreEqual(0, long4.UnitX.y);
            Assert.AreEqual(0, long4.UnitX.z);
            Assert.AreEqual(0, long4.UnitX.w);
            
            Assert.AreEqual(0, long4.UnitY.x);
            Assert.AreEqual(1, long4.UnitY.y);
            Assert.AreEqual(0, long4.UnitY.z);
            Assert.AreEqual(0, long4.UnitY.w);
            
            Assert.AreEqual(0, long4.UnitZ.x);
            Assert.AreEqual(0, long4.UnitZ.y);
            Assert.AreEqual(1, long4.UnitZ.z);
            Assert.AreEqual(0, long4.UnitZ.w);
            
            Assert.AreEqual(0, long4.UnitW.x);
            Assert.AreEqual(0, long4.UnitW.y);
            Assert.AreEqual(0, long4.UnitW.z);
            Assert.AreEqual(1, long4.UnitW.w);
            
            Assert.AreEqual(long.MaxValue, long4.MaxValue.x);
            Assert.AreEqual(long.MaxValue, long4.MaxValue.y);
            Assert.AreEqual(long.MaxValue, long4.MaxValue.z);
            Assert.AreEqual(long.MaxValue, long4.MaxValue.w);
            
            Assert.AreEqual(long.MinValue, long4.MinValue.x);
            Assert.AreEqual(long.MinValue, long4.MinValue.y);
            Assert.AreEqual(long.MinValue, long4.MinValue.z);
            Assert.AreEqual(long.MinValue, long4.MinValue.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new long4(1, -2L, -3L, 3L);
            var v2 = new long4(1, -2L, -3L, 3L);
            var v3 = new long4(3L, -3L, -2L, 1);
            Assert.That(v1 == new long4(v1));
            Assert.That(v2 == new long4(v2));
            Assert.That(v3 == new long4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new long4(-1L, -1L, 8L, -4L);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = long4.Parse(s0);
            var v1 = long4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = long4.TryParse(s0, out v0);
            var b1 = long4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = long4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = long4.TryParse("", out v0);
            Assert.False(b0);
            b0 = long4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { long4.Parse(null); });
            Assert.Throws<FormatException>(() => { long4.Parse(""); });
            Assert.Throws<FormatException>(() => { long4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = long4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = long4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = long4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new long4(9L, 2L, -5L, -5L);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<long4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new long4(2L, 1, -3L, 2L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(-9L, 4L, -9L, -3L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(2L, -7L, -1L, 6L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(-7L, -1L, 3L, -7L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(8L, -4L, -4L, 7L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(6L, 5L, 5L, 8L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(6L, 3L, 4L, -6L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(4L, 4L, -1L, 8L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(-9L, 9L, -8L, -8L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new long4(1, -1L, 8L, 1);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new long4(-7L, -9L, 1, 9L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(6L, -5L, -5L, 8L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(5L, 3L, 7L, 7L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(-6L, 6L, 8L, 7L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(-6L, 0, -6L, -5L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(-9L, 8L, 7L, -7L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(2L, 9L, 0, 6L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(-8L, 3L, -9L, 0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(9L, -4L, 8L, -5L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new long4(-2L, 7L, -2L, -8L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new long4(2L, 0, -9L, -5L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(9L, 1, -2L, 0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(4L, -8L, 9L, 4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(-3L, 8L, 8L, -1L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(2L, -9L, 7L, -5L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(6L, 4L, -6L, 3L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(3L, -7L, -5L, -1L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(-6L, 9L, 3L, 4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(-7L, -8L, -1L, -6L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new long4(-7L, 6L, 7L, 4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new long4(2L, 7L, 5L, -4L);
                var v1 = new long4(-1L, -5L, -5L, 7L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(-2L, 9L, -9L, -9L);
                var v1 = new long4(-7L, 1, -4L, -6L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(4L, -1L, 7L, -1L);
                var v1 = new long4(8L, 8L, -8L, 5L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(-8L, 4L, 9L, -6L);
                var v1 = new long4(1, -5L, 3L, -2L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(9L, -6L, -3L, -8L);
                var v1 = new long4(9L, -1L, -7L, 1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(-8L, 2L, -1L, 7L);
                var v1 = new long4(-7L, 4L, 9L, 7L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(2L, 3L, 5L, -4L);
                var v1 = new long4(-9L, -7L, 1, -3L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(9L, 0, -6L, 5L);
                var v1 = new long4(5L, -9L, 6L, -7L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(6L, 6L, 8L, 0);
                var v1 = new long4(8L, -5L, 5L, -4L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new long4(-3L, 5L, -2L, 6L);
                var v1 = new long4(-7L, 9L, 7L, -3L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new long4(-4L, -5L, -4L, -8L);
                var v1 = new long4(-5L, -4L, -2L, -3L);
                var v2 = new long4(1, -5L, -9L, 5L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(-9L, -2L, 4L, 4L);
                var v1 = new long4(-9L, -5L, 3L, 7L);
                var v2 = new long4(5L, -3L, 2L, 2L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(-6L, 2L, -8L, 8L);
                var v1 = new long4(-3L, 6L, 9L, 6L);
                var v2 = new long4(-5L, -1L, 9L, 3L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(-6L, 5L, -7L, -3L);
                var v1 = new long4(-1L, 1, -2L, -9L);
                var v2 = new long4(4L, -9L, 0, -2L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(-2L, -6L, -2L, -5L);
                var v1 = new long4(-5L, 6L, 7L, 0);
                var v2 = new long4(-3L, -2L, 1, -2L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(-6L, 2L, -9L, -4L);
                var v1 = new long4(5L, -3L, -1L, 8L);
                var v2 = new long4(2L, 0, 8L, -3L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(-8L, -1L, -6L, 3L);
                var v1 = new long4(0, 2L, -8L, -7L);
                var v2 = new long4(2L, 5L, -7L, -7L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(-5L, -4L, -1L, 8L);
                var v1 = new long4(3L, 8L, 9L, 4L);
                var v2 = new long4(4L, 5L, -6L, 8L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(1, -8L, -4L, -2L);
                var v1 = new long4(8L, -2L, 9L, -1L);
                var v2 = new long4(7L, -8L, -7L, 3L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new long4(9L, 3L, 0, 9L);
                var v1 = new long4(-3L, 3L, 9L, 9L);
                var v2 = new long4(4L, 1, -8L, -1L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new long4(6L, 0, 3L, 8L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(-3L, -9L, -1L, 2L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(1, 3L, -3L, -5L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(-7L, 2L, 0, 3L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(6L, -3L, 3L, -2L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(-6L, 9L, 6L, 7L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(6L, -6L, 7L, 6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(6L, -5L, -3L, 5L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(3L, 9L, -1L, -8L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new long4(3L, 3L, 9L, 3L);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new long4(-7L, -4L, -1L, -2L);
                var v1 = new long4(-7L, 6L, 2L, 8L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(-7L, 8L, 1, 9L);
                var v1 = new long4(-7L, -4L, -5L, -6L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(5L, -2L, 0, -5L);
                var v1 = new long4(8L, -6L, -4L, 4L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(-8L, 1, -3L, 2L);
                var v1 = new long4(-1L, 6L, 9L, -2L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(2L, -7L, 3L, 0);
                var v1 = new long4(4L, 3L, -7L, -3L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(3L, 9L, -5L, 0);
                var v1 = new long4(-3L, 5L, 1, 4L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(-2L, 3L, -4L, 8L);
                var v1 = new long4(-4L, 2L, 3L, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(-9L, 6L, -4L, -6L);
                var v1 = new long4(-3L, -9L, -7L, -1L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(-9L, 9L, 6L, -9L);
                var v1 = new long4(-1L, -5L, -2L, 1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new long4(-5L, 7L, -2L, -9L);
                var v1 = new long4(1, -4L, -1L, -2L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new long4(-4L, 9L, -4L, -7L);
                var v1 = new long4(-2L, -4L, -2L, -5L);
                var v2 = new long4(-3L, -6L, 9L, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(8L, -9L, -2L, 1);
                var v1 = new long4(8L, -6L, 5L, -9L);
                var v2 = new long4(8L, -2L, 7L, 6L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(-7L, 9L, 3L, 0);
                var v1 = new long4(2L, -4L, 7L, -4L);
                var v2 = new long4(-7L, 9L, 9L, -7L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(2L, 2L, -3L, 5L);
                var v1 = new long4(-6L, -1L, 9L, -8L);
                var v2 = new long4(7L, 2L, 3L, 2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(-1L, -6L, -9L, -6L);
                var v1 = new long4(6L, -7L, 5L, 1);
                var v2 = new long4(1, 7L, 0, 2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(-1L, -1L, -3L, -9L);
                var v1 = new long4(8L, -5L, 4L, -9L);
                var v2 = new long4(9L, -5L, -8L, 6L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(2L, 0, 2L, -8L);
                var v1 = new long4(2L, 9L, -8L, -5L);
                var v2 = new long4(5L, 1, 8L, 5L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(-5L, -2L, 7L, -9L);
                var v1 = new long4(3L, 7L, -5L, -5L);
                var v2 = new long4(1, -1L, -5L, 5L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(-7L, -1L, 8L, -2L);
                var v1 = new long4(-8L, 4L, -2L, -6L);
                var v2 = new long4(-8L, -2L, -3L, 6L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new long4(-5L, 7L, -9L, -1L);
                var v1 = new long4(9L, 4L, -7L, 8L);
                var v2 = new long4(1, 6L, 4L, -7L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new long4(9L, -5L, -5L, 0);
                var v1 = new long4(9L, 1, -3L, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(-1L, -5L, 3L, -4L);
                var v1 = new long4(-6L, -1L, 4L, -6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(0, -8L, -9L, -9L);
                var v1 = new long4(-7L, -4L, 1, 9L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(-4L, -5L, -3L, 2L);
                var v1 = new long4(0, -4L, 1, 6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(6L, 3L, -3L, -1L);
                var v1 = new long4(2L, -5L, -9L, -1L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(-9L, -2L, 8L, 7L);
                var v1 = new long4(1, -1L, -4L, -7L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(3L, 9L, -3L, 1);
                var v1 = new long4(-5L, -6L, 0, -6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(-4L, 5L, 5L, -4L);
                var v1 = new long4(7L, 9L, 0, -7L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(-4L, -7L, 7L, -2L);
                var v1 = new long4(-7L, -4L, -4L, 5L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new long4(-8L, 8L, -9L, 4L);
                var v1 = new long4(4L, -3L, 8L, 2L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new long4(-4L, -2L, 9L, 3L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(1, -7L, -3L, 1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(-7L, -1L, 0, 9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(-3L, 4L, -6L, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(4L, 4L, 5L, 6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(-3L, -4L, -4L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(-9L, 7L, -7L, 3L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(2L, -5L, 4L, 9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(8L, 3L, 2L, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new long4(9L, -1L, -8L, -4L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(902615102);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.Random(random, 3, 8);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5, 1.0);
            Assert.AreEqual(avg.y, 5, 1.0);
            Assert.AreEqual(avg.z, 5, 1.0);
            Assert.AreEqual(avg.w, 5, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(874874646);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.RandomUniform(random, 3, 8);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5, 1.0);
            Assert.AreEqual(avg.y, 5, 1.0);
            Assert.AreEqual(avg.z, 5, 1.0);
            Assert.AreEqual(avg.w, 5, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1456117417);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.Random(random, -5, -1);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3.5, 1.0);
            Assert.AreEqual(avg.y, -3.5, 1.0);
            Assert.AreEqual(avg.z, -3.5, 1.0);
            Assert.AreEqual(avg.w, -3.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1080912384);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.RandomUniform(random, -5, 0);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3, 1.0);
            Assert.AreEqual(avg.y, -3, 1.0);
            Assert.AreEqual(avg.z, -3, 1.0);
            Assert.AreEqual(avg.w, -3, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(149605870);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.Random(random, 4, 6);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            Assert.AreEqual(avg.w, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
            Assert.AreEqual(variance.w, 0.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1178389130);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.RandomPoisson(random, 2.7804663624989177);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.7804663624989177, 1.0);
            Assert.AreEqual(avg.y, 2.7804663624989177, 1.0);
            Assert.AreEqual(avg.z, 2.7804663624989177, 1.0);
            Assert.AreEqual(avg.w, 2.7804663624989177, 1.0);
            
            Assert.AreEqual(variance.x, 2.7804663624989177, 3.0);
            Assert.AreEqual(variance.y, 2.7804663624989177, 3.0);
            Assert.AreEqual(variance.z, 2.7804663624989177, 3.0);
            Assert.AreEqual(variance.w, 2.7804663624989177, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(1795261159);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.RandomPoisson(random, 2.6845771107750838);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.6845771107750838, 1.0);
            Assert.AreEqual(avg.y, 2.6845771107750838, 1.0);
            Assert.AreEqual(avg.z, 2.6845771107750838, 1.0);
            Assert.AreEqual(avg.w, 2.6845771107750838, 1.0);
            
            Assert.AreEqual(variance.x, 2.6845771107750838, 3.0);
            Assert.AreEqual(variance.y, 2.6845771107750838, 3.0);
            Assert.AreEqual(variance.z, 2.6845771107750838, 3.0);
            Assert.AreEqual(variance.w, 2.6845771107750838, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(949645885);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.RandomPoisson(random, 3.044690301895463);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.044690301895463, 1.0);
            Assert.AreEqual(avg.y, 3.044690301895463, 1.0);
            Assert.AreEqual(avg.z, 3.044690301895463, 1.0);
            Assert.AreEqual(avg.w, 3.044690301895463, 1.0);
            
            Assert.AreEqual(variance.x, 3.044690301895463, 3.0);
            Assert.AreEqual(variance.y, 3.044690301895463, 3.0);
            Assert.AreEqual(variance.z, 3.044690301895463, 3.0);
            Assert.AreEqual(variance.w, 3.044690301895463, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1371551134);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.RandomPoisson(random, 2.2051124454965407);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.2051124454965407, 1.0);
            Assert.AreEqual(avg.y, 2.2051124454965407, 1.0);
            Assert.AreEqual(avg.z, 2.2051124454965407, 1.0);
            Assert.AreEqual(avg.w, 2.2051124454965407, 1.0);
            
            Assert.AreEqual(variance.x, 2.2051124454965407, 3.0);
            Assert.AreEqual(variance.y, 2.2051124454965407, 3.0);
            Assert.AreEqual(variance.z, 2.2051124454965407, 3.0);
            Assert.AreEqual(variance.w, 2.2051124454965407, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(632092791);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = long4.RandomPoisson(random, 1.0803037675005867);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.0803037675005867, 1.0);
            Assert.AreEqual(avg.y, 1.0803037675005867, 1.0);
            Assert.AreEqual(avg.z, 1.0803037675005867, 1.0);
            Assert.AreEqual(avg.w, 1.0803037675005867, 1.0);
            
            Assert.AreEqual(variance.x, 1.0803037675005867, 3.0);
            Assert.AreEqual(variance.y, 1.0803037675005867, 3.0);
            Assert.AreEqual(variance.z, 1.0803037675005867, 3.0);
            Assert.AreEqual(variance.w, 1.0803037675005867, 3.0);
        }

    }
}
