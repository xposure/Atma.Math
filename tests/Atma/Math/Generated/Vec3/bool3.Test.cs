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

namespace Atma.Math.Generated.Vec3
{
    [TestFixture]
    public class BoolVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new bool3(false);
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var v = new bool3(true, true, false);
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var v = new bool3(new bool2(false, true));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var v = new bool3(new bool3(true, true, true));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var v = new bool3(new bool4(true, false, true, true));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new bool3(true, false, true);
            Assert.AreEqual(true, v[0]);
            Assert.AreEqual(false, v[1]);
            Assert.AreEqual(true, v[2]);

            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = false; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = false; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = false; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = false; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; });
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = false; });

            v[2] = false;
            Assert.AreEqual(false, v[2]);
            v[0] = true;
            Assert.AreEqual(true, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new bool3(false, false, true);
            var vals = v.Values;
            Assert.AreEqual(false, vals[0]);
            Assert.AreEqual(false, vals[1]);
            Assert.AreEqual(true, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(false, bool3.Zero.x);
            Assert.AreEqual(false, bool3.Zero.y);
            Assert.AreEqual(false, bool3.Zero.z);

            Assert.AreEqual(true, bool3.Ones.x);
            Assert.AreEqual(true, bool3.Ones.y);
            Assert.AreEqual(true, bool3.Ones.z);

            Assert.AreEqual(true, bool3.UnitX.x);
            Assert.AreEqual(false, bool3.UnitX.y);
            Assert.AreEqual(false, bool3.UnitX.z);

            Assert.AreEqual(false, bool3.UnitY.x);
            Assert.AreEqual(true, bool3.UnitY.y);
            Assert.AreEqual(false, bool3.UnitY.z);

            Assert.AreEqual(false, bool3.UnitZ.x);
            Assert.AreEqual(false, bool3.UnitZ.y);
            Assert.AreEqual(true, bool3.UnitZ.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new bool3(true, false, true);
            var v2 = new bool3(true, false, true);
            var v3 = new bool3(true, false, false);
            Assert.That(v1 == new bool3(v1));
            Assert.That(v2 == new bool3(v2));
            Assert.That(v3 == new bool3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new bool3(true, false, false);

            var s0 = v.ToString();
            var s1 = v.ToString("#");

            var v0 = bool3.Parse(s0);
            var v1 = bool3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);

            var b0 = bool3.TryParse(s0, out v0);
            var b1 = bool3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);

            b0 = bool3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = bool3.TryParse("", out v0);
            Assert.False(b0);
            b0 = bool3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);

            Assert.Throws<NullReferenceException>(() => { bool3.Parse(null); });
            Assert.Throws<FormatException>(() => { bool3.Parse(""); });
            Assert.Throws<FormatException>(() => { bool3.Parse(s0 + ", 0"); });

            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new bool3(false, true, true);
            var s0 = JsonConvert.SerializeObject(v0);

            var v1 = JsonConvert.DeserializeObject<bool3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);

            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
