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
    public class DoubleVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new double2(9d);
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(9d, v.y);
            }
            {
                var v = new double2(0.5d, 1.5d);
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
            }
            {
                var v = new double2(new double2(6.5d, -7d));
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-7d, v.y);
            }
            {
                var v = new double2(new double3(-9.5d, 1.0, 0.0));
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(1.0, v.y);
            }
            {
                var v = new double2(new double4(5d, 3d, 6.5d, -4d));
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(3d, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new double2(9d, 1.5d);
            Assert.AreEqual(9d, v[0]);
            Assert.AreEqual(1.5d, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[0] = 0.0;
            Assert.AreEqual(0.0, v[0]);
            v[0] = 1.0;
            Assert.AreEqual(1.0, v[0]);
            v[1] = 2d;
            Assert.AreEqual(2d, v[1]);
            v[1] = 3d;
            Assert.AreEqual(3d, v[1]);
            v[1] = 4d;
            Assert.AreEqual(4d, v[1]);
            v[0] = 5d;
            Assert.AreEqual(5d, v[0]);
            v[0] = 6d;
            Assert.AreEqual(6d, v[0]);
            v[0] = 7d;
            Assert.AreEqual(7d, v[0]);
            v[1] = 8d;
            Assert.AreEqual(8d, v[1]);
            v[0] = 9d;
            Assert.AreEqual(9d, v[0]);
            v[1] = -1d;
            Assert.AreEqual(-1d, v[1]);
            v[1] = -2d;
            Assert.AreEqual(-2d, v[1]);
            v[0] = -3d;
            Assert.AreEqual(-3d, v[0]);
            v[1] = -4d;
            Assert.AreEqual(-4d, v[1]);
            v[1] = -5d;
            Assert.AreEqual(-5d, v[1]);
            v[1] = -6d;
            Assert.AreEqual(-6d, v[1]);
            v[0] = -7d;
            Assert.AreEqual(-7d, v[0]);
            v[0] = -8d;
            Assert.AreEqual(-8d, v[0]);
            v[0] = -9d;
            Assert.AreEqual(-9d, v[0]);
            v[1] = -9.5d;
            Assert.AreEqual(-9.5d, v[1]);
            v[0] = -8.5d;
            Assert.AreEqual(-8.5d, v[0]);
            v[0] = -7.5d;
            Assert.AreEqual(-7.5d, v[0]);
            v[0] = -6.5d;
            Assert.AreEqual(-6.5d, v[0]);
            v[1] = -5.5d;
            Assert.AreEqual(-5.5d, v[1]);
            v[0] = -4.5d;
            Assert.AreEqual(-4.5d, v[0]);
            v[0] = -3.5d;
            Assert.AreEqual(-3.5d, v[0]);
            v[0] = -2.5d;
            Assert.AreEqual(-2.5d, v[0]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[0] = -0.5d;
            Assert.AreEqual(-0.5d, v[0]);
            v[1] = 0.5d;
            Assert.AreEqual(0.5d, v[1]);
            v[0] = 1.5d;
            Assert.AreEqual(1.5d, v[0]);
            v[1] = 2.5d;
            Assert.AreEqual(2.5d, v[1]);
            v[0] = 3.5d;
            Assert.AreEqual(3.5d, v[0]);
            v[1] = 4.5d;
            Assert.AreEqual(4.5d, v[1]);
            v[1] = 5.5d;
            Assert.AreEqual(5.5d, v[1]);
            v[0] = 6.5d;
            Assert.AreEqual(6.5d, v[0]);
            v[1] = 7.5d;
            Assert.AreEqual(7.5d, v[1]);
            v[0] = 8.5d;
            Assert.AreEqual(8.5d, v[0]);
            v[0] = 9.5d;
            Assert.AreEqual(9.5d, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new double2(-0.5d, -2.5d);
            var vals = v.Values;
            Assert.AreEqual(-0.5d, vals[0]);
            Assert.AreEqual(-2.5d, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, double2.Zero.x);
            Assert.AreEqual(0.0, double2.Zero.y);
            
            Assert.AreEqual(1.0, double2.Ones.x);
            Assert.AreEqual(1.0, double2.Ones.y);
            
            Assert.AreEqual(1.0, double2.UnitX.x);
            Assert.AreEqual(0.0, double2.UnitX.y);
            
            Assert.AreEqual(0.0, double2.UnitY.x);
            Assert.AreEqual(1.0, double2.UnitY.y);
            
            Assert.AreEqual(double.MaxValue, double2.MaxValue.x);
            Assert.AreEqual(double.MaxValue, double2.MaxValue.y);
            
            Assert.AreEqual(double.MinValue, double2.MinValue.x);
            Assert.AreEqual(double.MinValue, double2.MinValue.y);
            
            Assert.AreEqual(double.Epsilon, double2.Epsilon.x);
            Assert.AreEqual(double.Epsilon, double2.Epsilon.y);
            
            Assert.AreEqual(double.NaN, double2.NaN.x);
            Assert.AreEqual(double.NaN, double2.NaN.y);
            
            Assert.AreEqual(double.NegativeInfinity, double2.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, double2.NegativeInfinity.y);
            
            Assert.AreEqual(double.PositiveInfinity, double2.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, double2.PositiveInfinity.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new double2(2d, 8.5d);
            var v2 = new double2(2d, 8.5d);
            var v3 = new double2(8.5d, 2d);
            Assert.That(v1 == new double2(v1));
            Assert.That(v2 == new double2(v2));
            Assert.That(v3 == new double2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new double2(9d, -0.5d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = double2.Parse(s0);
            var v1 = double2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = double2.TryParse(s0, out v0);
            var b1 = double2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = double2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = double2.TryParse("", out v0);
            Assert.False(b0);
            b0 = double2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { double2.Parse(null); });
            Assert.Throws<FormatException>(() => { double2.Parse(""); });
            Assert.Throws<FormatException>(() => { double2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = double2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = double2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = double2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new double2(-2.5d, -8d);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<double2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new double2(0.0, -9d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(-1d, 5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(-8.5d, -6d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(6.5d, 1.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(-6.5d, -8.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(-8d, 9.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(-7d, -4d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(-1.5d, -2.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(3.5d, 9d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double2(-3.5d, 7d);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new double2(7.5d, -3d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(-7d, 6.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(6.5d, -7.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(4.5d, 4.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(6d, -1d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(8d, -1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(2.5d, -1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(8.5d, -9d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(6d, 8d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double2(-6.5d, -1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new double2(-4.5d, -1d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(-7.5d, -3.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(-1.5d, 9d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(2d, -1d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(8d, -7.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(4d, 3.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(8.5d, -6.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(9.5d, -3d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(4.5d, -2d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double2(9.5d, -2.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new double2(8d, -4.5d);
                var v1 = new double2(6d, -2.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(-5d, -5.5d);
                var v1 = new double2(9.5d, 8.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(9d, -1.5d);
                var v1 = new double2(6.5d, 7.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(3d, -2.5d);
                var v1 = new double2(-8.5d, 5.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(-4d, 8d);
                var v1 = new double2(8d, -9.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(-6d, -3.5d);
                var v1 = new double2(4.5d, -2.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(-2d, 6.5d);
                var v1 = new double2(7.5d, -2d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(3.5d, -7d);
                var v1 = new double2(6d, -0.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(4d, -2.5d);
                var v1 = new double2(0.5d, -8.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double2(-9d, 6.5d);
                var v1 = new double2(4.5d, -7.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new double2(-9d, 1.5d);
                var v1 = new double2(9d, -4d);
                var v2 = new double2(0.5d, 7.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(-2d, 2.5d);
                var v1 = new double2(-4.5d, -5.5d);
                var v2 = new double2(2d, 1.0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(-1d, 9d);
                var v1 = new double2(-1.5d, -1d);
                var v2 = new double2(-3d, 7d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(7d, 6d);
                var v1 = new double2(5.5d, 8d);
                var v2 = new double2(4d, -0.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(3.5d, 4d);
                var v1 = new double2(8.5d, 9.5d);
                var v2 = new double2(-2.5d, 8d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(-0.5d, 3d);
                var v1 = new double2(4d, -1d);
                var v2 = new double2(-6.5d, -9.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(-4d, 6.5d);
                var v1 = new double2(-7.5d, 7d);
                var v2 = new double2(9d, 1.0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(-7.5d, 8.5d);
                var v1 = new double2(-6d, -5.5d);
                var v2 = new double2(-6.5d, 6d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(-0.5d, 9.5d);
                var v1 = new double2(7.5d, 4d);
                var v2 = new double2(9.5d, -8d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double2(-6d, -1d);
                var v1 = new double2(-2.5d, -9.5d);
                var v2 = new double2(-8.5d, -3.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new double2(-7d, -1d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(-3d, 7.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(-6.5d, -4d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(2d, 8d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(-6d, -1d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(8.5d, -3d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(0.5d, 6.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(-6d, -2.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(-3.5d, -5.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double2(7d, 4.5d);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new double2(-3d, 4.5d);
                var v1 = new double2(-6d, -3.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(-3.5d, -3d);
                var v1 = new double2(-0.5d, 0.0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(1.5d, 6.5d);
                var v1 = new double2(7.5d, 2.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(-6d, 6d);
                var v1 = new double2(6d, -2.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(9.5d, -5d);
                var v1 = new double2(-4d, 1.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(-2.5d, 1.0);
                var v1 = new double2(-8.5d, -4.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(0.5d, 7d);
                var v1 = new double2(8d, -1d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(2.5d, 8d);
                var v1 = new double2(-0.5d, 3.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(-1.5d, 6.5d);
                var v1 = new double2(6.5d, -3.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double2(7.5d, 0.0);
                var v1 = new double2(-6.5d, 7d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new double2(2d, 2.5d);
                var v1 = new double2(1.5d, -7.5d);
                var v2 = new double2(-5.5d, -4.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(2d, -7.5d);
                var v1 = new double2(2.5d, -5.5d);
                var v2 = new double2(4d, 0.0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(7d, 2d);
                var v1 = new double2(3.5d, 1.5d);
                var v2 = new double2(-6.5d, -9d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(3d, -9.5d);
                var v1 = new double2(8.5d, -6d);
                var v2 = new double2(-3.5d, -3.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(-9d, -3.5d);
                var v1 = new double2(-6d, -8.5d);
                var v2 = new double2(-1d, -3.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(5.5d, 7d);
                var v1 = new double2(-1d, -1.5d);
                var v2 = new double2(-2.5d, -4.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(-8d, -5.5d);
                var v1 = new double2(-4.5d, 4.5d);
                var v2 = new double2(6.5d, 1.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(9.5d, -8d);
                var v1 = new double2(-2.5d, 9d);
                var v2 = new double2(8d, 8.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(5.5d, -7.5d);
                var v1 = new double2(-6d, 4d);
                var v2 = new double2(4.5d, -0.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double2(3d, -3.5d);
                var v1 = new double2(6d, 4d);
                var v2 = new double2(3d, 8.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new double2(-7.5d, 8.5d);
                var v1 = new double2(-4d, -5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(7.5d, -1d);
                var v1 = new double2(-9.5d, -5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(2d, -1d);
                var v1 = new double2(-9d, -1d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(3d, -6.5d);
                var v1 = new double2(5d, -9.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(-9d, -9d);
                var v1 = new double2(-0.5d, -6.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(-5.5d, -3d);
                var v1 = new double2(-2d, 3d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(-3d, 2.5d);
                var v1 = new double2(9d, 7d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(-2.5d, 6.5d);
                var v1 = new double2(2.5d, 1.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(5d, -1d);
                var v1 = new double2(3d, -7d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double2(-6d, -6d);
                var v1 = new double2(-3d, 1.0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new double2(-8d, 8.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(-8d, 2d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(-6d, 0.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(8d, -5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(2.5d, 3.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(8.5d, 3.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(-5.5d, -4.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(3d, -9.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(1.0, -1.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double2(2d, 9d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(312102399);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.Random(random, 0, 1);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1465387349);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomUniform(random, 2, 3);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(202418722);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.Random(random, -4, -3);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3.5, 1.0);
            Assert.AreEqual(avg.y, -3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(577623755);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomUniform(random, -3, 0);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(231588872);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.Random(random, -2, 0);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            
            Assert.AreEqual(variance.x, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.3333333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1759021916);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomNormal(random, 1.2577547837317709d, 1.1558835446629132d);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.2577547837317709, 1.0);
            Assert.AreEqual(avg.y, 1.2577547837317709, 1.0);
            
            Assert.AreEqual(variance.x, 1.1558835446629132, 3.0);
            Assert.AreEqual(variance.y, 1.1558835446629132, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1913008596);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomGaussian(random, 0.0738167381257826d, 3.6358582105654564d);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.0738167381257826, 1.0);
            Assert.AreEqual(avg.y, 0.0738167381257826, 1.0);
            
            Assert.AreEqual(variance.x, 3.6358582105654564, 3.0);
            Assert.AreEqual(variance.y, 3.6358582105654564, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(92912240);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomNormal(random, 1.8835649676078767d, 0.9454221050000853d);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.8835649676078767, 1.0);
            Assert.AreEqual(avg.y, 1.8835649676078767, 1.0);
            
            Assert.AreEqual(variance.x, 0.9454221050000853, 3.0);
            Assert.AreEqual(variance.y, 0.9454221050000853, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(1504732004);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomGaussian(random, -1.5643421744761719d, 7.104634264067111d);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5643421744761719, 1.0);
            Assert.AreEqual(avg.y, -1.5643421744761719, 1.0);
            
            Assert.AreEqual(variance.x, 7.104634264067111, 3.0);
            Assert.AreEqual(variance.y, 7.104634264067111, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(257469483);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomNormal(random, -0.6072049581479304d, 3.0634770463516365d);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.6072049581479304, 1.0);
            Assert.AreEqual(avg.y, -0.6072049581479304, 1.0);
            
            Assert.AreEqual(variance.x, 3.0634770463516365, 3.0);
            Assert.AreEqual(variance.y, 3.0634770463516365, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(1267011896);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomNormal(random);
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
            var random = new Random(522836063);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomNormal(random);
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
            var random = new Random(1075440104);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomNormal(random);
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
            var random = new Random(1458915983);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomNormal(random);
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
            var random = new Random(1695352363);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double2.RandomNormal(random);
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
