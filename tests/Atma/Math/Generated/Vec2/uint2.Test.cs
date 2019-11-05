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
    public class UintVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uint2(4u);
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
            }
            {
                var v = new uint2(9u, 0u);
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(0u, v.y);
            }
            {
                var v = new uint2(new uint2(1u, 2u));
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(2u, v.y);
            }
            {
                var v = new uint2(new uint3(9u, 9u, 9u));
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
            }
            {
                var v = new uint2(new uint4(1u, 7u, 8u, 0u));
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(7u, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uint2(3u, 4u);
            Assert.AreEqual(3u, v[0]);
            Assert.AreEqual(4u, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[0] = 0u;
            Assert.AreEqual(0u, v[0]);
            v[1] = 1u;
            Assert.AreEqual(1u, v[1]);
            v[0] = 2u;
            Assert.AreEqual(2u, v[0]);
            v[1] = 3u;
            Assert.AreEqual(3u, v[1]);
            v[1] = 4u;
            Assert.AreEqual(4u, v[1]);
            v[1] = 5u;
            Assert.AreEqual(5u, v[1]);
            v[1] = 6u;
            Assert.AreEqual(6u, v[1]);
            v[1] = 7u;
            Assert.AreEqual(7u, v[1]);
            v[1] = 8u;
            Assert.AreEqual(8u, v[1]);
            v[0] = 9u;
            Assert.AreEqual(9u, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uint2(3u, 3u);
            var vals = v.Values;
            Assert.AreEqual(3u, vals[0]);
            Assert.AreEqual(3u, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uint2.Zero.x);
            Assert.AreEqual(0u, uint2.Zero.y);
            
            Assert.AreEqual(1u, uint2.Ones.x);
            Assert.AreEqual(1u, uint2.Ones.y);
            
            Assert.AreEqual(1u, uint2.UnitX.x);
            Assert.AreEqual(0u, uint2.UnitX.y);
            
            Assert.AreEqual(0u, uint2.UnitY.x);
            Assert.AreEqual(1u, uint2.UnitY.y);
            
            Assert.AreEqual(uint.MaxValue, uint2.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uint2.MaxValue.y);
            
            Assert.AreEqual(uint.MinValue, uint2.MinValue.x);
            Assert.AreEqual(uint.MinValue, uint2.MinValue.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uint2(3u, 1u);
            var v2 = new uint2(3u, 1u);
            var v3 = new uint2(1u, 3u);
            Assert.That(v1 == new uint2(v1));
            Assert.That(v2 == new uint2(v2));
            Assert.That(v3 == new uint2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uint2(8u, 3u);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uint2.Parse(s0);
            var v1 = uint2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uint2.TryParse(s0, out v0);
            var b1 = uint2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uint2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uint2.TryParse("", out v0);
            Assert.False(b0);
            b0 = uint2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uint2.Parse(null); });
            Assert.Throws<FormatException>(() => { uint2.Parse(""); });
            Assert.Throws<FormatException>(() => { uint2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uint2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uint2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uint2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new uint2(7u, 0u);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<uint2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new uint2(8u, 7u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(3u, 2u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(2u, 4u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(5u, 1u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(3u, 4u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(9u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(4u, 6u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(4u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(4u, 3u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint2(2u, 0u);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new uint2(5u, 4u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(5u, 1u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(8u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(3u, 2u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(1u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(7u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(7u, 3u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(0u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(9u, 2u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint2(5u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new uint2(3u, 7u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(4u, 4u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(7u, 2u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(2u, 5u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(1u, 2u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(4u, 5u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(8u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(8u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(8u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint2(2u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new uint2(8u, 7u);
                var v1 = new uint2(8u, 9u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(4u, 2u);
                var v1 = new uint2(8u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(1u, 4u);
                var v1 = new uint2(0u, 5u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(2u, 4u);
                var v1 = new uint2(1u, 2u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(6u, 3u);
                var v1 = new uint2(3u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(7u, 2u);
                var v1 = new uint2(7u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(8u, 2u);
                var v1 = new uint2(2u, 4u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(3u, 9u);
                var v1 = new uint2(2u, 4u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(0u, 2u);
                var v1 = new uint2(0u, 9u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint2(4u, 2u);
                var v1 = new uint2(2u, 0u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new uint2(1u, 7u);
                var v1 = new uint2(8u, 0u);
                var v2 = new uint2(7u, 8u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(9u, 4u);
                var v1 = new uint2(4u, 1u);
                var v2 = new uint2(3u, 4u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(0u, 6u);
                var v1 = new uint2(8u, 6u);
                var v2 = new uint2(2u, 5u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(4u, 4u);
                var v1 = new uint2(0u, 0u);
                var v2 = new uint2(4u, 0u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(3u, 4u);
                var v1 = new uint2(1u, 3u);
                var v2 = new uint2(4u, 5u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(0u, 3u);
                var v1 = new uint2(9u, 2u);
                var v2 = new uint2(2u, 0u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(6u, 1u);
                var v1 = new uint2(7u, 5u);
                var v2 = new uint2(2u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(7u, 6u);
                var v1 = new uint2(6u, 6u);
                var v2 = new uint2(1u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(4u, 2u);
                var v1 = new uint2(8u, 4u);
                var v2 = new uint2(8u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint2(4u, 1u);
                var v1 = new uint2(2u, 7u);
                var v2 = new uint2(6u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new uint2(5u, 8u);
                var v1 = new uint2(1u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(4u, 9u);
                var v1 = new uint2(9u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(2u, 7u);
                var v1 = new uint2(9u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(9u, 5u);
                var v1 = new uint2(5u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(2u, 9u);
                var v1 = new uint2(9u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(7u, 6u);
                var v1 = new uint2(5u, 4u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(5u, 1u);
                var v1 = new uint2(8u, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(6u, 0u);
                var v1 = new uint2(6u, 9u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(2u, 7u);
                var v1 = new uint2(7u, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint2(9u, 9u);
                var v1 = new uint2(0u, 9u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new uint2(1u, 7u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(1u, 7u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(5u, 7u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(0u, 2u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(1u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(9u, 8u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(9u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(0u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(5u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint2(5u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1139137313);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.Random(random, 4, 8);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5.5, 1.0);
            Assert.AreEqual(avg.y, 5.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(907822379);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.RandomUniform(random, 4, 8);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5.5, 1.0);
            Assert.AreEqual(avg.y, 5.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(2112880465);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.Random(random, 2, 7);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1006855940);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.RandomUniform(random, 2, 6);
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
        public void RandomUniform4()
        {
            var random = new Random(2111366633);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.Random(random, 1, 6);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1896170832);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.RandomPoisson(random, 2.2543157021302336);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.2543157021302336, 1.0);
            Assert.AreEqual(avg.y, 2.2543157021302336, 1.0);
            
            Assert.AreEqual(variance.x, 2.2543157021302336, 3.0);
            Assert.AreEqual(variance.y, 2.2543157021302336, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(826156388);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.RandomPoisson(random, 1.357606539436433);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.357606539436433, 1.0);
            Assert.AreEqual(avg.y, 1.357606539436433, 1.0);
            
            Assert.AreEqual(variance.x, 1.357606539436433, 3.0);
            Assert.AreEqual(variance.y, 1.357606539436433, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(1538044118);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.RandomPoisson(random, 3.388995701395439);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.388995701395439, 1.0);
            Assert.AreEqual(avg.y, 3.388995701395439, 1.0);
            
            Assert.AreEqual(variance.x, 3.388995701395439, 3.0);
            Assert.AreEqual(variance.y, 3.388995701395439, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(151787199);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.RandomPoisson(random, 1.8781828779625627);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.8781828779625627, 1.0);
            Assert.AreEqual(avg.y, 1.8781828779625627, 1.0);
            
            Assert.AreEqual(variance.x, 1.8781828779625627, 3.0);
            Assert.AreEqual(variance.y, 1.8781828779625627, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1229139304);
            var sum = new double2(0.0);
            var sumSqr = new double2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint2.RandomPoisson(random, 2.2880972837042517);
                sum += (double2)v;
                sumSqr += glm.Pow2((double2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.2880972837042517, 1.0);
            Assert.AreEqual(avg.y, 2.2880972837042517, 1.0);
            
            Assert.AreEqual(variance.x, 2.2880972837042517, 3.0);
            Assert.AreEqual(variance.y, 2.2880972837042517, 3.0);
        }

    }
}
