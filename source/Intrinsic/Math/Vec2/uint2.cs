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
    /// A vector of type uint with 2 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct uint2 : IReadOnlyList<uint>, IEquatable<uint2>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public uint y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public uint2(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public uint2(uint v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public uint2(uint2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public uint2(uint3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public uint2(uint4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint2(IReadOnlyList<uint> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0u : v[0];
            this.y = c < 1 ? 0u : v[1];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint2(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0u : (uint)v[0];
            this.y = c < 1 ? 0u : (uint)v[1];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint2(uint[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0u : v[0];
            this.y = c < 1 ? 0u : v[1];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint2(uint[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0u : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0u : v[1 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint2(IEnumerable<uint> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a long2.
        /// </summary>
        public static implicit operator long2(uint2 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Implicitly converts this to a float2.
        /// </summary>
        public static implicit operator float2(uint2 v) => new float2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Implicitly converts this to a double2.
        /// </summary>
        public static implicit operator double2(uint2 v) => new double2((double)v.x, (double)v.y);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(uint2 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int3(uint2 v) => new int3((int)v.x, (int)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a int4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int4(uint2 v) => new int4((int)v.x, (int)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a uint3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint3(uint2 v) => new uint3((uint)v.x, (uint)v.y, 0u);
        
        /// <summary>
        /// Explicitly converts this to a uint4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint4(uint2 v) => new uint4((uint)v.x, (uint)v.y, 0u, 0u);
        
        /// <summary>
        /// Explicitly converts this to a float3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float3(uint2 v) => new float3((float)v.x, (float)v.y, 0f);
        
        /// <summary>
        /// Explicitly converts this to a float4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float4(uint2 v) => new float4((float)v.x, (float)v.y, 0f, 0f);
        
        /// <summary>
        /// Explicitly converts this to a double3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double3(uint2 v) => new double3((double)v.x, (double)v.y, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a double4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double4(uint2 v) => new double4((double)v.x, (double)v.y, 0.0, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a long3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long3(uint2 v) => new long3((long)v.x, (long)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a long4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long4(uint2 v) => new long4((long)v.x, (long)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(uint2 v) => new bool2(v.x != 0u, v.y != 0u);
        
        /// <summary>
        /// Explicitly converts this to a bool3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool3(uint2 v) => new bool3(v.x != 0u, v.y != 0u, false);
        
        /// <summary>
        /// Explicitly converts this to a bool4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool4(uint2 v) => new bool4(v.x != 0u, v.y != 0u, false, false);
        
        /// <summary>
        /// Explicitly converts this to a uint array.
        /// </summary>
        public static explicit operator uint[](uint2 v) => new [] { v.x, v.y };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](uint2 v) => new Object[] { v.x, v.y };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public uint this[int index]
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
        public swizzle_uint2 swizzle => new swizzle_uint2(x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uint2 xy
        {
            get
            {
                return new uint2(x, y);
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
        public uint2 rg
        {
            get
            {
                return new uint2(x, y);
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
        public uint r
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
        public uint g
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
        public uint[] Values => new[] { x, y };
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public uint MinElement => System.Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public uint MaxElement => System.Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)System.Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => (x*x + y*y);
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public uint Sum => (x + y);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)System.Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => (x + y);
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)System.Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => System.Math.Max(x, y);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static uint2 Zero { get; } = new uint2(0u, 0u);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static uint2 Ones { get; } = new uint2(1u, 1u);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static uint2 UnitX { get; } = new uint2(1u, 0u);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static uint2 UnitY { get; } = new uint2(0u, 1u);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static uint2 MaxValue { get; } = new uint2(uint.MaxValue, uint.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static uint2 MinValue { get; } = new uint2(uint.MinValue, uint.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(uint2 lhs, uint2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(uint2 lhs, uint2 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<uint> GetEnumerator()
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
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => (x.ToString(format) + sep + y.ToString(format));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => (x.ToString(format, provider) + sep + y.ToString(format, provider));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(uint2 rhs) => (x.Equals(rhs.x) && y.Equals(rhs.y));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is uint2 && Equals((uint2) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((x.GetHashCode()) * 397) ^ y.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => System.Math.Pow((System.Math.Pow((double)x, p) + System.Math.Pow((double)y, p)), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static uint2 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static uint2 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new uint2(uint.Parse(kvp[0].Trim()), uint.Parse(kvp[1].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static uint2 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new uint2(uint.Parse(kvp[0].Trim(), provider), uint.Parse(kvp[1].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static uint2 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new uint2(uint.Parse(kvp[0].Trim(), style), uint.Parse(kvp[1].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static uint2 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new uint2(uint.Parse(kvp[0].Trim(), style, provider), uint.Parse(kvp[1].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out uint2 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out uint2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            uint x = 0u, y = 0u;
            var ok = (uint.TryParse(kvp[0].Trim(), out x) && uint.TryParse(kvp[1].Trim(), out y));
            result = ok ? new uint2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out uint2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            uint x = 0u, y = 0u;
            var ok = (uint.TryParse(kvp[0].Trim(), style, provider, out x) && uint.TryParse(kvp[1].Trim(), style, provider, out y));
            result = ok ? new uint2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint2x2 OuterProduct(uint2 c, uint2 r) => new uint2x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint2x3 OuterProduct(uint3 c, uint2 r) => new uint2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint3x2 OuterProduct(uint2 c, uint3 r) => new uint3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint2x4 OuterProduct(uint4 c, uint2 r) => new uint2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint4x2 OuterProduct(uint2 c, uint4 r) => new uint4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uint2 lhs, uint2 rhs) => (lhs.x * rhs.x + lhs.y * rhs.y);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(uint2 lhs, uint2 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(uint2 lhs, uint2 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static uint Cross(uint2 l, uint2 r) => l.x * r.y - l.y * r.x;
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive).
        /// </summary>
        public static uint2 Random(Random random) => new uint2((uint)random.Next(), (uint)random.Next());

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(uint2 lhs, uint2 rhs) => new bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(uint2 lhs, uint rhs) => new bool2(lhs.x == rhs, lhs.y == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(uint lhs, uint2 rhs) => new bool2(lhs == rhs.x, lhs == rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(uint lhs, uint rhs) => new bool2(lhs == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(uint2 lhs, uint2 rhs) => new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(uint2 lhs, uint rhs) => new bool2(lhs.x != rhs, lhs.y != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(uint lhs, uint2 rhs) => new bool2(lhs != rhs.x, lhs != rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(uint lhs, uint rhs) => new bool2(lhs != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(uint2 lhs, uint2 rhs) => new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(uint2 lhs, uint rhs) => new bool2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(uint lhs, uint2 rhs) => new bool2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(uint lhs, uint rhs) => new bool2(lhs > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(uint2 lhs, uint2 rhs) => new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(uint2 lhs, uint rhs) => new bool2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(uint lhs, uint2 rhs) => new bool2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(uint lhs, uint rhs) => new bool2(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(uint2 lhs, uint2 rhs) => new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(uint2 lhs, uint rhs) => new bool2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(uint lhs, uint2 rhs) => new bool2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(uint lhs, uint rhs) => new bool2(lhs < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(uint2 lhs, uint2 rhs) => new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(uint2 lhs, uint rhs) => new bool2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(uint lhs, uint2 rhs) => new bool2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(uint lhs, uint rhs) => new bool2(lhs <= rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Abs (v).
        /// </summary>
        public static uint2 Abs(uint2 v) => new uint2(v.x, v.y);
        
        /// <summary>
        /// Returns a uint from the application of Abs (v).
        /// </summary>
        public static uint2 Abs(uint v) => new uint2(v);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uint2 HermiteInterpolationOrder3(uint2 v) => new uint2((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y);
        
        /// <summary>
        /// Returns a uint from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uint2 HermiteInterpolationOrder3(uint v) => new uint2((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uint2 HermiteInterpolationOrder5(uint2 v) => new uint2(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a uint from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uint2 HermiteInterpolationOrder5(uint v) => new uint2(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uint2 Sqr(uint2 v) => new uint2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a uint from the application of Sqr (v * v).
        /// </summary>
        public static uint2 Sqr(uint v) => new uint2(v * v);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uint2 Pow2(uint2 v) => new uint2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a uint from the application of Pow2 (v * v).
        /// </summary>
        public static uint2 Pow2(uint v) => new uint2(v * v);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uint2 Pow3(uint2 v) => new uint2(v.x * v.x * v.x, v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a uint from the application of Pow3 (v * v * v).
        /// </summary>
        public static uint2 Pow3(uint v) => new uint2(v * v * v);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uint2 Step(uint2 v) => new uint2(v.x >= 0u ? 1u : 0u, v.y >= 0u ? 1u : 0u);
        
        /// <summary>
        /// Returns a uint from the application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uint2 Step(uint v) => new uint2(v >= 0u ? 1u : 0u);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Sqrt ((uint)System.Math.Sqrt((double)v)).
        /// </summary>
        public static uint2 Sqrt(uint2 v) => new uint2((uint)System.Math.Sqrt((double)v.x), (uint)System.Math.Sqrt((double)v.y));
        
        /// <summary>
        /// Returns a uint from the application of Sqrt ((uint)System.Math.Sqrt((double)v)).
        /// </summary>
        public static uint2 Sqrt(uint v) => new uint2((uint)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of InverseSqrt ((uint)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static uint2 InverseSqrt(uint2 v) => new uint2((uint)(1.0 / System.Math.Sqrt((double)v.x)), (uint)(1.0 / System.Math.Sqrt((double)v.y)));
        
        /// <summary>
        /// Returns a uint from the application of InverseSqrt ((uint)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static uint2 InverseSqrt(uint v) => new uint2((uint)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int2 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int2 Sign(uint2 v) => new int2(System.Math.Sign(v.x), System.Math.Sign(v.y));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int2 Sign(uint v) => new int2(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static uint2 Max(uint2 lhs, uint2 rhs) => new uint2(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static uint2 Max(uint2 lhs, uint rhs) => new uint2(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static uint2 Max(uint lhs, uint2 rhs) => new uint2(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y));
        
        /// <summary>
        /// Returns a uint from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static uint2 Max(uint lhs, uint rhs) => new uint2(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static uint2 Min(uint2 lhs, uint2 rhs) => new uint2(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static uint2 Min(uint2 lhs, uint rhs) => new uint2(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static uint2 Min(uint lhs, uint2 rhs) => new uint2(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y));
        
        /// <summary>
        /// Returns a uint from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static uint2 Min(uint lhs, uint rhs) => new uint2(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Pow ((uint)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint2 Pow(uint2 lhs, uint2 rhs) => new uint2((uint)System.Math.Pow((double)lhs.x, (double)rhs.x), (uint)System.Math.Pow((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Pow ((uint)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint2 Pow(uint2 lhs, uint rhs) => new uint2((uint)System.Math.Pow((double)lhs.x, (double)rhs), (uint)System.Math.Pow((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Pow ((uint)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint2 Pow(uint lhs, uint2 rhs) => new uint2((uint)System.Math.Pow((double)lhs, (double)rhs.x), (uint)System.Math.Pow((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a uint from the application of Pow ((uint)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint2 Pow(uint lhs, uint rhs) => new uint2((uint)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Log ((uint)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint2 Log(uint2 lhs, uint2 rhs) => new uint2((uint)System.Math.Log((double)lhs.x, (double)rhs.x), (uint)System.Math.Log((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Log ((uint)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint2 Log(uint2 lhs, uint rhs) => new uint2((uint)System.Math.Log((double)lhs.x, (double)rhs), (uint)System.Math.Log((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Log ((uint)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint2 Log(uint lhs, uint2 rhs) => new uint2((uint)System.Math.Log((double)lhs, (double)rhs.x), (uint)System.Math.Log((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a uint from the application of Log ((uint)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint2 Log(uint lhs, uint rhs) => new uint2((uint)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint2 Clamp(uint2 v, uint2 min, uint2 max) => new uint2(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint2 Clamp(uint2 v, uint2 min, uint max) => new uint2(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint2 Clamp(uint2 v, uint min, uint2 max) => new uint2(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint2 Clamp(uint2 v, uint min, uint max) => new uint2(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint2 Clamp(uint v, uint2 min, uint2 max) => new uint2(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint2 Clamp(uint v, uint2 min, uint max) => new uint2(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint2 Clamp(uint v, uint min, uint2 max) => new uint2(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y));
        
        /// <summary>
        /// Returns a uint from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint2 Clamp(uint v, uint min, uint max) => new uint2(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Mix(uint2 min, uint2 max, uint2 a) => new uint2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Mix(uint2 min, uint2 max, uint a) => new uint2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Mix(uint2 min, uint max, uint2 a) => new uint2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Mix(uint2 min, uint max, uint a) => new uint2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Mix(uint min, uint2 max, uint2 a) => new uint2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Mix(uint min, uint2 max, uint a) => new uint2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Mix(uint min, uint max, uint2 a) => new uint2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a uint from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Mix(uint min, uint max, uint a) => new uint2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Lerp(uint2 min, uint2 max, uint2 a) => new uint2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Lerp(uint2 min, uint2 max, uint a) => new uint2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Lerp(uint2 min, uint max, uint2 a) => new uint2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Lerp(uint2 min, uint max, uint a) => new uint2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Lerp(uint min, uint2 max, uint2 a) => new uint2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Lerp(uint min, uint2 max, uint a) => new uint2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Lerp(uint min, uint max, uint2 a) => new uint2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a uint from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint2 Lerp(uint min, uint max, uint a) => new uint2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint2 Smoothstep(uint2 edge0, uint2 edge1, uint2 v) => new uint2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint2 Smoothstep(uint2 edge0, uint2 edge1, uint v) => new uint2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint2 Smoothstep(uint2 edge0, uint edge1, uint2 v) => new uint2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint2 Smoothstep(uint2 edge0, uint edge1, uint v) => new uint2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint2 Smoothstep(uint edge0, uint2 edge1, uint2 v) => new uint2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint2 Smoothstep(uint edge0, uint2 edge1, uint v) => new uint2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint2 Smoothstep(uint edge0, uint edge1, uint2 v) => new uint2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint2 Smoothstep(uint edge0, uint edge1, uint v) => new uint2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint2 Smootherstep(uint2 edge0, uint2 edge1, uint2 v) => new uint2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint2 Smootherstep(uint2 edge0, uint2 edge1, uint v) => new uint2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint2 Smootherstep(uint2 edge0, uint edge1, uint2 v) => new uint2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint2 Smootherstep(uint2 edge0, uint edge1, uint v) => new uint2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint2 Smootherstep(uint edge0, uint2 edge1, uint2 v) => new uint2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint2 Smootherstep(uint edge0, uint2 edge1, uint v) => new uint2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint2 Smootherstep(uint edge0, uint edge1, uint2 v) => new uint2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint2 Smootherstep(uint edge0, uint edge1, uint v) => new uint2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint2 Fma(uint2 a, uint2 b, uint2 c) => new uint2(a.x * b.x + c.x, a.y * b.y + c.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint2 Fma(uint2 a, uint2 b, uint c) => new uint2(a.x * b.x + c, a.y * b.y + c);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint2 Fma(uint2 a, uint b, uint2 c) => new uint2(a.x * b + c.x, a.y * b + c.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint2 Fma(uint2 a, uint b, uint c) => new uint2(a.x * b + c, a.y * b + c);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint2 Fma(uint a, uint2 b, uint2 c) => new uint2(a * b.x + c.x, a * b.y + c.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint2 Fma(uint a, uint2 b, uint c) => new uint2(a * b.x + c, a * b.y + c);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint2 Fma(uint a, uint b, uint2 c) => new uint2(a * b + c.x, a * b + c.y);
        
        /// <summary>
        /// Returns a uint from the application of Fma (a * b + c).
        /// </summary>
        public static uint2 Fma(uint a, uint b, uint c) => new uint2(a * b + c);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uint2 Add(uint2 lhs, uint2 rhs) => new uint2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uint2 Add(uint2 lhs, uint rhs) => new uint2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uint2 Add(uint lhs, uint2 rhs) => new uint2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of Add (lhs + rhs).
        /// </summary>
        public static uint2 Add(uint lhs, uint rhs) => new uint2(lhs + rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uint2 Sub(uint2 lhs, uint2 rhs) => new uint2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uint2 Sub(uint2 lhs, uint rhs) => new uint2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uint2 Sub(uint lhs, uint2 rhs) => new uint2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of Sub (lhs - rhs).
        /// </summary>
        public static uint2 Sub(uint lhs, uint rhs) => new uint2(lhs - rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uint2 Mul(uint2 lhs, uint2 rhs) => new uint2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uint2 Mul(uint2 lhs, uint rhs) => new uint2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uint2 Mul(uint lhs, uint2 rhs) => new uint2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of Mul (lhs * rhs).
        /// </summary>
        public static uint2 Mul(uint lhs, uint rhs) => new uint2(lhs * rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uint2 Div(uint2 lhs, uint2 rhs) => new uint2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uint2 Div(uint2 lhs, uint rhs) => new uint2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uint2 Div(uint lhs, uint2 rhs) => new uint2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of Div (lhs / rhs).
        /// </summary>
        public static uint2 Div(uint lhs, uint rhs) => new uint2(lhs / rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint2 Xor(uint2 lhs, uint2 rhs) => new uint2(lhs.x ^ rhs.x, lhs.y ^ rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint2 Xor(uint2 lhs, uint rhs) => new uint2(lhs.x ^ rhs, lhs.y ^ rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint2 Xor(uint lhs, uint2 rhs) => new uint2(lhs ^ rhs.x, lhs ^ rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint2 Xor(uint lhs, uint rhs) => new uint2(lhs ^ rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint2 BitwiseOr(uint2 lhs, uint2 rhs) => new uint2(lhs.x | rhs.x, lhs.y | rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint2 BitwiseOr(uint2 lhs, uint rhs) => new uint2(lhs.x | rhs, lhs.y | rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint2 BitwiseOr(uint lhs, uint2 rhs) => new uint2(lhs | rhs.x, lhs | rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint2 BitwiseOr(uint lhs, uint rhs) => new uint2(lhs | rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint2 BitwiseAnd(uint2 lhs, uint2 rhs) => new uint2(lhs.x & rhs.x, lhs.y & rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint2 BitwiseAnd(uint2 lhs, uint rhs) => new uint2(lhs.x & rhs, lhs.y & rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint2 BitwiseAnd(uint lhs, uint2 rhs) => new uint2(lhs & rhs.x, lhs & rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint2 BitwiseAnd(uint lhs, uint rhs) => new uint2(lhs & rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint2 LeftShift(uint2 lhs, int2 rhs) => new uint2(lhs.x << rhs.x, lhs.y << rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint2 LeftShift(uint2 lhs, int rhs) => new uint2(lhs.x << rhs, lhs.y << rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint2 LeftShift(uint lhs, int2 rhs) => new uint2(lhs << rhs.x, lhs << rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint2 LeftShift(uint lhs, int rhs) => new uint2(lhs << rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint2 RightShift(uint2 lhs, int2 rhs) => new uint2(lhs.x >> rhs.x, lhs.y >> rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint2 RightShift(uint2 lhs, int rhs) => new uint2(lhs.x >> rhs, lhs.y >> rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint2 RightShift(uint lhs, int2 rhs) => new uint2(lhs >> rhs.x, lhs >> rhs.y);
        
        /// <summary>
        /// Returns a uint from the application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint2 RightShift(uint lhs, int rhs) => new uint2(lhs >> rhs);
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uint2 Random(Random random, uint2 maxValue) => new uint2((uint)random.Next((int)maxValue.x), (uint)random.Next((int)maxValue.y));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uint2 Random(Random random, uint maxValue) => new uint2((uint)random.Next((int)maxValue));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint2 Random(Random random, uint2 minValue, uint2 maxValue) => new uint2((uint)random.Next((int)minValue.x, (int)maxValue.x), (uint)random.Next((int)minValue.y, (int)maxValue.y));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint2 Random(Random random, uint2 minValue, uint maxValue) => new uint2((uint)random.Next((int)minValue.x, (int)maxValue), (uint)random.Next((int)minValue.y, (int)maxValue));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint2 Random(Random random, uint minValue, uint2 maxValue) => new uint2((uint)random.Next((int)minValue, (int)maxValue.x), (uint)random.Next((int)minValue, (int)maxValue.y));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint2 Random(Random random, uint minValue, uint maxValue) => new uint2((uint)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint2 RandomUniform(Random random, uint2 minValue, uint2 maxValue) => new uint2((uint)random.Next((int)minValue.x, (int)maxValue.x), (uint)random.Next((int)minValue.y, (int)maxValue.y));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint2 RandomUniform(Random random, uint2 minValue, uint maxValue) => new uint2((uint)random.Next((int)minValue.x, (int)maxValue), (uint)random.Next((int)minValue.y, (int)maxValue));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint2 RandomUniform(Random random, uint minValue, uint2 maxValue) => new uint2((uint)random.Next((int)minValue, (int)maxValue.x), (uint)random.Next((int)minValue, (int)maxValue.y));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint2 RandomUniform(Random random, uint minValue, uint maxValue) => new uint2((uint)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static uint2 RandomPoisson(Random random, double2 lambda) => new uint2((uint)lambda.x.GetPoisson(random), (uint)lambda.y.GetPoisson(random));
        
        /// <summary>
        /// Returns a uint2 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static uint2 RandomPoisson(Random random, double lambda) => new uint2((uint)lambda.GetPoisson(random));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(uint2 lhs, uint2 rhs) => new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(uint2 lhs, uint rhs) => new bool2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(uint lhs, uint2 rhs) => new bool2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(uint2 lhs, uint2 rhs) => new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(uint2 lhs, uint rhs) => new bool2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(uint lhs, uint2 rhs) => new bool2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(uint2 lhs, uint2 rhs) => new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(uint2 lhs, uint rhs) => new bool2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(uint lhs, uint2 rhs) => new bool2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(uint2 lhs, uint2 rhs) => new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(uint2 lhs, uint rhs) => new bool2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(uint lhs, uint2 rhs) => new bool2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uint2 operator+(uint2 lhs, uint2 rhs) => new uint2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uint2 operator+(uint2 lhs, uint rhs) => new uint2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uint2 operator+(uint lhs, uint2 rhs) => new uint2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uint2 operator-(uint2 lhs, uint2 rhs) => new uint2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uint2 operator-(uint2 lhs, uint rhs) => new uint2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uint2 operator-(uint lhs, uint2 rhs) => new uint2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uint2 operator*(uint2 lhs, uint2 rhs) => new uint2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uint2 operator*(uint2 lhs, uint rhs) => new uint2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uint2 operator*(uint lhs, uint2 rhs) => new uint2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uint2 operator/(uint2 lhs, uint2 rhs) => new uint2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uint2 operator/(uint2 lhs, uint rhs) => new uint2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uint2 operator/(uint lhs, uint2 rhs) => new uint2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator+ (identity).
        /// </summary>
        public static uint2 operator+(uint2 v) => v;
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator~ (~v).
        /// </summary>
        public static uint2 operator~(uint2 v) => new uint2(~v.x, ~v.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uint2 operator^(uint2 lhs, uint2 rhs) => new uint2(lhs.x ^ rhs.x, lhs.y ^ rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uint2 operator^(uint2 lhs, uint rhs) => new uint2(lhs.x ^ rhs, lhs.y ^ rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uint2 operator^(uint lhs, uint2 rhs) => new uint2(lhs ^ rhs.x, lhs ^ rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uint2 operator|(uint2 lhs, uint2 rhs) => new uint2(lhs.x | rhs.x, lhs.y | rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uint2 operator|(uint2 lhs, uint rhs) => new uint2(lhs.x | rhs, lhs.y | rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uint2 operator|(uint lhs, uint2 rhs) => new uint2(lhs | rhs.x, lhs | rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uint2 operator&(uint2 lhs, uint2 rhs) => new uint2(lhs.x & rhs.x, lhs.y & rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uint2 operator&(uint2 lhs, uint rhs) => new uint2(lhs.x & rhs, lhs.y & rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uint2 operator&(uint lhs, uint2 rhs) => new uint2(lhs & rhs.x, lhs & rhs.y);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint2 operator<<(uint2 lhs, int rhs) => new uint2(lhs.x << rhs, lhs.y << rhs);
        
        /// <summary>
        /// Returns a uint2 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint2 operator>>(uint2 lhs, int rhs) => new uint2(lhs.x >> rhs, lhs.y >> rhs);

        #endregion

    }
}
