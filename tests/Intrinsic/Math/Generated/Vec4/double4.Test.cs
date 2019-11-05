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
    public class DoubleVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new double4(0.5d);
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var v = new double4(-2d, 8.5d, -6.5d, -2d);
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var v = new double4(new double2(8d, -5d));
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new double4(new double3(8d, -1d, 0.0));
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new double4(new double4(-7.5d, -5d, 4.5d, 0.0));
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new double4(-0.5d, 0.0, -4d, 1.0);
            Assert.AreEqual(-0.5d, v[0]);
            Assert.AreEqual(0.0, v[1]);
            Assert.AreEqual(-4d, v[2]);
            Assert.AreEqual(1.0, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0.0; } );
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
            v[1] = 4d;
            Assert.AreEqual(4d, v[1]);
            v[1] = 5d;
            Assert.AreEqual(5d, v[1]);
            v[1] = 6d;
            Assert.AreEqual(6d, v[1]);
            v[1] = 7d;
            Assert.AreEqual(7d, v[1]);
            v[1] = 8d;
            Assert.AreEqual(8d, v[1]);
            v[0] = 9d;
            Assert.AreEqual(9d, v[0]);
            v[3] = -1d;
            Assert.AreEqual(-1d, v[3]);
            v[3] = -2d;
            Assert.AreEqual(-2d, v[3]);
            v[3] = -3d;
            Assert.AreEqual(-3d, v[3]);
            v[0] = -4d;
            Assert.AreEqual(-4d, v[0]);
            v[3] = -5d;
            Assert.AreEqual(-5d, v[3]);
            v[3] = -6d;
            Assert.AreEqual(-6d, v[3]);
            v[3] = -7d;
            Assert.AreEqual(-7d, v[3]);
            v[3] = -8d;
            Assert.AreEqual(-8d, v[3]);
            v[1] = -9d;
            Assert.AreEqual(-9d, v[1]);
            v[3] = -9.5d;
            Assert.AreEqual(-9.5d, v[3]);
            v[2] = -8.5d;
            Assert.AreEqual(-8.5d, v[2]);
            v[0] = -7.5d;
            Assert.AreEqual(-7.5d, v[0]);
            v[0] = -6.5d;
            Assert.AreEqual(-6.5d, v[0]);
            v[3] = -5.5d;
            Assert.AreEqual(-5.5d, v[3]);
            v[0] = -4.5d;
            Assert.AreEqual(-4.5d, v[0]);
            v[3] = -3.5d;
            Assert.AreEqual(-3.5d, v[3]);
            v[0] = -2.5d;
            Assert.AreEqual(-2.5d, v[0]);
            v[3] = -1.5d;
            Assert.AreEqual(-1.5d, v[3]);
            v[3] = -0.5d;
            Assert.AreEqual(-0.5d, v[3]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[3] = 1.5d;
            Assert.AreEqual(1.5d, v[3]);
            v[2] = 2.5d;
            Assert.AreEqual(2.5d, v[2]);
            v[0] = 3.5d;
            Assert.AreEqual(3.5d, v[0]);
            v[3] = 4.5d;
            Assert.AreEqual(4.5d, v[3]);
            v[0] = 5.5d;
            Assert.AreEqual(5.5d, v[0]);
            v[0] = 6.5d;
            Assert.AreEqual(6.5d, v[0]);
            v[0] = 7.5d;
            Assert.AreEqual(7.5d, v[0]);
            v[1] = 8.5d;
            Assert.AreEqual(8.5d, v[1]);
            v[3] = 9.5d;
            Assert.AreEqual(9.5d, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new double4(8d, 4d, -1d, -3d);
            var vals = v.Values;
            Assert.AreEqual(8d, vals[0]);
            Assert.AreEqual(4d, vals[1]);
            Assert.AreEqual(-1d, vals[2]);
            Assert.AreEqual(-3d, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, double4.Zero.x);
            Assert.AreEqual(0.0, double4.Zero.y);
            Assert.AreEqual(0.0, double4.Zero.z);
            Assert.AreEqual(0.0, double4.Zero.w);
            
            Assert.AreEqual(1.0, double4.Ones.x);
            Assert.AreEqual(1.0, double4.Ones.y);
            Assert.AreEqual(1.0, double4.Ones.z);
            Assert.AreEqual(1.0, double4.Ones.w);
            
            Assert.AreEqual(1.0, double4.UnitX.x);
            Assert.AreEqual(0.0, double4.UnitX.y);
            Assert.AreEqual(0.0, double4.UnitX.z);
            Assert.AreEqual(0.0, double4.UnitX.w);
            
            Assert.AreEqual(0.0, double4.UnitY.x);
            Assert.AreEqual(1.0, double4.UnitY.y);
            Assert.AreEqual(0.0, double4.UnitY.z);
            Assert.AreEqual(0.0, double4.UnitY.w);
            
            Assert.AreEqual(0.0, double4.UnitZ.x);
            Assert.AreEqual(0.0, double4.UnitZ.y);
            Assert.AreEqual(1.0, double4.UnitZ.z);
            Assert.AreEqual(0.0, double4.UnitZ.w);
            
            Assert.AreEqual(0.0, double4.UnitW.x);
            Assert.AreEqual(0.0, double4.UnitW.y);
            Assert.AreEqual(0.0, double4.UnitW.z);
            Assert.AreEqual(1.0, double4.UnitW.w);
            
            Assert.AreEqual(double.MaxValue, double4.MaxValue.x);
            Assert.AreEqual(double.MaxValue, double4.MaxValue.y);
            Assert.AreEqual(double.MaxValue, double4.MaxValue.z);
            Assert.AreEqual(double.MaxValue, double4.MaxValue.w);
            
            Assert.AreEqual(double.MinValue, double4.MinValue.x);
            Assert.AreEqual(double.MinValue, double4.MinValue.y);
            Assert.AreEqual(double.MinValue, double4.MinValue.z);
            Assert.AreEqual(double.MinValue, double4.MinValue.w);
            
            Assert.AreEqual(double.Epsilon, double4.Epsilon.x);
            Assert.AreEqual(double.Epsilon, double4.Epsilon.y);
            Assert.AreEqual(double.Epsilon, double4.Epsilon.z);
            Assert.AreEqual(double.Epsilon, double4.Epsilon.w);
            
            Assert.AreEqual(double.NaN, double4.NaN.x);
            Assert.AreEqual(double.NaN, double4.NaN.y);
            Assert.AreEqual(double.NaN, double4.NaN.z);
            Assert.AreEqual(double.NaN, double4.NaN.w);
            
            Assert.AreEqual(double.NegativeInfinity, double4.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, double4.NegativeInfinity.y);
            Assert.AreEqual(double.NegativeInfinity, double4.NegativeInfinity.z);
            Assert.AreEqual(double.NegativeInfinity, double4.NegativeInfinity.w);
            
            Assert.AreEqual(double.PositiveInfinity, double4.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, double4.PositiveInfinity.y);
            Assert.AreEqual(double.PositiveInfinity, double4.PositiveInfinity.z);
            Assert.AreEqual(double.PositiveInfinity, double4.PositiveInfinity.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new double4(6.5d, 4d, -7d, -7d);
            var v2 = new double4(6.5d, 4d, -7d, -7d);
            var v3 = new double4(-7d, -7d, 4d, 6.5d);
            Assert.That(v1 == new double4(v1));
            Assert.That(v2 == new double4(v2));
            Assert.That(v3 == new double4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new double4(-0.5d, 2d, -3.5d, -9d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = double4.Parse(s0);
            var v1 = double4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = double4.TryParse(s0, out v0);
            var b1 = double4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = double4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = double4.TryParse("", out v0);
            Assert.False(b0);
            b0 = double4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { double4.Parse(null); });
            Assert.Throws<FormatException>(() => { double4.Parse(""); });
            Assert.Throws<FormatException>(() => { double4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = double4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = double4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = double4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new double4(-3d, -4.5d, -7.5d, 0.0);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<double4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new double4(8.5d, -5.5d, -9d, -5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(7d, -3d, -9.5d, -7d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(4.5d, -5.5d, 0.0, -0.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(-3d, -9.5d, -8.5d, -7d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(6.5d, 2.5d, -1d, 1.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(-7d, -6.5d, -3.5d, -4d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(3d, -4d, -9.5d, -5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(0.0, -7d, -4d, -7.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(3d, 2.5d, 7d, -0.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new double4(6.5d, -2d, -0.5d, -3.5d);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new double4(1.0, -9d, -2d, 9d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(3d, -1.5d, 9d, -1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(-6.5d, -8d, 8.5d, 9.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(-5d, -5d, 4d, 2.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(-5d, 8.5d, -1d, -4d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(6.5d, 7d, 9.5d, 8.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(-5d, -3d, 0.5d, 1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(5d, 8.5d, 8d, 7.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(-6d, -5d, 6d, 6.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new double4(1.5d, -2.5d, -1d, -4d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new double4(-4d, -8.5d, 6d, -9.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(-2d, 1.0, 1.0, -2d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(-8.5d, 6d, 2d, 4.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(8d, -9.5d, 4d, 8.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(-2.5d, 5.5d, 4.5d, -5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(-1d, 8.5d, -7d, -3d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(-8d, -2.5d, -9d, 9.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(1.0, -2d, -6d, 4d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(-0.5d, -5.5d, -2d, 9.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new double4(1.0, -5.5d, 3d, -2.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new double4(-7.5d, -4.5d, -8d, -2.5d);
                var v1 = new double4(-3d, -0.5d, -4.5d, -8.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(-1.5d, 9d, -2.5d, 6.5d);
                var v1 = new double4(4d, -3d, -8.5d, 5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(-2.5d, -5.5d, 7.5d, 7.5d);
                var v1 = new double4(1.0, 2d, -2d, 6d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(7.5d, 7.5d, -6.5d, 1.0);
                var v1 = new double4(8.5d, -4d, 0.0, 2.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(-1d, -7d, 9d, -8.5d);
                var v1 = new double4(-3d, -7.5d, -4.5d, 3d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(-7d, -1d, -5.5d, -6d);
                var v1 = new double4(-4.5d, 0.0, 9.5d, 5.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(-4d, 7.5d, -8d, -4d);
                var v1 = new double4(-5d, -5.5d, -6d, -9.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(-4d, -1d, -0.5d, -6d);
                var v1 = new double4(5d, -6.5d, -7.5d, -5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(8d, 5.5d, -4.5d, -2.5d);
                var v1 = new double4(3d, 9.5d, 2.5d, 5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new double4(9.5d, 4.5d, -8.5d, 1.5d);
                var v1 = new double4(-9d, 5.5d, -7.5d, 6.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new double4(-9.5d, -1d, -9.5d, 6d);
                var v1 = new double4(9.5d, 1.5d, 4d, -6d);
                var v2 = new double4(1.5d, -9.5d, -6d, -2.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(-8d, -5.5d, -8.5d, 3.5d);
                var v1 = new double4(-8d, 4.5d, -0.5d, 1.5d);
                var v2 = new double4(-4d, 6.5d, -8.5d, 0.0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(-5.5d, -3d, 7d, 0.0);
                var v1 = new double4(-8d, -6.5d, -1d, -7d);
                var v2 = new double4(4.5d, 4.5d, 1.5d, 9.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(-3.5d, 0.0, 7d, 7d);
                var v1 = new double4(5.5d, -9.5d, 7d, -9d);
                var v2 = new double4(8.5d, 2.5d, 1.5d, -1.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(9.5d, -6.5d, 0.0, -5.5d);
                var v1 = new double4(9.5d, -2d, -5.5d, -6.5d);
                var v2 = new double4(0.5d, -9.5d, -7.5d, -3.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(-6.5d, 3d, 7.5d, 8d);
                var v1 = new double4(8d, 9.5d, 2.5d, -6.5d);
                var v2 = new double4(2.5d, -7.5d, 6d, -7d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(-2.5d, -7.5d, 6.5d, 3.5d);
                var v1 = new double4(-0.5d, 1.0, 2d, 1.5d);
                var v2 = new double4(-7.5d, -9.5d, 0.0, 4.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(-7.5d, -3.5d, -7d, -7.5d);
                var v1 = new double4(-1d, 7d, 9d, 6d);
                var v2 = new double4(-8d, -7.5d, -4.5d, 1.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(-6.5d, 8.5d, 9d, 9.5d);
                var v1 = new double4(0.0, 7d, 5.5d, -8d);
                var v2 = new double4(-7d, -6.5d, 7.5d, -8d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new double4(-6d, 0.5d, 4.5d, -1.5d);
                var v1 = new double4(-8d, 1.5d, 3d, 3d);
                var v2 = new double4(3d, 3d, -3.5d, -6.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new double4(-7.5d, -9.5d, -7d, 8d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(-7d, 6.5d, 1.0, -4d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(-4d, -8d, 8d, -5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(-7d, 6d, -2.5d, -6.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(5.5d, -6.5d, -4.5d, 8d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(-1.5d, 8d, 7.5d, -9.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(-5.5d, -4.5d, 4d, 0.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(-6.5d, -7.5d, 5.5d, 6d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(2d, 6d, -2d, 3d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new double4(-3d, -9d, 7d, -5.5d);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new double4(-3.5d, 8d, -4d, 4.5d);
                var v1 = new double4(3d, -6d, -2.5d, 7d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(-4.5d, 7d, -8.5d, 6.5d);
                var v1 = new double4(-3d, -2.5d, 2d, -7d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(0.5d, -2.5d, -6.5d, 6d);
                var v1 = new double4(-7.5d, 3d, 4d, 4d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(-2.5d, 9d, 8.5d, -0.5d);
                var v1 = new double4(-3d, -6.5d, -2d, -2.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(-1d, 8d, -8d, 3.5d);
                var v1 = new double4(3d, 6.5d, 6d, 7d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(-8.5d, 7.5d, -4d, -8.5d);
                var v1 = new double4(-6d, 5d, 2.5d, -3d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(1.0, 7.5d, 4d, -2d);
                var v1 = new double4(9.5d, 4d, -6d, -7.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(3d, 8d, 7d, 3.5d);
                var v1 = new double4(-8d, 8.5d, 4.5d, 2d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(6.5d, 4.5d, -4.5d, 4d);
                var v1 = new double4(9d, 9d, -3d, 3.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new double4(-8.5d, -5d, -3.5d, -5.5d);
                var v1 = new double4(0.5d, -5.5d, -1.5d, -8.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new double4(5.5d, 9.5d, 7.5d, -5.5d);
                var v1 = new double4(-6d, -3.5d, 1.0, 9.5d);
                var v2 = new double4(7.5d, 4d, 2d, -1.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(9.5d, 0.0, -1d, -9d);
                var v1 = new double4(8.5d, -1.5d, -0.5d, -6.5d);
                var v2 = new double4(-4d, -4d, 0.0, -8d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(4d, -2d, 6.5d, -9d);
                var v1 = new double4(-4d, -9.5d, -5.5d, -4.5d);
                var v2 = new double4(0.5d, 6d, 9d, 0.0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(-3d, -5d, -5d, -1.5d);
                var v1 = new double4(-9.5d, 2d, 6.5d, -7d);
                var v2 = new double4(-3.5d, -1d, -9d, 0.0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(6d, 1.0, -8.5d, 7.5d);
                var v1 = new double4(4d, 5.5d, 3d, -7.5d);
                var v2 = new double4(8.5d, -9.5d, -9.5d, 3d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(0.5d, -6.5d, -3.5d, -8d);
                var v1 = new double4(-9.5d, -8d, 7.5d, 3.5d);
                var v2 = new double4(1.5d, 9d, 6d, -6.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(-4d, 0.0, 2d, -1d);
                var v1 = new double4(-7d, -6.5d, 1.5d, 3.5d);
                var v2 = new double4(3.5d, 5.5d, -3d, -3d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(8.5d, -3.5d, -8.5d, 4.5d);
                var v1 = new double4(2d, -2.5d, 2d, 2.5d);
                var v2 = new double4(5.5d, -2d, 8.5d, 7.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(-7d, -9d, 7.5d, 8d);
                var v1 = new double4(-3d, -4.5d, 9d, 6.5d);
                var v2 = new double4(4.5d, 8.5d, -5.5d, 3d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new double4(3.5d, 2.5d, 4d, -5d);
                var v1 = new double4(-0.5d, -3.5d, 9d, 5.5d);
                var v2 = new double4(-1d, -4d, -9d, 4.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new double4(-7.5d, 7.5d, 1.0, -4d);
                var v1 = new double4(5.5d, -5.5d, 8d, 6d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(3d, -2d, -7.5d, -5d);
                var v1 = new double4(-5d, -7.5d, -7d, -2.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(0.5d, 4d, 9.5d, 7d);
                var v1 = new double4(-4d, -9.5d, -9d, 4d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(6.5d, 0.5d, -9d, -9.5d);
                var v1 = new double4(1.0, 8d, -5d, 2.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(6.5d, 6d, 9.5d, 2d);
                var v1 = new double4(-9d, -5d, 0.0, -7d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(9d, 9.5d, 6d, 1.0);
                var v1 = new double4(0.0, 6.5d, -9.5d, 3d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(4d, 9d, -1.5d, 5d);
                var v1 = new double4(8.5d, 2.5d, 9d, 1.0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(-9d, 7.5d, -7d, 4d);
                var v1 = new double4(5d, -0.5d, 4d, 5.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(7.5d, 0.5d, -8d, 7d);
                var v1 = new double4(-6.5d, -5d, 8d, -5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new double4(4d, -6.5d, 8.5d, -5d);
                var v1 = new double4(-3d, -8d, 3d, 0.0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new double4(-7.5d, 3d, -2d, -8d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(-3d, 8.5d, 7d, 4.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(-5.5d, -1d, -9.5d, 5.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(4d, 8d, 5d, -5.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(-0.5d, -4d, 4.5d, -1.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(-0.5d, 9.5d, 4d, -2.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(-0.5d, -6.5d, 5d, -0.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(5.5d, 9.5d, 1.0, -4.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(-7.5d, -9.5d, -6d, 4.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new double4(-3d, -1d, 9d, -1d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1808264058);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.Random(random, -4, -2);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3, 1.0);
            Assert.AreEqual(avg.y, -3, 1.0);
            Assert.AreEqual(avg.z, -3, 1.0);
            Assert.AreEqual(avg.w, -3, 1.0);
            
            Assert.AreEqual(variance.x, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.3333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(601460722);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomUniform(random, -3, 0);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            Assert.AreEqual(avg.z, -1.5, 1.0);
            Assert.AreEqual(avg.w, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1864429349);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.Random(random, 1, 4);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            Assert.AreEqual(avg.w, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1489224316);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomUniform(random, 0, 1);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            Assert.AreEqual(avg.z, 0.5, 1.0);
            Assert.AreEqual(avg.w, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.08333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.08333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1888777585);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.Random(random, -1, 1);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.3333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.3333333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(307826155);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomNormal(random, -0.9933218206247882d, 6.2955080141758115d);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.9933218206247882, 1.0);
            Assert.AreEqual(avg.y, -0.9933218206247882, 1.0);
            Assert.AreEqual(avg.z, -0.9933218206247882, 1.0);
            Assert.AreEqual(avg.w, -0.9933218206247882, 1.0);
            
            Assert.AreEqual(variance.x, 6.2955080141758115, 3.0);
            Assert.AreEqual(variance.y, 6.2955080141758115, 3.0);
            Assert.AreEqual(variance.z, 6.2955080141758115, 3.0);
            Assert.AreEqual(variance.w, 6.2955080141758115, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(153839475);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomGaussian(random, -0.9136950070567871d, 3.613417671813358d);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.9136950070567871, 1.0);
            Assert.AreEqual(avg.y, -0.9136950070567871, 1.0);
            Assert.AreEqual(avg.z, -0.9136950070567871, 1.0);
            Assert.AreEqual(avg.w, -0.9136950070567871, 1.0);
            
            Assert.AreEqual(variance.x, 3.613417671813358, 3.0);
            Assert.AreEqual(variance.y, 3.613417671813358, 3.0);
            Assert.AreEqual(variance.z, 3.613417671813358, 3.0);
            Assert.AreEqual(variance.w, 3.613417671813358, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1973935831);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomNormal(random, 1.276556763461119d, 6.303853749439052d);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.276556763461119, 1.0);
            Assert.AreEqual(avg.y, 1.276556763461119, 1.0);
            Assert.AreEqual(avg.z, 1.276556763461119, 1.0);
            Assert.AreEqual(avg.w, 1.276556763461119, 1.0);
            
            Assert.AreEqual(variance.x, 6.303853749439052, 3.0);
            Assert.AreEqual(variance.y, 6.303853749439052, 3.0);
            Assert.AreEqual(variance.z, 6.303853749439052, 3.0);
            Assert.AreEqual(variance.w, 6.303853749439052, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(562116067);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomGaussian(random, 0.7244639055451674d, 0.1446415903720267d);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.7244639055451674, 1.0);
            Assert.AreEqual(avg.y, 0.7244639055451674, 1.0);
            Assert.AreEqual(avg.z, 0.7244639055451674, 1.0);
            Assert.AreEqual(avg.w, 0.7244639055451674, 1.0);
            
            Assert.AreEqual(variance.x, 0.1446415903720267, 3.0);
            Assert.AreEqual(variance.y, 0.1446415903720267, 3.0);
            Assert.AreEqual(variance.z, 0.1446415903720267, 3.0);
            Assert.AreEqual(variance.w, 0.1446415903720267, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1862896974);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomNormal(random, -0.23267331078307385d, 4.1857988639668555d);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.23267331078307385, 1.0);
            Assert.AreEqual(avg.y, -0.23267331078307385, 1.0);
            Assert.AreEqual(avg.z, -0.23267331078307385, 1.0);
            Assert.AreEqual(avg.w, -0.23267331078307385, 1.0);
            
            Assert.AreEqual(variance.x, 4.1857988639668555, 3.0);
            Assert.AreEqual(variance.y, 4.1857988639668555, 3.0);
            Assert.AreEqual(variance.z, 4.1857988639668555, 3.0);
            Assert.AreEqual(variance.w, 4.1857988639668555, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(799836175);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(1597530394);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(991407967);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(661450474);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(371495708);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = double4.RandomNormal(random);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

    }
}
