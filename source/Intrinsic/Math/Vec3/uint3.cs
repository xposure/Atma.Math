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
    /// A vector of type uint with 3 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct uint3 : IReadOnlyList<uint>, IEquatable<uint3>
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
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public uint z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public uint3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public uint3(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uint3(uint2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0u;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public uint3(uint2 v, uint z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public uint3(uint3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public uint3(uint4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint3(IReadOnlyList<uint> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0u : v[0];
            this.y = c < 1 ? 0u : v[1];
            this.z = c < 2 ? 0u : v[2];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint3(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0u : (uint)v[0];
            this.y = c < 1 ? 0u : (uint)v[1];
            this.z = c < 2 ? 0u : (uint)v[2];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint3(uint[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0u : v[0];
            this.y = c < 1 ? 0u : v[1];
            this.z = c < 2 ? 0u : v[2];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint3(uint[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0u : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0u : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0u : v[2 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uint3(IEnumerable<uint> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a long3.
        /// </summary>
        public static implicit operator long3(uint3 v) => new long3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Implicitly converts this to a float3.
        /// </summary>
        public static implicit operator float3(uint3 v) => new float3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Implicitly converts this to a double3.
        /// </summary>
        public static implicit operator double3(uint3 v) => new double3((double)v.x, (double)v.y, (double)v.z);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(uint3 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int3.
        /// </summary>
        public static explicit operator int3(uint3 v) => new int3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a int4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int4(uint3 v) => new int4((int)v.x, (int)v.y, (int)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(uint3 v) => new uint2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uint4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint4(uint3 v) => new uint4((uint)v.x, (uint)v.y, (uint)v.z, 0u);
        
        /// <summary>
        /// Explicitly converts this to a float2.
        /// </summary>
        public static explicit operator float2(uint3 v) => new float2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a float4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float4(uint3 v) => new float4((float)v.x, (float)v.y, (float)v.z, 0f);
        
        /// <summary>
        /// Explicitly converts this to a double2.
        /// </summary>
        public static explicit operator double2(uint3 v) => new double2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a double4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double4(uint3 v) => new double4((double)v.x, (double)v.y, (double)v.z, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(uint3 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a long4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long4(uint3 v) => new long4((long)v.x, (long)v.y, (long)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(uint3 v) => new bool2(v.x != 0u, v.y != 0u);
        
        /// <summary>
        /// Explicitly converts this to a bool3.
        /// </summary>
        public static explicit operator bool3(uint3 v) => new bool3(v.x != 0u, v.y != 0u, v.z != 0u);
        
        /// <summary>
        /// Explicitly converts this to a bool4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool4(uint3 v) => new bool4(v.x != 0u, v.y != 0u, v.z != 0u, false);
        
        /// <summary>
        /// Explicitly converts this to a uint array.
        /// </summary>
        public static explicit operator uint[](uint3 v) => new [] { v.x, v.y, v.z };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](uint3 v) => new Object[] { v.x, v.y, v.z };

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
                    case 2: return z;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_uint3 swizzle => new swizzle_uint3(x, y, z);
        
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
        public uint2 xz
        {
            get
            {
                return new uint2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uint2 yz
        {
            get
            {
                return new uint2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uint3 xyz
        {
            get
            {
                return new uint3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
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
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uint2 rb
        {
            get
            {
                return new uint2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uint2 gb
        {
            get
            {
                return new uint2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uint3 rgb
        {
            get
            {
                return new uint3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
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
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uint b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public uint[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public uint MinElement => System.Math.Min(System.Math.Min(x, y), z);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public uint MaxElement => System.Math.Max(System.Math.Max(x, y), z);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)System.Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => ((x*x + y*y) + z*z);
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public uint Sum => ((x + y) + z);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)System.Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => ((x + y) + z);
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)System.Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => System.Math.Max(System.Math.Max(x, y), z);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static uint3 Zero { get; } = new uint3(0u, 0u, 0u);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static uint3 Ones { get; } = new uint3(1u, 1u, 1u);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static uint3 UnitX { get; } = new uint3(1u, 0u, 0u);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static uint3 UnitY { get; } = new uint3(0u, 1u, 0u);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static uint3 UnitZ { get; } = new uint3(0u, 0u, 1u);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static uint3 MaxValue { get; } = new uint3(uint.MaxValue, uint.MaxValue, uint.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static uint3 MinValue { get; } = new uint3(uint.MinValue, uint.MinValue, uint.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(uint3 lhs, uint3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(uint3 lhs, uint3 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<uint> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
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
        public string ToString(string sep) => ((x + sep + y) + sep + z);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => ((x.ToString(provider) + sep + y.ToString(provider)) + sep + z.ToString(provider));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => ((x.ToString(format) + sep + y.ToString(format)) + sep + z.ToString(format));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => ((x.ToString(format, provider) + sep + y.ToString(format, provider)) + sep + z.ToString(format, provider));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(uint3 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is uint3 && Equals((uint3) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((x.GetHashCode()) * 397) ^ y.GetHashCode()) * 397) ^ z.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => System.Math.Pow(((System.Math.Pow((double)x, p) + System.Math.Pow((double)y, p)) + System.Math.Pow((double)z, p)), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static uint3 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static uint3 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new uint3(uint.Parse(kvp[0].Trim()), uint.Parse(kvp[1].Trim()), uint.Parse(kvp[2].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static uint3 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new uint3(uint.Parse(kvp[0].Trim(), provider), uint.Parse(kvp[1].Trim(), provider), uint.Parse(kvp[2].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static uint3 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new uint3(uint.Parse(kvp[0].Trim(), style), uint.Parse(kvp[1].Trim(), style), uint.Parse(kvp[2].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static uint3 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new uint3(uint.Parse(kvp[0].Trim(), style, provider), uint.Parse(kvp[1].Trim(), style, provider), uint.Parse(kvp[2].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out uint3 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out uint3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            uint x = 0u, y = 0u, z = 0u;
            var ok = ((uint.TryParse(kvp[0].Trim(), out x) && uint.TryParse(kvp[1].Trim(), out y)) && uint.TryParse(kvp[2].Trim(), out z));
            result = ok ? new uint3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out uint3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            uint x = 0u, y = 0u, z = 0u;
            var ok = ((uint.TryParse(kvp[0].Trim(), style, provider, out x) && uint.TryParse(kvp[1].Trim(), style, provider, out y)) && uint.TryParse(kvp[2].Trim(), style, provider, out z));
            result = ok ? new uint3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint3x2 OuterProduct(uint2 c, uint3 r) => new uint3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint2x3 OuterProduct(uint3 c, uint2 r) => new uint2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint3x3 OuterProduct(uint3 c, uint3 r) => new uint3x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint3x4 OuterProduct(uint4 c, uint3 r) => new uint3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static uint4x3 OuterProduct(uint3 c, uint4 r) => new uint4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uint3 lhs, uint3 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(uint3 lhs, uint3 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(uint3 lhs, uint3 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static uint3 Cross(uint3 l, uint3 r) => new uint3(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive).
        /// </summary>
        public static uint3 Random(Random random) => new uint3((uint)random.Next(), (uint)random.Next(), (uint)random.Next());

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(uint3 lhs, uint3 rhs) => new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(uint3 lhs, uint rhs) => new bool3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(uint lhs, uint3 rhs) => new bool3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(uint lhs, uint rhs) => new bool3(lhs == rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(uint3 lhs, uint3 rhs) => new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(uint3 lhs, uint rhs) => new bool3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(uint lhs, uint3 rhs) => new bool3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(uint lhs, uint rhs) => new bool3(lhs != rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(uint3 lhs, uint3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(uint3 lhs, uint rhs) => new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(uint lhs, uint3 rhs) => new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(uint lhs, uint rhs) => new bool3(lhs > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(uint3 lhs, uint3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(uint3 lhs, uint rhs) => new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(uint lhs, uint3 rhs) => new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(uint lhs, uint rhs) => new bool3(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(uint3 lhs, uint3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(uint3 lhs, uint rhs) => new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(uint lhs, uint3 rhs) => new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(uint lhs, uint rhs) => new bool3(lhs < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(uint3 lhs, uint3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(uint3 lhs, uint rhs) => new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(uint lhs, uint3 rhs) => new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(uint lhs, uint rhs) => new bool3(lhs <= rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Abs (v).
        /// </summary>
        public static uint3 Abs(uint3 v) => new uint3(v.x, v.y, v.z);
        
        /// <summary>
        /// Returns a uint from the application of Abs (v).
        /// </summary>
        public static uint3 Abs(uint v) => new uint3(v);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uint3 HermiteInterpolationOrder3(uint3 v) => new uint3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a uint from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uint3 HermiteInterpolationOrder3(uint v) => new uint3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uint3 HermiteInterpolationOrder5(uint3 v) => new uint3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a uint from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uint3 HermiteInterpolationOrder5(uint v) => new uint3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uint3 Sqr(uint3 v) => new uint3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a uint from the application of Sqr (v * v).
        /// </summary>
        public static uint3 Sqr(uint v) => new uint3(v * v);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uint3 Pow2(uint3 v) => new uint3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a uint from the application of Pow2 (v * v).
        /// </summary>
        public static uint3 Pow2(uint v) => new uint3(v * v);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uint3 Pow3(uint3 v) => new uint3(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a uint from the application of Pow3 (v * v * v).
        /// </summary>
        public static uint3 Pow3(uint v) => new uint3(v * v * v);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uint3 Step(uint3 v) => new uint3(v.x >= 0u ? 1u : 0u, v.y >= 0u ? 1u : 0u, v.z >= 0u ? 1u : 0u);
        
        /// <summary>
        /// Returns a uint from the application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uint3 Step(uint v) => new uint3(v >= 0u ? 1u : 0u);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Sqrt ((uint)System.Math.Sqrt((double)v)).
        /// </summary>
        public static uint3 Sqrt(uint3 v) => new uint3((uint)System.Math.Sqrt((double)v.x), (uint)System.Math.Sqrt((double)v.y), (uint)System.Math.Sqrt((double)v.z));
        
        /// <summary>
        /// Returns a uint from the application of Sqrt ((uint)System.Math.Sqrt((double)v)).
        /// </summary>
        public static uint3 Sqrt(uint v) => new uint3((uint)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of InverseSqrt ((uint)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static uint3 InverseSqrt(uint3 v) => new uint3((uint)(1.0 / System.Math.Sqrt((double)v.x)), (uint)(1.0 / System.Math.Sqrt((double)v.y)), (uint)(1.0 / System.Math.Sqrt((double)v.z)));
        
        /// <summary>
        /// Returns a uint from the application of InverseSqrt ((uint)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static uint3 InverseSqrt(uint v) => new uint3((uint)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int3 Sign(uint3 v) => new int3(System.Math.Sign(v.x), System.Math.Sign(v.y), System.Math.Sign(v.z));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int3 Sign(uint v) => new int3(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static uint3 Max(uint3 lhs, uint3 rhs) => new uint3(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y), System.Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static uint3 Max(uint3 lhs, uint rhs) => new uint3(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs), System.Math.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static uint3 Max(uint lhs, uint3 rhs) => new uint3(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y), System.Math.Max(lhs, rhs.z));
        
        /// <summary>
        /// Returns a uint from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static uint3 Max(uint lhs, uint rhs) => new uint3(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static uint3 Min(uint3 lhs, uint3 rhs) => new uint3(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y), System.Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static uint3 Min(uint3 lhs, uint rhs) => new uint3(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs), System.Math.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static uint3 Min(uint lhs, uint3 rhs) => new uint3(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y), System.Math.Min(lhs, rhs.z));
        
        /// <summary>
        /// Returns a uint from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static uint3 Min(uint lhs, uint rhs) => new uint3(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Pow ((uint)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint3 Pow(uint3 lhs, uint3 rhs) => new uint3((uint)System.Math.Pow((double)lhs.x, (double)rhs.x), (uint)System.Math.Pow((double)lhs.y, (double)rhs.y), (uint)System.Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Pow ((uint)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint3 Pow(uint3 lhs, uint rhs) => new uint3((uint)System.Math.Pow((double)lhs.x, (double)rhs), (uint)System.Math.Pow((double)lhs.y, (double)rhs), (uint)System.Math.Pow((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Pow ((uint)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint3 Pow(uint lhs, uint3 rhs) => new uint3((uint)System.Math.Pow((double)lhs, (double)rhs.x), (uint)System.Math.Pow((double)lhs, (double)rhs.y), (uint)System.Math.Pow((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a uint from the application of Pow ((uint)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint3 Pow(uint lhs, uint rhs) => new uint3((uint)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Log ((uint)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint3 Log(uint3 lhs, uint3 rhs) => new uint3((uint)System.Math.Log((double)lhs.x, (double)rhs.x), (uint)System.Math.Log((double)lhs.y, (double)rhs.y), (uint)System.Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Log ((uint)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint3 Log(uint3 lhs, uint rhs) => new uint3((uint)System.Math.Log((double)lhs.x, (double)rhs), (uint)System.Math.Log((double)lhs.y, (double)rhs), (uint)System.Math.Log((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Log ((uint)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint3 Log(uint lhs, uint3 rhs) => new uint3((uint)System.Math.Log((double)lhs, (double)rhs.x), (uint)System.Math.Log((double)lhs, (double)rhs.y), (uint)System.Math.Log((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a uint from the application of Log ((uint)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint3 Log(uint lhs, uint rhs) => new uint3((uint)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint3 Clamp(uint3 v, uint3 min, uint3 max) => new uint3(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y), System.Math.Min(System.Math.Max(v.z, min.z), max.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint3 Clamp(uint3 v, uint3 min, uint max) => new uint3(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max), System.Math.Min(System.Math.Max(v.z, min.z), max));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint3 Clamp(uint3 v, uint min, uint3 max) => new uint3(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y), System.Math.Min(System.Math.Max(v.z, min), max.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint3 Clamp(uint3 v, uint min, uint max) => new uint3(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max), System.Math.Min(System.Math.Max(v.z, min), max));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint3 Clamp(uint v, uint3 min, uint3 max) => new uint3(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y), System.Math.Min(System.Math.Max(v, min.z), max.z));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint3 Clamp(uint v, uint3 min, uint max) => new uint3(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max), System.Math.Min(System.Math.Max(v, min.z), max));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint3 Clamp(uint v, uint min, uint3 max) => new uint3(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y), System.Math.Min(System.Math.Max(v, min), max.z));
        
        /// <summary>
        /// Returns a uint from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static uint3 Clamp(uint v, uint min, uint max) => new uint3(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Mix(uint3 min, uint3 max, uint3 a) => new uint3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Mix(uint3 min, uint3 max, uint a) => new uint3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Mix(uint3 min, uint max, uint3 a) => new uint3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Mix(uint3 min, uint max, uint a) => new uint3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Mix(uint min, uint3 max, uint3 a) => new uint3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Mix(uint min, uint3 max, uint a) => new uint3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Mix(uint min, uint max, uint3 a) => new uint3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a uint from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Mix(uint min, uint max, uint a) => new uint3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Lerp(uint3 min, uint3 max, uint3 a) => new uint3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Lerp(uint3 min, uint3 max, uint a) => new uint3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Lerp(uint3 min, uint max, uint3 a) => new uint3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Lerp(uint3 min, uint max, uint a) => new uint3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Lerp(uint min, uint3 max, uint3 a) => new uint3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Lerp(uint min, uint3 max, uint a) => new uint3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Lerp(uint min, uint max, uint3 a) => new uint3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a uint from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint3 Lerp(uint min, uint max, uint a) => new uint3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint3 Smoothstep(uint3 edge0, uint3 edge1, uint3 v) => new uint3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint3 Smoothstep(uint3 edge0, uint3 edge1, uint v) => new uint3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint3 Smoothstep(uint3 edge0, uint edge1, uint3 v) => new uint3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint3 Smoothstep(uint3 edge0, uint edge1, uint v) => new uint3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint3 Smoothstep(uint edge0, uint3 edge1, uint3 v) => new uint3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint3 Smoothstep(uint edge0, uint3 edge1, uint v) => new uint3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint3 Smoothstep(uint edge0, uint edge1, uint3 v) => new uint3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint3 Smoothstep(uint edge0, uint edge1, uint v) => new uint3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint3 Smootherstep(uint3 edge0, uint3 edge1, uint3 v) => new uint3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint3 Smootherstep(uint3 edge0, uint3 edge1, uint v) => new uint3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint3 Smootherstep(uint3 edge0, uint edge1, uint3 v) => new uint3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint3 Smootherstep(uint3 edge0, uint edge1, uint v) => new uint3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint3 Smootherstep(uint edge0, uint3 edge1, uint3 v) => new uint3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint3 Smootherstep(uint edge0, uint3 edge1, uint v) => new uint3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint3 Smootherstep(uint edge0, uint edge1, uint3 v) => new uint3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint3 Smootherstep(uint edge0, uint edge1, uint v) => new uint3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint3 Fma(uint3 a, uint3 b, uint3 c) => new uint3(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint3 Fma(uint3 a, uint3 b, uint c) => new uint3(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint3 Fma(uint3 a, uint b, uint3 c) => new uint3(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint3 Fma(uint3 a, uint b, uint c) => new uint3(a.x * b + c, a.y * b + c, a.z * b + c);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint3 Fma(uint a, uint3 b, uint3 c) => new uint3(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint3 Fma(uint a, uint3 b, uint c) => new uint3(a * b.x + c, a * b.y + c, a * b.z + c);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint3 Fma(uint a, uint b, uint3 c) => new uint3(a * b + c.x, a * b + c.y, a * b + c.z);
        
        /// <summary>
        /// Returns a uint from the application of Fma (a * b + c).
        /// </summary>
        public static uint3 Fma(uint a, uint b, uint c) => new uint3(a * b + c);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uint3 Add(uint3 lhs, uint3 rhs) => new uint3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uint3 Add(uint3 lhs, uint rhs) => new uint3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uint3 Add(uint lhs, uint3 rhs) => new uint3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of Add (lhs + rhs).
        /// </summary>
        public static uint3 Add(uint lhs, uint rhs) => new uint3(lhs + rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uint3 Sub(uint3 lhs, uint3 rhs) => new uint3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uint3 Sub(uint3 lhs, uint rhs) => new uint3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uint3 Sub(uint lhs, uint3 rhs) => new uint3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of Sub (lhs - rhs).
        /// </summary>
        public static uint3 Sub(uint lhs, uint rhs) => new uint3(lhs - rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uint3 Mul(uint3 lhs, uint3 rhs) => new uint3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uint3 Mul(uint3 lhs, uint rhs) => new uint3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uint3 Mul(uint lhs, uint3 rhs) => new uint3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of Mul (lhs * rhs).
        /// </summary>
        public static uint3 Mul(uint lhs, uint rhs) => new uint3(lhs * rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uint3 Div(uint3 lhs, uint3 rhs) => new uint3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uint3 Div(uint3 lhs, uint rhs) => new uint3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uint3 Div(uint lhs, uint3 rhs) => new uint3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of Div (lhs / rhs).
        /// </summary>
        public static uint3 Div(uint lhs, uint rhs) => new uint3(lhs / rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint3 Xor(uint3 lhs, uint3 rhs) => new uint3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint3 Xor(uint3 lhs, uint rhs) => new uint3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint3 Xor(uint lhs, uint3 rhs) => new uint3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint3 Xor(uint lhs, uint rhs) => new uint3(lhs ^ rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint3 BitwiseOr(uint3 lhs, uint3 rhs) => new uint3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint3 BitwiseOr(uint3 lhs, uint rhs) => new uint3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint3 BitwiseOr(uint lhs, uint3 rhs) => new uint3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint3 BitwiseOr(uint lhs, uint rhs) => new uint3(lhs | rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint3 BitwiseAnd(uint3 lhs, uint3 rhs) => new uint3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint3 BitwiseAnd(uint3 lhs, uint rhs) => new uint3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint3 BitwiseAnd(uint lhs, uint3 rhs) => new uint3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint3 BitwiseAnd(uint lhs, uint rhs) => new uint3(lhs & rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint3 LeftShift(uint3 lhs, int3 rhs) => new uint3(lhs.x << rhs.x, lhs.y << rhs.y, lhs.z << rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint3 LeftShift(uint3 lhs, int rhs) => new uint3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint3 LeftShift(uint lhs, int3 rhs) => new uint3(lhs << rhs.x, lhs << rhs.y, lhs << rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint3 LeftShift(uint lhs, int rhs) => new uint3(lhs << rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint3 RightShift(uint3 lhs, int3 rhs) => new uint3(lhs.x >> rhs.x, lhs.y >> rhs.y, lhs.z >> rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint3 RightShift(uint3 lhs, int rhs) => new uint3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint3 RightShift(uint lhs, int3 rhs) => new uint3(lhs >> rhs.x, lhs >> rhs.y, lhs >> rhs.z);
        
        /// <summary>
        /// Returns a uint from the application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint3 RightShift(uint lhs, int rhs) => new uint3(lhs >> rhs);
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uint3 Random(Random random, uint3 maxValue) => new uint3((uint)random.Next((int)maxValue.x), (uint)random.Next((int)maxValue.y), (uint)random.Next((int)maxValue.z));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uint3 Random(Random random, uint maxValue) => new uint3((uint)random.Next((int)maxValue));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint3 Random(Random random, uint3 minValue, uint3 maxValue) => new uint3((uint)random.Next((int)minValue.x, (int)maxValue.x), (uint)random.Next((int)minValue.y, (int)maxValue.y), (uint)random.Next((int)minValue.z, (int)maxValue.z));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint3 Random(Random random, uint3 minValue, uint maxValue) => new uint3((uint)random.Next((int)minValue.x, (int)maxValue), (uint)random.Next((int)minValue.y, (int)maxValue), (uint)random.Next((int)minValue.z, (int)maxValue));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint3 Random(Random random, uint minValue, uint3 maxValue) => new uint3((uint)random.Next((int)minValue, (int)maxValue.x), (uint)random.Next((int)minValue, (int)maxValue.y), (uint)random.Next((int)minValue, (int)maxValue.z));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint3 Random(Random random, uint minValue, uint maxValue) => new uint3((uint)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint3 RandomUniform(Random random, uint3 minValue, uint3 maxValue) => new uint3((uint)random.Next((int)minValue.x, (int)maxValue.x), (uint)random.Next((int)minValue.y, (int)maxValue.y), (uint)random.Next((int)minValue.z, (int)maxValue.z));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint3 RandomUniform(Random random, uint3 minValue, uint maxValue) => new uint3((uint)random.Next((int)minValue.x, (int)maxValue), (uint)random.Next((int)minValue.y, (int)maxValue), (uint)random.Next((int)minValue.z, (int)maxValue));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint3 RandomUniform(Random random, uint minValue, uint3 maxValue) => new uint3((uint)random.Next((int)minValue, (int)maxValue.x), (uint)random.Next((int)minValue, (int)maxValue.y), (uint)random.Next((int)minValue, (int)maxValue.z));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint3 RandomUniform(Random random, uint minValue, uint maxValue) => new uint3((uint)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static uint3 RandomPoisson(Random random, double3 lambda) => new uint3((uint)lambda.x.GetPoisson(random), (uint)lambda.y.GetPoisson(random), (uint)lambda.z.GetPoisson(random));
        
        /// <summary>
        /// Returns a uint3 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static uint3 RandomPoisson(Random random, double lambda) => new uint3((uint)lambda.GetPoisson(random));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(uint3 lhs, uint3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(uint3 lhs, uint rhs) => new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(uint lhs, uint3 rhs) => new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(uint3 lhs, uint3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(uint3 lhs, uint rhs) => new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(uint lhs, uint3 rhs) => new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(uint3 lhs, uint3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(uint3 lhs, uint rhs) => new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(uint lhs, uint3 rhs) => new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(uint3 lhs, uint3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(uint3 lhs, uint rhs) => new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(uint lhs, uint3 rhs) => new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uint3 operator+(uint3 lhs, uint3 rhs) => new uint3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uint3 operator+(uint3 lhs, uint rhs) => new uint3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uint3 operator+(uint lhs, uint3 rhs) => new uint3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uint3 operator-(uint3 lhs, uint3 rhs) => new uint3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uint3 operator-(uint3 lhs, uint rhs) => new uint3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uint3 operator-(uint lhs, uint3 rhs) => new uint3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uint3 operator*(uint3 lhs, uint3 rhs) => new uint3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uint3 operator*(uint3 lhs, uint rhs) => new uint3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uint3 operator*(uint lhs, uint3 rhs) => new uint3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uint3 operator/(uint3 lhs, uint3 rhs) => new uint3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uint3 operator/(uint3 lhs, uint rhs) => new uint3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uint3 operator/(uint lhs, uint3 rhs) => new uint3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator+ (identity).
        /// </summary>
        public static uint3 operator+(uint3 v) => v;
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator~ (~v).
        /// </summary>
        public static uint3 operator~(uint3 v) => new uint3(~v.x, ~v.y, ~v.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uint3 operator^(uint3 lhs, uint3 rhs) => new uint3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uint3 operator^(uint3 lhs, uint rhs) => new uint3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uint3 operator^(uint lhs, uint3 rhs) => new uint3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uint3 operator|(uint3 lhs, uint3 rhs) => new uint3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uint3 operator|(uint3 lhs, uint rhs) => new uint3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uint3 operator|(uint lhs, uint3 rhs) => new uint3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uint3 operator&(uint3 lhs, uint3 rhs) => new uint3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uint3 operator&(uint3 lhs, uint rhs) => new uint3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uint3 operator&(uint lhs, uint3 rhs) => new uint3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint3 operator<<(uint3 lhs, int rhs) => new uint3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);
        
        /// <summary>
        /// Returns a uint3 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint3 operator>>(uint3 lhs, int rhs) => new uint3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);

        #endregion

    }
}
