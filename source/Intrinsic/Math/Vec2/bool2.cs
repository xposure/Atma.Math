using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using Atma.Math.Swizzle;

// ReSharper disable InconsistentNaming

namespace Atma.Math
{
    
    /// <summary>
    /// A vector of type bool with 2 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct bool2 : IReadOnlyList<bool>, IEquatable<bool2>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public bool y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bool2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public bool2(bool v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public bool2(bool2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public bool2(bool3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public bool2(bool4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bool2(IReadOnlyList<bool> v)
        {
            var c = v.Count;
            this.x = c < 0 ? false : v[0];
            this.y = c < 1 ? false : v[1];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bool2(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? false : (bool)v[0];
            this.y = c < 1 ? false : (bool)v[1];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bool2(bool[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? false : v[0];
            this.y = c < 1 ? false : v[1];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bool2(bool[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? false : v[0 + startIndex];
            this.y = c + startIndex < 1 ? false : v[1 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public bool2(IEnumerable<bool> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(bool2 v) => new int2(v.x ? 1 : 0, v.y ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a int3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int3(bool2 v) => new int3(v.x ? 1 : 0, v.y ? 1 : 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a int4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int4(bool2 v) => new int4(v.x ? 1 : 0, v.y ? 1 : 0, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(bool2 v) => new uint2(v.x ? 1u : 0u, v.y ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a uint3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint3(bool2 v) => new uint3(v.x ? 1u : 0u, v.y ? 1u : 0u, 0u);
        
        /// <summary>
        /// Explicitly converts this to a uint4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint4(bool2 v) => new uint4(v.x ? 1u : 0u, v.y ? 1u : 0u, 0u, 0u);
        
        /// <summary>
        /// Explicitly converts this to a float2.
        /// </summary>
        public static explicit operator float2(bool2 v) => new float2(v.x ? 1f : 0f, v.y ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a float3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float3(bool2 v) => new float3(v.x ? 1f : 0f, v.y ? 1f : 0f, 0f);
        
        /// <summary>
        /// Explicitly converts this to a float4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float4(bool2 v) => new float4(v.x ? 1f : 0f, v.y ? 1f : 0f, 0f, 0f);
        
        /// <summary>
        /// Explicitly converts this to a double2.
        /// </summary>
        public static explicit operator double2(bool2 v) => new double2(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a double3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double3(bool2 v) => new double3(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a double4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double4(bool2 v) => new double4(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(bool2 v) => new long2(v.x ? 1 : 0, v.y ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a long3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long3(bool2 v) => new long3(v.x ? 1 : 0, v.y ? 1 : 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a long4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long4(bool2 v) => new long4(v.x ? 1 : 0, v.y ? 1 : 0, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a bool3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool3(bool2 v) => new bool3((bool)v.x, (bool)v.y, false);
        
        /// <summary>
        /// Explicitly converts this to a bool4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool4(bool2 v) => new bool4((bool)v.x, (bool)v.y, false, false);
        
        /// <summary>
        /// Explicitly converts this to a bool array.
        /// </summary>
        public static explicit operator bool[](bool2 v) => new [] { v.x, v.y };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](bool2 v) => new Object[] { v.x, v.y };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_bool2 swizzle => new swizzle_bool2(x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public bool2 xy
        {
            get
            {
                return new bool2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public bool2 rg
        {
            get
            {
                return new bool2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public bool r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public bool g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public bool[] Values => new[] { x, y };
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public bool MinElement => (x && y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public bool MaxElement => (x || y);
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => (x && y);
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => (x || y);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static bool2 Zero { get; } = new bool2(false, false);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static bool2 Ones { get; } = new bool2(true, true);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static bool2 UnitX { get; } = new bool2(true, false);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static bool2 UnitY { get; } = new bool2(false, true);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(bool2 lhs, bool2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(bool2 lhs, bool2 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
        {
            yield return x;
            yield return y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => (x + sep + y);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => (x.ToString(provider) + sep + y.ToString(provider));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bool2 rhs) => (x.Equals(rhs.x) && y.Equals(rhs.y));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bool2 && Equals((bool2) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((x.GetHashCode()) * 2) ^ y.GetHashCode();
            }
        }

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static bool2 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static bool2 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new bool2(bool.Parse(kvp[0].Trim()), bool.Parse(kvp[1].Trim()));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out bool2 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out bool2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            bool x = false, y = false;
            var ok = (bool.TryParse(kvp[0].Trim(), out x) && bool.TryParse(kvp[1].Trim(), out y));
            result = ok ? new bool2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns a bool2 with independent and identically distributed random true/false values (the probability for 'true' can be configured).
        /// </summary>
        public static bool2 Random(Random random, float trueProbability = 0.5f) => new bool2(random.NextDouble() < trueProbability, random.NextDouble() < trueProbability);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(bool2 lhs, bool2 rhs) => new bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(bool2 lhs, bool rhs) => new bool2(lhs.x == rhs, lhs.y == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(bool lhs, bool2 rhs) => new bool2(lhs == rhs.x, lhs == rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(bool lhs, bool rhs) => new bool2(lhs == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(bool2 lhs, bool2 rhs) => new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(bool2 lhs, bool rhs) => new bool2(lhs.x != rhs, lhs.y != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(bool lhs, bool2 rhs) => new bool2(lhs != rhs.x, lhs != rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(bool lhs, bool rhs) => new bool2(lhs != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Not (!v).
        /// </summary>
        public static bool2 Not(bool2 v) => new bool2(!v.x, !v.y);
        
        /// <summary>
        /// Returns a bool from the application of Not (!v).
        /// </summary>
        public static bool2 Not(bool v) => new bool2(!v);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bool2 And(bool2 lhs, bool2 rhs) => new bool2(lhs.x && rhs.x, lhs.y && rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bool2 And(bool2 lhs, bool rhs) => new bool2(lhs.x && rhs, lhs.y && rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bool2 And(bool lhs, bool2 rhs) => new bool2(lhs && rhs.x, lhs && rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static bool2 And(bool lhs, bool rhs) => new bool2(lhs && rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bool2 Nand(bool2 lhs, bool2 rhs) => new bool2(!(lhs.x && rhs.x), !(lhs.y && rhs.y));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bool2 Nand(bool2 lhs, bool rhs) => new bool2(!(lhs.x && rhs), !(lhs.y && rhs));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bool2 Nand(bool lhs, bool2 rhs) => new bool2(!(lhs && rhs.x), !(lhs && rhs.y));
        
        /// <summary>
        /// Returns a bool from the application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static bool2 Nand(bool lhs, bool rhs) => new bool2(!(lhs && rhs));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bool2 Or(bool2 lhs, bool2 rhs) => new bool2(lhs.x || rhs.x, lhs.y || rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bool2 Or(bool2 lhs, bool rhs) => new bool2(lhs.x || rhs, lhs.y || rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static bool2 Or(bool lhs, bool2 rhs) => new bool2(lhs || rhs.x, lhs || rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of Or (lhs || rhs).
        /// </summary>
        public static bool2 Or(bool lhs, bool rhs) => new bool2(lhs || rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bool2 Nor(bool2 lhs, bool2 rhs) => new bool2(!(lhs.x || rhs.x), !(lhs.y || rhs.y));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bool2 Nor(bool2 lhs, bool rhs) => new bool2(!(lhs.x || rhs), !(lhs.y || rhs));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bool2 Nor(bool lhs, bool2 rhs) => new bool2(!(lhs || rhs.x), !(lhs || rhs.y));
        
        /// <summary>
        /// Returns a bool from the application of Nor (!(lhs || rhs)).
        /// </summary>
        public static bool2 Nor(bool lhs, bool rhs) => new bool2(!(lhs || rhs));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bool2 Xor(bool2 lhs, bool2 rhs) => new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bool2 Xor(bool2 lhs, bool rhs) => new bool2(lhs.x != rhs, lhs.y != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static bool2 Xor(bool lhs, bool2 rhs) => new bool2(lhs != rhs.x, lhs != rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of Xor (lhs != rhs).
        /// </summary>
        public static bool2 Xor(bool lhs, bool rhs) => new bool2(lhs != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bool2 Xnor(bool2 lhs, bool2 rhs) => new bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bool2 Xnor(bool2 lhs, bool rhs) => new bool2(lhs.x == rhs, lhs.y == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static bool2 Xnor(bool lhs, bool2 rhs) => new bool2(lhs == rhs.x, lhs == rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of Xnor (lhs == rhs).
        /// </summary>
        public static bool2 Xnor(bool lhs, bool rhs) => new bool2(lhs == rhs);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator! (!v).
        /// </summary>
        public static bool2 operator!(bool2 v) => new bool2(!v.x, !v.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bool2 operator&(bool2 lhs, bool2 rhs) => new bool2(lhs.x && rhs.x, lhs.y && rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bool2 operator&(bool2 lhs, bool rhs) => new bool2(lhs.x && rhs, lhs.y && rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static bool2 operator&(bool lhs, bool2 rhs) => new bool2(lhs && rhs.x, lhs && rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bool2 operator|(bool2 lhs, bool2 rhs) => new bool2(lhs.x || rhs.x, lhs.y || rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bool2 operator|(bool2 lhs, bool rhs) => new bool2(lhs.x || rhs, lhs.y || rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static bool2 operator|(bool lhs, bool2 rhs) => new bool2(lhs || rhs.x, lhs || rhs.y);

        #endregion

    }
}
