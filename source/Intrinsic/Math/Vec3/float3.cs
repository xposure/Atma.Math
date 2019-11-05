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
    /// A vector of type float with 3 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct float3 : IReadOnlyList<float>, IEquatable<float3>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public float z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public float3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public float3(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public float3(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public float3(float2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public float3(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public float3(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float3(IReadOnlyList<float> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
            this.z = c < 2 ? 0f : v[2];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float3(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : (float)v[0];
            this.y = c < 1 ? 0f : (float)v[1];
            this.z = c < 2 ? 0f : (float)v[2];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float3(float[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
            this.z = c < 2 ? 0f : v[2];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float3(float[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0f : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0f : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0f : v[2 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float3(IEnumerable<float> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a double3.
        /// </summary>
        public static implicit operator double3(float3 v) => new double3((double)v.x, (double)v.y, (double)v.z);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(float3 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int3.
        /// </summary>
        public static explicit operator int3(float3 v) => new int3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a int4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int4(float3 v) => new int4((int)v.x, (int)v.y, (int)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(float3 v) => new uint2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uint3.
        /// </summary>
        public static explicit operator uint3(float3 v) => new uint3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uint4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint4(float3 v) => new uint4((uint)v.x, (uint)v.y, (uint)v.z, 0u);
        
        /// <summary>
        /// Explicitly converts this to a float2.
        /// </summary>
        public static explicit operator float2(float3 v) => new float2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a float4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float4(float3 v) => new float4((float)v.x, (float)v.y, (float)v.z, 0f);
        
        /// <summary>
        /// Explicitly converts this to a double2.
        /// </summary>
        public static explicit operator double2(float3 v) => new double2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a double4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double4(float3 v) => new double4((double)v.x, (double)v.y, (double)v.z, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(float3 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a long3.
        /// </summary>
        public static explicit operator long3(float3 v) => new long3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a long4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long4(float3 v) => new long4((long)v.x, (long)v.y, (long)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(float3 v) => new bool2(v.x != 0f, v.y != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bool3.
        /// </summary>
        public static explicit operator bool3(float3 v) => new bool3(v.x != 0f, v.y != 0f, v.z != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bool4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool4(float3 v) => new bool4(v.x != 0f, v.y != 0f, v.z != 0f, false);
        
        /// <summary>
        /// Explicitly converts this to a float array.
        /// </summary>
        public static explicit operator float[](float3 v) => new [] { v.x, v.y, v.z };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](float3 v) => new Object[] { v.x, v.y, v.z };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public float this[int index]
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
        public swizzle_float3 swizzle => new swizzle_float3(x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public float2 xy
        {
            get
            {
                return new float2(x, y);
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
        public float2 xz
        {
            get
            {
                return new float2(x, z);
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
        public float2 yz
        {
            get
            {
                return new float2(y, z);
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
        public float3 xyz
        {
            get
            {
                return new float3(x, y, z);
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
        public float2 rg
        {
            get
            {
                return new float2(x, y);
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
        public float2 rb
        {
            get
            {
                return new float2(x, z);
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
        public float2 gb
        {
            get
            {
                return new float2(y, z);
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
        public float3 rgb
        {
            get
            {
                return new float3(x, y, z);
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
        public float r
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
        public float g
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
        public float b
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
        public float[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public float MinElement => System.Math.Min(System.Math.Min(x, y), z);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public float MaxElement => System.Math.Max(System.Math.Max(x, y), z);
        
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
        public float Sum => ((x + y) + z);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)System.Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => ((System.Math.Abs(x) + System.Math.Abs(y)) + System.Math.Abs(z));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)System.Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => System.Math.Max(System.Math.Max(System.Math.Abs(x), System.Math.Abs(y)), System.Math.Abs(z));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public float3 Normalized => this / (float)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public float3 NormalizedSafe => this == Zero ? Zero : this / (float)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static float3 Zero { get; } = new float3(0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static float3 Ones { get; } = new float3(1f, 1f, 1f);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static float3 UnitX { get; } = new float3(1f, 0f, 0f);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static float3 UnitY { get; } = new float3(0f, 1f, 0f);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static float3 UnitZ { get; } = new float3(0f, 0f, 1f);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static float3 MaxValue { get; } = new float3(float.MaxValue, float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static float3 MinValue { get; } = new float3(float.MinValue, float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static float3 Epsilon { get; } = new float3(float.Epsilon, float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static float3 NaN { get; } = new float3(float.NaN, float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static float3 NegativeInfinity { get; } = new float3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static float3 PositiveInfinity { get; } = new float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(float3 lhs, float3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(float3 lhs, float3 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<float> GetEnumerator()
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
        public bool Equals(float3 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is float3 && Equals((float3) obj);
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
        public double NormP(double p) => System.Math.Pow(((System.Math.Pow((double)System.Math.Abs(x), p) + System.Math.Pow((double)System.Math.Abs(y), p)) + System.Math.Pow((double)System.Math.Abs(z), p)), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static float3 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static float3 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new float3(float.Parse(kvp[0].Trim()), float.Parse(kvp[1].Trim()), float.Parse(kvp[2].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static float3 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new float3(float.Parse(kvp[0].Trim(), provider), float.Parse(kvp[1].Trim(), provider), float.Parse(kvp[2].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static float3 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new float3(float.Parse(kvp[0].Trim(), style), float.Parse(kvp[1].Trim(), style), float.Parse(kvp[2].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static float3 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new float3(float.Parse(kvp[0].Trim(), style, provider), float.Parse(kvp[1].Trim(), style, provider), float.Parse(kvp[2].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out float3 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out float3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            float x = 0f, y = 0f, z = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), out x) && float.TryParse(kvp[1].Trim(), out y)) && float.TryParse(kvp[2].Trim(), out z));
            result = ok ? new float3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out float3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            float x = 0f, y = 0f, z = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), style, provider, out x) && float.TryParse(kvp[1].Trim(), style, provider, out y)) && float.TryParse(kvp[2].Trim(), style, provider, out z));
            result = ok ? new float3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(float3 lhs, float3 rhs, float eps = 0.1f) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float3x2 OuterProduct(float2 c, float3 r) => new float3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float2x3 OuterProduct(float3 c, float2 r) => new float2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float3x3 OuterProduct(float3 c, float3 r) => new float3x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float3x4 OuterProduct(float4 c, float3 r) => new float3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float4x3 OuterProduct(float3 c, float4 r) => new float4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(float3 lhs, float3 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(float3 lhs, float3 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(float3 lhs, float3 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float3 Reflect(float3 I, float3 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float3 Refract(float3 I, float3 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (float)System.Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static float3 FaceForward(float3 N, float3 I, float3 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static float3 Cross(float3 l, float3 r) => new float3(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static float3 Random(Random random) => new float3((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static float3 RandomSigned(Random random) => new float3((float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static float3 RandomNormal(Random random) => new float3((float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(float3 lhs, float3 rhs) => new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(float3 lhs, float rhs) => new bool3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(float lhs, float3 rhs) => new bool3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(float lhs, float rhs) => new bool3(lhs == rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(float3 lhs, float3 rhs) => new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(float3 lhs, float rhs) => new bool3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(float lhs, float3 rhs) => new bool3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(float lhs, float rhs) => new bool3(lhs != rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(float3 lhs, float3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(float3 lhs, float rhs) => new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(float lhs, float3 rhs) => new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(float lhs, float rhs) => new bool3(lhs > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(float3 lhs, float3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(float3 lhs, float rhs) => new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(float lhs, float3 rhs) => new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(float lhs, float rhs) => new bool3(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(float3 lhs, float3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(float3 lhs, float rhs) => new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(float lhs, float3 rhs) => new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(float lhs, float rhs) => new bool3(lhs < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(float3 lhs, float3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(float3 lhs, float rhs) => new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(float lhs, float3 rhs) => new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(float lhs, float rhs) => new bool3(lhs <= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool3 IsInfinity(float3 v) => new bool3(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z));
        
        /// <summary>
        /// Returns a bool from the application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool3 IsInfinity(float v) => new bool3(float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool3 IsFinite(float3 v) => new bool3(!float.IsNaN(v.x) && !float.IsInfinity(v.x), !float.IsNaN(v.y) && !float.IsInfinity(v.y), !float.IsNaN(v.z) && !float.IsInfinity(v.z));
        
        /// <summary>
        /// Returns a bool from the application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool3 IsFinite(float v) => new bool3(!float.IsNaN(v) && !float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool3 IsNaN(float3 v) => new bool3(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z));
        
        /// <summary>
        /// Returns a bool from the application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool3 IsNaN(float v) => new bool3(float.IsNaN(v));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool3 IsNegativeInfinity(float3 v) => new bool3(float.IsNegativeInfinity(v.x), float.IsNegativeInfinity(v.y), float.IsNegativeInfinity(v.z));
        
        /// <summary>
        /// Returns a bool from the application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool3 IsNegativeInfinity(float v) => new bool3(float.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bool3 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool3 IsPositiveInfinity(float3 v) => new bool3(float.IsPositiveInfinity(v.x), float.IsPositiveInfinity(v.y), float.IsPositiveInfinity(v.z));
        
        /// <summary>
        /// Returns a bool from the application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool3 IsPositiveInfinity(float v) => new bool3(float.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static float3 Abs(float3 v) => new float3(System.Math.Abs(v.x), System.Math.Abs(v.y), System.Math.Abs(v.z));
        
        /// <summary>
        /// Returns a float from the application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static float3 Abs(float v) => new float3(System.Math.Abs(v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static float3 HermiteInterpolationOrder3(float3 v) => new float3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a float from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static float3 HermiteInterpolationOrder3(float v) => new float3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a float3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static float3 HermiteInterpolationOrder5(float3 v) => new float3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a float from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static float3 HermiteInterpolationOrder5(float v) => new float3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static float3 Sqr(float3 v) => new float3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a float from the application of Sqr (v * v).
        /// </summary>
        public static float3 Sqr(float v) => new float3(v * v);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static float3 Pow2(float3 v) => new float3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a float from the application of Pow2 (v * v).
        /// </summary>
        public static float3 Pow2(float v) => new float3(v * v);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static float3 Pow3(float3 v) => new float3(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a float from the application of Pow3 (v * v * v).
        /// </summary>
        public static float3 Pow3(float v) => new float3(v * v * v);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static float3 Step(float3 v) => new float3(v.x >= 0f ? 1f : 0f, v.y >= 0f ? 1f : 0f, v.z >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a float from the application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static float3 Step(float v) => new float3(v >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sqrt ((float)System.Math.Sqrt((double)v)).
        /// </summary>
        public static float3 Sqrt(float3 v) => new float3((float)System.Math.Sqrt((double)v.x), (float)System.Math.Sqrt((double)v.y), (float)System.Math.Sqrt((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Sqrt ((float)System.Math.Sqrt((double)v)).
        /// </summary>
        public static float3 Sqrt(float v) => new float3((float)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of InverseSqrt ((float)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static float3 InverseSqrt(float3 v) => new float3((float)(1.0 / System.Math.Sqrt((double)v.x)), (float)(1.0 / System.Math.Sqrt((double)v.y)), (float)(1.0 / System.Math.Sqrt((double)v.z)));
        
        /// <summary>
        /// Returns a float from the application of InverseSqrt ((float)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static float3 InverseSqrt(float v) => new float3((float)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int3 Sign(float3 v) => new int3(System.Math.Sign(v.x), System.Math.Sign(v.y), System.Math.Sign(v.z));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int3 Sign(float v) => new int3(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float3 Max(float3 lhs, float3 rhs) => new float3(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y), System.Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float3 Max(float3 lhs, float rhs) => new float3(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs), System.Math.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float3 Max(float lhs, float3 rhs) => new float3(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y), System.Math.Max(lhs, rhs.z));
        
        /// <summary>
        /// Returns a float from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float3 Max(float lhs, float rhs) => new float3(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float3 Min(float3 lhs, float3 rhs) => new float3(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y), System.Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float3 Min(float3 lhs, float rhs) => new float3(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs), System.Math.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float3 Min(float lhs, float3 rhs) => new float3(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y), System.Math.Min(lhs, rhs.z));
        
        /// <summary>
        /// Returns a float from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float3 Min(float lhs, float rhs) => new float3(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float3 Pow(float3 lhs, float3 rhs) => new float3((float)System.Math.Pow((double)lhs.x, (double)rhs.x), (float)System.Math.Pow((double)lhs.y, (double)rhs.y), (float)System.Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float3 Pow(float3 lhs, float rhs) => new float3((float)System.Math.Pow((double)lhs.x, (double)rhs), (float)System.Math.Pow((double)lhs.y, (double)rhs), (float)System.Math.Pow((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float3 Pow(float lhs, float3 rhs) => new float3((float)System.Math.Pow((double)lhs, (double)rhs.x), (float)System.Math.Pow((double)lhs, (double)rhs.y), (float)System.Math.Pow((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a float from the application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float3 Pow(float lhs, float rhs) => new float3((float)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float3 Log(float3 lhs, float3 rhs) => new float3((float)System.Math.Log((double)lhs.x, (double)rhs.x), (float)System.Math.Log((double)lhs.y, (double)rhs.y), (float)System.Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float3 Log(float3 lhs, float rhs) => new float3((float)System.Math.Log((double)lhs.x, (double)rhs), (float)System.Math.Log((double)lhs.y, (double)rhs), (float)System.Math.Log((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float3 Log(float lhs, float3 rhs) => new float3((float)System.Math.Log((double)lhs, (double)rhs.x), (float)System.Math.Log((double)lhs, (double)rhs.y), (float)System.Math.Log((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a float from the application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float3 Log(float lhs, float rhs) => new float3((float)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float3 Clamp(float3 v, float3 min, float3 max) => new float3(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y), System.Math.Min(System.Math.Max(v.z, min.z), max.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float3 Clamp(float3 v, float3 min, float max) => new float3(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max), System.Math.Min(System.Math.Max(v.z, min.z), max));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float3 Clamp(float3 v, float min, float3 max) => new float3(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y), System.Math.Min(System.Math.Max(v.z, min), max.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float3 Clamp(float3 v, float min, float max) => new float3(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max), System.Math.Min(System.Math.Max(v.z, min), max));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float3 Clamp(float v, float3 min, float3 max) => new float3(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y), System.Math.Min(System.Math.Max(v, min.z), max.z));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float3 Clamp(float v, float3 min, float max) => new float3(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max), System.Math.Min(System.Math.Max(v, min.z), max));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float3 Clamp(float v, float min, float3 max) => new float3(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y), System.Math.Min(System.Math.Max(v, min), max.z));
        
        /// <summary>
        /// Returns a float from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float3 Clamp(float v, float min, float max) => new float3(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float3 Mix(float3 min, float3 max, float3 a) => new float3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float3 Mix(float3 min, float3 max, float a) => new float3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float3 Mix(float3 min, float max, float3 a) => new float3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float3 Mix(float3 min, float max, float a) => new float3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float3 Mix(float min, float3 max, float3 a) => new float3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float3 Mix(float min, float3 max, float a) => new float3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float3 Mix(float min, float max, float3 a) => new float3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a float from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float3 Mix(float min, float max, float a) => new float3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float3 Lerp(float3 min, float3 max, float3 a) => new float3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float3 Lerp(float3 min, float3 max, float a) => new float3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float3 Lerp(float3 min, float max, float3 a) => new float3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float3 Lerp(float3 min, float max, float a) => new float3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float3 Lerp(float min, float3 max, float3 a) => new float3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float3 Lerp(float min, float3 max, float a) => new float3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float3 Lerp(float min, float max, float3 a) => new float3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a float from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float3 Lerp(float min, float max, float a) => new float3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float3 Smoothstep(float3 edge0, float3 edge1, float3 v) => new float3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float3 Smoothstep(float3 edge0, float3 edge1, float v) => new float3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float3 Smoothstep(float3 edge0, float edge1, float3 v) => new float3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float3 Smoothstep(float3 edge0, float edge1, float v) => new float3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float3 Smoothstep(float edge0, float3 edge1, float3 v) => new float3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float3 Smoothstep(float edge0, float3 edge1, float v) => new float3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float3 Smoothstep(float edge0, float edge1, float3 v) => new float3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float3 Smoothstep(float edge0, float edge1, float v) => new float3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float3 Smootherstep(float3 edge0, float3 edge1, float3 v) => new float3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float3 Smootherstep(float3 edge0, float3 edge1, float v) => new float3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float3 Smootherstep(float3 edge0, float edge1, float3 v) => new float3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float3 Smootherstep(float3 edge0, float edge1, float v) => new float3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float3 Smootherstep(float edge0, float3 edge1, float3 v) => new float3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float3 Smootherstep(float edge0, float3 edge1, float v) => new float3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float3 Smootherstep(float edge0, float edge1, float3 v) => new float3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float3 Smootherstep(float edge0, float edge1, float v) => new float3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float3 Fma(float3 a, float3 b, float3 c) => new float3(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float3 Fma(float3 a, float3 b, float c) => new float3(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float3 Fma(float3 a, float b, float3 c) => new float3(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float3 Fma(float3 a, float b, float c) => new float3(a.x * b + c, a.y * b + c, a.z * b + c);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float3 Fma(float a, float3 b, float3 c) => new float3(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float3 Fma(float a, float3 b, float c) => new float3(a * b.x + c, a * b.y + c, a * b.z + c);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float3 Fma(float a, float b, float3 c) => new float3(a * b + c.x, a * b + c.y, a * b + c.z);
        
        /// <summary>
        /// Returns a float from the application of Fma (a * b + c).
        /// </summary>
        public static float3 Fma(float a, float b, float c) => new float3(a * b + c);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float3 Add(float3 lhs, float3 rhs) => new float3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float3 Add(float3 lhs, float rhs) => new float3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float3 Add(float lhs, float3 rhs) => new float3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a float from the application of Add (lhs + rhs).
        /// </summary>
        public static float3 Add(float lhs, float rhs) => new float3(lhs + rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float3 Sub(float3 lhs, float3 rhs) => new float3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float3 Sub(float3 lhs, float rhs) => new float3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float3 Sub(float lhs, float3 rhs) => new float3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a float from the application of Sub (lhs - rhs).
        /// </summary>
        public static float3 Sub(float lhs, float rhs) => new float3(lhs - rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float3 Mul(float3 lhs, float3 rhs) => new float3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float3 Mul(float3 lhs, float rhs) => new float3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float3 Mul(float lhs, float3 rhs) => new float3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a float from the application of Mul (lhs * rhs).
        /// </summary>
        public static float3 Mul(float lhs, float rhs) => new float3(lhs * rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float3 Div(float3 lhs, float3 rhs) => new float3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float3 Div(float3 lhs, float rhs) => new float3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float3 Div(float lhs, float3 rhs) => new float3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a float from the application of Div (lhs / rhs).
        /// </summary>
        public static float3 Div(float lhs, float rhs) => new float3(lhs / rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float3 Modulo(float3 lhs, float3 rhs) => new float3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float3 Modulo(float3 lhs, float rhs) => new float3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float3 Modulo(float lhs, float3 rhs) => new float3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);
        
        /// <summary>
        /// Returns a float from the application of Modulo (lhs % rhs).
        /// </summary>
        public static float3 Modulo(float lhs, float rhs) => new float3(lhs % rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static float3 Degrees(float3 v) => new float3((float)(v.x * 57.295779513082320876798154814105170332405472466564321f), (float)(v.y * 57.295779513082320876798154814105170332405472466564321f), (float)(v.z * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a float from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static float3 Degrees(float v) => new float3((float)(v * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static float3 Radians(float3 v) => new float3((float)(v.x * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.y * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.z * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a float from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static float3 Radians(float v) => new float3((float)(v * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Acos ((float)System.Math.Acos((double)v)).
        /// </summary>
        public static float3 Acos(float3 v) => new float3((float)System.Math.Acos((double)v.x), (float)System.Math.Acos((double)v.y), (float)System.Math.Acos((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Acos ((float)System.Math.Acos((double)v)).
        /// </summary>
        public static float3 Acos(float v) => new float3((float)System.Math.Acos((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Asin ((float)System.Math.Asin((double)v)).
        /// </summary>
        public static float3 Asin(float3 v) => new float3((float)System.Math.Asin((double)v.x), (float)System.Math.Asin((double)v.y), (float)System.Math.Asin((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Asin ((float)System.Math.Asin((double)v)).
        /// </summary>
        public static float3 Asin(float v) => new float3((float)System.Math.Asin((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Atan ((float)System.Math.Atan((double)v)).
        /// </summary>
        public static float3 Atan(float3 v) => new float3((float)System.Math.Atan((double)v.x), (float)System.Math.Atan((double)v.y), (float)System.Math.Atan((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Atan ((float)System.Math.Atan((double)v)).
        /// </summary>
        public static float3 Atan(float v) => new float3((float)System.Math.Atan((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Cos ((float)System.Math.Cos((double)v)).
        /// </summary>
        public static float3 Cos(float3 v) => new float3((float)System.Math.Cos((double)v.x), (float)System.Math.Cos((double)v.y), (float)System.Math.Cos((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Cos ((float)System.Math.Cos((double)v)).
        /// </summary>
        public static float3 Cos(float v) => new float3((float)System.Math.Cos((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Cosh ((float)System.Math.Cosh((double)v)).
        /// </summary>
        public static float3 Cosh(float3 v) => new float3((float)System.Math.Cosh((double)v.x), (float)System.Math.Cosh((double)v.y), (float)System.Math.Cosh((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Cosh ((float)System.Math.Cosh((double)v)).
        /// </summary>
        public static float3 Cosh(float v) => new float3((float)System.Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Exp ((float)System.Math.Exp((double)v)).
        /// </summary>
        public static float3 Exp(float3 v) => new float3((float)System.Math.Exp((double)v.x), (float)System.Math.Exp((double)v.y), (float)System.Math.Exp((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Exp ((float)System.Math.Exp((double)v)).
        /// </summary>
        public static float3 Exp(float v) => new float3((float)System.Math.Exp((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log ((float)System.Math.Log((double)v)).
        /// </summary>
        public static float3 Log(float3 v) => new float3((float)System.Math.Log((double)v.x), (float)System.Math.Log((double)v.y), (float)System.Math.Log((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Log ((float)System.Math.Log((double)v)).
        /// </summary>
        public static float3 Log(float v) => new float3((float)System.Math.Log((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log2 ((float)System.Math.Log((double)v, 2)).
        /// </summary>
        public static float3 Log2(float3 v) => new float3((float)System.Math.Log((double)v.x, 2), (float)System.Math.Log((double)v.y, 2), (float)System.Math.Log((double)v.z, 2));
        
        /// <summary>
        /// Returns a float from the application of Log2 ((float)System.Math.Log((double)v, 2)).
        /// </summary>
        public static float3 Log2(float v) => new float3((float)System.Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Log10 ((float)System.Math.Log10((double)v)).
        /// </summary>
        public static float3 Log10(float3 v) => new float3((float)System.Math.Log10((double)v.x), (float)System.Math.Log10((double)v.y), (float)System.Math.Log10((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Log10 ((float)System.Math.Log10((double)v)).
        /// </summary>
        public static float3 Log10(float v) => new float3((float)System.Math.Log10((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Floor ((float)System.Math.Floor(v)).
        /// </summary>
        public static float3 Floor(float3 v) => new float3((float)System.Math.Floor(v.x), (float)System.Math.Floor(v.y), (float)System.Math.Floor(v.z));
        
        /// <summary>
        /// Returns a float from the application of Floor ((float)System.Math.Floor(v)).
        /// </summary>
        public static float3 Floor(float v) => new float3((float)System.Math.Floor(v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Ceiling ((float)System.Math.Ceiling(v)).
        /// </summary>
        public static float3 Ceiling(float3 v) => new float3((float)System.Math.Ceiling(v.x), (float)System.Math.Ceiling(v.y), (float)System.Math.Ceiling(v.z));
        
        /// <summary>
        /// Returns a float from the application of Ceiling ((float)System.Math.Ceiling(v)).
        /// </summary>
        public static float3 Ceiling(float v) => new float3((float)System.Math.Ceiling(v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Round ((float)System.Math.Round(v)).
        /// </summary>
        public static float3 Round(float3 v) => new float3((float)System.Math.Round(v.x), (float)System.Math.Round(v.y), (float)System.Math.Round(v.z));
        
        /// <summary>
        /// Returns a float from the application of Round ((float)System.Math.Round(v)).
        /// </summary>
        public static float3 Round(float v) => new float3((float)System.Math.Round(v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sin ((float)System.Math.Sin((double)v)).
        /// </summary>
        public static float3 Sin(float3 v) => new float3((float)System.Math.Sin((double)v.x), (float)System.Math.Sin((double)v.y), (float)System.Math.Sin((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Sin ((float)System.Math.Sin((double)v)).
        /// </summary>
        public static float3 Sin(float v) => new float3((float)System.Math.Sin((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Sinh ((float)System.Math.Sinh((double)v)).
        /// </summary>
        public static float3 Sinh(float3 v) => new float3((float)System.Math.Sinh((double)v.x), (float)System.Math.Sinh((double)v.y), (float)System.Math.Sinh((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Sinh ((float)System.Math.Sinh((double)v)).
        /// </summary>
        public static float3 Sinh(float v) => new float3((float)System.Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Tan ((float)System.Math.Tan((double)v)).
        /// </summary>
        public static float3 Tan(float3 v) => new float3((float)System.Math.Tan((double)v.x), (float)System.Math.Tan((double)v.y), (float)System.Math.Tan((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Tan ((float)System.Math.Tan((double)v)).
        /// </summary>
        public static float3 Tan(float v) => new float3((float)System.Math.Tan((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Tanh ((float)System.Math.Tanh((double)v)).
        /// </summary>
        public static float3 Tanh(float3 v) => new float3((float)System.Math.Tanh((double)v.x), (float)System.Math.Tanh((double)v.y), (float)System.Math.Tanh((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Tanh ((float)System.Math.Tanh((double)v)).
        /// </summary>
        public static float3 Tanh(float v) => new float3((float)System.Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Truncate ((float)System.Math.Truncate((double)v)).
        /// </summary>
        public static float3 Truncate(float3 v) => new float3((float)System.Math.Truncate((double)v.x), (float)System.Math.Truncate((double)v.y), (float)System.Math.Truncate((double)v.z));
        
        /// <summary>
        /// Returns a float from the application of Truncate ((float)System.Math.Truncate((double)v)).
        /// </summary>
        public static float3 Truncate(float v) => new float3((float)System.Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Fract ((float)(v - System.Math.Floor(v))).
        /// </summary>
        public static float3 Fract(float3 v) => new float3((float)(v.x - System.Math.Floor(v.x)), (float)(v.y - System.Math.Floor(v.y)), (float)(v.z - System.Math.Floor(v.z)));
        
        /// <summary>
        /// Returns a float from the application of Fract ((float)(v - System.Math.Floor(v))).
        /// </summary>
        public static float3 Fract(float v) => new float3((float)(v - System.Math.Floor(v)));
        
        /// <summary>
        /// Returns a float3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static float3 Trunc(float3 v) => new float3((long)(v.x), (long)(v.y), (long)(v.z));
        
        /// <summary>
        /// Returns a float from the application of Trunc ((long)(v)).
        /// </summary>
        public static float3 Trunc(float v) => new float3((long)(v));
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float3 Random(Random random, float3 minValue, float3 maxValue) => new float3((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float3 Random(Random random, float3 minValue, float maxValue) => new float3((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float3 Random(Random random, float minValue, float3 maxValue) => new float3((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue, (float)random.NextDouble() * (maxValue.z - minValue) + minValue);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float3 Random(Random random, float minValue, float maxValue) => new float3((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float3 RandomUniform(Random random, float3 minValue, float3 maxValue) => new float3((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float3 RandomUniform(Random random, float3 minValue, float maxValue) => new float3((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float3 RandomUniform(Random random, float minValue, float3 maxValue) => new float3((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue, (float)random.NextDouble() * (maxValue.z - minValue) + minValue);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float3 RandomUniform(Random random, float minValue, float maxValue) => new float3((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float3 RandomNormal(Random random, float3 mean, float3 variance) => new float3((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (float)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float3 RandomNormal(Random random, float3 mean, float variance) => new float3((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float3 RandomNormal(Random random, float mean, float3 variance) => new float3((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float3 RandomNormal(Random random, float mean, float variance) => new float3((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float3 RandomGaussian(Random random, float3 mean, float3 variance) => new float3((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (float)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float3 RandomGaussian(Random random, float3 mean, float variance) => new float3((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float3 RandomGaussian(Random random, float mean, float3 variance) => new float3((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float3 RandomGaussian(Random random, float mean, float variance) => new float3((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(float3 lhs, float3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(float3 lhs, float rhs) => new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(float lhs, float3 rhs) => new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(float3 lhs, float3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(float3 lhs, float rhs) => new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(float lhs, float3 rhs) => new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(float3 lhs, float3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(float3 lhs, float rhs) => new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(float lhs, float3 rhs) => new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(float3 lhs, float3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(float3 lhs, float rhs) => new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(float lhs, float3 rhs) => new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float3 operator+(float3 lhs, float3 rhs) => new float3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float3 operator+(float3 lhs, float rhs) => new float3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float3 operator+(float lhs, float3 rhs) => new float3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float3 operator-(float3 lhs, float3 rhs) => new float3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float3 operator-(float3 lhs, float rhs) => new float3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float3 operator-(float lhs, float3 rhs) => new float3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float3 operator*(float3 lhs, float3 rhs) => new float3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float3 operator*(float3 lhs, float rhs) => new float3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float3 operator*(float lhs, float3 rhs) => new float3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float3 operator/(float3 lhs, float3 rhs) => new float3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float3 operator/(float3 lhs, float rhs) => new float3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float3 operator/(float lhs, float3 rhs) => new float3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator+ (identity).
        /// </summary>
        public static float3 operator+(float3 v) => v;
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator- (-v).
        /// </summary>
        public static float3 operator-(float3 v) => new float3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float3 operator%(float3 lhs, float3 rhs) => new float3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float3 operator%(float3 lhs, float rhs) => new float3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);
        
        /// <summary>
        /// Returns a float3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float3 operator%(float lhs, float3 rhs) => new float3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);

        #endregion

    }
}
