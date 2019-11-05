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
    public class DoubleVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new double3(0.5d);
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
            }
            {
                var v = new double3(-9.5d, -3d, -4.5d);
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(-4.5d, v.z);
            }
            {
                var v = new double3(new double2(-2.5d, 1.5d));
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var v = new double3(new double3(2d, -6d, -2.5d));
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(-6d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var v = new double3(new double4(5.5d, -3.5d, 4.5d, 6.5d));
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new double3(1.5d, 6d, 4d);
            Assert.AreEqual(1.5d, v[0]);
            Assert.AreEqual(6d, v[1]);
            Assert.AreEqual(4d, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[0] = 0.0;
            Assert.AreEqual(0.0, v[0]);
            v[2] = 1.0;
            Assert.AreEqual(1.0, v[2]);
            v[1] = 2d;
            Assert.AreEqual(2d, v[1]);
            v[0] = 3d;
            Assert.AreEqual(3d, v[0]);
            v[2] = 4d;
            Assert.AreEqual(4d, v[2]);
            v[0] = 5d;
            Assert.AreEqual(5d, v[0]);
            v[2] = 6d;
            Assert.AreEqual(6d, v[2]);
            v[2] = 7d;
            Assert.AreEqual(7d, v[2]);
            v[2] = 8d;
            Assert.AreEqual(8d, v[2]);
            v[2] = 9d;
            Assert.AreEqual(9d, v[2]);
            v[1] = -1d;
            Assert.AreEqual(-1d, v[1]);
            v[1] = -2d;
            Assert.AreEqual(-2d, v[1]);
            v[0] = -3d;
            Assert.AreEqual(-3d, v[0]);
            v[0] = -4d;
            Assert.AreEqual(-4d, v[0]);
            v[0] = -5d;
            Assert.AreEqual(-5d, v[0]);
            v[0] = -6d;
            Assert.AreEqual(-6d, v[0]);
            v[1] = -7d;
            Assert.AreEqual(-7d, v[1]);
            v[2] = -8d;
            Assert.AreEqual(-8d, v[2]);
            v[0] = -9d;
            Assert.AreEqual(-9d, v[0]);
            v[2] = -9.5d;
            Assert.AreEqual(-9.5d, v[2]);
            v[0] = -8.5d;
            Assert.AreEqual(-8.5d, v[0]);
            v[0] = -7.5d;
            Assert.AreEqual(-7.5d, v[0]);
            v[0] = -6.5d;
            Assert.AreEqual(-6.5d, v[0]);
            v[0] = -5.5d;
            Assert.AreEqual(-5.5d, v[0]);
            v[0] = -4.5d;
            Assert.AreEqual(-4.5d, v[0]);
            v[0] = -3.5d;
            Assert.AreEqual(-3.5d, v[0]);
            v[0] = -2.5d;
            Assert.AreEqual(-2.5d, v[0]);
            v[2] = -1.5d;
            Assert.AreEqual(-1.5d, v[2]);
            v[2] = -0.5d;
            Assert.AreEqual(-0.5d, v[2]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[1] = 1.5d;
            Assert.AreEqual(1.5d, v[1]);
            v[1] = 2.5d;
            Assert.AreEqual(2.5d, v[1]);
            v[2] = 3.5d;
            Assert.AreEqual(3.5d, v[2]);
            v[0] = 4.5d;
            Assert.AreEqual(4.5d, v[0]);
            v[0] = 5.5d;
            Assert.AreEqual(5.5d, v[0]);
            v[0] = 6.5d;
            Assert.AreEqual(6.5d, v[0]);
            v[0] = 7.5d;
            Assert.AreEqual(7.5d, v[0]);
            v[0] = 8.5d;
            Assert.AreEqual(8.5d, v[0]);
            v[2] = 9.5d;
            Assert.AreEqual(9.5d, v[2]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new double3(8d, 7.5d, 5.5d);
            var vals = v.Values;
            Assert.AreEqual(8d, vals[0]);
            Assert.AreEqual(7.5d, vals[1]);
            Assert.AreEqual(5.5d, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, double3.Zero.x);
            Assert.AreEqual(0.0, double3.Zero.y);
            Assert.AreEqual(0.0, double3.Zero.z);
            
            Assert.AreEqual(1.0, double3.Ones.x);
            Assert.AreEqual(1.0, double3.Ones.y);
            Assert.AreEqual(1.0, double3.Ones.z);
            
            Assert.AreEqual(1.0, double3.UnitX.x);
            Assert.AreEqual(0.0, double3.UnitX.y);
            Assert.AreEqual(0.0, double3.UnitX.z);
            
            Assert.AreEqual(0.0, double3.UnitY.x);
            Assert.AreEqual(1.0, double3.UnitY.y);
            Assert.AreEqual(0.0, double3.UnitY.z);
            
            Assert.AreEqual(0.0, double3.UnitZ.x);
            Assert.AreEqual(0.0, double3.UnitZ.y);
            Assert.AreEqual(1.0, double3.UnitZ.z);
            
            Assert.AreEqual(double.MaxValue, double3.MaxValue.x);
            Assert.AreEqual(double.MaxValue, double3.MaxValue.y);
            Assert.AreEqual(double.MaxValue, double3.MaxValue.z);
            
            Assert.AreEqual(double.MinValue, double3.MinValue.x);
            Assert.AreEqual(double.MinValue, double3.MinValue.y);
            Assert.AreEqual(double.MinValue, double3.MinValue.z);
            
            Assert.AreEqual(double.Epsilon, double3.Epsilon.x);
            Assert.AreEqual(double.Epsilon, double3.Epsilon.y);
            Assert.AreEqual(double.Epsilon, double3.Epsilon.z);
            
            Assert.AreEqual(double.NaN, double3.NaN.x);
            Assert.AreEqual(double.NaN, double3.NaN.y);
            Assert.AreEqual(double.NaN, double3.NaN.z);
            
            Assert.AreEqual(double.NegativeInfinity, double3.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, double3.NegativeInfinity.y);
            Assert.AreEqual(double.NegativeInfinity, double3.NegativeInfinity.z);
            
            Assert.AreEqual(double.PositiveInfinity, double3.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, double3.PositiveInfinity.y);
            Assert.AreEqual(double.PositiveInfinity, double3.PositiveInfinity.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new double3(-5.5d, -2.5d, 5.5d);
            var v2 = new double3(-5.5d, -2.5d, 5.5d);
            var v3 = new double3(5.5d, -2.5d, -5.5d);
            Assert.That(v1 == new double3(v1));
            Assert.That(v2 == new double3(v2));
            Assert.That(v3 == new double3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new double3(-1.5d, 9.5d, -8.5d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = double3.Parse(s0);
            var v1 = double3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = double3.TryParse(s0, out v0);
            var b1 = double3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = double3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = double3.TryParse("", out v0);
            Assert.False(b0);
            b0 = double3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { double3.Parse(null); });
            Assert.Throws<FormatException>(() => { double3.Parse(""); });
            Assert.Throws<FormatException>(() => { double3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = double3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = double3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = double3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new double3(7d, 6d, 0.5d);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<double3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new double3(-7.5d, 7d, 3.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(3.5d, 1.5d, -3.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(6.5d, 7d, 3d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(-2d, 7d, -9.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(-8d, -1.5d, 1.0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(6d, 9.5d, -1d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(-8d, -6d, 9.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(-5.5d, 2.5d, 7.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(5.5d, -3.5d, -7d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double3(-3d, 8.5d, 1.0);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new double3(-6d, -5.5d, 4.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(8d, -3.5d, -2d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(4.5d, -8d, -4.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(-9.5d, -9d, 7d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(1.5d, -3d, -4.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(8.5d, 0.0, 7d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(1.5d, -9.5d, 7d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(-9.5d, 4.5d, -5.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(-3.5d, 3d, 0.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double3(-9.5d, -4.5d, -9.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new double3(3d, -7.5d, 0.0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(7.5d, -9d, 8.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(1.0, 4.5d, -2.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(1.5d, -5d, -3d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(6.5d, 7d, -3.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(2.5d, -0.5d, -1d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(8d, -9d, 3.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(-0.5d, -7d, 8d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(-5.5d, -0.5d, 1.0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double3(-1d, -0.5d, 6d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new double3(6.5d, 7.5d, -6d);
                var v1 = new double3(-8.5d, 7.5d, -2d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(-6d, 6d, -1.5d);
                var v1 = new double3(-4.5d, -6d, 0.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(-1d, 5d, 2.5d);
                var v1 = new double3(9d, 8d, -0.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(2d, 5.5d, 6.5d);
                var v1 = new double3(0.5d, 4.5d, 7d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(8d, -6.5d, 8.5d);
                var v1 = new double3(2d, 5.5d, -3d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(-5.5d, -5d, -1.5d);
                var v1 = new double3(-3d, 6d, -7d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(-1.5d, 7.5d, 1.5d);
                var v1 = new double3(-6d, -6d, 8.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(7.5d, -2d, 4.5d);
                var v1 = new double3(5d, 2.5d, 9d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(-6.5d, 8.5d, 5d);
                var v1 = new double3(-8.5d, 6d, -9.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double3(-1d, 5d, 3d);
                var v1 = new double3(8d, -3d, -4d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new double3(0.0, -8.5d, 2.5d);
                var v1 = new double3(1.0, 9.5d, 8d);
                var v2 = new double3(-3d, 8d, 6d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(-6d, 2.5d, -7.5d);
                var v1 = new double3(-3d, -4.5d, 1.0);
                var v2 = new double3(1.5d, -9d, 8d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(8.5d, -5d, 3d);
                var v1 = new double3(-1d, 7.5d, -1d);
                var v2 = new double3(-5d, -3.5d, -0.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(-1.5d, -8.5d, 6.5d);
                var v1 = new double3(5.5d, -8d, 6d);
                var v2 = new double3(-7d, 4d, -4.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(-4.5d, 1.0, -7d);
                var v1 = new double3(-8.5d, -6d, -8.5d);
                var v2 = new double3(4.5d, 9.5d, -1.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(3.5d, -0.5d, 4.5d);
                var v1 = new double3(-7d, -8.5d, 7.5d);
                var v2 = new double3(9d, -1d, 5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(3d, -0.5d, -6.5d);
                var v1 = new double3(-7.5d, -2.5d, -4d);
                var v2 = new double3(-9d, -5.5d, -2.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(9d, -9.5d, -5d);
                var v1 = new double3(-6d, 6.5d, -8.5d);
                var v2 = new double3(-6d, 5d, -7d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(1.5d, -8d, 9.5d);
                var v1 = new double3(-7.5d, -7d, 8.5d);
                var v2 = new double3(-7.5d, -7.5d, 6.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double3(5.5d, -1d, 0.0);
                var v1 = new double3(9.5d, -4.5d, 6d);
                var v2 = new double3(0.0, -3d, -5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new double3(5.5d, -7.5d, 0.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(9d, -4d, 3d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(2d, 2.5d, 4.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(-9.5d, 8d, 2.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(-0.5d, -8.5d, 2d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(6d, -9.5d, -7.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(-7d, -3.5d, -5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(-9d, 6.5d, 1.0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(-7d, 1.5d, -6d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double3(-8.5d, 6d, 6.5d);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new double3(4.5d, -6.5d, 8.5d);
                var v1 = new double3(-4d, 5.5d, -6.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(-0.5d, -7d, -3d);
                var v1 = new double3(-1.5d, -2.5d, -4d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(-7d, -8.5d, -9.5d);
                var v1 = new double3(7d, 5d, -6d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(4d, 9.5d, 5.5d);
                var v1 = new double3(3d, -4d, 6d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(-2d, -0.5d, 9.5d);
                var v1 = new double3(9.5d, -3.5d, 6.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(4.5d, 6d, 0.5d);
                var v1 = new double3(2d, -7d, 1.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(8d, 5d, -8d);
                var v1 = new double3(-8.5d, 0.5d, 4d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(-2.5d, 7.5d, -1d);
                var v1 = new double3(-9.5d, -1.5d, 9d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(-6d, 6d, 2.5d);
                var v1 = new double3(-7.5d, -2d, -4d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double3(-2d, 0.5d, 8d);
                var v1 = new double3(2.5d, 2d, 5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new double3(-7.5d, 2d, 8d);
                var v1 = new double3(3.5d, -5d, -4d);
                var v2 = new double3(1.0, 6d, -1d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(3.5d, -5d, -9.5d);
                var v1 = new double3(5d, -2.5d, -9.5d);
                var v2 = new double3(-2d, -7d, -8d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(-3d, -2d, 0.5d);
                var v1 = new double3(-4d, 2.5d, 4d);
                var v2 = new double3(7.5d, 3d, -4.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(2.5d, -7d, 8.5d);
                var v1 = new double3(-0.5d, 4.5d, 8d);
                var v2 = new double3(-7.5d, 5d, -9.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(6d, -9d, -0.5d);
                var v1 = new double3(-8.5d, 1.5d, -2d);
                var v2 = new double3(-2.5d, -7d, -5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(1.0, 1.0, -1d);
                var v1 = new double3(8d, 0.0, -6d);
                var v2 = new double3(9.5d, -7.5d, 0.0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(-6d, 7d, 9d);
                var v1 = new double3(3d, 6.5d, -1d);
                var v2 = new double3(-0.5d, 9d, -0.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(-3d, 3d, -8.5d);
                var v1 = new double3(-2d, -5.5d, -8.5d);
                var v2 = new double3(0.0, 4d, 8.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(-1.5d, 2.5d, -8.5d);
                var v1 = new double3(-8d, -2.5d, -5d);
                var v2 = new double3(0.5d, 5.5d, 1.0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double3(-4d, -5.5d, -7d);
                var v1 = new double3(-7.5d, 0.5d, -2d);
                var v2 = new double3(7d, 6d, 8.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new double3(4.5d, -1d, -9.5d);
                var v1 = new double3(7.5d, 8.5d, 2.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(9.5d, 8.5d, -5.5d);
                var v1 = new double3(3d, -8d, -6d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(-1.5d, -1.5d, 2.5d);
                var v1 = new double3(-4.5d, 6d, -2.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(1.5d, 2.5d, -7.5d);
                var v1 = new double3(-8d, -3.5d, 2.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(-0.5d, -2d, -6.5d);
                var v1 = new double3(-9.5d, 9d, 0.0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(9d, 1.5d, -1d);
                var v1 = new double3(-9d, 7d, -6d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(6d, 8.5d, -4d);
                var v1 = new double3(9d, 2.5d, -1d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(-3d, 0.0, -7d);
                var v1 = new double3(3.5d, 9.5d, -3d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(9.5d, 4.5d, 3d);
                var v1 = new double3(-0.5d, -5.5d, -2d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double3(1.0, -6d, -4.5d);
                var v1 = new double3(-2.5d, 8d, -3.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new double3(8.5d, -1.5d, 0.0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(1.5d, -3.5d, 1.0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(9d, 0.5d, -4d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(-5.5d, -1.5d, -5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(-3.5d, 0.0, -7d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(0.0, 7d, -0.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(4.5d, -8d, -1.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(8d, -4d, -6.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(9d, -7d, 2.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double3(9.5d, 3d, -9d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new double3(-8d, 4d, -8.5d);
                var v1 = new double3(-2.5d, 1.5d, 8d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(9d, 2d, -6d);
                var v1 = new double3(-5.5d, 5d, -2d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(0.5d, 7d, -9.5d);
                var v1 = new double3(-3.5d, 4.5d, -7d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(8d, 6.5d, -7.5d);
                var v1 = new double3(3d, 3.5d, -4d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(2.5d, 6d, -3.5d);
                var v1 = new double3(-7d, -5d, -4d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(2d, -2d, 3.5d);
                var v1 = new double3(-4.5d, -8d, -0.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(0.0, -9.5d, 4.5d);
                var v1 = new double3(-2.5d, 4d, 9.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(-8d, 6.5d, -9d);
                var v1 = new double3(4.5d, 0.5d, -1.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(-6.5d, 5d, 2d);
                var v1 = new double3(-5.5d, -7.5d, -4.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new double3(0.5d, -4d, -1d);
                var v1 = new double3(7d, 4.5d, -4.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1434568866);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.Random(random, 0, 4);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            Assert.AreEqual(avg.z, 2, 1.0);
            
            Assert.AreEqual(variance.x, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.3333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(342920882);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomUniform(random, 0, 4);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            Assert.AreEqual(avg.z, 2, 1.0);
            
            Assert.AreEqual(variance.x, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.3333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1988071181);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.Random(random, -1, 2);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            Assert.AreEqual(avg.z, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1602640935);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomUniform(random, 2, 6);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            Assert.AreEqual(avg.z, 4, 1.0);
            
            Assert.AreEqual(variance.x, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.3333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1354055339);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.Random(random, 1, 5);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            Assert.AreEqual(avg.z, 3, 1.0);
            
            Assert.AreEqual(variance.x, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.3333333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(636555449);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomNormal(random, 0.16646879267248726d, 6.721767749042142d);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.16646879267248726, 1.0);
            Assert.AreEqual(avg.y, 0.16646879267248726, 1.0);
            Assert.AreEqual(avg.z, 0.16646879267248726, 1.0);
            
            Assert.AreEqual(variance.x, 6.721767749042142, 3.0);
            Assert.AreEqual(variance.y, 6.721767749042142, 3.0);
            Assert.AreEqual(variance.z, 6.721767749042142, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(790542129);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomGaussian(random, 1.1651027291850666d, 8.069974006186227d);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.1651027291850666, 1.0);
            Assert.AreEqual(avg.y, 1.1651027291850666, 1.0);
            Assert.AreEqual(avg.z, 1.1651027291850666, 1.0);
            
            Assert.AreEqual(variance.x, 8.069974006186227, 3.0);
            Assert.AreEqual(variance.y, 8.069974006186227, 3.0);
            Assert.AreEqual(variance.z, 8.069974006186227, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1117929420);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomNormal(random, -1.0251490413328397d, 5.379537928560534d);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.0251490413328397, 1.0);
            Assert.AreEqual(avg.y, -1.0251490413328397, 1.0);
            Assert.AreEqual(avg.z, -1.0251490413328397, 1.0);
            
            Assert.AreEqual(variance.x, 5.379537928560534, 3.0);
            Assert.AreEqual(variance.y, 5.379537928560534, 3.0);
            Assert.AreEqual(variance.z, 5.379537928560534, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(382265537);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomGaussian(random, -0.47305618341688827d, 1.5387500876275588d);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.47305618341688827, 1.0);
            Assert.AreEqual(avg.y, -0.47305618341688827, 1.0);
            Assert.AreEqual(avg.z, -0.47305618341688827, 1.0);
            
            Assert.AreEqual(variance.x, 1.5387500876275588, 3.0);
            Assert.AreEqual(variance.y, 1.5387500876275588, 3.0);
            Assert.AreEqual(variance.z, 1.5387500876275588, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1379935950);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomNormal(random, 0.4840810329113534d, 7.49759281403273d);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.4840810329113534, 1.0);
            Assert.AreEqual(avg.y, 0.4840810329113534, 1.0);
            Assert.AreEqual(avg.z, 0.4840810329113534, 1.0);
            
            Assert.AreEqual(variance.x, 7.49759281403273, 3.0);
            Assert.AreEqual(variance.y, 7.49759281403273, 3.0);
            Assert.AreEqual(variance.z, 7.49759281403273, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(144545429);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(1473888562);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(2100457284);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(433898803);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(572885896);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double3.RandomNormal(random);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

    }
}
