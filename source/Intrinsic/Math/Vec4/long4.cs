using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using Intrinsic.Math.Swizzle;

// ReSharper disable InconsistentNaming

namespace Intrinsic.Math
{
    
    /// <summary>
    /// A vector of type long with 4 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct long4 : IReadOnlyList<long>, IEquatable<long4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public long x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public long y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public long z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public long w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public long4(long x, long y, long z, long w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public long4(long v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public long4(long2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0;
            this.w = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public long4(long2 v, long z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public long4(long2 v, long z, long w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public long4(long3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public long4(long3 v, long w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public long4(long4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public long4(IReadOnlyList<long> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0 : v[0];
            this.y = c < 1 ? 0 : v[1];
            this.z = c < 2 ? 0 : v[2];
            this.w = c < 3 ? 0 : v[3];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public long4(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0 : (long)v[0];
            this.y = c < 1 ? 0 : (long)v[1];
            this.z = c < 2 ? 0 : (long)v[2];
            this.w = c < 3 ? 0 : (long)v[3];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public long4(long[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0 : v[0];
            this.y = c < 1 ? 0 : v[1];
            this.z = c < 2 ? 0 : v[2];
            this.w = c < 3 ? 0 : v[3];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public long4(long[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0 : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0 : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0 : v[3 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public long4(IEnumerable<long> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(long4 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int3.
        /// </summary>
        public static explicit operator int3(long4 v) => new int3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a int4.
        /// </summary>
        public static explicit operator int4(long4 v) => new int4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(long4 v) => new uint2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uint3.
        /// </summary>
        public static explicit operator uint3(long4 v) => new uint3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uint4.
        /// </summary>
        public static explicit operator uint4(long4 v) => new uint4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a float2.
        /// </summary>
        public static explicit operator float2(long4 v) => new float2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a float3.
        /// </summary>
        public static explicit operator float3(long4 v) => new float3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a float4.
        /// </summary>
        public static explicit operator float4(long4 v) => new float4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a double2.
        /// </summary>
        public static explicit operator double2(long4 v) => new double2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a double3.
        /// </summary>
        public static explicit operator double3(long4 v) => new double3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a double4.
        /// </summary>
        public static explicit operator double4(long4 v) => new double4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(long4 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a long3.
        /// </summary>
        public static explicit operator long3(long4 v) => new long3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(long4 v) => new bool2(v.x != 0, v.y != 0);
        
        /// <summary>
        /// Explicitly converts this to a bool3.
        /// </summary>
        public static explicit operator bool3(long4 v) => new bool3(v.x != 0, v.y != 0, v.z != 0);
        
        /// <summary>
        /// Explicitly converts this to a bool4.
        /// </summary>
        public static explicit operator bool4(long4 v) => new bool4(v.x != 0, v.y != 0, v.z != 0, v.w != 0);
        
        /// <summary>
        /// Explicitly converts this to a long array.
        /// </summary>
        public static explicit operator long[](long4 v) => new [] { v.x, v.y, v.z, v.w };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](long4 v) => new Object[] { v.x, v.y, v.z, v.w };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public long this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
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
                    case 3: w = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_long4 swizzle => new swizzle_long4(x, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long2 xy
        {
            get
            {
                return new long2(x, y);
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
        public long2 xz
        {
            get
            {
                return new long2(x, z);
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
        public long2 yz
        {
            get
            {
                return new long2(y, z);
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
        public long3 xyz
        {
            get
            {
                return new long3(x, y, z);
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
        public long2 xw
        {
            get
            {
                return new long2(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long2 yw
        {
            get
            {
                return new long2(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long3 xyw
        {
            get
            {
                return new long3(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long2 zw
        {
            get
            {
                return new long2(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long3 xzw
        {
            get
            {
                return new long3(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long3 yzw
        {
            get
            {
                return new long3(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long4 xyzw
        {
            get
            {
                return new long4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long2 rg
        {
            get
            {
                return new long2(x, y);
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
        public long2 rb
        {
            get
            {
                return new long2(x, z);
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
        public long2 gb
        {
            get
            {
                return new long2(y, z);
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
        public long3 rgb
        {
            get
            {
                return new long3(x, y, z);
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
        public long2 ra
        {
            get
            {
                return new long2(x, w);
            }
            set
            {
                x = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long2 ga
        {
            get
            {
                return new long2(y, w);
            }
            set
            {
                y = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long3 rga
        {
            get
            {
                return new long3(x, y, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long2 ba
        {
            get
            {
                return new long2(z, w);
            }
            set
            {
                z = value.x;
                w = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long3 rba
        {
            get
            {
                return new long3(x, z, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long3 gba
        {
            get
            {
                return new long3(y, z, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long4 rgba
        {
            get
            {
                return new long4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long r
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
        public long g
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
        public long b
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
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public long a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public long[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public long MinElement => System.Math.Min(System.Math.Min(x, y), System.Math.Min(z, w));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public long MaxElement => System.Math.Max(System.Math.Max(x, y), System.Math.Max(z, w));
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)System.Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => ((x*x + y*y) + (z*z + w*w));
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public long Sum => ((x + y) + (z + w));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)System.Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => ((System.Math.Abs(x) + System.Math.Abs(y)) + (System.Math.Abs(z) + System.Math.Abs(w)));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public double Norm2 => (double)System.Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => System.Math.Max(System.Math.Max(System.Math.Abs(x), System.Math.Abs(y)), System.Math.Max(System.Math.Abs(z), System.Math.Abs(w)));

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static long4 Zero { get; } = new long4(0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static long4 Ones { get; } = new long4(1, 1, 1, 1);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static long4 UnitX { get; } = new long4(1, 0, 0, 0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static long4 UnitY { get; } = new long4(0, 1, 0, 0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static long4 UnitZ { get; } = new long4(0, 0, 1, 0);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static long4 UnitW { get; } = new long4(0, 0, 0, 1);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static long4 MaxValue { get; } = new long4(long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static long4 MinValue { get; } = new long4(long.MinValue, long.MinValue, long.MinValue, long.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(long4 lhs, long4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(long4 lhs, long4 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<long> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
            yield return w;
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
        public string ToString(string sep) => ((x + sep + y) + sep + (z + sep + w));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => ((x.ToString(provider) + sep + y.ToString(provider)) + sep + (z.ToString(provider) + sep + w.ToString(provider)));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => ((x.ToString(format) + sep + y.ToString(format)) + sep + (z.ToString(format) + sep + w.ToString(format)));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => ((x.ToString(format, provider) + sep + y.ToString(format, provider)) + sep + (z.ToString(format, provider) + sep + w.ToString(format, provider)));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(long4 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is long4 && Equals((long4) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((x.GetHashCode()) * 397) ^ y.GetHashCode()) * 397) ^ z.GetHashCode()) * 397) ^ w.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => System.Math.Pow(((System.Math.Pow((double)System.Math.Abs(x), p) + System.Math.Pow((double)System.Math.Abs(y), p)) + (System.Math.Pow((double)System.Math.Abs(z), p) + System.Math.Pow((double)System.Math.Abs(w), p))), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static long4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static long4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new long4(long.Parse(kvp[0].Trim()), long.Parse(kvp[1].Trim()), long.Parse(kvp[2].Trim()), long.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static long4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new long4(long.Parse(kvp[0].Trim(), provider), long.Parse(kvp[1].Trim(), provider), long.Parse(kvp[2].Trim(), provider), long.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static long4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new long4(long.Parse(kvp[0].Trim(), style), long.Parse(kvp[1].Trim(), style), long.Parse(kvp[2].Trim(), style), long.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static long4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new long4(long.Parse(kvp[0].Trim(), style, provider), long.Parse(kvp[1].Trim(), style, provider), long.Parse(kvp[2].Trim(), style, provider), long.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out long4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out long4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            long x = 0, y = 0, z = 0, w = 0;
            var ok = ((long.TryParse(kvp[0].Trim(), out x) && long.TryParse(kvp[1].Trim(), out y)) && (long.TryParse(kvp[2].Trim(), out z) && long.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new long4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out long4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            long x = 0, y = 0, z = 0, w = 0;
            var ok = ((long.TryParse(kvp[0].Trim(), style, provider, out x) && long.TryParse(kvp[1].Trim(), style, provider, out y)) && (long.TryParse(kvp[2].Trim(), style, provider, out z) && long.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new long4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static long4x2 OuterProduct(long2 c, long4 r) => new long4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static long2x4 OuterProduct(long4 c, long2 r) => new long2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static long4x3 OuterProduct(long3 c, long4 r) => new long4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static long3x4 OuterProduct(long4 c, long3 r) => new long3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static long4x4 OuterProduct(long4 c, long4 r) => new long4x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static long Dot(long4 lhs, long4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(long4 lhs, long4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(long4 lhs, long4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static long4 Reflect(long4 I, long4 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static long4 Refract(long4 I, long4 N, long eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (long)System.Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static long4 FaceForward(long4 N, long4 I, long4 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive).
        /// </summary>
        public static long4 Random(Random random) => new long4((long)random.Next(), (long)random.Next(), (long)random.Next(), (long)random.Next());

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(long4 lhs, long4 rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(long4 lhs, long rhs) => new bool4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(long lhs, long4 rhs) => new bool4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(long lhs, long rhs) => new bool4(lhs == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(long4 lhs, long4 rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(long4 lhs, long rhs) => new bool4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(long lhs, long4 rhs) => new bool4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(long lhs, long rhs) => new bool4(lhs != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(long4 lhs, long4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(long4 lhs, long rhs) => new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(long lhs, long4 rhs) => new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(long lhs, long rhs) => new bool4(lhs > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(long4 lhs, long4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(long4 lhs, long rhs) => new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(long lhs, long4 rhs) => new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(long lhs, long rhs) => new bool4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(long4 lhs, long4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(long4 lhs, long rhs) => new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(long lhs, long4 rhs) => new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(long lhs, long rhs) => new bool4(lhs < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(long4 lhs, long4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(long4 lhs, long rhs) => new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(long lhs, long4 rhs) => new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(long lhs, long rhs) => new bool4(lhs <= rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static long4 Abs(long4 v) => new long4(System.Math.Abs(v.x), System.Math.Abs(v.y), System.Math.Abs(v.z), System.Math.Abs(v.w));
        
        /// <summary>
        /// Returns a long from the application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static long4 Abs(long v) => new long4(System.Math.Abs(v));
        
        /// <summary>
        /// Returns a long4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static long4 HermiteInterpolationOrder3(long4 v) => new long4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a long from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static long4 HermiteInterpolationOrder3(long v) => new long4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a long4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static long4 HermiteInterpolationOrder5(long4 v) => new long4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a long from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static long4 HermiteInterpolationOrder5(long v) => new long4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static long4 Sqr(long4 v) => new long4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a long from the application of Sqr (v * v).
        /// </summary>
        public static long4 Sqr(long v) => new long4(v * v);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static long4 Pow2(long4 v) => new long4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a long from the application of Pow2 (v * v).
        /// </summary>
        public static long4 Pow2(long v) => new long4(v * v);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static long4 Pow3(long4 v) => new long4(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a long from the application of Pow3 (v * v * v).
        /// </summary>
        public static long4 Pow3(long v) => new long4(v * v * v);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static long4 Step(long4 v) => new long4(v.x >= 0 ? 1 : 0, v.y >= 0 ? 1 : 0, v.z >= 0 ? 1 : 0, v.w >= 0 ? 1 : 0);
        
        /// <summary>
        /// Returns a long from the application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static long4 Step(long v) => new long4(v >= 0 ? 1 : 0);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Sqrt ((long)System.Math.Sqrt((double)v)).
        /// </summary>
        public static long4 Sqrt(long4 v) => new long4((long)System.Math.Sqrt((double)v.x), (long)System.Math.Sqrt((double)v.y), (long)System.Math.Sqrt((double)v.z), (long)System.Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a long from the application of Sqrt ((long)System.Math.Sqrt((double)v)).
        /// </summary>
        public static long4 Sqrt(long v) => new long4((long)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a long4 from component-wise application of InverseSqrt ((long)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static long4 InverseSqrt(long4 v) => new long4((long)(1.0 / System.Math.Sqrt((double)v.x)), (long)(1.0 / System.Math.Sqrt((double)v.y)), (long)(1.0 / System.Math.Sqrt((double)v.z)), (long)(1.0 / System.Math.Sqrt((double)v.w)));
        
        /// <summary>
        /// Returns a long from the application of InverseSqrt ((long)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static long4 InverseSqrt(long v) => new long4((long)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int4 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int4 Sign(long4 v) => new int4(System.Math.Sign(v.x), System.Math.Sign(v.y), System.Math.Sign(v.z), System.Math.Sign(v.w));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int4 Sign(long v) => new int4(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static long4 Max(long4 lhs, long4 rhs) => new long4(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y), System.Math.Max(lhs.z, rhs.z), System.Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static long4 Max(long4 lhs, long rhs) => new long4(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs), System.Math.Max(lhs.z, rhs), System.Math.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static long4 Max(long lhs, long4 rhs) => new long4(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y), System.Math.Max(lhs, rhs.z), System.Math.Max(lhs, rhs.w));
        
        /// <summary>
        /// Returns a long from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static long4 Max(long lhs, long rhs) => new long4(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static long4 Min(long4 lhs, long4 rhs) => new long4(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y), System.Math.Min(lhs.z, rhs.z), System.Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static long4 Min(long4 lhs, long rhs) => new long4(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs), System.Math.Min(lhs.z, rhs), System.Math.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static long4 Min(long lhs, long4 rhs) => new long4(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y), System.Math.Min(lhs, rhs.z), System.Math.Min(lhs, rhs.w));
        
        /// <summary>
        /// Returns a long from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static long4 Min(long lhs, long rhs) => new long4(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Pow ((long)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static long4 Pow(long4 lhs, long4 rhs) => new long4((long)System.Math.Pow((double)lhs.x, (double)rhs.x), (long)System.Math.Pow((double)lhs.y, (double)rhs.y), (long)System.Math.Pow((double)lhs.z, (double)rhs.z), (long)System.Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Pow ((long)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static long4 Pow(long4 lhs, long rhs) => new long4((long)System.Math.Pow((double)lhs.x, (double)rhs), (long)System.Math.Pow((double)lhs.y, (double)rhs), (long)System.Math.Pow((double)lhs.z, (double)rhs), (long)System.Math.Pow((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Pow ((long)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static long4 Pow(long lhs, long4 rhs) => new long4((long)System.Math.Pow((double)lhs, (double)rhs.x), (long)System.Math.Pow((double)lhs, (double)rhs.y), (long)System.Math.Pow((double)lhs, (double)rhs.z), (long)System.Math.Pow((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a long from the application of Pow ((long)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static long4 Pow(long lhs, long rhs) => new long4((long)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Log ((long)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static long4 Log(long4 lhs, long4 rhs) => new long4((long)System.Math.Log((double)lhs.x, (double)rhs.x), (long)System.Math.Log((double)lhs.y, (double)rhs.y), (long)System.Math.Log((double)lhs.z, (double)rhs.z), (long)System.Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Log ((long)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static long4 Log(long4 lhs, long rhs) => new long4((long)System.Math.Log((double)lhs.x, (double)rhs), (long)System.Math.Log((double)lhs.y, (double)rhs), (long)System.Math.Log((double)lhs.z, (double)rhs), (long)System.Math.Log((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Log ((long)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static long4 Log(long lhs, long4 rhs) => new long4((long)System.Math.Log((double)lhs, (double)rhs.x), (long)System.Math.Log((double)lhs, (double)rhs.y), (long)System.Math.Log((double)lhs, (double)rhs.z), (long)System.Math.Log((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a long from the application of Log ((long)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static long4 Log(long lhs, long rhs) => new long4((long)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long4 Clamp(long4 v, long4 min, long4 max) => new long4(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y), System.Math.Min(System.Math.Max(v.z, min.z), max.z), System.Math.Min(System.Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long4 Clamp(long4 v, long4 min, long max) => new long4(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max), System.Math.Min(System.Math.Max(v.z, min.z), max), System.Math.Min(System.Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long4 Clamp(long4 v, long min, long4 max) => new long4(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y), System.Math.Min(System.Math.Max(v.z, min), max.z), System.Math.Min(System.Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long4 Clamp(long4 v, long min, long max) => new long4(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max), System.Math.Min(System.Math.Max(v.z, min), max), System.Math.Min(System.Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long4 Clamp(long v, long4 min, long4 max) => new long4(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y), System.Math.Min(System.Math.Max(v, min.z), max.z), System.Math.Min(System.Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long4 Clamp(long v, long4 min, long max) => new long4(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max), System.Math.Min(System.Math.Max(v, min.z), max), System.Math.Min(System.Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long4 Clamp(long v, long min, long4 max) => new long4(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y), System.Math.Min(System.Math.Max(v, min), max.z), System.Math.Min(System.Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a long from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long4 Clamp(long v, long min, long max) => new long4(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long4 Mix(long4 min, long4 max, long4 a) => new long4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long4 Mix(long4 min, long4 max, long a) => new long4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long4 Mix(long4 min, long max, long4 a) => new long4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long4 Mix(long4 min, long max, long a) => new long4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long4 Mix(long min, long4 max, long4 a) => new long4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long4 Mix(long min, long4 max, long a) => new long4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long4 Mix(long min, long max, long4 a) => new long4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a long from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long4 Mix(long min, long max, long a) => new long4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long4 Lerp(long4 min, long4 max, long4 a) => new long4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long4 Lerp(long4 min, long4 max, long a) => new long4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long4 Lerp(long4 min, long max, long4 a) => new long4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long4 Lerp(long4 min, long max, long a) => new long4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long4 Lerp(long min, long4 max, long4 a) => new long4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long4 Lerp(long min, long4 max, long a) => new long4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long4 Lerp(long min, long max, long4 a) => new long4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a long from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long4 Lerp(long min, long max, long a) => new long4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long4 Smoothstep(long4 edge0, long4 edge1, long4 v) => new long4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long4 Smoothstep(long4 edge0, long4 edge1, long v) => new long4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long4 Smoothstep(long4 edge0, long edge1, long4 v) => new long4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long4 Smoothstep(long4 edge0, long edge1, long v) => new long4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long4 Smoothstep(long edge0, long4 edge1, long4 v) => new long4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long4 Smoothstep(long edge0, long4 edge1, long v) => new long4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long4 Smoothstep(long edge0, long edge1, long4 v) => new long4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a long from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long4 Smoothstep(long edge0, long edge1, long v) => new long4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long4 Smootherstep(long4 edge0, long4 edge1, long4 v) => new long4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long4 Smootherstep(long4 edge0, long4 edge1, long v) => new long4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long4 Smootherstep(long4 edge0, long edge1, long4 v) => new long4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long4 Smootherstep(long4 edge0, long edge1, long v) => new long4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long4 Smootherstep(long edge0, long4 edge1, long4 v) => new long4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long4 Smootherstep(long edge0, long4 edge1, long v) => new long4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long4 Smootherstep(long edge0, long edge1, long4 v) => new long4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a long from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long4 Smootherstep(long edge0, long edge1, long v) => new long4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a long4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long4 Fma(long4 a, long4 b, long4 c) => new long4(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long4 Fma(long4 a, long4 b, long c) => new long4(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long4 Fma(long4 a, long b, long4 c) => new long4(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long4 Fma(long4 a, long b, long c) => new long4(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long4 Fma(long a, long4 b, long4 c) => new long4(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long4 Fma(long a, long4 b, long c) => new long4(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long4 Fma(long a, long b, long4 c) => new long4(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w);
        
        /// <summary>
        /// Returns a long from the application of Fma (a * b + c).
        /// </summary>
        public static long4 Fma(long a, long b, long c) => new long4(a * b + c);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static long4 Add(long4 lhs, long4 rhs) => new long4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static long4 Add(long4 lhs, long rhs) => new long4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static long4 Add(long lhs, long4 rhs) => new long4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a long from the application of Add (lhs + rhs).
        /// </summary>
        public static long4 Add(long lhs, long rhs) => new long4(lhs + rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static long4 Sub(long4 lhs, long4 rhs) => new long4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static long4 Sub(long4 lhs, long rhs) => new long4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static long4 Sub(long lhs, long4 rhs) => new long4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a long from the application of Sub (lhs - rhs).
        /// </summary>
        public static long4 Sub(long lhs, long rhs) => new long4(lhs - rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static long4 Mul(long4 lhs, long4 rhs) => new long4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static long4 Mul(long4 lhs, long rhs) => new long4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static long4 Mul(long lhs, long4 rhs) => new long4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a long from the application of Mul (lhs * rhs).
        /// </summary>
        public static long4 Mul(long lhs, long rhs) => new long4(lhs * rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static long4 Div(long4 lhs, long4 rhs) => new long4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static long4 Div(long4 lhs, long rhs) => new long4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static long4 Div(long lhs, long4 rhs) => new long4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a long from the application of Div (lhs / rhs).
        /// </summary>
        public static long4 Div(long lhs, long rhs) => new long4(lhs / rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static long4 Xor(long4 lhs, long4 rhs) => new long4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static long4 Xor(long4 lhs, long rhs) => new long4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static long4 Xor(long lhs, long4 rhs) => new long4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);
        
        /// <summary>
        /// Returns a long from the application of Xor (lhs ^ rhs).
        /// </summary>
        public static long4 Xor(long lhs, long rhs) => new long4(lhs ^ rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static long4 BitwiseOr(long4 lhs, long4 rhs) => new long4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static long4 BitwiseOr(long4 lhs, long rhs) => new long4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static long4 BitwiseOr(long lhs, long4 rhs) => new long4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);
        
        /// <summary>
        /// Returns a long from the application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static long4 BitwiseOr(long lhs, long rhs) => new long4(lhs | rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static long4 BitwiseAnd(long4 lhs, long4 rhs) => new long4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static long4 BitwiseAnd(long4 lhs, long rhs) => new long4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static long4 BitwiseAnd(long lhs, long4 rhs) => new long4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);
        
        /// <summary>
        /// Returns a long from the application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static long4 BitwiseAnd(long lhs, long rhs) => new long4(lhs & rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static long4 LeftShift(long4 lhs, int4 rhs) => new long4(lhs.x << rhs.x, lhs.y << rhs.y, lhs.z << rhs.z, lhs.w << rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static long4 LeftShift(long4 lhs, int rhs) => new long4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static long4 LeftShift(long lhs, int4 rhs) => new long4(lhs << rhs.x, lhs << rhs.y, lhs << rhs.z, lhs << rhs.w);
        
        /// <summary>
        /// Returns a long from the application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static long4 LeftShift(long lhs, int rhs) => new long4(lhs << rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static long4 RightShift(long4 lhs, int4 rhs) => new long4(lhs.x >> rhs.x, lhs.y >> rhs.y, lhs.z >> rhs.z, lhs.w >> rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static long4 RightShift(long4 lhs, int rhs) => new long4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static long4 RightShift(long lhs, int4 rhs) => new long4(lhs >> rhs.x, lhs >> rhs.y, lhs >> rhs.z, lhs >> rhs.w);
        
        /// <summary>
        /// Returns a long from the application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static long4 RightShift(long lhs, int rhs) => new long4(lhs >> rhs);
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static long4 Random(Random random, long4 maxValue) => new long4((long)random.Next((int)maxValue.x), (long)random.Next((int)maxValue.y), (long)random.Next((int)maxValue.z), (long)random.Next((int)maxValue.w));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static long4 Random(Random random, long maxValue) => new long4((long)random.Next((int)maxValue));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long4 Random(Random random, long4 minValue, long4 maxValue) => new long4((long)random.Next((int)minValue.x, (int)maxValue.x), (long)random.Next((int)minValue.y, (int)maxValue.y), (long)random.Next((int)minValue.z, (int)maxValue.z), (long)random.Next((int)minValue.w, (int)maxValue.w));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long4 Random(Random random, long4 minValue, long maxValue) => new long4((long)random.Next((int)minValue.x, (int)maxValue), (long)random.Next((int)minValue.y, (int)maxValue), (long)random.Next((int)minValue.z, (int)maxValue), (long)random.Next((int)minValue.w, (int)maxValue));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long4 Random(Random random, long minValue, long4 maxValue) => new long4((long)random.Next((int)minValue, (int)maxValue.x), (long)random.Next((int)minValue, (int)maxValue.y), (long)random.Next((int)minValue, (int)maxValue.z), (long)random.Next((int)minValue, (int)maxValue.w));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long4 Random(Random random, long minValue, long maxValue) => new long4((long)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long4 RandomUniform(Random random, long4 minValue, long4 maxValue) => new long4((long)random.Next((int)minValue.x, (int)maxValue.x), (long)random.Next((int)minValue.y, (int)maxValue.y), (long)random.Next((int)minValue.z, (int)maxValue.z), (long)random.Next((int)minValue.w, (int)maxValue.w));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long4 RandomUniform(Random random, long4 minValue, long maxValue) => new long4((long)random.Next((int)minValue.x, (int)maxValue), (long)random.Next((int)minValue.y, (int)maxValue), (long)random.Next((int)minValue.z, (int)maxValue), (long)random.Next((int)minValue.w, (int)maxValue));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long4 RandomUniform(Random random, long minValue, long4 maxValue) => new long4((long)random.Next((int)minValue, (int)maxValue.x), (long)random.Next((int)minValue, (int)maxValue.y), (long)random.Next((int)minValue, (int)maxValue.z), (long)random.Next((int)minValue, (int)maxValue.w));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long4 RandomUniform(Random random, long minValue, long maxValue) => new long4((long)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static long4 RandomPoisson(Random random, double4 lambda) => new long4((long)lambda.x.GetPoisson(random), (long)lambda.y.GetPoisson(random), (long)lambda.z.GetPoisson(random), (long)lambda.w.GetPoisson(random));
        
        /// <summary>
        /// Returns a long4 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static long4 RandomPoisson(Random random, double lambda) => new long4((long)lambda.GetPoisson(random));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(long4 lhs, long4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(long4 lhs, long rhs) => new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(long lhs, long4 rhs) => new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(long4 lhs, long4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(long4 lhs, long rhs) => new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(long lhs, long4 rhs) => new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(long4 lhs, long4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(long4 lhs, long rhs) => new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(long lhs, long4 rhs) => new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(long4 lhs, long4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(long4 lhs, long rhs) => new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(long lhs, long4 rhs) => new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static long4 operator+(long4 lhs, long4 rhs) => new long4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static long4 operator+(long4 lhs, long rhs) => new long4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static long4 operator+(long lhs, long4 rhs) => new long4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static long4 operator-(long4 lhs, long4 rhs) => new long4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static long4 operator-(long4 lhs, long rhs) => new long4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static long4 operator-(long lhs, long4 rhs) => new long4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static long4 operator*(long4 lhs, long4 rhs) => new long4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static long4 operator*(long4 lhs, long rhs) => new long4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static long4 operator*(long lhs, long4 rhs) => new long4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static long4 operator/(long4 lhs, long4 rhs) => new long4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static long4 operator/(long4 lhs, long rhs) => new long4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static long4 operator/(long lhs, long4 rhs) => new long4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator+ (identity).
        /// </summary>
        public static long4 operator+(long4 v) => v;
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator- (-v).
        /// </summary>
        public static long4 operator-(long4 v) => new long4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator~ (~v).
        /// </summary>
        public static long4 operator~(long4 v) => new long4(~v.x, ~v.y, ~v.z, ~v.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static long4 operator^(long4 lhs, long4 rhs) => new long4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static long4 operator^(long4 lhs, long rhs) => new long4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static long4 operator^(long lhs, long4 rhs) => new long4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static long4 operator|(long4 lhs, long4 rhs) => new long4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static long4 operator|(long4 lhs, long rhs) => new long4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static long4 operator|(long lhs, long4 rhs) => new long4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static long4 operator&(long4 lhs, long4 rhs) => new long4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static long4 operator&(long4 lhs, long rhs) => new long4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static long4 operator&(long lhs, long4 rhs) => new long4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        public static long4 operator<<(long4 lhs, int rhs) => new long4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);
        
        /// <summary>
        /// Returns a long4 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        public static long4 operator>>(long4 lhs, int rhs) => new long4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);

        #endregion

    }
}
