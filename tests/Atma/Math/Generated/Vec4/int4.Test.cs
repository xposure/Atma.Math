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
                var v = new int4(-4, -4, -7, 9);
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var v = new int4(new int2(2, -6));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new int4(new int3(7, 4, 2));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new int4(new int4(-9, 8, -5, 8));
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(8, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new int4(4, 3, -5, -1);
            Assert.AreEqual(4, v[0]);
            Assert.AreEqual(3, v[1]);
            Assert.AreEqual(-5, v[2]);
            Assert.AreEqual(-1, v[3]);
            
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
            
            v[2] = 0;
            Assert.AreEqual(0, v[2]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[2] = -3;
            Assert.AreEqual(-3, v[2]);
            v[2] = -4;
            Assert.AreEqual(-4, v[2]);
            v[2] = -5;
            Assert.AreEqual(-5, v[2]);
            v[2] = -6;
            Assert.AreEqual(-6, v[2]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[3] = -8;
            Assert.AreEqual(-8, v[3]);
            v[2] = -9;
            Assert.AreEqual(-9, v[2]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new int4(3, 5, -1, -5);
            var vals = v.Values;
            Assert.AreEqual(3, vals[0]);
            Assert.AreEqual(5, vals[1]);
            Assert.AreEqual(-1, vals[2]);
            Assert.AreEqual(-5, vals[3]);
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
            var v1 = new int4(4, 1, -7, 6);
            var v2 = new int4(4, 1, -7, 6);
            var v3 = new int4(6, -7, 1, 4);
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
            var v = new int4(-4, 5, -6, -3);
            
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
            var v0 = new int4(-5, -1, 9, 3);
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
                var v0 = new int4(-4, -8, 8, -6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(7, -1, 2, 2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(0, 7, -6, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(8, 5, 4, -4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(7, -5, -8, 7);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-6, 9, -3, -6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(9, 8, -9, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-4, 5, -8, 1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-8, 6, 0, -5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int4(-1, 7, -9, -2);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new int4(7, 6, 5, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-1, 1, 9, -7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-4, 8, 9, 6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(0, 5, 5, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-6, 1, -4, -5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(4, 9, -1, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(6, 4, -6, -3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(-5, -8, -3, 0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(7, 7, 1, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int4(5, 5, -7, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new int4(4, -8, 5, -2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-9, -6, 8, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(5, -3, 7, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(1, -3, -7, -8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-9, 5, -8, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-1, 7, 4, -3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-9, 4, -1, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(4, 6, -3, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(3, -7, -4, 4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int4(-6, -3, -1, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new int4(2, -2, 5, 6);
                var v1 = new int4(5, -6, 9, -4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-2, 2, 1, -7);
                var v1 = new int4(-1, -9, -6, -1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-5, -4, 0, 1);
                var v1 = new int4(-7, 9, -3, -8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(8, -5, -1, 2);
                var v1 = new int4(-6, 1, 9, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(2, -1, -4, 4);
                var v1 = new int4(-9, -5, 4, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(3, 7, 1, 7);
                var v1 = new int4(-3, -8, -2, 2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(9, 5, -9, 6);
                var v1 = new int4(-6, -6, -6, -2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-9, 6, -8, 9);
                var v1 = new int4(4, 7, -7, -1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(-3, -4, -5, -9);
                var v1 = new int4(4, -1, -2, -9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int4(8, 9, -8, 9);
                var v1 = new int4(8, 4, 5, -1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new int4(6, -8, -9, 0);
                var v1 = new int4(-8, 3, -6, -8);
                var v2 = new int4(-9, -3, 9, 0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(-7, 6, -7, -8);
                var v1 = new int4(-2, -2, -4, 1);
                var v2 = new int4(2, 4, -1, 8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(-4, 8, -9, 7);
                var v1 = new int4(-3, -9, -3, 2);
                var v2 = new int4(8, -8, 0, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(6, -7, 0, 8);
                var v1 = new int4(-3, 8, -5, 9);
                var v2 = new int4(-7, 0, -6, 8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(8, 3, 1, 3);
                var v1 = new int4(7, 3, -5, 2);
                var v2 = new int4(6, 9, 6, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(3, 7, 4, -9);
                var v1 = new int4(0, 7, -2, -8);
                var v2 = new int4(5, -2, -2, -5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(-1, 5, 7, -3);
                var v1 = new int4(9, 1, -1, -3);
                var v2 = new int4(-2, 9, -8, 8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(-8, 9, -4, 4);
                var v1 = new int4(2, -8, -8, -7);
                var v2 = new int4(9, -1, 5, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(3, -6, 8, 9);
                var v1 = new int4(8, -7, 3, -6);
                var v2 = new int4(-2, 6, -2, 2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int4(-5, 2, -3, 5);
                var v1 = new int4(-8, -4, -7, -3);
                var v2 = new int4(9, -6, 1, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new int4(8, 0, -8, -5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(-8, -4, 2, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(3, 2, 8, -3);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(-7, 4, 7, 3);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(0, 3, -1, -7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(-4, 5, 0, 1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(4, 3, 9, -7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(-2, 5, -7, 2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(1, 9, 4, -4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int4(8, -9, -8, 1);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new int4(-1, -2, -5, 4);
                var v1 = new int4(-4, -4, -3, 7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(-2, -8, 4, 5);
                var v1 = new int4(8, 4, 6, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(-2, 8, -3, -8);
                var v1 = new int4(0, -6, 2, 1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(9, 2, 3, -8);
                var v1 = new int4(3, 6, -9, 4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(-9, -8, 8, 8);
                var v1 = new int4(-3, -4, 2, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(9, 2, -5, 3);
                var v1 = new int4(1, -1, 2, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(4, 6, 2, 6);
                var v1 = new int4(-1, -1, 0, -5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(9, -3, -4, -1);
                var v1 = new int4(9, -4, 4, 5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(-9, -9, 5, -1);
                var v1 = new int4(-5, -8, 5, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int4(6, 5, 7, -7);
                var v1 = new int4(1, -8, 0, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new int4(0, 6, -9, 1);
                var v1 = new int4(-7, -3, 2, 7);
                var v2 = new int4(-2, -5, -7, -1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-8, 1, -8, 3);
                var v1 = new int4(-9, -2, 6, 8);
                var v2 = new int4(1, -8, -3, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-6, -3, 5, -1);
                var v1 = new int4(1, -8, -3, -2);
                var v2 = new int4(2, -8, -1, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-7, -8, -1, -6);
                var v1 = new int4(-1, 5, 0, 0);
                var v2 = new int4(-3, 0, 3, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-4, 4, 7, 8);
                var v1 = new int4(-5, -4, 9, 2);
                var v2 = new int4(-3, 1, 5, 3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(6, -1, 5, -4);
                var v1 = new int4(1, 4, 8, 0);
                var v2 = new int4(-1, 0, 5, 0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(0, -1, -8, -6);
                var v1 = new int4(-7, -3, 4, -5);
                var v2 = new int4(9, 3, -7, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(9, 3, -6, 7);
                var v1 = new int4(7, 7, 4, -6);
                var v2 = new int4(-3, 7, 8, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-9, 6, -8, 7);
                var v1 = new int4(-2, 3, -1, -3);
                var v2 = new int4(-8, 6, 8, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int4(-6, -3, 5, -9);
                var v1 = new int4(-6, 9, -4, 2);
                var v2 = new int4(-4, 8, 3, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new int4(7, 8, -7, 5);
                var v1 = new int4(0, 4, -1, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-8, -9, -2, 5);
                var v1 = new int4(-6, 7, 2, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(5, 7, 3, 3);
                var v1 = new int4(-3, -3, 6, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-6, 4, -3, -8);
                var v1 = new int4(-2, 0, -5, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(4, 2, 0, 0);
                var v1 = new int4(-5, 5, 8, -3);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-8, -5, 0, 6);
                var v1 = new int4(1, 4, 3, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(9, 9, 8, -3);
                var v1 = new int4(6, -2, 1, -4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(1, -4, 9, -6);
                var v1 = new int4(-1, -2, -6, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(4, 4, 1, -3);
                var v1 = new int4(6, 2, -5, 0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int4(-8, 9, 5, -8);
                var v1 = new int4(-2, 0, 1, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new int4(4, 8, -1, -7);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(9, 3, -4, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(-1, 0, -7, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(-9, -2, -1, -6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(-7, -5, 0, -2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(7, -7, -9, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(2, -6, 6, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(-3, -4, -3, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(4, 7, -4, -6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int4(-4, -3, -8, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1865365137);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.Random(random, -3, 0);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            Assert.AreEqual(avg.z, -2, 1.0);
            Assert.AreEqual(avg.w, -2, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.z, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.w, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(2096680071);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomUniform(random, -3, 2);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            Assert.AreEqual(avg.z, -1, 1.0);
            Assert.AreEqual(avg.w, -1, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1217315260);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.Random(random, 3, 8);
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
        public void RandomUniform3()
        {
            var random = new Random(1997646510);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomUniform(random, -2, 0);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            Assert.AreEqual(avg.z, -1.5, 1.0);
            Assert.AreEqual(avg.w, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
            Assert.AreEqual(variance.w, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(893135817);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.Random(random, 0, 5);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            Assert.AreEqual(avg.z, 2, 1.0);
            Assert.AreEqual(avg.w, 2, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1434024893);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 2.3067386209996132);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.3067386209996132, 1.0);
            Assert.AreEqual(avg.y, 2.3067386209996132, 1.0);
            Assert.AreEqual(avg.z, 2.3067386209996132, 1.0);
            Assert.AreEqual(avg.w, 2.3067386209996132, 1.0);
            
            Assert.AreEqual(variance.x, 2.3067386209996132, 3.0);
            Assert.AreEqual(variance.y, 2.3067386209996132, 3.0);
            Assert.AreEqual(variance.z, 2.3067386209996132, 3.0);
            Assert.AreEqual(variance.w, 2.3067386209996132, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(30862415);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 1.6497551580657042);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.6497551580657042, 1.0);
            Assert.AreEqual(avg.y, 1.6497551580657042, 1.0);
            Assert.AreEqual(avg.z, 1.6497551580657042, 1.0);
            Assert.AreEqual(avg.w, 1.6497551580657042, 1.0);
            
            Assert.AreEqual(variance.x, 1.6497551580657042, 3.0);
            Assert.AreEqual(variance.y, 1.6497551580657042, 3.0);
            Assert.AreEqual(variance.z, 1.6497551580657042, 3.0);
            Assert.AreEqual(variance.w, 1.6497551580657042, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(1792151607);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 1.172058621734408);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.172058621734408, 1.0);
            Assert.AreEqual(avg.y, 1.172058621734408, 1.0);
            Assert.AreEqual(avg.z, 1.172058621734408, 1.0);
            Assert.AreEqual(avg.w, 1.172058621734408, 1.0);
            
            Assert.AreEqual(variance.x, 1.172058621734408, 3.0);
            Assert.AreEqual(variance.y, 1.172058621734408, 3.0);
            Assert.AreEqual(variance.z, 1.172058621734408, 3.0);
            Assert.AreEqual(variance.w, 1.172058621734408, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(705231604);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 1.1291788195395744);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.1291788195395744, 1.0);
            Assert.AreEqual(avg.y, 1.1291788195395744, 1.0);
            Assert.AreEqual(avg.z, 1.1291788195395744, 1.0);
            Assert.AreEqual(avg.w, 1.1291788195395744, 1.0);
            
            Assert.AreEqual(variance.x, 1.1291788195395744, 3.0);
            Assert.AreEqual(variance.y, 1.1291788195395744, 3.0);
            Assert.AreEqual(variance.z, 1.1291788195395744, 3.0);
            Assert.AreEqual(variance.w, 1.1291788195395744, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1775363146);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int4.RandomPoisson(random, 2.272957039425595);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.272957039425595, 1.0);
            Assert.AreEqual(avg.y, 2.272957039425595, 1.0);
            Assert.AreEqual(avg.z, 2.272957039425595, 1.0);
            Assert.AreEqual(avg.w, 2.272957039425595, 1.0);
            
            Assert.AreEqual(variance.x, 2.272957039425595, 3.0);
            Assert.AreEqual(variance.y, 2.272957039425595, 3.0);
            Assert.AreEqual(variance.z, 2.272957039425595, 3.0);
            Assert.AreEqual(variance.w, 2.272957039425595, 3.0);
        }

    }
}
