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
    public class UintVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uint4(0u);
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uint4(2u, 9u, 1u, 2u);
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var v = new uint4(new uint2(1u, 4u));
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uint4(new uint3(5u, 6u, 4u));
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uint4(new uint4(9u, 6u, 1u, 9u));
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(9u, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uint4(2u, 7u, 0u, 8u);
            Assert.AreEqual(2u, v[0]);
            Assert.AreEqual(7u, v[1]);
            Assert.AreEqual(0u, v[2]);
            Assert.AreEqual(8u, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[1] = 0u;
            Assert.AreEqual(0u, v[1]);
            v[0] = 1u;
            Assert.AreEqual(1u, v[0]);
            v[3] = 2u;
            Assert.AreEqual(2u, v[3]);
            v[3] = 3u;
            Assert.AreEqual(3u, v[3]);
            v[3] = 4u;
            Assert.AreEqual(4u, v[3]);
            v[2] = 5u;
            Assert.AreEqual(5u, v[2]);
            v[1] = 6u;
            Assert.AreEqual(6u, v[1]);
            v[1] = 7u;
            Assert.AreEqual(7u, v[1]);
            v[1] = 8u;
            Assert.AreEqual(8u, v[1]);
            v[2] = 9u;
            Assert.AreEqual(9u, v[2]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uint4(1u, 8u, 8u, 0u);
            var vals = v.Values;
            Assert.AreEqual(1u, vals[0]);
            Assert.AreEqual(8u, vals[1]);
            Assert.AreEqual(8u, vals[2]);
            Assert.AreEqual(0u, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uint4.Zero.x);
            Assert.AreEqual(0u, uint4.Zero.y);
            Assert.AreEqual(0u, uint4.Zero.z);
            Assert.AreEqual(0u, uint4.Zero.w);
            
            Assert.AreEqual(1u, uint4.Ones.x);
            Assert.AreEqual(1u, uint4.Ones.y);
            Assert.AreEqual(1u, uint4.Ones.z);
            Assert.AreEqual(1u, uint4.Ones.w);
            
            Assert.AreEqual(1u, uint4.UnitX.x);
            Assert.AreEqual(0u, uint4.UnitX.y);
            Assert.AreEqual(0u, uint4.UnitX.z);
            Assert.AreEqual(0u, uint4.UnitX.w);
            
            Assert.AreEqual(0u, uint4.UnitY.x);
            Assert.AreEqual(1u, uint4.UnitY.y);
            Assert.AreEqual(0u, uint4.UnitY.z);
            Assert.AreEqual(0u, uint4.UnitY.w);
            
            Assert.AreEqual(0u, uint4.UnitZ.x);
            Assert.AreEqual(0u, uint4.UnitZ.y);
            Assert.AreEqual(1u, uint4.UnitZ.z);
            Assert.AreEqual(0u, uint4.UnitZ.w);
            
            Assert.AreEqual(0u, uint4.UnitW.x);
            Assert.AreEqual(0u, uint4.UnitW.y);
            Assert.AreEqual(0u, uint4.UnitW.z);
            Assert.AreEqual(1u, uint4.UnitW.w);
            
            Assert.AreEqual(uint.MaxValue, uint4.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uint4.MaxValue.y);
            Assert.AreEqual(uint.MaxValue, uint4.MaxValue.z);
            Assert.AreEqual(uint.MaxValue, uint4.MaxValue.w);
            
            Assert.AreEqual(uint.MinValue, uint4.MinValue.x);
            Assert.AreEqual(uint.MinValue, uint4.MinValue.y);
            Assert.AreEqual(uint.MinValue, uint4.MinValue.z);
            Assert.AreEqual(uint.MinValue, uint4.MinValue.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uint4(2u, 5u, 6u, 0u);
            var v2 = new uint4(2u, 5u, 6u, 0u);
            var v3 = new uint4(0u, 6u, 5u, 2u);
            Assert.That(v1 == new uint4(v1));
            Assert.That(v2 == new uint4(v2));
            Assert.That(v3 == new uint4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uint4(6u, 8u, 0u, 9u);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uint4.Parse(s0);
            var v1 = uint4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uint4.TryParse(s0, out v0);
            var b1 = uint4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uint4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uint4.TryParse("", out v0);
            Assert.False(b0);
            b0 = uint4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uint4.Parse(null); });
            Assert.Throws<FormatException>(() => { uint4.Parse(""); });
            Assert.Throws<FormatException>(() => { uint4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uint4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uint4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uint4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new uint4(7u, 1u, 7u, 4u);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<uint4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new uint4(6u, 4u, 6u, 1u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(1u, 5u, 8u, 3u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(4u, 6u, 8u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(8u, 7u, 5u, 5u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(4u, 7u, 8u, 5u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(5u, 5u, 2u, 9u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(7u, 6u, 3u, 2u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(8u, 8u, 0u, 3u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(1u, 1u, 1u, 7u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uint4(7u, 1u, 0u, 0u);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new uint4(4u, 8u, 0u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(8u, 0u, 8u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(2u, 1u, 4u, 1u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(6u, 7u, 9u, 3u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(7u, 1u, 7u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(4u, 4u, 9u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(0u, 0u, 4u, 5u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(6u, 3u, 5u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(1u, 5u, 9u, 8u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uint4(0u, 5u, 7u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new uint4(1u, 4u, 5u, 9u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(7u, 8u, 1u, 9u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(7u, 9u, 4u, 1u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(4u, 1u, 1u, 7u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(0u, 2u, 8u, 7u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(3u, 4u, 7u, 7u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(2u, 4u, 9u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(3u, 8u, 7u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(4u, 6u, 7u, 1u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uint4(0u, 4u, 6u, 2u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new uint4(4u, 9u, 0u, 3u);
                var v1 = new uint4(2u, 3u, 3u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(3u, 9u, 1u, 7u);
                var v1 = new uint4(8u, 4u, 0u, 4u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(9u, 0u, 9u, 3u);
                var v1 = new uint4(5u, 4u, 2u, 4u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(0u, 5u, 8u, 4u);
                var v1 = new uint4(7u, 4u, 1u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(6u, 5u, 8u, 2u);
                var v1 = new uint4(6u, 7u, 4u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(5u, 2u, 8u, 2u);
                var v1 = new uint4(2u, 2u, 0u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(8u, 0u, 7u, 3u);
                var v1 = new uint4(6u, 8u, 1u, 9u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(6u, 6u, 2u, 6u);
                var v1 = new uint4(4u, 9u, 0u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(7u, 4u, 1u, 2u);
                var v1 = new uint4(6u, 7u, 8u, 2u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uint4(6u, 1u, 8u, 2u);
                var v1 = new uint4(6u, 0u, 1u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new uint4(3u, 4u, 2u, 3u);
                var v1 = new uint4(6u, 1u, 4u, 0u);
                var v2 = new uint4(3u, 9u, 5u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(2u, 7u, 1u, 7u);
                var v1 = new uint4(6u, 5u, 6u, 1u);
                var v2 = new uint4(9u, 2u, 1u, 6u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(9u, 6u, 3u, 4u);
                var v1 = new uint4(7u, 5u, 7u, 3u);
                var v2 = new uint4(7u, 7u, 1u, 1u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(5u, 6u, 0u, 8u);
                var v1 = new uint4(3u, 2u, 2u, 7u);
                var v2 = new uint4(3u, 3u, 3u, 1u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(3u, 3u, 6u, 7u);
                var v1 = new uint4(5u, 6u, 3u, 0u);
                var v2 = new uint4(3u, 6u, 3u, 0u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(8u, 0u, 3u, 8u);
                var v1 = new uint4(1u, 1u, 5u, 4u);
                var v2 = new uint4(6u, 9u, 2u, 0u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(4u, 7u, 7u, 6u);
                var v1 = new uint4(0u, 3u, 2u, 6u);
                var v2 = new uint4(2u, 1u, 1u, 4u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(9u, 9u, 8u, 1u);
                var v1 = new uint4(4u, 1u, 8u, 9u);
                var v2 = new uint4(2u, 0u, 0u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(9u, 4u, 5u, 1u);
                var v1 = new uint4(7u, 8u, 5u, 3u);
                var v2 = new uint4(0u, 5u, 3u, 8u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uint4(8u, 6u, 9u, 9u);
                var v1 = new uint4(3u, 7u, 7u, 6u);
                var v2 = new uint4(8u, 8u, 8u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new uint4(3u, 5u, 6u, 1u);
                var v1 = new uint4(1u, 7u, 1u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(7u, 1u, 6u, 4u);
                var v1 = new uint4(9u, 2u, 0u, 3u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(2u, 3u, 5u, 9u);
                var v1 = new uint4(4u, 7u, 7u, 5u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(9u, 4u, 7u, 8u);
                var v1 = new uint4(0u, 3u, 0u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(6u, 2u, 3u, 8u);
                var v1 = new uint4(1u, 2u, 7u, 6u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(8u, 1u, 8u, 0u);
                var v1 = new uint4(3u, 4u, 7u, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(0u, 0u, 5u, 3u);
                var v1 = new uint4(2u, 3u, 7u, 5u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(7u, 0u, 1u, 7u);
                var v1 = new uint4(0u, 2u, 1u, 3u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(0u, 4u, 8u, 6u);
                var v1 = new uint4(9u, 1u, 2u, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uint4(6u, 9u, 1u, 2u);
                var v1 = new uint4(8u, 7u, 2u, 5u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new uint4(2u, 9u, 3u, 5u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(7u, 1u, 0u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(1u, 7u, 8u, 8u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(6u, 1u, 2u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(7u, 7u, 0u, 5u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(6u, 8u, 4u, 8u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(8u, 6u, 9u, 4u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(5u, 1u, 5u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(9u, 5u, 5u, 8u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uint4(5u, 8u, 8u, 0u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1937880292);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.Random(random, 0, 4);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            Assert.AreEqual(avg.z, 1.5, 1.0);
            Assert.AreEqual(avg.w, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(21711579);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.RandomUniform(random, 1, 5);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            Assert.AreEqual(avg.w, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1144800105);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.Random(random, 2, 6);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            Assert.AreEqual(avg.z, 3.5, 1.0);
            Assert.AreEqual(avg.w, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(2070161665);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.RandomUniform(random, 3, 6);
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
        public void RandomUniform4()
        {
            var random = new Random(965650972);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.Random(random, 4, 8);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5.5, 1.0);
            Assert.AreEqual(avg.y, 5.5, 1.0);
            Assert.AreEqual(avg.z, 5.5, 1.0);
            Assert.AreEqual(avg.w, 5.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1361509738);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.RandomPoisson(random, 0.7042531334814863);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.7042531334814863, 1.0);
            Assert.AreEqual(avg.y, 0.7042531334814863, 1.0);
            Assert.AreEqual(avg.z, 0.7042531334814863, 1.0);
            Assert.AreEqual(avg.w, 0.7042531334814863, 1.0);
            
            Assert.AreEqual(variance.x, 0.7042531334814863, 3.0);
            Assert.AreEqual(variance.y, 0.7042531334814863, 3.0);
            Assert.AreEqual(variance.z, 0.7042531334814863, 3.0);
            Assert.AreEqual(variance.w, 0.7042531334814863, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(103377570);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.RandomPoisson(random, 3.252240645583831);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.252240645583831, 1.0);
            Assert.AreEqual(avg.y, 3.252240645583831, 1.0);
            Assert.AreEqual(avg.z, 3.252240645583831, 1.0);
            Assert.AreEqual(avg.w, 3.252240645583831, 1.0);
            
            Assert.AreEqual(variance.x, 3.252240645583831, 3.0);
            Assert.AreEqual(variance.y, 3.252240645583831, 3.0);
            Assert.AreEqual(variance.z, 3.252240645583831, 3.0);
            Assert.AreEqual(variance.w, 3.252240645583831, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(1719636452);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.RandomPoisson(random, 2.5695731342162813);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5695731342162813, 1.0);
            Assert.AreEqual(avg.y, 2.5695731342162813, 1.0);
            Assert.AreEqual(avg.z, 2.5695731342162813, 1.0);
            Assert.AreEqual(avg.w, 2.5695731342162813, 1.0);
            
            Assert.AreEqual(variance.x, 2.5695731342162813, 3.0);
            Assert.AreEqual(variance.y, 2.5695731342162813, 3.0);
            Assert.AreEqual(variance.z, 2.5695731342162813, 3.0);
            Assert.AreEqual(variance.w, 2.5695731342162813, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(777746759);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.RandomPoisson(random, 2.7316643070577014);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.7316643070577014, 1.0);
            Assert.AreEqual(avg.y, 2.7316643070577014, 1.0);
            Assert.AreEqual(avg.z, 2.7316643070577014, 1.0);
            Assert.AreEqual(avg.w, 2.7316643070577014, 1.0);
            
            Assert.AreEqual(variance.x, 2.7316643070577014, 3.0);
            Assert.AreEqual(variance.y, 2.7316643070577014, 3.0);
            Assert.AreEqual(variance.z, 2.7316643070577014, 3.0);
            Assert.AreEqual(variance.w, 2.7316643070577014, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1847878301);
            var sum = new double4(0.0);
            var sumSqr = new double4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uint4.RandomPoisson(random, 0.6704715519074684);
                sum += (double4)v;
                sumSqr += glm.Pow2((double4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.6704715519074684, 1.0);
            Assert.AreEqual(avg.y, 0.6704715519074684, 1.0);
            Assert.AreEqual(avg.z, 0.6704715519074684, 1.0);
            Assert.AreEqual(avg.w, 0.6704715519074684, 1.0);
            
            Assert.AreEqual(variance.x, 0.6704715519074684, 3.0);
            Assert.AreEqual(variance.y, 0.6704715519074684, 3.0);
            Assert.AreEqual(variance.z, 0.6704715519074684, 3.0);
            Assert.AreEqual(variance.w, 0.6704715519074684, 3.0);
        }

    }
}
