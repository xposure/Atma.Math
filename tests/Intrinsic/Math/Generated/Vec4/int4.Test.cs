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
    public class IntVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new int4(1);
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var v = new int4(1, 4, -8, 8);
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var v = new int4(new int2(-7, -7));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new int4(new int3(7, 9, -7));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new int4(new int4(-2, -9, 8, -1));
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-1, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new int4(1, 7, 8, 7);
            Assert.AreEqual(1, v[0]);
            Assert.AreEqual(7, v[1]);
            Assert.AreEqual(8, v[2]);
            Assert.AreEqual(7, v[3]);
            
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
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[3] = 2;
            Assert.AreEqual(2, v[3]);
            v[3] = 3;
            Assert.AreEqual(3, v[3]);
            v[3] = 4;
            Assert.AreEqual(4, v[3]);
            v[3] = 5;
            Assert.AreEqual(5, v[3]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[3] = -1;
            Assert.AreEqual(-1, v[3]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[3] = -8;
            Assert.AreEqual(-8, v[3]);
            v[3] = -9;
            Assert.AreEqual(-9, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new int4(-1, 5, 9, 2);
            var vals = v.Values;
            Assert.AreEqual(-1, vals[0]);
            Assert.AreEqual(5, vals[1]);
            Assert.AreEqual(9, vals[2]);
            Assert.AreEqual(2, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, int4.Zero.x);
            Assert.AreEqual(0, int4.Zero.y);
            Assert.AreEqual(0, int4.Zero.z);
            Assert.AreEqual(0, int4.Zero.w);
            
            Assert.AreEqual(1, int4.Ones.x);
            Assert.AreEqual(1, int4.Ones.y);
            Assert.AreEqual(1, int4.Ones.z);
            Assert.AreEqual(1, int4.Ones.w);
            
            Assert.AreEqual(1, int4.UnitX.x);
            Assert.AreEqual(0, int4.UnitX.y);
            Assert.AreEqual(0, int4.UnitX.z);
            Assert.AreEqual(0, int4.UnitX.w);
            
            Assert.AreEqual(0, int4.UnitY.x);
            Assert.AreEqual(1, int4.UnitY.y);
            Assert.AreEqual(0, int4.UnitY.z);
            Assert.AreEqual(0, int4.UnitY.w);
            
            Assert.AreEqual(0, int4.UnitZ.x);
            Assert.AreEqual(0, int4.UnitZ.y);
            Assert.AreEqual(1, int4.UnitZ.z);
            Assert.AreEqual(0, int4.UnitZ.w);
            
            Assert.AreEqual(0, int4.UnitW.x);
            Assert.AreEqual(0, int4.UnitW.y);
            Assert.AreEqual(0, int4.UnitW.z);
            Assert.AreEqual(1, int4.UnitW.w);
            
            Assert.AreEqual(int.MaxValue, int4.MaxValue.x);
            Assert.AreEqual(int.MaxValue, int4.MaxValue.y);
            Assert.AreEqual(int.MaxValue, int4.MaxValue.z);
            Assert.AreEqual(int.MaxValue, int4.MaxValue.w);
            
            Assert.AreEqual(int.MinValue, int4.MinValue.x);
            Assert.AreEqual(int.MinValue, int4.MinValue.y);
            Assert.AreEqual(int.MinValue, int4.MinValue.z);
            Assert.AreEqual(int.MinValue, int4.MinValue.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new int4(4, 6, 5, -5);
            var v2 = new int4(4, 6, 5, -5);
            var v3 = new int4(-5, 5, 6, 4);
            Assert.That(v1 == new int4(v1));
            Assert.That(v2 == new int4(v2));
            Assert.That(v3 == new int4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new int4(7, 5, 7, 2);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = int4.Parse(s0);
            var v1 = int4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = int4.TryParse(s0, out v0);
            var b1 = int4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = int4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = int4.TryParse("", out v0);
            Assert.False(b0);
            b0 = int4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { int4.Parse(null); });
            Assert.Throws<FormatException>(() => { int4.Parse(""); });
            Assert.Throws<FormatException>(() => { int4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = int4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = int4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = int4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new int4(-3, 7, -5, 6);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<int4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new int4(3, -7, 4, -6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-9, -7, -4, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(2, -6, -9, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-4, -8, 1, 9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(1, -7, 4, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-9, -3, 4, -3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-5, 4, 8, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(4, 2, -7, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(9, 3, -9, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-3, 2, 2, -1);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new int4(-4, -3, 1, -7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-9, 0, -4, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(6, -1, -8, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-5, -6, 6, 7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-5, 7, 6, -4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(7, 4, -1, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-3, -1, 2, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-5, -5, 5, 5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-2, 6, 6, 6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-2, -9, 1, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new int4(8, -7, -2, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(4, -5, 5, -5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-3, 4, -1, -3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-3, -9, -2, 9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-3, -3, 8, -7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-7, -3, 0, 9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-4, 2, 0, -1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(8, 1, -7, 8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-3, 7, -5, 2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(3, -7, -5, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new int4(6, -3, 6, -5);
                var v1 = new int4(-7, -8, -4, -3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(7, -3, -8, -2);
                var v1 = new int4(3, 2, 6, 3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(9, 1, -2, 2);
                var v1 = new int4(3, 7, 3, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(0, -4, -7, 9);
                var v1 = new int4(6, -6, 0, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-1, 3, -6, 9);
                var v1 = new int4(-5, 4, 2, -6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-5, -8, 9, -5);
                var v1 = new int4(-1, -1, -6, 8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-2, 3, 9, 4);
                var v1 = new int4(8, -2, 1, -8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(8, 0, -5, 2);
                var v1 = new int4(1, 3, 5, -2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-2, -2, 1, -9);
                var v1 = new int4(6, -6, 7, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-9, -5, 6, 4);
                var v1 = new int4(-8, 8, -4, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new int4(-6, 1, -5, 9);
                var v1 = new int4(1, 8, -2, -2);
                var v2 = new int4(0, 7, 8, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(1, 2, 5, 3);
                var v1 = new int4(0, 8, -3, 8);
                var v2 = new int4(-7, -7, -9, -6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(6, 1, -7, 3);
                var v1 = new int4(-7, -5, 3, 1);
                var v2 = new int4(-3, -7, -1, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(-6, -4, 7, 0);
                var v1 = new int4(4, 2, -4, 2);
                var v2 = new int4(-1, -5, -4, 6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(5, -7, -3, 5);
                var v1 = new int4(-1, -9, -8, -9);
                var v2 = new int4(1, -9, 3, 0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(-2, 8, -5, 4);
                var v1 = new int4(3, 7, -2, 3);
                var v2 = new int4(-1, -4, 7, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(1, -3, 3, -4);
                var v1 = new int4(2, -6, 4, -2);
                var v2 = new int4(6, 9, -8, -9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(1, -7, 9, -3);
                var v1 = new int4(-9, -2, 9, -7);
                var v2 = new int4(-1, 6, 8, -6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(7, 8, -8, 2);
                var v1 = new int4(2, -1, -5, -1);
                var v2 = new int4(9, 6, 4, -8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(-5, 4, -7, 4);
                var v1 = new int4(-4, -1, -3, 1);
                var v2 = new int4(9, -5, 3, 6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new int4(3, -4, 3, -7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(5, 4, 9, 2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(2, -1, 3, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(-6, -2, -8, 3);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(5, 0, -4, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(4, 5, 9, -4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(-7, -7, 8, -2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(3, 6, -9, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(5, 3, 9, 9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(3, -5, 0, -5);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new int4(-9, -9, -2, 4);
                var v1 = new int4(4, 1, 3, 7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(-6, 1, -2, 9);
                var v1 = new int4(-8, 4, -6, -6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(6, 4, 9, -6);
                var v1 = new int4(0, 0, -1, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(7, 0, -2, -8);
                var v1 = new int4(-4, -5, 3, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(1, 4, 4, 7);
                var v1 = new int4(4, -2, 6, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(-7, -1, -7, 3);
                var v1 = new int4(0, 1, -5, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(6, 4, -6, -9);
                var v1 = new int4(9, -5, -4, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(8, -3, -6, 3);
                var v1 = new int4(8, 5, -3, 1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(-7, 5, 7, -4);
                var v1 = new int4(-9, 8, -1, -4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(-8, 8, -8, 8);
                var v1 = new int4(3, 7, -8, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new int4(-8, 8, -6, -7);
                var v1 = new int4(2, 2, 5, 1);
                var v2 = new int4(4, 5, -1, -6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-7, 8, 8, -9);
                var v1 = new int4(6, -7, -1, -4);
                var v2 = new int4(-5, 5, 7, 7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(0, 9, -2, 1);
                var v1 = new int4(2, -7, -3, -8);
                var v2 = new int4(-2, -6, -7, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-8, 1, 9, 0);
                var v1 = new int4(-7, -9, -7, -5);
                var v2 = new int4(-5, 4, 3, 9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(8, -4, -9, 3);
                var v1 = new int4(-3, -5, -2, -2);
                var v2 = new int4(0, 7, -6, -3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(9, 3, -8, 7);
                var v1 = new int4(-3, -3, 3, 1);
                var v2 = new int4(-2, 7, 0, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(6, 9, -7, -5);
                var v1 = new int4(8, -2, -3, -6);
                var v2 = new int4(6, 1, -3, 8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-8, 9, 4, -7);
                var v1 = new int4(4, 4, 1, 9);
                var v2 = new int4(4, -7, 9, -3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(1, 8, 2, 2);
                var v1 = new int4(1, 1, -8, 0);
                var v2 = new int4(-3, -4, -6, 3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-8, -6, 3, 7);
                var v1 = new int4(-5, 0, 5, 7);
                var v2 = new int4(-1, 9, 8, 2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new int4(-8, 8, -1, 4);
                var v1 = new int4(-7, -4, 3, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-7, -2, 9, 2);
                var v1 = new int4(-5, -2, 2, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-8, -6, 8, -3);
                var v1 = new int4(4, -5, -5, 0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(9, 9, 2, -6);
                var v1 = new int4(-1, -5, -3, -9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-1, 3, -7, -5);
                var v1 = new int4(-8, 0, 1, 8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(8, 2, 6, -7);
                var v1 = new int4(-5, -7, -9, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(0, -5, 1, 7);
                var v1 = new int4(6, 9, -7, 3);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-4, -1, -4, 7);
                var v1 = new int4(-1, 7, -1, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-8, 9, -1, -2);
                var v1 = new int4(-4, 6, -1, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-4, 0, 3, 1);
                var v1 = new int4(7, -7, 5, -2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new int4(-2, 6, 7, -5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(-7, 4, 0, -7);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(7, 2, 9, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(-8, 4, 8, 6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(5, 5, -2, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(-3, 5, -5, 5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(2, 0, -6, -4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(6, -2, 3, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(1, 9, -5, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(4, 3, -2, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(379243695);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.Random(random, -5, 0);
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
        public void RandomUniform1()
        {
            var random = new Random(2030481085);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomUniform(random, -5, 0);
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
        public void RandomUniform2()
        {
            var random = new Random(1973225027);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.Random(random, 3, 6);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            Assert.AreEqual(avg.z, 4, 1.0);
            Assert.AreEqual(avg.w, 4, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.z, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.w, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(200946413);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomUniform(random, 3, 8);
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
        public void RandomUniform4()
        {
            var random = new Random(459757222);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.Random(random, 4, 7);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5, 1.0);
            Assert.AreEqual(avg.y, 5, 1.0);
            Assert.AreEqual(avg.z, 5, 1.0);
            Assert.AreEqual(avg.w, 5, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.z, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.w, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(868237778);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 0.601625173865643);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.601625173865643, 1.0);
            Assert.AreEqual(avg.y, 0.601625173865643, 1.0);
            Assert.AreEqual(avg.z, 0.601625173865643, 1.0);
            Assert.AreEqual(avg.w, 0.601625173865643, 1.0);
            
            Assert.AreEqual(variance.x, 0.601625173865643, 3.0);
            Assert.AreEqual(variance.y, 0.601625173865643, 3.0);
            Assert.AreEqual(variance.z, 0.601625173865643, 3.0);
            Assert.AreEqual(variance.w, 0.601625173865643, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(1110094572);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 1.8634182994083588);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.8634182994083588, 1.0);
            Assert.AreEqual(avg.y, 1.8634182994083588, 1.0);
            Assert.AreEqual(avg.z, 1.8634182994083588, 1.0);
            Assert.AreEqual(avg.w, 1.8634182994083588, 1.0);
            
            Assert.AreEqual(variance.x, 1.8634182994083588, 3.0);
            Assert.AreEqual(variance.y, 1.8634182994083588, 3.0);
            Assert.AreEqual(variance.z, 1.8634182994083588, 3.0);
            Assert.AreEqual(variance.w, 1.8634182994083588, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(1259797237);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 0.7986147498239832);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.7986147498239832, 1.0);
            Assert.AreEqual(avg.y, 0.7986147498239832, 1.0);
            Assert.AreEqual(avg.z, 0.7986147498239832, 1.0);
            Assert.AreEqual(avg.w, 0.7986147498239832, 1.0);
            
            Assert.AreEqual(variance.x, 0.7986147498239832, 3.0);
            Assert.AreEqual(variance.y, 0.7986147498239832, 3.0);
            Assert.AreEqual(variance.z, 0.7986147498239832, 3.0);
            Assert.AreEqual(variance.w, 0.7986147498239832, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1533804597);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 3.0262712568632657);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.0262712568632657, 1.0);
            Assert.AreEqual(avg.y, 3.0262712568632657, 1.0);
            Assert.AreEqual(avg.z, 3.0262712568632657, 1.0);
            Assert.AreEqual(avg.w, 3.0262712568632657, 1.0);
            
            Assert.AreEqual(variance.x, 3.0262712568632657, 3.0);
            Assert.AreEqual(variance.y, 3.0262712568632657, 3.0);
            Assert.AreEqual(variance.z, 3.0262712568632657, 3.0);
            Assert.AreEqual(variance.w, 3.0262712568632657, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(125779293);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 2.7630012842188596);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.7630012842188596, 1.0);
            Assert.AreEqual(avg.y, 2.7630012842188596, 1.0);
            Assert.AreEqual(avg.z, 2.7630012842188596, 1.0);
            Assert.AreEqual(avg.w, 2.7630012842188596, 1.0);
            
            Assert.AreEqual(variance.x, 2.7630012842188596, 3.0);
            Assert.AreEqual(variance.y, 2.7630012842188596, 3.0);
            Assert.AreEqual(variance.z, 2.7630012842188596, 3.0);
            Assert.AreEqual(variance.w, 2.7630012842188596, 3.0);
        }

    }
}
