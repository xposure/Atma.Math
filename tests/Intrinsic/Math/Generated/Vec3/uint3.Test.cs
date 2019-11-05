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
    public class UintVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uint3(7u);
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var v = new uint3(7u, 5u, 9u);
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var v = new uint3(new uint2(6u, 0u));
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var v = new uint3(new uint3(8u, 1u, 5u));
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(5u, v.z);
            }
            {
                var v = new uint3(new uint4(5u, 3u, 3u, 1u));
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uint3(7u, 4u, 3u);
            Assert.AreEqual(7u, v[0]);
            Assert.AreEqual(4u, v[1]);
            Assert.AreEqual(3u, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[1] = 0u;
            Assert.AreEqual(0u, v[1]);
            v[1] = 1u;
            Assert.AreEqual(1u, v[1]);
            v[2] = 2u;
            Assert.AreEqual(2u, v[2]);
            v[2] = 3u;
            Assert.AreEqual(3u, v[2]);
            v[1] = 4u;
            Assert.AreEqual(4u, v[1]);
            v[0] = 5u;
            Assert.AreEqual(5u, v[0]);
            v[1] = 6u;
            Assert.AreEqual(6u, v[1]);
            v[2] = 7u;
            Assert.AreEqual(7u, v[2]);
            v[0] = 8u;
            Assert.AreEqual(8u, v[0]);
            v[0] = 9u;
            Assert.AreEqual(9u, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uint3(2u, 6u, 6u);
            var vals = v.Values;
            Assert.AreEqual(2u, vals[0]);
            Assert.AreEqual(6u, vals[1]);
            Assert.AreEqual(6u, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uint3.Zero.x);
            Assert.AreEqual(0u, uint3.Zero.y);
            Assert.AreEqual(0u, uint3.Zero.z);
            
            Assert.AreEqual(1u, uint3.Ones.x);
            Assert.AreEqual(1u, uint3.Ones.y);
            Assert.AreEqual(1u, uint3.Ones.z);
            
            Assert.AreEqual(1u, uint3.UnitX.x);
            Assert.AreEqual(0u, uint3.UnitX.y);
            Assert.AreEqual(0u, uint3.UnitX.z);
            
            Assert.AreEqual(0u, uint3.UnitY.x);
            Assert.AreEqual(1u, uint3.UnitY.y);
            Assert.AreEqual(0u, uint3.UnitY.z);
            
            Assert.AreEqual(0u, uint3.UnitZ.x);
            Assert.AreEqual(0u, uint3.UnitZ.y);
            Assert.AreEqual(1u, uint3.UnitZ.z);
            
            Assert.AreEqual(uint.MaxValue, uint3.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uint3.MaxValue.y);
            Assert.AreEqual(uint.MaxValue, uint3.MaxValue.z);
            
            Assert.AreEqual(uint.MinValue, uint3.MinValue.x);
            Assert.AreEqual(uint.MinValue, uint3.MinValue.y);
            Assert.AreEqual(uint.MinValue, uint3.MinValue.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uint3(8u, 6u, 4u);
            var v2 = new uint3(8u, 6u, 4u);
            var v3 = new uint3(4u, 6u, 8u);
            Assert.That(v1 == new uint3(v1));
            Assert.That(v2 == new uint3(v2));
            Assert.That(v3 == new uint3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uint3(7u, 7u, 2u);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uint3.Parse(s0);
            var v1 = uint3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uint3.TryParse(s0, out v0);
            var b1 = uint3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uint3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uint3.TryParse("", out v0);
            Assert.False(b0);
            b0 = uint3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uint3.Parse(null); });
            Assert.Throws<FormatException>(() => { uint3.Parse(""); });
            Assert.Throws<FormatException>(() => { uint3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uint3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uint3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uint3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new uint3(1u, 4u, 9u);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<uint3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new uint3(5u, 4u, 0u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(2u, 7u, 9u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(7u, 9u, 0u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(9u, 9u, 0u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(6u, 8u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(5u, 9u, 6u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(7u, 4u, 2u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(7u, 5u, 0u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(0u, 8u, 1u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint3(6u, 1u, 9u);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new uint3(4u, 3u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(8u, 7u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(0u, 7u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(8u, 7u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(5u, 1u, 8u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(5u, 0u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(4u, 4u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(3u, 1u, 4u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(5u, 8u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint3(1u, 3u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new uint3(3u, 9u, 1u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(9u, 7u, 1u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(4u, 7u, 4u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(1u, 4u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(9u, 9u, 5u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(8u, 8u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(4u, 9u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(6u, 6u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(1u, 8u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint3(6u, 1u, 4u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new uint3(4u, 4u, 9u);
                var v1 = new uint3(5u, 3u, 2u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(9u, 3u, 5u);
                var v1 = new uint3(9u, 2u, 2u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(7u, 7u, 2u);
                var v1 = new uint3(8u, 2u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(1u, 1u, 3u);
                var v1 = new uint3(7u, 5u, 5u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(4u, 3u, 1u);
                var v1 = new uint3(4u, 3u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(5u, 7u, 9u);
                var v1 = new uint3(4u, 3u, 4u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(8u, 0u, 9u);
                var v1 = new uint3(5u, 7u, 5u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(8u, 5u, 8u);
                var v1 = new uint3(3u, 8u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(6u, 8u, 9u);
                var v1 = new uint3(8u, 2u, 4u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint3(5u, 6u, 8u);
                var v1 = new uint3(3u, 1u, 0u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new uint3(9u, 7u, 0u);
                var v1 = new uint3(4u, 9u, 5u);
                var v2 = new uint3(1u, 9u, 0u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(0u, 5u, 0u);
                var v1 = new uint3(5u, 7u, 8u);
                var v2 = new uint3(1u, 4u, 5u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(2u, 4u, 3u);
                var v1 = new uint3(4u, 6u, 3u);
                var v2 = new uint3(4u, 8u, 5u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(0u, 7u, 8u);
                var v1 = new uint3(1u, 2u, 1u);
                var v2 = new uint3(4u, 4u, 0u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(1u, 5u, 3u);
                var v1 = new uint3(2u, 9u, 1u);
                var v2 = new uint3(9u, 5u, 8u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(6u, 4u, 6u);
                var v1 = new uint3(0u, 4u, 6u);
                var v2 = new uint3(8u, 9u, 7u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(6u, 5u, 1u);
                var v1 = new uint3(6u, 9u, 0u);
                var v2 = new uint3(9u, 1u, 1u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(2u, 8u, 2u);
                var v1 = new uint3(9u, 0u, 3u);
                var v2 = new uint3(7u, 0u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(2u, 0u, 4u);
                var v1 = new uint3(1u, 4u, 1u);
                var v2 = new uint3(5u, 8u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint3(8u, 0u, 3u);
                var v1 = new uint3(1u, 3u, 2u);
                var v2 = new uint3(4u, 8u, 8u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new uint3(9u, 4u, 1u);
                var v1 = new uint3(7u, 3u, 5u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(3u, 4u, 4u);
                var v1 = new uint3(5u, 8u, 7u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(9u, 8u, 0u);
                var v1 = new uint3(2u, 4u, 4u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(5u, 5u, 4u);
                var v1 = new uint3(0u, 7u, 4u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(6u, 3u, 8u);
                var v1 = new uint3(3u, 0u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(9u, 0u, 0u);
                var v1 = new uint3(9u, 3u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(3u, 9u, 9u);
                var v1 = new uint3(0u, 0u, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(9u, 1u, 4u);
                var v1 = new uint3(0u, 2u, 6u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(0u, 9u, 1u);
                var v1 = new uint3(3u, 4u, 8u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint3(4u, 8u, 7u);
                var v1 = new uint3(7u, 0u, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new uint3(9u, 9u, 2u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(1u, 5u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(0u, 4u, 2u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(2u, 4u, 8u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(8u, 1u, 2u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(3u, 1u, 1u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(1u, 4u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(3u, 0u, 7u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(3u, 6u, 5u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint3(3u, 3u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new uint3(4u, 8u, 3u);
                var v1 = new uint3(3u, 8u, 9u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(4u, 3u, 4u);
                var v1 = new uint3(9u, 4u, 7u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(5u, 0u, 7u);
                var v1 = new uint3(3u, 8u, 0u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(9u, 8u, 2u);
                var v1 = new uint3(9u, 1u, 2u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(6u, 9u, 8u);
                var v1 = new uint3(1u, 1u, 4u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(7u, 4u, 8u);
                var v1 = new uint3(5u, 1u, 2u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(5u, 9u, 9u);
                var v1 = new uint3(9u, 5u, 3u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(3u, 3u, 3u);
                var v1 = new uint3(0u, 0u, 9u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(9u, 2u, 3u);
                var v1 = new uint3(0u, 8u, 0u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uint3(2u, 5u, 7u);
                var v1 = new uint3(0u, 6u, 9u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1407925616);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.Random(random, 5, 8);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 6, 1.0);
            Assert.AreEqual(avg.y, 6, 1.0);
            Assert.AreEqual(avg.z, 6, 1.0);
            
            Assert.AreEqual(variance.x, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.y, 0.6666666666666666, 3.0);
            Assert.AreEqual(variance.z, 0.6666666666666666, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(369564132);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.RandomUniform(random, 2, 7);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            Assert.AreEqual(avg.z, 4, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1961427931);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.Random(random, 4, 7);
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
        public void RandomUniform3()
        {
            var random = new Random(1629284185);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.RandomUniform(random, 4, 9);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 6, 1.0);
            Assert.AreEqual(avg.y, 6, 1.0);
            Assert.AreEqual(avg.z, 6, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1327412089);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.Random(random, 2, 6);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            Assert.AreEqual(avg.z, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1531807439);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.RandomPoisson(random, 2.901952828933463);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.901952828933463, 1.0);
            Assert.AreEqual(avg.y, 2.901952828933463, 1.0);
            Assert.AreEqual(avg.z, 2.901952828933463, 1.0);
            
            Assert.AreEqual(variance.x, 2.901952828933463, 3.0);
            Assert.AreEqual(variance.y, 2.901952828933463, 3.0);
            Assert.AreEqual(variance.z, 2.901952828933463, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(1829240447);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.RandomPoisson(random, 2.2014197184245194);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.2014197184245194, 1.0);
            Assert.AreEqual(avg.y, 2.2014197184245194, 1.0);
            Assert.AreEqual(avg.z, 2.2014197184245194, 1.0);
            
            Assert.AreEqual(variance.x, 2.2014197184245194, 3.0);
            Assert.AreEqual(variance.y, 2.2014197184245194, 3.0);
            Assert.AreEqual(variance.z, 2.2014197184245194, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(527372074);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.RandomPoisson(random, 2.637728889536918);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.637728889536918, 1.0);
            Assert.AreEqual(avg.y, 2.637728889536918, 1.0);
            Assert.AreEqual(avg.z, 2.637728889536918, 1.0);
            
            Assert.AreEqual(variance.x, 2.637728889536918, 3.0);
            Assert.AreEqual(variance.y, 2.637728889536918, 3.0);
            Assert.AreEqual(variance.z, 2.637728889536918, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(105466825);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.RandomPoisson(random, 3.47730674593584);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.47730674593584, 1.0);
            Assert.AreEqual(avg.y, 3.47730674593584, 1.0);
            Assert.AreEqual(avg.z, 3.47730674593584, 1.0);
            
            Assert.AreEqual(variance.x, 3.47730674593584, 3.0);
            Assert.AreEqual(variance.y, 3.47730674593584, 3.0);
            Assert.AreEqual(variance.z, 3.47730674593584, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(844925168);
            var sum = new double3(0.0);
            var sumSqr = new double3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint3.RandomPoisson(random, 1.602115423931794);
                sum += (double3)v;
                sumSqr += glm.Pow2((double3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.602115423931794, 1.0);
            Assert.AreEqual(avg.y, 1.602115423931794, 1.0);
            Assert.AreEqual(avg.z, 1.602115423931794, 1.0);
            
            Assert.AreEqual(variance.x, 1.602115423931794, 3.0);
            Assert.AreEqual(variance.y, 1.602115423931794, 3.0);
            Assert.AreEqual(variance.z, 1.602115423931794, 3.0);
        }

    }
}
