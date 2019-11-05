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
    /// A vector of type int with 3 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct int3 : IReadOnlyList<int>, IEquatable<int3>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public int x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public int y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public int z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public int3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public int3(int v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public int3(int2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public int3(int2 v, int z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public int3(int3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public int3(int4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public int3(IReadOnlyList<int> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0 : v[0];
            this.y = c < 1 ? 0 : v[1];
            this.z = c < 2 ? 0 : v[2];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public int3(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0 : (int)v[0];
            this.y = c < 1 ? 0 : (int)v[1];
            this.z = c < 2 ? 0 : (int)v[2];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public int3(int[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0 : v[0];
            this.y = c < 1 ? 0 : v[1];
            this.z = c < 2 ? 0 : v[2];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public int3(int[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0 : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0 : v[2 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public int3(IEnumerable<int> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a long3.
        /// </summary>
        public static implicit operator long3(int3 v) => new long3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Implicitly converts this to a float3.
        /// </summary>
        public static implicit operator float3(int3 v) => new float3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Implicitly converts this to a double3.
        /// </summary>
        public static implicit operator double3(int3 v) => new double3((double)v.x, (double)v.y, (double)v.z);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(int3 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int4(int3 v) => new int4((int)v.x, (int)v.y, (int)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(int3 v) => new uint2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uint3.
        /// </summary>
        public static explicit operator uint3(int3 v) => new uint3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uint4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint4(int3 v) => new uint4((uint)v.x, (uint)v.y, (uint)v.z, 0u);
        
        /// <summary>
        /// Explicitly converts this to a float2.
        /// </summary>
        public static explicit operator float2(int3 v) => new float2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a float4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float4(int3 v) => new float4((float)v.x, (float)v.y, (float)v.z, 0f);
        
        /// <summary>
        /// Explicitly converts this to a double2.
        /// </summary>
        public static explicit operator double2(int3 v) => new double2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a double4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double4(int3 v) => new double4((double)v.x, (double)v.y, (double)v.z, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(int3 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a long4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long4(int3 v) => new long4((long)v.x, (long)v.y, (long)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(int3 v) => new bool2(v.x != 0, v.y != 0);
        
        /// <summary>
        /// Explicitly converts this to a bool3.
        /// </summary>
        public static explicit operator bool3(int3 v) => new bool3(v.x != 0, v.y != 0, v.z != 0);
        
        /// <summary>
        /// Explicitly converts this to a bool4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool4(int3 v) => new bool4(v.x != 0, v.y != 0, v.z != 0, false);
        
        /// <summary>
        /// Explicitly converts this to a int array.
        /// </summary>
        public static explicit operator int[](int3 v) => new [] { v.x, v.y, v.z };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](int3 v) => new Object[] { v.x, v.y, v.z };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public int this[int index]
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
        public swizzle_int3 swizzle => new swizzle_int3(x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public int2 xy
        {
            get
            {
                return new int2(x, y);
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
        public int2 xz
        {
            get
            {
                return new int2(x, z);
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
        public int2 yz
        {
            get
            {
                return new int2(y, z);
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
        public int3 xyz
        {
            get
            {
                return new int3(x, y, z);
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
        public int2 rg
        {
            get
            {
                return new int2(x, y);
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
        public int2 rb
        {
            get
            {
                return new int2(x, z);
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
        public int2 gb
        {
            get
            {
                return new int2(y, z);
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
        public int3 rgb
        {
            get
            {
                return new int3(x, y, z);
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
        public int r
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
        public int g
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
        public int b
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
        public int[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public int MinElement => System.Math.Min(System.Math.Min(x, y), z);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public int MaxElement => System.Math.Max(System.Math.Max(x, y), z);
        
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
        public int Sum => ((x + y) + z);
        
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

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static int3 Zero { get; } = new int3(0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static int3 Ones { get; } = new int3(1, 1, 1);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static int3 UnitX { get; } = new int3(1, 0, 0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static int3 UnitY { get; } = new int3(0, 1, 0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static int3 UnitZ { get; } = new int3(0, 0, 1);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static int3 MaxValue { get; } = new int3(int.MaxValue, int.MaxValue, int.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static int3 MinValue { get; } = new int3(int.MinValue, int.MinValue, int.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(int3 lhs, int3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(int3 lhs, int3 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<int> GetEnumerator()
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
        public bool Equals(int3 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is int3 && Equals((int3) obj);
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
        public static int3 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static int3 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new int3(int.Parse(kvp[0].Trim()), int.Parse(kvp[1].Trim()), int.Parse(kvp[2].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static int3 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new int3(int.Parse(kvp[0].Trim(), provider), int.Parse(kvp[1].Trim(), provider), int.Parse(kvp[2].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static int3 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new int3(int.Parse(kvp[0].Trim(), style), int.Parse(kvp[1].Trim(), style), int.Parse(kvp[2].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static int3 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new int3(int.Parse(kvp[0].Trim(), style, provider), int.Parse(kvp[1].Trim(), style, provider), int.Parse(kvp[2].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out int3 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out int3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            int x = 0, y = 0, z = 0;
            var ok = ((int.TryParse(kvp[0].Trim(), out x) && int.TryParse(kvp[1].Trim(), out y)) && int.TryParse(kvp[2].Trim(), out z));
            result = ok ? new int3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out int3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            int x = 0, y = 0, z = 0;
            var ok = ((int.TryParse(kvp[0].Trim(), style, provider, out x) && int.TryParse(kvp[1].Trim(), style, provider, out y)) && int.TryParse(kvp[2].Trim(), style, provider, out z));
            result = ok ? new int3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static int3x2 OuterProduct(int2 c, int3 r) => new int3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static int2x3 OuterProduct(int3 c, int2 r) => new int2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static int3x3 OuterProduct(int3 c, int3 r) => new int3x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static int3x4 OuterProduct(int4 c, int3 r) => new int3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static int4x3 OuterProduct(int3 c, int4 r) => new int4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static int Dot(int3 lhs, int3 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(int3 lhs, int3 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(int3 lhs, int3 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static int3 Reflect(int3 I, int3 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static int3 Refract(int3 I, int3 N, int eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (int)System.Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static int3 FaceForward(int3 N, int3 I, int3 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static int3 Cross(int3 l, int3 r) => new int3(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive).
        /// </summary>
        public static int3 Random(Random random) => new int3((int)random.Next(), (int)random.Next(), (int)random.Next());

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(int3 lhs, int3 rhs) => new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(int3 lhs, int rhs) => new bool3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(int lhs, int3 rhs) => new bool3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(int lhs, int rhs) => new bool3(lhs == rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(int3 lhs, int3 rhs) => new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(int3 lhs, int rhs) => new bool3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(int lhs, int3 rhs) => new bool3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(int lhs, int rhs) => new bool3(lhs != rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(int3 lhs, int3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(int3 lhs, int rhs) => new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(int lhs, int3 rhs) => new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(int lhs, int rhs) => new bool3(lhs > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(int3 lhs, int3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(int3 lhs, int rhs) => new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(int lhs, int3 rhs) => new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(int lhs, int rhs) => new bool3(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(int3 lhs, int3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(int3 lhs, int rhs) => new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(int lhs, int3 rhs) => new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(int lhs, int rhs) => new bool3(lhs < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(int3 lhs, int3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(int3 lhs, int rhs) => new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(int lhs, int3 rhs) => new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(int lhs, int rhs) => new bool3(lhs <= rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static int3 Abs(int3 v) => new int3(System.Math.Abs(v.x), System.Math.Abs(v.y), System.Math.Abs(v.z));
        
        /// <summary>
        /// Returns a int from the application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static int3 Abs(int v) => new int3(System.Math.Abs(v));
        
        /// <summary>
        /// Returns a int3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static int3 HermiteInterpolationOrder3(int3 v) => new int3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a int from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static int3 HermiteInterpolationOrder3(int v) => new int3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a int3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static int3 HermiteInterpolationOrder5(int3 v) => new int3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a int from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static int3 HermiteInterpolationOrder5(int v) => new int3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static int3 Sqr(int3 v) => new int3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a int from the application of Sqr (v * v).
        /// </summary>
        public static int3 Sqr(int v) => new int3(v * v);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static int3 Pow2(int3 v) => new int3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a int from the application of Pow2 (v * v).
        /// </summary>
        public static int3 Pow2(int v) => new int3(v * v);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static int3 Pow3(int3 v) => new int3(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a int from the application of Pow3 (v * v * v).
        /// </summary>
        public static int3 Pow3(int v) => new int3(v * v * v);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static int3 Step(int3 v) => new int3(v.x >= 0 ? 1 : 0, v.y >= 0 ? 1 : 0, v.z >= 0 ? 1 : 0);
        
        /// <summary>
        /// Returns a int from the application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static int3 Step(int v) => new int3(v >= 0 ? 1 : 0);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sqrt ((int)System.Math.Sqrt((double)v)).
        /// </summary>
        public static int3 Sqrt(int3 v) => new int3((int)System.Math.Sqrt((double)v.x), (int)System.Math.Sqrt((double)v.y), (int)System.Math.Sqrt((double)v.z));
        
        /// <summary>
        /// Returns a int from the application of Sqrt ((int)System.Math.Sqrt((double)v)).
        /// </summary>
        public static int3 Sqrt(int v) => new int3((int)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a int3 from component-wise application of InverseSqrt ((int)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static int3 InverseSqrt(int3 v) => new int3((int)(1.0 / System.Math.Sqrt((double)v.x)), (int)(1.0 / System.Math.Sqrt((double)v.y)), (int)(1.0 / System.Math.Sqrt((double)v.z)));
        
        /// <summary>
        /// Returns a int from the application of InverseSqrt ((int)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static int3 InverseSqrt(int v) => new int3((int)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int3 Sign(int3 v) => new int3(System.Math.Sign(v.x), System.Math.Sign(v.y), System.Math.Sign(v.z));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int3 Sign(int v) => new int3(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static int3 Max(int3 lhs, int3 rhs) => new int3(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y), System.Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static int3 Max(int3 lhs, int rhs) => new int3(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs), System.Math.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static int3 Max(int lhs, int3 rhs) => new int3(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y), System.Math.Max(lhs, rhs.z));
        
        /// <summary>
        /// Returns a int from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static int3 Max(int lhs, int rhs) => new int3(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static int3 Min(int3 lhs, int3 rhs) => new int3(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y), System.Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static int3 Min(int3 lhs, int rhs) => new int3(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs), System.Math.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static int3 Min(int lhs, int3 rhs) => new int3(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y), System.Math.Min(lhs, rhs.z));
        
        /// <summary>
        /// Returns a int from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static int3 Min(int lhs, int rhs) => new int3(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Pow ((int)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static int3 Pow(int3 lhs, int3 rhs) => new int3((int)System.Math.Pow((double)lhs.x, (double)rhs.x), (int)System.Math.Pow((double)lhs.y, (double)rhs.y), (int)System.Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Pow ((int)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static int3 Pow(int3 lhs, int rhs) => new int3((int)System.Math.Pow((double)lhs.x, (double)rhs), (int)System.Math.Pow((double)lhs.y, (double)rhs), (int)System.Math.Pow((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Pow ((int)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static int3 Pow(int lhs, int3 rhs) => new int3((int)System.Math.Pow((double)lhs, (double)rhs.x), (int)System.Math.Pow((double)lhs, (double)rhs.y), (int)System.Math.Pow((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a int from the application of Pow ((int)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static int3 Pow(int lhs, int rhs) => new int3((int)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Log ((int)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static int3 Log(int3 lhs, int3 rhs) => new int3((int)System.Math.Log((double)lhs.x, (double)rhs.x), (int)System.Math.Log((double)lhs.y, (double)rhs.y), (int)System.Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Log ((int)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static int3 Log(int3 lhs, int rhs) => new int3((int)System.Math.Log((double)lhs.x, (double)rhs), (int)System.Math.Log((double)lhs.y, (double)rhs), (int)System.Math.Log((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Log ((int)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static int3 Log(int lhs, int3 rhs) => new int3((int)System.Math.Log((double)lhs, (double)rhs.x), (int)System.Math.Log((double)lhs, (double)rhs.y), (int)System.Math.Log((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a int from the application of Log ((int)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static int3 Log(int lhs, int rhs) => new int3((int)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int3 Clamp(int3 v, int3 min, int3 max) => new int3(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y), System.Math.Min(System.Math.Max(v.z, min.z), max.z));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int3 Clamp(int3 v, int3 min, int max) => new int3(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max), System.Math.Min(System.Math.Max(v.z, min.z), max));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int3 Clamp(int3 v, int min, int3 max) => new int3(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y), System.Math.Min(System.Math.Max(v.z, min), max.z));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int3 Clamp(int3 v, int min, int max) => new int3(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max), System.Math.Min(System.Math.Max(v.z, min), max));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int3 Clamp(int v, int3 min, int3 max) => new int3(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y), System.Math.Min(System.Math.Max(v, min.z), max.z));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int3 Clamp(int v, int3 min, int max) => new int3(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max), System.Math.Min(System.Math.Max(v, min.z), max));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int3 Clamp(int v, int min, int3 max) => new int3(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y), System.Math.Min(System.Math.Max(v, min), max.z));
        
        /// <summary>
        /// Returns a int from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int3 Clamp(int v, int min, int max) => new int3(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int3 Mix(int3 min, int3 max, int3 a) => new int3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int3 Mix(int3 min, int3 max, int a) => new int3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int3 Mix(int3 min, int max, int3 a) => new int3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int3 Mix(int3 min, int max, int a) => new int3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int3 Mix(int min, int3 max, int3 a) => new int3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int3 Mix(int min, int3 max, int a) => new int3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int3 Mix(int min, int max, int3 a) => new int3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a int from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int3 Mix(int min, int max, int a) => new int3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int3 Lerp(int3 min, int3 max, int3 a) => new int3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int3 Lerp(int3 min, int3 max, int a) => new int3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int3 Lerp(int3 min, int max, int3 a) => new int3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int3 Lerp(int3 min, int max, int a) => new int3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int3 Lerp(int min, int3 max, int3 a) => new int3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int3 Lerp(int min, int3 max, int a) => new int3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int3 Lerp(int min, int max, int3 a) => new int3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a int from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int3 Lerp(int min, int max, int a) => new int3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int3 Smoothstep(int3 edge0, int3 edge1, int3 v) => new int3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int3 Smoothstep(int3 edge0, int3 edge1, int v) => new int3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int3 Smoothstep(int3 edge0, int edge1, int3 v) => new int3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int3 Smoothstep(int3 edge0, int edge1, int v) => new int3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int3 Smoothstep(int edge0, int3 edge1, int3 v) => new int3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int3 Smoothstep(int edge0, int3 edge1, int v) => new int3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int3 Smoothstep(int edge0, int edge1, int3 v) => new int3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a int from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int3 Smoothstep(int edge0, int edge1, int v) => new int3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int3 Smootherstep(int3 edge0, int3 edge1, int3 v) => new int3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int3 Smootherstep(int3 edge0, int3 edge1, int v) => new int3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int3 Smootherstep(int3 edge0, int edge1, int3 v) => new int3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int3 Smootherstep(int3 edge0, int edge1, int v) => new int3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int3 Smootherstep(int edge0, int3 edge1, int3 v) => new int3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int3 Smootherstep(int edge0, int3 edge1, int v) => new int3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int3 Smootherstep(int edge0, int edge1, int3 v) => new int3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a int from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int3 Smootherstep(int edge0, int edge1, int v) => new int3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a int3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int3 Fma(int3 a, int3 b, int3 c) => new int3(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int3 Fma(int3 a, int3 b, int c) => new int3(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int3 Fma(int3 a, int b, int3 c) => new int3(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int3 Fma(int3 a, int b, int c) => new int3(a.x * b + c, a.y * b + c, a.z * b + c);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int3 Fma(int a, int3 b, int3 c) => new int3(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int3 Fma(int a, int3 b, int c) => new int3(a * b.x + c, a * b.y + c, a * b.z + c);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int3 Fma(int a, int b, int3 c) => new int3(a * b + c.x, a * b + c.y, a * b + c.z);
        
        /// <summary>
        /// Returns a int from the application of Fma (a * b + c).
        /// </summary>
        public static int3 Fma(int a, int b, int c) => new int3(a * b + c);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static int3 Add(int3 lhs, int3 rhs) => new int3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static int3 Add(int3 lhs, int rhs) => new int3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static int3 Add(int lhs, int3 rhs) => new int3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a int from the application of Add (lhs + rhs).
        /// </summary>
        public static int3 Add(int lhs, int rhs) => new int3(lhs + rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static int3 Sub(int3 lhs, int3 rhs) => new int3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static int3 Sub(int3 lhs, int rhs) => new int3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static int3 Sub(int lhs, int3 rhs) => new int3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a int from the application of Sub (lhs - rhs).
        /// </summary>
        public static int3 Sub(int lhs, int rhs) => new int3(lhs - rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static int3 Mul(int3 lhs, int3 rhs) => new int3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static int3 Mul(int3 lhs, int rhs) => new int3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static int3 Mul(int lhs, int3 rhs) => new int3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a int from the application of Mul (lhs * rhs).
        /// </summary>
        public static int3 Mul(int lhs, int rhs) => new int3(lhs * rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static int3 Div(int3 lhs, int3 rhs) => new int3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static int3 Div(int3 lhs, int rhs) => new int3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static int3 Div(int lhs, int3 rhs) => new int3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a int from the application of Div (lhs / rhs).
        /// </summary>
        public static int3 Div(int lhs, int rhs) => new int3(lhs / rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static int3 Xor(int3 lhs, int3 rhs) => new int3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static int3 Xor(int3 lhs, int rhs) => new int3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static int3 Xor(int lhs, int3 rhs) => new int3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);
        
        /// <summary>
        /// Returns a int from the application of Xor (lhs ^ rhs).
        /// </summary>
        public static int3 Xor(int lhs, int rhs) => new int3(lhs ^ rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static int3 BitwiseOr(int3 lhs, int3 rhs) => new int3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static int3 BitwiseOr(int3 lhs, int rhs) => new int3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static int3 BitwiseOr(int lhs, int3 rhs) => new int3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        
        /// <summary>
        /// Returns a int from the application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static int3 BitwiseOr(int lhs, int rhs) => new int3(lhs | rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static int3 BitwiseAnd(int3 lhs, int3 rhs) => new int3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static int3 BitwiseAnd(int3 lhs, int rhs) => new int3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static int3 BitwiseAnd(int lhs, int3 rhs) => new int3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);
        
        /// <summary>
        /// Returns a int from the application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static int3 BitwiseAnd(int lhs, int rhs) => new int3(lhs & rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static int3 LeftShift(int3 lhs, int3 rhs) => new int3(lhs.x << rhs.x, lhs.y << rhs.y, lhs.z << rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static int3 LeftShift(int3 lhs, int rhs) => new int3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static int3 LeftShift(int lhs, int3 rhs) => new int3(lhs << rhs.x, lhs << rhs.y, lhs << rhs.z);
        
        /// <summary>
        /// Returns a int from the application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static int3 LeftShift(int lhs, int rhs) => new int3(lhs << rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static int3 RightShift(int3 lhs, int3 rhs) => new int3(lhs.x >> rhs.x, lhs.y >> rhs.y, lhs.z >> rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static int3 RightShift(int3 lhs, int rhs) => new int3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static int3 RightShift(int lhs, int3 rhs) => new int3(lhs >> rhs.x, lhs >> rhs.y, lhs >> rhs.z);
        
        /// <summary>
        /// Returns a int from the application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static int3 RightShift(int lhs, int rhs) => new int3(lhs >> rhs);
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static int3 Random(Random random, int3 maxValue) => new int3((int)random.Next((int)maxValue.x), (int)random.Next((int)maxValue.y), (int)random.Next((int)maxValue.z));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static int3 Random(Random random, int maxValue) => new int3((int)random.Next((int)maxValue));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int3 Random(Random random, int3 minValue, int3 maxValue) => new int3((int)random.Next((int)minValue.x, (int)maxValue.x), (int)random.Next((int)minValue.y, (int)maxValue.y), (int)random.Next((int)minValue.z, (int)maxValue.z));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int3 Random(Random random, int3 minValue, int maxValue) => new int3((int)random.Next((int)minValue.x, (int)maxValue), (int)random.Next((int)minValue.y, (int)maxValue), (int)random.Next((int)minValue.z, (int)maxValue));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int3 Random(Random random, int minValue, int3 maxValue) => new int3((int)random.Next((int)minValue, (int)maxValue.x), (int)random.Next((int)minValue, (int)maxValue.y), (int)random.Next((int)minValue, (int)maxValue.z));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int3 Random(Random random, int minValue, int maxValue) => new int3((int)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int3 RandomUniform(Random random, int3 minValue, int3 maxValue) => new int3((int)random.Next((int)minValue.x, (int)maxValue.x), (int)random.Next((int)minValue.y, (int)maxValue.y), (int)random.Next((int)minValue.z, (int)maxValue.z));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int3 RandomUniform(Random random, int3 minValue, int maxValue) => new int3((int)random.Next((int)minValue.x, (int)maxValue), (int)random.Next((int)minValue.y, (int)maxValue), (int)random.Next((int)minValue.z, (int)maxValue));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int3 RandomUniform(Random random, int minValue, int3 maxValue) => new int3((int)random.Next((int)minValue, (int)maxValue.x), (int)random.Next((int)minValue, (int)maxValue.y), (int)random.Next((int)minValue, (int)maxValue.z));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int3 RandomUniform(Random random, int minValue, int maxValue) => new int3((int)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static int3 RandomPoisson(Random random, double3 lambda) => new int3((int)lambda.x.GetPoisson(random), (int)lambda.y.GetPoisson(random), (int)lambda.z.GetPoisson(random));
        
        /// <summary>
        /// Returns a int3 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static int3 RandomPoisson(Random random, double lambda) => new int3((int)lambda.GetPoisson(random));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(int3 lhs, int3 rhs) => new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(int3 lhs, int rhs) => new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool3 operator<(int lhs, int3 rhs) => new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(int3 lhs, int3 rhs) => new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(int3 lhs, int rhs) => new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool3 operator<=(int lhs, int3 rhs) => new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(int3 lhs, int3 rhs) => new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(int3 lhs, int rhs) => new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool3 operator>(int lhs, int3 rhs) => new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(int3 lhs, int3 rhs) => new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(int3 lhs, int rhs) => new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool3 operator>=(int lhs, int3 rhs) => new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static int3 operator+(int3 lhs, int3 rhs) => new int3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static int3 operator+(int3 lhs, int rhs) => new int3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static int3 operator+(int lhs, int3 rhs) => new int3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static int3 operator-(int3 lhs, int3 rhs) => new int3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static int3 operator-(int3 lhs, int rhs) => new int3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static int3 operator-(int lhs, int3 rhs) => new int3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static int3 operator*(int3 lhs, int3 rhs) => new int3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static int3 operator*(int3 lhs, int rhs) => new int3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static int3 operator*(int lhs, int3 rhs) => new int3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static int3 operator/(int3 lhs, int3 rhs) => new int3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static int3 operator/(int3 lhs, int rhs) => new int3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static int3 operator/(int lhs, int3 rhs) => new int3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator+ (identity).
        /// </summary>
        public static int3 operator+(int3 v) => v;
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator- (-v).
        /// </summary>
        public static int3 operator-(int3 v) => new int3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator~ (~v).
        /// </summary>
        public static int3 operator~(int3 v) => new int3(~v.x, ~v.y, ~v.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static int3 operator^(int3 lhs, int3 rhs) => new int3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static int3 operator^(int3 lhs, int rhs) => new int3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static int3 operator^(int lhs, int3 rhs) => new int3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static int3 operator|(int3 lhs, int3 rhs) => new int3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static int3 operator|(int3 lhs, int rhs) => new int3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static int3 operator|(int lhs, int3 rhs) => new int3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static int3 operator&(int3 lhs, int3 rhs) => new int3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static int3 operator&(int3 lhs, int rhs) => new int3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static int3 operator&(int lhs, int3 rhs) => new int3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        public static int3 operator<<(int3 lhs, int rhs) => new int3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);
        
        /// <summary>
        /// Returns a int3 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        public static int3 operator>>(int3 lhs, int rhs) => new int3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);

        #endregion

    }
}
