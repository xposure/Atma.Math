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

namespace  Intrinsic.Math.Generated.Vec3
{
    [TestFixture]
    public class IntVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new int3(-8);
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var v = new int3(9, 5, -8);
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var v = new int3(new int2(3, -1));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new int3(new int3(-3, -6, 3));
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var v = new int3(new int4(3, -3, -5, -5));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-5, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new int3(-8, 2, 1);
            Assert.AreEqual(-8, v[0]);
            Assert.AreEqual(2, v[1]);
            Assert.AreEqual(1, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[1] = 3;
            Assert.AreEqual(3, v[1]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
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
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[2] = -9;
            Assert.AreEqual(-9, v[2]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new int3(8, 4, -9);
            var vals = v.Values;
            Assert.AreEqual(8, vals[0]);
            Assert.AreEqual(4, vals[1]);
            Assert.AreEqual(-9, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, int3.Zero.x);
            Assert.AreEqual(0, int3.Zero.y);
            Assert.AreEqual(0, int3.Zero.z);
            
            Assert.AreEqual(1, int3.Ones.x);
            Assert.AreEqual(1, int3.Ones.y);
            Assert.AreEqual(1, int3.Ones.z);
            
            Assert.AreEqual(1, int3.UnitX.x);
            Assert.AreEqual(0, int3.UnitX.y);
            Assert.AreEqual(0, int3.UnitX.z);
            
            Assert.AreEqual(0, int3.UnitY.x);
            Assert.AreEqual(1, int3.UnitY.y);
            Assert.AreEqual(0, int3.UnitY.z);
            
            Assert.AreEqual(0, int3.UnitZ.x);
            Assert.AreEqual(0, int3.UnitZ.y);
            Assert.AreEqual(1, int3.UnitZ.z);
            
            Assert.AreEqual(int.MaxValue, int3.MaxValue.x);
            Assert.AreEqual(int.MaxValue, int3.MaxValue.y);
            Assert.AreEqual(int.MaxValue, int3.MaxValue.z);
            
            Assert.AreEqual(int.MinValue, int3.MinValue.x);
            Assert.AreEqual(int.MinValue, int3.MinValue.y);
            Assert.AreEqual(int.MinValue, int3.MinValue.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new int3(-4, -9, -4);
            var v2 = new int3(-4, -9, -4);
            var v3 = new int3(-4, -10, -4);
            Assert.That(v1 == new int3(v1));
            Assert.That(v2 == new int3(v2));
            Assert.That(v3 == new int3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new int3(-1, 0, -1);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = int3.Parse(s0);
            var v1 = int3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = int3.TryParse(s0, out v0);
            var b1 = int3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = int3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = int3.TryParse("", out v0);
            Assert.False(b0);
            b0 = int3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { int3.Parse(null); });
            Assert.Throws<FormatException>(() => { int3.Parse(""); });
            Assert.Throws<FormatException>(() => { int3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = int3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = int3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = int3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new int3(6, 3, -4);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<int3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new int3(-5, 8, -5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-9, 2, -4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(5, 5, 6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-9, 7, -1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-9, 8, 6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(3, 1, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(4, 2, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-1, 1, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-9, -3, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-9, 4, 8);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new int3(4, -2, -8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(-8, 2, -1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(5, 0, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(3, 9, 6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(-8, -1, 0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(5, 6, -3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(1, 7, -1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(-9, -5, 1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(2, 7, 6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(7, -4, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new int3(-1, -3, -7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(-8, 6, -3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(4, 8, 0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(-6, -3, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(-1, -1, 5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(3, 9, 9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(-8, 0, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(0, 0, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(-1, 6, -8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(8, -6, 5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new int3(5, 8, -8);
                var v1 = new int3(6, -1, -6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(0, -1, 1);
                var v1 = new int3(1, -7, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(-5, 5, 1);
                var v1 = new int3(-3, 6, 2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(1, 0, -5);
                var v1 = new int3(1, -5, 2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(9, 4, 5);
                var v1 = new int3(6, -4, 1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(-7, 2, 1);
                var v1 = new int3(9, 6, -5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(7, 9, -7);
                var v1 = new int3(7, 2, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(-3, 0, 6);
                var v1 = new int3(-9, 5, 4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(5, 3, -2);
                var v1 = new int3(0, -1, 2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(4, 3, -3);
                var v1 = new int3(-6, -6, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new int3(5, 2, -6);
                var v1 = new int3(-5, -8, 2);
                var v2 = new int3(-8, 4, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-7, -6, 9);
                var v1 = new int3(1, -1, 6);
                var v2 = new int3(-2, -2, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-4, 2, -8);
                var v1 = new int3(-7, -8, 5);
                var v2 = new int3(9, -3, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-2, -3, -2);
                var v1 = new int3(-6, -9, 3);
                var v2 = new int3(1, -6, -5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(4, -2, 4);
                var v1 = new int3(-7, -5, -4);
                var v2 = new int3(-9, -7, -2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(7, 0, -9);
                var v1 = new int3(-4, -8, -1);
                var v2 = new int3(3, -6, -7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-3, 7, 3);
                var v1 = new int3(9, 4, 4);
                var v2 = new int3(7, 6, -2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-4, 0, -6);
                var v1 = new int3(5, 0, -5);
                var v2 = new int3(-2, 7, -9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(0, -6, 6);
                var v1 = new int3(4, -7, 1);
                var v2 = new int3(-3, 2, -3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-5, -7, -4);
                var v1 = new int3(0, -2, 3);
                var v2 = new int3(6, 7, 7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new int3(-4, -1, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-8, -6, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(9, 7, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(3, 4, -8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-7, -5, 9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(9, -6, 0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-4, -1, -5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-8, -6, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-8, 1, 0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(8, 5, 4);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new int3(0, -1, -8);
                var v1 = new int3(-3, 7, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(6, -6, -6);
                var v1 = new int3(-9, -3, 4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(5, 5, 1);
                var v1 = new int3(-7, -6, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-6, 1, 9);
                var v1 = new int3(-3, 8, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-6, 8, 7);
                var v1 = new int3(1, -1, -1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(9, -3, 0);
                var v1 = new int3(-1, -6, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(8, 5, 8);
                var v1 = new int3(1, -2, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(1, -3, -5);
                var v1 = new int3(-7, -2, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-1, 2, 3);
                var v1 = new int3(-1, 8, 5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-8, 7, 1);
                var v1 = new int3(4, -6, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new int3(2, 2, -3);
                var v1 = new int3(0, 8, 5);
                var v2 = new int3(4, 2, 8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-5, -3, -7);
                var v1 = new int3(6, 1, 8);
                var v2 = new int3(-4, -6, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-5, 4, -5);
                var v1 = new int3(7, -2, 3);
                var v2 = new int3(3, -9, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-7, 2, 9);
                var v1 = new int3(0, 1, 8);
                var v2 = new int3(-9, 3, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-5, -6, 5);
                var v1 = new int3(1, -2, -8);
                var v2 = new int3(1, 1, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-4, 3, -5);
                var v1 = new int3(8, -3, 0);
                var v2 = new int3(6, 5, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(0, -4, 9);
                var v1 = new int3(9, -6, 9);
                var v2 = new int3(-8, 6, 0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-8, -4, -2);
                var v1 = new int3(8, 7, -7);
                var v2 = new int3(3, -9, 0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(0, -4, -2);
                var v1 = new int3(-7, 5, -1);
                var v2 = new int3(3, 9, -5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-2, 8, 8);
                var v1 = new int3(8, -4, -5);
                var v2 = new int3(1, -8, 9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new int3(-1, 5, -1);
                var v1 = new int3(-3, 4, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(3, 5, -3);
                var v1 = new int3(2, -9, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(4, -2, 8);
                var v1 = new int3(0, -9, -7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-1, -8, 6);
                var v1 = new int3(8, 8, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-5, 0, -7);
                var v1 = new int3(1, -9, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(9, -2, 9);
                var v1 = new int3(7, -5, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(6, -6, -4);
                var v1 = new int3(-5, 0, -4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-4, -8, 0);
                var v1 = new int3(3, 0, -4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-4, -1, -2);
                var v1 = new int3(3, 2, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(1, 2, -6);
                var v1 = new int3(9, -8, 3);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new int3(6, -9, -2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(0, 4, 6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-9, -4, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-3, -7, -4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-5, 3, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(7, -7, -5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-6, 1, 5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-8, -1, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-2, -8, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(5, 1, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new int3(5, 2, -2);
                var v1 = new int3(7, 5, 8);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-3, -3, -7);
                var v1 = new int3(5, 2, 7);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-8, 8, -8);
                var v1 = new int3(-9, 3, -8);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(9, -6, -8);
                var v1 = new int3(-1, -4, -6);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(5, 8, 4);
                var v1 = new int3(6, 9, -3);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(7, -6, -2);
                var v1 = new int3(2, 1, -2);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-6, 7, -7);
                var v1 = new int3(2, 5, -5);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(1, 3, -9);
                var v1 = new int3(9, -7, -2);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(7, 3, -4);
                var v1 = new int3(-2, 7, -3);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(2, -5, 7);
                var v1 = new int3(-5, 1, -6);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1780635494);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.Random(random, -3, 0);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            Assert.AreEqual(avg.z, -2, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.z, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(2144337901);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomUniform(random, -1, 3);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            Assert.AreEqual(avg.z, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(186654162);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.Random(random, -1, 3);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            Assert.AreEqual(avg.z, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1958932776);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomUniform(random, 1, 5);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1700121967);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.Random(random, 0, 2);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            Assert.AreEqual(avg.z, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1159097561);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 2.0790699494905165);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.0790699494905165, 1.0);
            Assert.AreEqual(avg.y, 2.0790699494905165, 1.0);
            Assert.AreEqual(avg.z, 2.0790699494905165, 1.0);
            
            Assert.AreEqual(variance.x, 2.0790699494905165, 3.0);
            Assert.AreEqual(variance.y, 2.0790699494905165, 3.0);
            Assert.AreEqual(variance.z, 2.0790699494905165, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(917240767);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 3.024302597867466);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.024302597867466, 1.0);
            Assert.AreEqual(avg.y, 3.024302597867466, 1.0);
            Assert.AreEqual(avg.z, 3.024302597867466, 1.0);
            
            Assert.AreEqual(variance.x, 3.024302597867466, 3.0);
            Assert.AreEqual(variance.y, 3.024302597867466, 3.0);
            Assert.AreEqual(variance.z, 3.024302597867466, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(900081952);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 1.0891061474518413);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.0891061474518413, 1.0);
            Assert.AreEqual(avg.y, 1.0891061474518413, 1.0);
            Assert.AreEqual(avg.z, 1.0891061474518413, 1.0);
            
            Assert.AreEqual(variance.x, 1.0891061474518413, 3.0);
            Assert.AreEqual(variance.y, 1.0891061474518413, 3.0);
            Assert.AreEqual(variance.z, 1.0891061474518413, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(493530742);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 2.6544238664928934);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.6544238664928934, 1.0);
            Assert.AreEqual(avg.y, 2.6544238664928934, 1.0);
            Assert.AreEqual(avg.z, 2.6544238664928934, 1.0);
            
            Assert.AreEqual(variance.x, 2.6544238664928934, 3.0);
            Assert.AreEqual(variance.y, 2.6544238664928934, 3.0);
            Assert.AreEqual(variance.z, 2.6544238664928934, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1901556046);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 2.124719613056965);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.124719613056965, 1.0);
            Assert.AreEqual(avg.y, 2.124719613056965, 1.0);
            Assert.AreEqual(avg.z, 2.124719613056965, 1.0);
            
            Assert.AreEqual(variance.x, 2.124719613056965, 3.0);
            Assert.AreEqual(variance.y, 2.124719613056965, 3.0);
            Assert.AreEqual(variance.z, 2.124719613056965, 3.0);
        }

    }
}
