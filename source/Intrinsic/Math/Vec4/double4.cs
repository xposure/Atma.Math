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
    /// A vector of type double with 4 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct double4 : IReadOnlyList<double>, IEquatable<double4>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public double y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public double z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public double w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public double4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public double4(double v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public double4(double2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0.0;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public double4(double2 v, double z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public double4(double2 v, double z, double w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public double4(double3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public double4(double3 v, double w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public double4(double4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double4(IReadOnlyList<double> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
            this.z = c < 2 ? 0.0 : v[2];
            this.w = c < 3 ? 0.0 : v[3];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double4(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : (double)v[0];
            this.y = c < 1 ? 0.0 : (double)v[1];
            this.z = c < 2 ? 0.0 : (double)v[2];
            this.w = c < 3 ? 0.0 : (double)v[3];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double4(double[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
            this.z = c < 2 ? 0.0 : v[2];
            this.w = c < 3 ? 0.0 : v[3];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double4(double[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0.0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0.0 : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0.0 : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0.0 : v[3 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double4(IEnumerable<double> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(double4 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int3.
        /// </summary>
        public static explicit operator int3(double4 v) => new int3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a int4.
        /// </summary>
        public static explicit operator int4(double4 v) => new int4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(double4 v) => new uint2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uint3.
        /// </summary>
        public static explicit operator uint3(double4 v) => new uint3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uint4.
        /// </summary>
        public static explicit operator uint4(double4 v) => new uint4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a float2.
        /// </summary>
        public static explicit operator float2(double4 v) => new float2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a float3.
        /// </summary>
        public static explicit operator float3(double4 v) => new float3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a float4.
        /// </summary>
        public static explicit operator float4(double4 v) => new float4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a double2.
        /// </summary>
        public static explicit operator double2(double4 v) => new double2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a double3.
        /// </summary>
        public static explicit operator double3(double4 v) => new double3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(double4 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a long3.
        /// </summary>
        public static explicit operator long3(double4 v) => new long3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a long4.
        /// </summary>
        public static explicit operator long4(double4 v) => new long4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(double4 v) => new bool2(v.x != 0.0, v.y != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bool3.
        /// </summary>
        public static explicit operator bool3(double4 v) => new bool3(v.x != 0.0, v.y != 0.0, v.z != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bool4.
        /// </summary>
        public static explicit operator bool4(double4 v) => new bool4(v.x != 0.0, v.y != 0.0, v.z != 0.0, v.w != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a double array.
        /// </summary>
        public static explicit operator double[](double4 v) => new [] { v.x, v.y, v.z, v.w };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](double4 v) => new Object[] { v.x, v.y, v.z, v.w };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public double this[int index]
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
        public swizzle_double4 swizzle => new swizzle_double4(x, y, z, w);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public double2 xy
        {
            get
            {
                return new double2(x, y);
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
        public double2 xz
        {
            get
            {
                return new double2(x, z);
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
        public double2 yz
        {
            get
            {
                return new double2(y, z);
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
        public double3 xyz
        {
            get
            {
                return new double3(x, y, z);
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
        public double2 xw
        {
            get
            {
                return new double2(x, w);
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
        public double2 yw
        {
            get
            {
                return new double2(y, w);
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
        public double3 xyw
        {
            get
            {
                return new double3(x, y, w);
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
        public double2 zw
        {
            get
            {
                return new double2(z, w);
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
        public double3 xzw
        {
            get
            {
                return new double3(x, z, w);
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
        public double3 yzw
        {
            get
            {
                return new double3(y, z, w);
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
        public double4 xyzw
        {
            get
            {
                return new double4(x, y, z, w);
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
        public double2 rg
        {
            get
            {
                return new double2(x, y);
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
        public double2 rb
        {
            get
            {
                return new double2(x, z);
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
        public double2 gb
        {
            get
            {
                return new double2(y, z);
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
        public double3 rgb
        {
            get
            {
                return new double3(x, y, z);
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
        public double2 ra
        {
            get
            {
                return new double2(x, w);
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
        public double2 ga
        {
            get
            {
                return new double2(y, w);
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
        public double3 rga
        {
            get
            {
                return new double3(x, y, w);
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
        public double2 ba
        {
            get
            {
                return new double2(z, w);
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
        public double3 rba
        {
            get
            {
                return new double3(x, z, w);
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
        public double3 gba
        {
            get
            {
                return new double3(y, z, w);
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
        public double4 rgba
        {
            get
            {
                return new double4(x, y, z, w);
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
        public double r
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
        public double g
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
        public double b
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
        public double a
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
        public double[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public double MinElement => System.Math.Min(System.Math.Min(x, y), System.Math.Min(z, w));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public double MaxElement => System.Math.Max(System.Math.Max(x, y), System.Math.Max(z, w));
        
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
        public double Sum => ((x + y) + (z + w));
        
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
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public double4 Normalized => this / (double)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public double4 NormalizedSafe => this == Zero ? Zero : this / (double)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static double4 Zero { get; } = new double4(0.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static double4 Ones { get; } = new double4(1.0, 1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static double4 UnitX { get; } = new double4(1.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static double4 UnitY { get; } = new double4(0.0, 1.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static double4 UnitZ { get; } = new double4(0.0, 0.0, 1.0, 0.0);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static double4 UnitW { get; } = new double4(0.0, 0.0, 0.0, 1.0);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static double4 MaxValue { get; } = new double4(double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static double4 MinValue { get; } = new double4(double.MinValue, double.MinValue, double.MinValue, double.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static double4 Epsilon { get; } = new double4(double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static double4 NaN { get; } = new double4(double.NaN, double.NaN, double.NaN, double.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static double4 NegativeInfinity { get; } = new double4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static double4 PositiveInfinity { get; } = new double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(double4 lhs, double4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(double4 lhs, double4 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
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
        public bool Equals(double4 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is double4 && Equals((double4) obj);
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
        public static double4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static double4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new double4(double.Parse(kvp[0].Trim()), double.Parse(kvp[1].Trim()), double.Parse(kvp[2].Trim()), double.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static double4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new double4(double.Parse(kvp[0].Trim(), provider), double.Parse(kvp[1].Trim(), provider), double.Parse(kvp[2].Trim(), provider), double.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static double4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new double4(double.Parse(kvp[0].Trim(), style), double.Parse(kvp[1].Trim(), style), double.Parse(kvp[2].Trim(), style), double.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static double4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new double4(double.Parse(kvp[0].Trim(), style, provider), double.Parse(kvp[1].Trim(), style, provider), double.Parse(kvp[2].Trim(), style, provider), double.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out double4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out double4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            double x = 0.0, y = 0.0, z = 0.0, w = 0.0;
            var ok = ((double.TryParse(kvp[0].Trim(), out x) && double.TryParse(kvp[1].Trim(), out y)) && (double.TryParse(kvp[2].Trim(), out z) && double.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new double4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out double4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            double x = 0.0, y = 0.0, z = 0.0, w = 0.0;
            var ok = ((double.TryParse(kvp[0].Trim(), style, provider, out x) && double.TryParse(kvp[1].Trim(), style, provider, out y)) && (double.TryParse(kvp[2].Trim(), style, provider, out z) && double.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new double4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(double4 lhs, double4 rhs, double eps = 0.1d) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double4x2 OuterProduct(double2 c, double4 r) => new double4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double2x4 OuterProduct(double4 c, double2 r) => new double2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double4x3 OuterProduct(double3 c, double4 r) => new double4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double3x4 OuterProduct(double4 c, double3 r) => new double3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double4x4 OuterProduct(double4 c, double4 r) => new double4x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(double4 lhs, double4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(double4 lhs, double4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(double4 lhs, double4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static double4 Reflect(double4 I, double4 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static double4 Refract(double4 I, double4 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (double)System.Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static double4 FaceForward(double4 N, double4 I, double4 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static double4 Random(Random random) => new double4((double)random.NextDouble(), (double)random.NextDouble(), (double)random.NextDouble(), (double)random.NextDouble());
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static double4 RandomSigned(Random random) => new double4((double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static double4 RandomNormal(Random random) => new double4((double)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (double)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (double)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (double)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(double4 lhs, double4 rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(double4 lhs, double rhs) => new bool4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(double lhs, double4 rhs) => new bool4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(double lhs, double rhs) => new bool4(lhs == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(double4 lhs, double4 rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(double4 lhs, double rhs) => new bool4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(double lhs, double4 rhs) => new bool4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(double lhs, double rhs) => new bool4(lhs != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(double4 lhs, double4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(double4 lhs, double rhs) => new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(double lhs, double4 rhs) => new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(double lhs, double rhs) => new bool4(lhs > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(double4 lhs, double4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(double4 lhs, double rhs) => new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(double lhs, double4 rhs) => new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(double lhs, double rhs) => new bool4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(double4 lhs, double4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(double4 lhs, double rhs) => new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(double lhs, double4 rhs) => new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(double lhs, double rhs) => new bool4(lhs < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(double4 lhs, double4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(double4 lhs, double rhs) => new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(double lhs, double4 rhs) => new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(double lhs, double rhs) => new bool4(lhs <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(double4 v) => new bool4(double.IsInfinity(v.x), double.IsInfinity(v.y), double.IsInfinity(v.z), double.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(double v) => new bool4(double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bool4 IsFinite(double4 v) => new bool4(!double.IsNaN(v.x) && !double.IsInfinity(v.x), !double.IsNaN(v.y) && !double.IsInfinity(v.y), !double.IsNaN(v.z) && !double.IsInfinity(v.z), !double.IsNaN(v.w) && !double.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bool4 IsFinite(double v) => new bool4(!double.IsNaN(v) && !double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(double4 v) => new bool4(double.IsNaN(v.x), double.IsNaN(v.y), double.IsNaN(v.z), double.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(double v) => new bool4(double.IsNaN(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bool4 IsNegativeInfinity(double4 v) => new bool4(double.IsNegativeInfinity(v.x), double.IsNegativeInfinity(v.y), double.IsNegativeInfinity(v.z), double.IsNegativeInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bool4 IsNegativeInfinity(double v) => new bool4(double.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bool4 IsPositiveInfinity(double4 v) => new bool4(double.IsPositiveInfinity(v.x), double.IsPositiveInfinity(v.y), double.IsPositiveInfinity(v.z), double.IsPositiveInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bool4 IsPositiveInfinity(double v) => new bool4(double.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static double4 Abs(double4 v) => new double4(System.Math.Abs(v.x), System.Math.Abs(v.y), System.Math.Abs(v.z), System.Math.Abs(v.w));
        
        /// <summary>
        /// Returns a double from the application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static double4 Abs(double v) => new double4(System.Math.Abs(v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static double4 HermiteInterpolationOrder3(double4 v) => new double4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a double from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static double4 HermiteInterpolationOrder3(double v) => new double4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static double4 HermiteInterpolationOrder5(double4 v) => new double4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a double from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static double4 HermiteInterpolationOrder5(double v) => new double4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static double4 Sqr(double4 v) => new double4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a double from the application of Sqr (v * v).
        /// </summary>
        public static double4 Sqr(double v) => new double4(v * v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static double4 Pow2(double4 v) => new double4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a double from the application of Pow2 (v * v).
        /// </summary>
        public static double4 Pow2(double v) => new double4(v * v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static double4 Pow3(double4 v) => new double4(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a double from the application of Pow3 (v * v * v).
        /// </summary>
        public static double4 Pow3(double v) => new double4(v * v * v);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static double4 Step(double4 v) => new double4(v.x >= 0.0 ? 1.0 : 0.0, v.y >= 0.0 ? 1.0 : 0.0, v.z >= 0.0 ? 1.0 : 0.0, v.w >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a double from the application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static double4 Step(double v) => new double4(v >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sqrt ((double)System.Math.Sqrt((double)v)).
        /// </summary>
        public static double4 Sqrt(double4 v) => new double4((double)System.Math.Sqrt((double)v.x), (double)System.Math.Sqrt((double)v.y), (double)System.Math.Sqrt((double)v.z), (double)System.Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Sqrt ((double)System.Math.Sqrt((double)v)).
        /// </summary>
        public static double4 Sqrt(double v) => new double4((double)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of InverseSqrt ((double)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static double4 InverseSqrt(double4 v) => new double4((double)(1.0 / System.Math.Sqrt((double)v.x)), (double)(1.0 / System.Math.Sqrt((double)v.y)), (double)(1.0 / System.Math.Sqrt((double)v.z)), (double)(1.0 / System.Math.Sqrt((double)v.w)));
        
        /// <summary>
        /// Returns a double from the application of InverseSqrt ((double)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static double4 InverseSqrt(double v) => new double4((double)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int4 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int4 Sign(double4 v) => new int4(System.Math.Sign(v.x), System.Math.Sign(v.y), System.Math.Sign(v.z), System.Math.Sign(v.w));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int4 Sign(double v) => new int4(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static double4 Max(double4 lhs, double4 rhs) => new double4(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y), System.Math.Max(lhs.z, rhs.z), System.Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static double4 Max(double4 lhs, double rhs) => new double4(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs), System.Math.Max(lhs.z, rhs), System.Math.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static double4 Max(double lhs, double4 rhs) => new double4(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y), System.Math.Max(lhs, rhs.z), System.Math.Max(lhs, rhs.w));
        
        /// <summary>
        /// Returns a double from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static double4 Max(double lhs, double rhs) => new double4(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static double4 Min(double4 lhs, double4 rhs) => new double4(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y), System.Math.Min(lhs.z, rhs.z), System.Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static double4 Min(double4 lhs, double rhs) => new double4(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs), System.Math.Min(lhs.z, rhs), System.Math.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static double4 Min(double lhs, double4 rhs) => new double4(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y), System.Math.Min(lhs, rhs.z), System.Math.Min(lhs, rhs.w));
        
        /// <summary>
        /// Returns a double from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static double4 Min(double lhs, double rhs) => new double4(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Pow ((double)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double4 Pow(double4 lhs, double4 rhs) => new double4((double)System.Math.Pow((double)lhs.x, (double)rhs.x), (double)System.Math.Pow((double)lhs.y, (double)rhs.y), (double)System.Math.Pow((double)lhs.z, (double)rhs.z), (double)System.Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Pow ((double)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double4 Pow(double4 lhs, double rhs) => new double4((double)System.Math.Pow((double)lhs.x, (double)rhs), (double)System.Math.Pow((double)lhs.y, (double)rhs), (double)System.Math.Pow((double)lhs.z, (double)rhs), (double)System.Math.Pow((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Pow ((double)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double4 Pow(double lhs, double4 rhs) => new double4((double)System.Math.Pow((double)lhs, (double)rhs.x), (double)System.Math.Pow((double)lhs, (double)rhs.y), (double)System.Math.Pow((double)lhs, (double)rhs.z), (double)System.Math.Pow((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a double from the application of Pow ((double)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double4 Pow(double lhs, double rhs) => new double4((double)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Log ((double)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double4 Log(double4 lhs, double4 rhs) => new double4((double)System.Math.Log((double)lhs.x, (double)rhs.x), (double)System.Math.Log((double)lhs.y, (double)rhs.y), (double)System.Math.Log((double)lhs.z, (double)rhs.z), (double)System.Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Log ((double)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double4 Log(double4 lhs, double rhs) => new double4((double)System.Math.Log((double)lhs.x, (double)rhs), (double)System.Math.Log((double)lhs.y, (double)rhs), (double)System.Math.Log((double)lhs.z, (double)rhs), (double)System.Math.Log((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Log ((double)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double4 Log(double lhs, double4 rhs) => new double4((double)System.Math.Log((double)lhs, (double)rhs.x), (double)System.Math.Log((double)lhs, (double)rhs.y), (double)System.Math.Log((double)lhs, (double)rhs.z), (double)System.Math.Log((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a double from the application of Log ((double)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double4 Log(double lhs, double rhs) => new double4((double)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double4 Clamp(double4 v, double4 min, double4 max) => new double4(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y), System.Math.Min(System.Math.Max(v.z, min.z), max.z), System.Math.Min(System.Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double4 Clamp(double4 v, double4 min, double max) => new double4(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max), System.Math.Min(System.Math.Max(v.z, min.z), max), System.Math.Min(System.Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double4 Clamp(double4 v, double min, double4 max) => new double4(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y), System.Math.Min(System.Math.Max(v.z, min), max.z), System.Math.Min(System.Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double4 Clamp(double4 v, double min, double max) => new double4(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max), System.Math.Min(System.Math.Max(v.z, min), max), System.Math.Min(System.Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double4 Clamp(double v, double4 min, double4 max) => new double4(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y), System.Math.Min(System.Math.Max(v, min.z), max.z), System.Math.Min(System.Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double4 Clamp(double v, double4 min, double max) => new double4(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max), System.Math.Min(System.Math.Max(v, min.z), max), System.Math.Min(System.Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double4 Clamp(double v, double min, double4 max) => new double4(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y), System.Math.Min(System.Math.Max(v, min), max.z), System.Math.Min(System.Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a double from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double4 Clamp(double v, double min, double max) => new double4(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double4 Mix(double4 min, double4 max, double4 a) => new double4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double4 Mix(double4 min, double4 max, double a) => new double4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double4 Mix(double4 min, double max, double4 a) => new double4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double4 Mix(double4 min, double max, double a) => new double4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double4 Mix(double min, double4 max, double4 a) => new double4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double4 Mix(double min, double4 max, double a) => new double4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double4 Mix(double min, double max, double4 a) => new double4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a double from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double4 Mix(double min, double max, double a) => new double4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double4 Lerp(double4 min, double4 max, double4 a) => new double4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double4 Lerp(double4 min, double4 max, double a) => new double4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double4 Lerp(double4 min, double max, double4 a) => new double4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double4 Lerp(double4 min, double max, double a) => new double4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double4 Lerp(double min, double4 max, double4 a) => new double4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double4 Lerp(double min, double4 max, double a) => new double4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double4 Lerp(double min, double max, double4 a) => new double4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a double from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double4 Lerp(double min, double max, double a) => new double4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double4 Smoothstep(double4 edge0, double4 edge1, double4 v) => new double4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double4 Smoothstep(double4 edge0, double4 edge1, double v) => new double4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double4 Smoothstep(double4 edge0, double edge1, double4 v) => new double4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double4 Smoothstep(double4 edge0, double edge1, double v) => new double4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double4 Smoothstep(double edge0, double4 edge1, double4 v) => new double4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double4 Smoothstep(double edge0, double4 edge1, double v) => new double4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double4 Smoothstep(double edge0, double edge1, double4 v) => new double4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double4 Smoothstep(double edge0, double edge1, double v) => new double4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double4 Smootherstep(double4 edge0, double4 edge1, double4 v) => new double4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double4 Smootherstep(double4 edge0, double4 edge1, double v) => new double4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double4 Smootherstep(double4 edge0, double edge1, double4 v) => new double4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double4 Smootherstep(double4 edge0, double edge1, double v) => new double4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double4 Smootherstep(double edge0, double4 edge1, double4 v) => new double4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double4 Smootherstep(double edge0, double4 edge1, double v) => new double4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double4 Smootherstep(double edge0, double edge1, double4 v) => new double4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double4 Smootherstep(double edge0, double edge1, double v) => new double4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double4 Fma(double4 a, double4 b, double4 c) => new double4(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double4 Fma(double4 a, double4 b, double c) => new double4(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double4 Fma(double4 a, double b, double4 c) => new double4(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double4 Fma(double4 a, double b, double c) => new double4(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double4 Fma(double a, double4 b, double4 c) => new double4(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double4 Fma(double a, double4 b, double c) => new double4(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double4 Fma(double a, double b, double4 c) => new double4(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w);
        
        /// <summary>
        /// Returns a double from the application of Fma (a * b + c).
        /// </summary>
        public static double4 Fma(double a, double b, double c) => new double4(a * b + c);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static double4 Add(double4 lhs, double4 rhs) => new double4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static double4 Add(double4 lhs, double rhs) => new double4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static double4 Add(double lhs, double4 rhs) => new double4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a double from the application of Add (lhs + rhs).
        /// </summary>
        public static double4 Add(double lhs, double rhs) => new double4(lhs + rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static double4 Sub(double4 lhs, double4 rhs) => new double4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static double4 Sub(double4 lhs, double rhs) => new double4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static double4 Sub(double lhs, double4 rhs) => new double4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a double from the application of Sub (lhs - rhs).
        /// </summary>
        public static double4 Sub(double lhs, double rhs) => new double4(lhs - rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static double4 Mul(double4 lhs, double4 rhs) => new double4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static double4 Mul(double4 lhs, double rhs) => new double4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static double4 Mul(double lhs, double4 rhs) => new double4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a double from the application of Mul (lhs * rhs).
        /// </summary>
        public static double4 Mul(double lhs, double rhs) => new double4(lhs * rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static double4 Div(double4 lhs, double4 rhs) => new double4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static double4 Div(double4 lhs, double rhs) => new double4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static double4 Div(double lhs, double4 rhs) => new double4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a double from the application of Div (lhs / rhs).
        /// </summary>
        public static double4 Div(double lhs, double rhs) => new double4(lhs / rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static double4 Modulo(double4 lhs, double4 rhs) => new double4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static double4 Modulo(double4 lhs, double rhs) => new double4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static double4 Modulo(double lhs, double4 rhs) => new double4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);
        
        /// <summary>
        /// Returns a double from the application of Modulo (lhs % rhs).
        /// </summary>
        public static double4 Modulo(double lhs, double rhs) => new double4(lhs % rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static double4 Degrees(double4 v) => new double4((double)(v.x * 57.295779513082320876798154814105170332405472466564321d), (double)(v.y * 57.295779513082320876798154814105170332405472466564321d), (double)(v.z * 57.295779513082320876798154814105170332405472466564321d), (double)(v.w * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a double from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static double4 Degrees(double v) => new double4((double)(v * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static double4 Radians(double4 v) => new double4((double)(v.x * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.y * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.z * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.w * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a double from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static double4 Radians(double v) => new double4((double)(v * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Acos ((double)System.Math.Acos((double)v)).
        /// </summary>
        public static double4 Acos(double4 v) => new double4((double)System.Math.Acos((double)v.x), (double)System.Math.Acos((double)v.y), (double)System.Math.Acos((double)v.z), (double)System.Math.Acos((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Acos ((double)System.Math.Acos((double)v)).
        /// </summary>
        public static double4 Acos(double v) => new double4((double)System.Math.Acos((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Asin ((double)System.Math.Asin((double)v)).
        /// </summary>
        public static double4 Asin(double4 v) => new double4((double)System.Math.Asin((double)v.x), (double)System.Math.Asin((double)v.y), (double)System.Math.Asin((double)v.z), (double)System.Math.Asin((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Asin ((double)System.Math.Asin((double)v)).
        /// </summary>
        public static double4 Asin(double v) => new double4((double)System.Math.Asin((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Atan ((double)System.Math.Atan((double)v)).
        /// </summary>
        public static double4 Atan(double4 v) => new double4((double)System.Math.Atan((double)v.x), (double)System.Math.Atan((double)v.y), (double)System.Math.Atan((double)v.z), (double)System.Math.Atan((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Atan ((double)System.Math.Atan((double)v)).
        /// </summary>
        public static double4 Atan(double v) => new double4((double)System.Math.Atan((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Cos ((double)System.Math.Cos((double)v)).
        /// </summary>
        public static double4 Cos(double4 v) => new double4((double)System.Math.Cos((double)v.x), (double)System.Math.Cos((double)v.y), (double)System.Math.Cos((double)v.z), (double)System.Math.Cos((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Cos ((double)System.Math.Cos((double)v)).
        /// </summary>
        public static double4 Cos(double v) => new double4((double)System.Math.Cos((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Cosh ((double)System.Math.Cosh((double)v)).
        /// </summary>
        public static double4 Cosh(double4 v) => new double4((double)System.Math.Cosh((double)v.x), (double)System.Math.Cosh((double)v.y), (double)System.Math.Cosh((double)v.z), (double)System.Math.Cosh((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Cosh ((double)System.Math.Cosh((double)v)).
        /// </summary>
        public static double4 Cosh(double v) => new double4((double)System.Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Exp ((double)System.Math.Exp((double)v)).
        /// </summary>
        public static double4 Exp(double4 v) => new double4((double)System.Math.Exp((double)v.x), (double)System.Math.Exp((double)v.y), (double)System.Math.Exp((double)v.z), (double)System.Math.Exp((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Exp ((double)System.Math.Exp((double)v)).
        /// </summary>
        public static double4 Exp(double v) => new double4((double)System.Math.Exp((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Log ((double)System.Math.Log((double)v)).
        /// </summary>
        public static double4 Log(double4 v) => new double4((double)System.Math.Log((double)v.x), (double)System.Math.Log((double)v.y), (double)System.Math.Log((double)v.z), (double)System.Math.Log((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Log ((double)System.Math.Log((double)v)).
        /// </summary>
        public static double4 Log(double v) => new double4((double)System.Math.Log((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Log2 ((double)System.Math.Log((double)v, 2)).
        /// </summary>
        public static double4 Log2(double4 v) => new double4((double)System.Math.Log((double)v.x, 2), (double)System.Math.Log((double)v.y, 2), (double)System.Math.Log((double)v.z, 2), (double)System.Math.Log((double)v.w, 2));
        
        /// <summary>
        /// Returns a double from the application of Log2 ((double)System.Math.Log((double)v, 2)).
        /// </summary>
        public static double4 Log2(double v) => new double4((double)System.Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Log10 ((double)System.Math.Log10((double)v)).
        /// </summary>
        public static double4 Log10(double4 v) => new double4((double)System.Math.Log10((double)v.x), (double)System.Math.Log10((double)v.y), (double)System.Math.Log10((double)v.z), (double)System.Math.Log10((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Log10 ((double)System.Math.Log10((double)v)).
        /// </summary>
        public static double4 Log10(double v) => new double4((double)System.Math.Log10((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Floor ((double)System.Math.Floor(v)).
        /// </summary>
        public static double4 Floor(double4 v) => new double4((double)System.Math.Floor(v.x), (double)System.Math.Floor(v.y), (double)System.Math.Floor(v.z), (double)System.Math.Floor(v.w));
        
        /// <summary>
        /// Returns a double from the application of Floor ((double)System.Math.Floor(v)).
        /// </summary>
        public static double4 Floor(double v) => new double4((double)System.Math.Floor(v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Ceiling ((double)System.Math.Ceiling(v)).
        /// </summary>
        public static double4 Ceiling(double4 v) => new double4((double)System.Math.Ceiling(v.x), (double)System.Math.Ceiling(v.y), (double)System.Math.Ceiling(v.z), (double)System.Math.Ceiling(v.w));
        
        /// <summary>
        /// Returns a double from the application of Ceiling ((double)System.Math.Ceiling(v)).
        /// </summary>
        public static double4 Ceiling(double v) => new double4((double)System.Math.Ceiling(v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Round ((double)System.Math.Round(v)).
        /// </summary>
        public static double4 Round(double4 v) => new double4((double)System.Math.Round(v.x), (double)System.Math.Round(v.y), (double)System.Math.Round(v.z), (double)System.Math.Round(v.w));
        
        /// <summary>
        /// Returns a double from the application of Round ((double)System.Math.Round(v)).
        /// </summary>
        public static double4 Round(double v) => new double4((double)System.Math.Round(v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sin ((double)System.Math.Sin((double)v)).
        /// </summary>
        public static double4 Sin(double4 v) => new double4((double)System.Math.Sin((double)v.x), (double)System.Math.Sin((double)v.y), (double)System.Math.Sin((double)v.z), (double)System.Math.Sin((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Sin ((double)System.Math.Sin((double)v)).
        /// </summary>
        public static double4 Sin(double v) => new double4((double)System.Math.Sin((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Sinh ((double)System.Math.Sinh((double)v)).
        /// </summary>
        public static double4 Sinh(double4 v) => new double4((double)System.Math.Sinh((double)v.x), (double)System.Math.Sinh((double)v.y), (double)System.Math.Sinh((double)v.z), (double)System.Math.Sinh((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Sinh ((double)System.Math.Sinh((double)v)).
        /// </summary>
        public static double4 Sinh(double v) => new double4((double)System.Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Tan ((double)System.Math.Tan((double)v)).
        /// </summary>
        public static double4 Tan(double4 v) => new double4((double)System.Math.Tan((double)v.x), (double)System.Math.Tan((double)v.y), (double)System.Math.Tan((double)v.z), (double)System.Math.Tan((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Tan ((double)System.Math.Tan((double)v)).
        /// </summary>
        public static double4 Tan(double v) => new double4((double)System.Math.Tan((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Tanh ((double)System.Math.Tanh((double)v)).
        /// </summary>
        public static double4 Tanh(double4 v) => new double4((double)System.Math.Tanh((double)v.x), (double)System.Math.Tanh((double)v.y), (double)System.Math.Tanh((double)v.z), (double)System.Math.Tanh((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Tanh ((double)System.Math.Tanh((double)v)).
        /// </summary>
        public static double4 Tanh(double v) => new double4((double)System.Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Truncate ((double)System.Math.Truncate((double)v)).
        /// </summary>
        public static double4 Truncate(double4 v) => new double4((double)System.Math.Truncate((double)v.x), (double)System.Math.Truncate((double)v.y), (double)System.Math.Truncate((double)v.z), (double)System.Math.Truncate((double)v.w));
        
        /// <summary>
        /// Returns a double from the application of Truncate ((double)System.Math.Truncate((double)v)).
        /// </summary>
        public static double4 Truncate(double v) => new double4((double)System.Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Fract ((double)(v - System.Math.Floor(v))).
        /// </summary>
        public static double4 Fract(double4 v) => new double4((double)(v.x - System.Math.Floor(v.x)), (double)(v.y - System.Math.Floor(v.y)), (double)(v.z - System.Math.Floor(v.z)), (double)(v.w - System.Math.Floor(v.w)));
        
        /// <summary>
        /// Returns a double from the application of Fract ((double)(v - System.Math.Floor(v))).
        /// </summary>
        public static double4 Fract(double v) => new double4((double)(v - System.Math.Floor(v)));
        
        /// <summary>
        /// Returns a double4 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static double4 Trunc(double4 v) => new double4((long)(v.x), (long)(v.y), (long)(v.z), (long)(v.w));
        
        /// <summary>
        /// Returns a double from the application of Trunc ((long)(v)).
        /// </summary>
        public static double4 Trunc(double v) => new double4((long)(v));
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double4 Random(Random random, double4 minValue, double4 maxValue) => new double4((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double4 Random(Random random, double4 minValue, double maxValue) => new double4((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double4 Random(Random random, double minValue, double4 maxValue) => new double4((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue, (double)random.NextDouble() * (maxValue.z - minValue) + minValue, (double)random.NextDouble() * (maxValue.w - minValue) + minValue);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double4 Random(Random random, double minValue, double maxValue) => new double4((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double4 RandomUniform(Random random, double4 minValue, double4 maxValue) => new double4((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double4 RandomUniform(Random random, double4 minValue, double maxValue) => new double4((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (double)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (double)random.NextDouble() * (maxValue - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double4 RandomUniform(Random random, double minValue, double4 maxValue) => new double4((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue, (double)random.NextDouble() * (maxValue.z - minValue) + minValue, (double)random.NextDouble() * (maxValue.w - minValue) + minValue);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double4 RandomUniform(Random random, double minValue, double maxValue) => new double4((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double4 RandomNormal(Random random, double4 mean, double4 variance) => new double4((double)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (double)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (double)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z, (double)(System.Math.Sqrt((double)variance.w) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double4 RandomNormal(Random random, double4 mean, double variance) => new double4((double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z, (double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double4 RandomNormal(Random random, double mean, double4 variance) => new double4((double)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (double)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (double)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (double)(System.Math.Sqrt((double)variance.w) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double4 RandomNormal(Random random, double mean, double variance) => new double4((double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double4 RandomGaussian(Random random, double4 mean, double4 variance) => new double4((double)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (double)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (double)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z, (double)(System.Math.Sqrt((double)variance.w) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double4 RandomGaussian(Random random, double4 mean, double variance) => new double4((double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z, (double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double4 RandomGaussian(Random random, double mean, double4 variance) => new double4((double)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (double)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (double)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (double)(System.Math.Sqrt((double)variance.w) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a double4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double4 RandomGaussian(Random random, double mean, double variance) => new double4((double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(double4 lhs, double4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(double4 lhs, double rhs) => new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(double lhs, double4 rhs) => new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(double4 lhs, double4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(double4 lhs, double rhs) => new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(double lhs, double4 rhs) => new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(double4 lhs, double4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(double4 lhs, double rhs) => new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(double lhs, double4 rhs) => new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(double4 lhs, double4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(double4 lhs, double rhs) => new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(double lhs, double4 rhs) => new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double4 operator+(double4 lhs, double4 rhs) => new double4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double4 operator+(double4 lhs, double rhs) => new double4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double4 operator+(double lhs, double4 rhs) => new double4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double4 operator-(double4 lhs, double4 rhs) => new double4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double4 operator-(double4 lhs, double rhs) => new double4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double4 operator-(double lhs, double4 rhs) => new double4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double4 operator*(double4 lhs, double4 rhs) => new double4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double4 operator*(double4 lhs, double rhs) => new double4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double4 operator*(double lhs, double4 rhs) => new double4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double4 operator/(double4 lhs, double4 rhs) => new double4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double4 operator/(double4 lhs, double rhs) => new double4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double4 operator/(double lhs, double4 rhs) => new double4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator+ (identity).
        /// </summary>
        public static double4 operator+(double4 v) => v;
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator- (-v).
        /// </summary>
        public static double4 operator-(double4 v) => new double4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static double4 operator%(double4 lhs, double4 rhs) => new double4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static double4 operator%(double4 lhs, double rhs) => new double4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a double4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static double4 operator%(double lhs, double4 rhs) => new double4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);

        #endregion

    }
}
