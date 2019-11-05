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
    public class IntVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new int3(-7);
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var v = new int3(-9, -5, 9);
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var v = new int3(new int2(6, 9));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new int3(new int3(5, -9, -3));
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var v = new int3(new int4(9, 1, -9, -3));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-9, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new int3(-4, 8, -4);
            Assert.AreEqual(-4, v[0]);
            Assert.AreEqual(8, v[1]);
            Assert.AreEqual(-4, v[2]);
            
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
            
            v[2] = 0;
            Assert.AreEqual(0, v[2]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new int3(-4, -7, 0);
            var vals = v.Values;
            Assert.AreEqual(-4, vals[0]);
            Assert.AreEqual(-7, vals[1]);
            Assert.AreEqual(0, vals[2]);
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
            var v1 = new int3(-5, 1, 2);
            var v2 = new int3(-5, 1, 2);
            var v3 = new int3(2, 1, -5);
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
            var v = new int3(4, -7, 5);
            
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
            var v0 = new int3(5, 2, -9);
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
                var v0 = new int3(5, 9, -7);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-9, -7, -6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-5, -3, 6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(1, -7, -4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-4, 9, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(1, 3, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(6, -9, -8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-1, -7, 8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(-6, -9, -1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int3(5, 5, -5);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new int3(-1, -6, -4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(0, 6, 6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(-9, -1, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(-5, 1, -3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(9, -7, -4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(3, -3, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(1, 7, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(4, -2, -7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(6, 7, -3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int3(-6, -8, -5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new int3(-5, 9, -5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(-5, 8, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(1, 6, -2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(6, 7, 0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(6, -7, -7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(5, -5, -1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(6, 5, -3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(7, 8, 5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(5, -5, 2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int3(-7, -6, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new int3(3, -4, 3);
                var v1 = new int3(-4, 0, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(-9, 1, -3);
                var v1 = new int3(-9, -2, 8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(7, 0, -6);
                var v1 = new int3(-5, -6, 1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(-8, -3, -7);
                var v1 = new int3(-6, -3, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(0, 6, -4);
                var v1 = new int3(8, -5, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(4, 9, 5);
                var v1 = new int3(6, 6, -1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(-1, -4, -8);
                var v1 = new int3(-3, -4, -6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(-5, 4, -7);
                var v1 = new int3(3, 6, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(3, 3, 3);
                var v1 = new int3(-6, 4, -5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int3(0, 6, 1);
                var v1 = new int3(-3, -4, -3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new int3(-8, 8, 8);
                var v1 = new int3(4, 7, 8);
                var v2 = new int3(8, 8, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(6, -1, 2);
                var v1 = new int3(2, -1, -7);
                var v2 = new int3(5, 7, -6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(2, -3, 4);
                var v1 = new int3(5, -5, 1);
                var v2 = new int3(0, -9, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(8, 4, 9);
                var v1 = new int3(0, -7, 7);
                var v2 = new int3(-1, 6, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-1, -9, -1);
                var v1 = new int3(-2, 3, -2);
                var v2 = new int3(-2, -8, -2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(6, 1, 5);
                var v1 = new int3(-7, -9, 6);
                var v2 = new int3(1, 7, -7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-2, -2, -4);
                var v1 = new int3(6, 4, 8);
                var v2 = new int3(-7, -9, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(-5, 5, -3);
                var v1 = new int3(-4, -1, 3);
                var v2 = new int3(6, -5, 7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(5, -1, 8);
                var v1 = new int3(-3, -3, -7);
                var v2 = new int3(9, -3, -7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int3(5, -2, 5);
                var v1 = new int3(3, -8, 9);
                var v2 = new int3(9, -9, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new int3(-9, -2, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-8, 8, -9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-5, -7, 9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-6, 9, -5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(1, 8, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-1, -5, 8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-9, 8, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(5, 3, -4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-1, -4, 1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int3(-8, 3, -6);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new int3(2, 3, 4);
                var v1 = new int3(7, 3, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(5, -8, -9);
                var v1 = new int3(-2, 5, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-4, 8, 6);
                var v1 = new int3(5, 7, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(1, 8, 1);
                var v1 = new int3(-7, 6, -4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-6, -3, -6);
                var v1 = new int3(0, -5, -6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(6, 0, -8);
                var v1 = new int3(-1, -5, -4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-7, -6, -3);
                var v1 = new int3(9, 1, 5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-2, -2, -5);
                var v1 = new int3(-6, 8, -5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-3, 1, 7);
                var v1 = new int3(5, -1, 3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int3(-6, 4, -7);
                var v1 = new int3(9, -2, 9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new int3(9, -5, 9);
                var v1 = new int3(-8, 7, 7);
                var v2 = new int3(8, -7, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(1, -6, 9);
                var v1 = new int3(-3, -7, -8);
                var v2 = new int3(-6, 3, 7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-8, -7, -9);
                var v1 = new int3(-7, 9, 5);
                var v2 = new int3(9, 2, -4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(8, 9, 7);
                var v1 = new int3(5, -6, 3);
                var v2 = new int3(4, 4, -2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-4, -6, 0);
                var v1 = new int3(-3, 0, 2);
                var v2 = new int3(3, -1, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-5, -8, 5);
                var v1 = new int3(5, 8, 2);
                var v2 = new int3(-1, -6, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-4, -3, 5);
                var v1 = new int3(4, 7, 4);
                var v2 = new int3(-3, 0, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(-8, -5, -9);
                var v1 = new int3(5, 7, -3);
                var v2 = new int3(5, 2, 7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(6, 4, -7);
                var v1 = new int3(-7, -3, -8);
                var v2 = new int3(5, -5, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int3(8, 3, 0);
                var v1 = new int3(4, -5, 0);
                var v2 = new int3(2, -1, -2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new int3(9, -4, 0);
                var v1 = new int3(0, -6, 6);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-7, 2, -9);
                var v1 = new int3(1, -7, -4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(6, -1, -4);
                var v1 = new int3(7, -4, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-4, 2, -3);
                var v1 = new int3(3, 4, -9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-1, -6, -1);
                var v1 = new int3(-5, 6, 6);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-8, -2, -6);
                var v1 = new int3(-8, -4, 0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-5, 2, 6);
                var v1 = new int3(-3, 8, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-6, -5, 6);
                var v1 = new int3(-3, -7, 8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(8, 3, -2);
                var v1 = new int3(-3, -4, -3);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int3(-5, 5, 8);
                var v1 = new int3(0, 9, 0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new int3(-4, -7, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-3, 0, -8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(1, -3, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(6, -6, 0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-4, 7, -1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(8, 1, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-1, 0, 5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-7, -6, 7);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(-6, 5, -5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int3(7, 1, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new int3(8, -5, 6);
                var v1 = new int3(0, 3, 7);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-7, 7, -3);
                var v1 = new int3(-7, -6, 0);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(2, 3, 9);
                var v1 = new int3(2, -8, 2);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-9, -6, -4);
                var v1 = new int3(3, 0, 8);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-8, -3, 3);
                var v1 = new int3(4, 7, 9);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-4, 5, 7);
                var v1 = new int3(-3, -3, -6);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-6, -9, 7);
                var v1 = new int3(-7, 6, 1);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(8, -6, 9);
                var v1 = new int3(-8, 9, 2);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(9, 8, 8);
                var v1 = new int3(2, 1, 6);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new int3(-6, 4, -4);
                var v1 = new int3(-8, 1, -1);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(717778136);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.Random(random, -3, 1);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            Assert.AreEqual(avg.z, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(949093070);
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
        public void RandomUniform2()
        {
            var random = new Random(217418614);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.Random(random, -2, 1);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            Assert.AreEqual(avg.z, -1, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.z, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(850059509);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomUniform(random, 3, 7);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1893032463);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.Random(random, 4, 7);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5, 1.0);
            Assert.AreEqual(avg.y, 5, 1.0);
            Assert.AreEqual(avg.z, 5, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.z, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(434128247);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 0.6140042921127772);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.6140042921127772, 1.0);
            Assert.AreEqual(avg.y, 0.6140042921127772, 1.0);
            Assert.AreEqual(avg.z, 0.6140042921127772, 1.0);
            
            Assert.AreEqual(variance.x, 0.6140042921127772, 3.0);
            Assert.AreEqual(variance.y, 0.6140042921127772, 3.0);
            Assert.AreEqual(variance.z, 0.6140042921127772, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(1030759061);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 3.34248948695254);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.34248948695254, 1.0);
            Assert.AreEqual(avg.y, 3.34248948695254, 1.0);
            Assert.AreEqual(avg.z, 3.34248948695254, 1.0);
            
            Assert.AreEqual(variance.x, 3.34248948695254, 3.0);
            Assert.AreEqual(variance.y, 3.34248948695254, 3.0);
            Assert.AreEqual(variance.z, 3.34248948695254, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(792254961);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 2.479324292847572);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.479324292847572, 1.0);
            Assert.AreEqual(avg.y, 2.479324292847572, 1.0);
            Assert.AreEqual(avg.z, 2.479324292847572, 1.0);
            
            Assert.AreEqual(variance.x, 2.479324292847572, 3.0);
            Assert.AreEqual(variance.y, 2.479324292847572, 3.0);
            Assert.AreEqual(variance.z, 2.479324292847572, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1705128250);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 2.82191314842641);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.82191314842641, 1.0);
            Assert.AreEqual(avg.y, 2.82191314842641, 1.0);
            Assert.AreEqual(avg.z, 2.82191314842641, 1.0);
            
            Assert.AreEqual(variance.x, 2.82191314842641, 3.0);
            Assert.AreEqual(variance.y, 2.82191314842641, 3.0);
            Assert.AreEqual(variance.z, 2.82191314842641, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(627776145);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int3.RandomPoisson(random, 0.5802227105387592);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5802227105387592, 1.0);
            Assert.AreEqual(avg.y, 0.5802227105387592, 1.0);
            Assert.AreEqual(avg.z, 0.5802227105387592, 1.0);
            
            Assert.AreEqual(variance.x, 0.5802227105387592, 3.0);
            Assert.AreEqual(variance.y, 0.5802227105387592, 3.0);
            Assert.AreEqual(variance.z, 0.5802227105387592, 3.0);
        }

    }
}
