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
    public class IntVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new int2(0);
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var v = new int2(3, 4);
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(4, v.y);
            }
            {
                var v = new int2(new int2(-4, -6));
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-6, v.y);
            }
            {
                var v = new int2(new int3(0, 9, 0));
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(9, v.y);
            }
            {
                var v = new int2(new int4(-2, 4, 9, 4));
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(4, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new int2(-7, -3);
            Assert.AreEqual(-7, v[0]);
            Assert.AreEqual(-3, v[1]);
            
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
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[1] = 3;
            Assert.AreEqual(3, v[1]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[0] = -9;
            Assert.AreEqual(-9, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new int2(-8, -2);
            var vals = v.Values;
            Assert.AreEqual(-8, vals[0]);
            Assert.AreEqual(-2, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, int2.Zero.x);
            Assert.AreEqual(0, int2.Zero.y);
            
            Assert.AreEqual(1, int2.Ones.x);
            Assert.AreEqual(1, int2.Ones.y);
            
            Assert.AreEqual(1, int2.UnitX.x);
            Assert.AreEqual(0, int2.UnitX.y);
            
            Assert.AreEqual(0, int2.UnitY.x);
            Assert.AreEqual(1, int2.UnitY.y);
            
            Assert.AreEqual(int.MaxValue, int2.MaxValue.x);
            Assert.AreEqual(int.MaxValue, int2.MaxValue.y);
            
            Assert.AreEqual(int.MinValue, int2.MinValue.x);
            Assert.AreEqual(int.MinValue, int2.MinValue.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new int2(-2, -7);
            var v2 = new int2(-2, -7);
            var v3 = new int2(-7, -2);
            Assert.That(v1 == new int2(v1));
            Assert.That(v2 == new int2(v2));
            Assert.That(v3 == new int2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new int2(7, -2);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = int2.Parse(s0);
            var v1 = int2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = int2.TryParse(s0, out v0);
            var b1 = int2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = int2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = int2.TryParse("", out v0);
            Assert.False(b0);
            b0 = int2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { int2.Parse(null); });
            Assert.Throws<FormatException>(() => { int2.Parse(""); });
            Assert.Throws<FormatException>(() => { int2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = int2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = int2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = int2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new int2(6, 6);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<int2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new int2(7, -8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(9, -5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(-7, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(3, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(-6, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(-3, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(-4, 9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(7, -3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(9, 9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new int2(-7, 4);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new int2(8, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(4, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(-7, -5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(-4, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(-2, 0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(-3, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(-3, -7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(7, -5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(-1, -7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new int2(5, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new int2(-7, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(-2, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(6, 6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(-7, -2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(-1, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(1, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(2, 2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(-5, 8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(-8, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new int2(-7, -8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new int2(-8, -3);
                var v1 = new int2(1, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(-6, 1);
                var v1 = new int2(-8, 4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(4, 6);
                var v1 = new int2(-4, 8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(-1, 6);
                var v1 = new int2(-7, -2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(-5, 2);
                var v1 = new int2(2, -9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(-5, 4);
                var v1 = new int2(4, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(-7, -2);
                var v1 = new int2(0, 3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(7, -4);
                var v1 = new int2(4, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(6, 4);
                var v1 = new int2(0, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new int2(-4, -8);
                var v1 = new int2(-2, -5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new int2(-5, -9);
                var v1 = new int2(-8, -1);
                var v2 = new int2(7, -9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(-1, 9);
                var v1 = new int2(-7, -4);
                var v2 = new int2(-9, -2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(6, 8);
                var v1 = new int2(-6, 8);
                var v2 = new int2(6, -3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(1, -1);
                var v1 = new int2(3, 8);
                var v2 = new int2(-8, 2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(1, -5);
                var v1 = new int2(-9, -7);
                var v2 = new int2(8, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(-9, -5);
                var v1 = new int2(3, 3);
                var v2 = new int2(-8, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(-9, 5);
                var v1 = new int2(-5, 0);
                var v2 = new int2(-9, 6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(8, 6);
                var v1 = new int2(0, 7);
                var v2 = new int2(5, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(-2, -2);
                var v1 = new int2(-4, -9);
                var v2 = new int2(8, -6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new int2(2, 5);
                var v1 = new int2(1, -6);
                var v2 = new int2(8, -3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new int2(-3, -7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(0, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(6, 8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(3, 1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(-3, 4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(0, -9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(6, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(5, 3);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(-8, 1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new int2(4, -5);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new int2(-1, 5);
                var v1 = new int2(2, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(-2, 8);
                var v1 = new int2(-3, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(4, 7);
                var v1 = new int2(4, 7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(-5, -1);
                var v1 = new int2(6, 8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(5, -6);
                var v1 = new int2(2, -5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(6, -7);
                var v1 = new int2(5, 9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(5, 1);
                var v1 = new int2(-4, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(-7, 3);
                var v1 = new int2(-3, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(-2, 3);
                var v1 = new int2(9, 9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new int2(-3, 7);
                var v1 = new int2(-3, 2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new int2(-6, -2);
                var v1 = new int2(-2, -9);
                var v2 = new int2(-1, 3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(1, -9);
                var v1 = new int2(-4, -4);
                var v2 = new int2(5, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(-6, 0);
                var v1 = new int2(-5, -6);
                var v2 = new int2(7, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(-3, -8);
                var v1 = new int2(1, 5);
                var v2 = new int2(3, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(8, -1);
                var v1 = new int2(4, 3);
                var v2 = new int2(-1, 9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(3, -7);
                var v1 = new int2(4, 0);
                var v2 = new int2(-5, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(-1, -6);
                var v1 = new int2(6, -3);
                var v2 = new int2(7, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(6, 9);
                var v1 = new int2(2, 8);
                var v2 = new int2(-5, -6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(1, 2);
                var v1 = new int2(-3, 3);
                var v2 = new int2(5, -2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new int2(-5, 9);
                var v1 = new int2(8, 4);
                var v2 = new int2(-1, 0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new int2(-4, -6);
                var v1 = new int2(2, 0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(2, -5);
                var v1 = new int2(0, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(8, -3);
                var v1 = new int2(7, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(-7, -1);
                var v1 = new int2(-6, 3);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(4, 9);
                var v1 = new int2(-5, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(-4, -9);
                var v1 = new int2(-8, -9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(-1, 0);
                var v1 = new int2(-9, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(4, -8);
                var v1 = new int2(-9, 8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(0, 0);
                var v1 = new int2(1, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new int2(3, 2);
                var v1 = new int2(-2, 0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new int2(-2, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(-9, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(-8, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(9, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(-5, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(6, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(-5, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(2, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(9, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new int2(-9, -5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(2096214291);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.Random(random, 3, 6);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1864899357);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.RandomUniform(random, 2, 6);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1155803487);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.Random(random, -5, -1);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3.5, 1.0);
            Assert.AreEqual(avg.y, -3.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1963932918);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.RandomUniform(random, 0, 5);
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
        public void RandomUniform4()
        {
            var random = new Random(920959964);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.Random(random, -1, 3);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(128929582);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.RandomPoisson(random, 1.5890432955180498);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5890432955180498, 1.0);
            Assert.AreEqual(avg.y, 1.5890432955180498, 1.0);
            
            Assert.AreEqual(variance.x, 1.5890432955180498, 3.0);
            Assert.AreEqual(variance.y, 1.5890432955180498, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(1783233366);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.RandomPoisson(random, 2.6415849170375547);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.6415849170375547, 1.0);
            Assert.AreEqual(avg.y, 2.6415849170375547, 1.0);
            
            Assert.AreEqual(variance.x, 2.6415849170375547, 3.0);
            Assert.AreEqual(variance.y, 2.6415849170375547, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(487056296);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.RandomPoisson(random, 2.723723294783255);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.723723294783255, 1.0);
            Assert.AreEqual(avg.y, 2.723723294783255, 1.0);
            
            Assert.AreEqual(variance.x, 2.723723294783255, 3.0);
            Assert.AreEqual(variance.y, 2.723723294783255, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(2010326915);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.RandomPoisson(random, 2.1210085785114243);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.1210085785114243, 1.0);
            Assert.AreEqual(avg.y, 2.1210085785114243, 1.0);
            
            Assert.AreEqual(variance.x, 2.1210085785114243, 3.0);
            Assert.AreEqual(variance.y, 2.1210085785114243, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(38732635);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = int2.RandomPoisson(random, 1.2811272804537448);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.2811272804537448, 1.0);
            Assert.AreEqual(avg.y, 1.2811272804537448, 1.0);
            
            Assert.AreEqual(variance.x, 1.2811272804537448, 3.0);
            Assert.AreEqual(variance.y, 1.2811272804537448, 3.0);
        }

    }
}
