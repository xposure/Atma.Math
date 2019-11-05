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
    /// A vector of type float with 4 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct float4 : IReadOnlyList<float>, IEquatable<float4>
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
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public float w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public float4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public float4(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public float4(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0f;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public float4(float2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public float4(float2 v, float z, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public float4(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public float4(float3 v, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public float4(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float4(IReadOnlyList<float> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
            this.z = c < 2 ? 0f : v[2];
            this.w = c < 3 ? 0f : v[3];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float4(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : (float)v[0];
            this.y = c < 1 ? 0f : (float)v[1];
            this.z = c < 2 ? 0f : (float)v[2];
            this.w = c < 3 ? 0f : (float)v[3];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float4(float[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
            this.z = c < 2 ? 0f : v[2];
            this.w = c < 3 ? 0f : v[3];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float4(float[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0f : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0f : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0f : v[2 + startIndex];
            this.w = c + startIndex < 3 ? 0f : v[3 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float4(IEnumerable<float> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a double4.
        /// </summary>
        public static implicit operator double4(float4 v) => new double4((double)v.x, (double)v.y, (double)v.z, (double)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(float4 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int3.
        /// </summary>
        public static explicit operator int3(float4 v) => new int3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a int4.
        /// </summary>
        public static explicit operator int4(float4 v) => new int4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(float4 v) => new uint2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uint3.
        /// </summary>
        public static explicit operator uint3(float4 v) => new uint3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uint4.
        /// </summary>
        public static explicit operator uint4(float4 v) => new uint4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a float2.
        /// </summary>
        public static explicit operator float2(float4 v) => new float2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a float3.
        /// </summary>
        public static explicit operator float3(float4 v) => new float3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a double2.
        /// </summary>
        public static explicit operator double2(float4 v) => new double2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a double3.
        /// </summary>
        public static explicit operator double3(float4 v) => new double3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(float4 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a long3.
        /// </summary>
        public static explicit operator long3(float4 v) => new long3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a long4.
        /// </summary>
        public static explicit operator long4(float4 v) => new long4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(float4 v) => new bool2(v.x != 0f, v.y != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bool3.
        /// </summary>
        public static explicit operator bool3(float4 v) => new bool3(v.x != 0f, v.y != 0f, v.z != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bool4.
        /// </summary>
        public static explicit operator bool4(float4 v) => new bool4(v.x != 0f, v.y != 0f, v.z != 0f, v.w != 0f);
        
        /// <summary>
        /// Explicitly converts this to a float array.
        /// </summary>
        public static explicit operator float[](float4 v) => new [] { v.x, v.y, v.z, v.w };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](float4 v) => new Object[] { v.x, v.y, v.z, v.w };

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
        public swizzle_float4 swizzle => new swizzle_float4(x, y, z, w);
        
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
        public float2 xw
        {
            get
            {
                return new float2(x, w);
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
        public float2 yw
        {
            get
            {
                return new float2(y, w);
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
        public float3 xyw
        {
            get
            {
                return new float3(x, y, w);
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
        public float2 zw
        {
            get
            {
                return new float2(z, w);
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
        public float3 xzw
        {
            get
            {
                return new float3(x, z, w);
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
        public float3 yzw
        {
            get
            {
                return new float3(y, z, w);
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
        public float4 xyzw
        {
            get
            {
                return new float4(x, y, z, w);
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
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public float2 ra
        {
            get
            {
                return new float2(x, w);
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
        public float2 ga
        {
            get
            {
                return new float2(y, w);
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
        public float3 rga
        {
            get
            {
                return new float3(x, y, w);
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
        public float2 ba
        {
            get
            {
                return new float2(z, w);
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
        public float3 rba
        {
            get
            {
                return new float3(x, z, w);
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
        public float3 gba
        {
            get
            {
                return new float3(y, z, w);
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
        public float4 rgba
        {
            get
            {
                return new float4(x, y, z, w);
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
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public float a
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
        public float[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public float MinElement => System.Math.Min(System.Math.Min(x, y), System.Math.Min(z, w));
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public float MaxElement => System.Math.Max(System.Math.Max(x, y), System.Math.Max(z, w));
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)System.Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => ((x*x + y*y) + (z*z + w*w));
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public float Sum => ((x + y) + (z + w));
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)System.Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => ((System.Math.Abs(x) + System.Math.Abs(y)) + (System.Math.Abs(z) + System.Math.Abs(w)));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)System.Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => System.Math.Max(System.Math.Max(System.Math.Abs(x), System.Math.Abs(y)), System.Math.Max(System.Math.Abs(z), System.Math.Abs(w)));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public float4 Normalized => this / (float)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public float4 NormalizedSafe => this == Zero ? Zero : this / (float)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static float4 Zero { get; } = new float4(0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static float4 Ones { get; } = new float4(1f, 1f, 1f, 1f);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static float4 UnitX { get; } = new float4(1f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static float4 UnitY { get; } = new float4(0f, 1f, 0f, 0f);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static float4 UnitZ { get; } = new float4(0f, 0f, 1f, 0f);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static float4 UnitW { get; } = new float4(0f, 0f, 0f, 1f);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static float4 MaxValue { get; } = new float4(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static float4 MinValue { get; } = new float4(float.MinValue, float.MinValue, float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static float4 Epsilon { get; } = new float4(float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static float4 NaN { get; } = new float4(float.NaN, float.NaN, float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static float4 NegativeInfinity { get; } = new float4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static float4 PositiveInfinity { get; } = new float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(float4 lhs, float4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(float4 lhs, float4 rhs) => !lhs.Equals(rhs);

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
        public bool Equals(float4 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is float4 && Equals((float4) obj);
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
        public static float4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static float4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new float4(float.Parse(kvp[0].Trim()), float.Parse(kvp[1].Trim()), float.Parse(kvp[2].Trim()), float.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static float4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new float4(float.Parse(kvp[0].Trim(), provider), float.Parse(kvp[1].Trim(), provider), float.Parse(kvp[2].Trim(), provider), float.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static float4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new float4(float.Parse(kvp[0].Trim(), style), float.Parse(kvp[1].Trim(), style), float.Parse(kvp[2].Trim(), style), float.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static float4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new float4(float.Parse(kvp[0].Trim(), style, provider), float.Parse(kvp[1].Trim(), style, provider), float.Parse(kvp[2].Trim(), style, provider), float.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out float4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out float4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            float x = 0f, y = 0f, z = 0f, w = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), out x) && float.TryParse(kvp[1].Trim(), out y)) && (float.TryParse(kvp[2].Trim(), out z) && float.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new float4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out float4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            float x = 0f, y = 0f, z = 0f, w = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), style, provider, out x) && float.TryParse(kvp[1].Trim(), style, provider, out y)) && (float.TryParse(kvp[2].Trim(), style, provider, out z) && float.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new float4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(float4 lhs, float4 rhs, float eps = 0.1f) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float4x2 OuterProduct(float2 c, float4 r) => new float4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float2x4 OuterProduct(float4 c, float2 r) => new float2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float4x3 OuterProduct(float3 c, float4 r) => new float4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float3x4 OuterProduct(float4 c, float3 r) => new float3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float4x4 OuterProduct(float4 c, float4 r) => new float4x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z, c.x * r.w, c.y * r.w, c.z * r.w, c.w * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(float4 lhs, float4 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(float4 lhs, float4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(float4 lhs, float4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float4 Reflect(float4 I, float4 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float4 Refract(float4 I, float4 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (float)System.Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static float4 FaceForward(float4 N, float4 I, float4 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static float4 Random(Random random) => new float4((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static float4 RandomSigned(Random random) => new float4((float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static float4 RandomNormal(Random random) => new float4((float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(float4 lhs, float4 rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(float4 lhs, float rhs) => new bool4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(float lhs, float4 rhs) => new bool4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(float lhs, float rhs) => new bool4(lhs == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(float4 lhs, float4 rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(float4 lhs, float rhs) => new bool4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(float lhs, float4 rhs) => new bool4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(float lhs, float rhs) => new bool4(lhs != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(float4 lhs, float4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(float4 lhs, float rhs) => new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(float lhs, float4 rhs) => new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(float lhs, float rhs) => new bool4(lhs > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(float4 lhs, float4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(float4 lhs, float rhs) => new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(float lhs, float4 rhs) => new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(float lhs, float rhs) => new bool4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(float4 lhs, float4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(float4 lhs, float rhs) => new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(float lhs, float4 rhs) => new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(float lhs, float rhs) => new bool4(lhs < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(float4 lhs, float4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(float4 lhs, float rhs) => new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(float lhs, float4 rhs) => new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(float lhs, float rhs) => new bool4(lhs <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(float4 v) => new bool4(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z), float.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(float v) => new bool4(float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsFinite(float4 v) => new bool4(!float.IsNaN(v.x) && !float.IsInfinity(v.x), !float.IsNaN(v.y) && !float.IsInfinity(v.y), !float.IsNaN(v.z) && !float.IsInfinity(v.z), !float.IsNaN(v.w) && !float.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsFinite(float v) => new bool4(!float.IsNaN(v) && !float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(float4 v) => new bool4(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z), float.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(float v) => new bool4(float.IsNaN(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool4 IsNegativeInfinity(float4 v) => new bool4(float.IsNegativeInfinity(v.x), float.IsNegativeInfinity(v.y), float.IsNegativeInfinity(v.z), float.IsNegativeInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool4 IsNegativeInfinity(float v) => new bool4(float.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool4 IsPositiveInfinity(float4 v) => new bool4(float.IsPositiveInfinity(v.x), float.IsPositiveInfinity(v.y), float.IsPositiveInfinity(v.z), float.IsPositiveInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool4 IsPositiveInfinity(float v) => new bool4(float.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static float4 Abs(float4 v) => new float4(System.Math.Abs(v.x), System.Math.Abs(v.y), System.Math.Abs(v.z), System.Math.Abs(v.w));
        
        /// <summary>
        /// Returns a float from the application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static float4 Abs(float v) => new float4(System.Math.Abs(v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static float4 HermiteInterpolationOrder3(float4 v) => new float4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a float from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static float4 HermiteInterpolationOrder3(float v) => new float4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static float4 HermiteInterpolationOrder5(float4 v) => new float4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a float from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static float4 HermiteInterpolationOrder5(float v) => new float4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static float4 Sqr(float4 v) => new float4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a float from the application of Sqr (v * v).
        /// </summary>
        public static float4 Sqr(float v) => new float4(v * v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static float4 Pow2(float4 v) => new float4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a float from the application of Pow2 (v * v).
        /// </summary>
        public static float4 Pow2(float v) => new float4(v * v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static float4 Pow3(float4 v) => new float4(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z, v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a float from the application of Pow3 (v * v * v).
        /// </summary>
        public static float4 Pow3(float v) => new float4(v * v * v);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static float4 Step(float4 v) => new float4(v.x >= 0f ? 1f : 0f, v.y >= 0f ? 1f : 0f, v.z >= 0f ? 1f : 0f, v.w >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a float from the application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static float4 Step(float v) => new float4(v >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sqrt ((float)System.Math.Sqrt((double)v)).
        /// </summary>
        public static float4 Sqrt(float4 v) => new float4((float)System.Math.Sqrt((double)v.x), (float)System.Math.Sqrt((double)v.y), (float)System.Math.Sqrt((double)v.z), (float)System.Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Sqrt ((float)System.Math.Sqrt((double)v)).
        /// </summary>
        public static float4 Sqrt(float v) => new float4((float)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of InverseSqrt ((float)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static float4 InverseSqrt(float4 v) => new float4((float)(1.0 / System.Math.Sqrt((double)v.x)), (float)(1.0 / System.Math.Sqrt((double)v.y)), (float)(1.0 / System.Math.Sqrt((double)v.z)), (float)(1.0 / System.Math.Sqrt((double)v.w)));
        
        /// <summary>
        /// Returns a float from the application of InverseSqrt ((float)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static float4 InverseSqrt(float v) => new float4((float)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int4 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int4 Sign(float4 v) => new int4(System.Math.Sign(v.x), System.Math.Sign(v.y), System.Math.Sign(v.z), System.Math.Sign(v.w));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int4 Sign(float v) => new int4(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float4 Max(float4 lhs, float4 rhs) => new float4(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y), System.Math.Max(lhs.z, rhs.z), System.Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float4 Max(float4 lhs, float rhs) => new float4(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs), System.Math.Max(lhs.z, rhs), System.Math.Max(lhs.w, rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float4 Max(float lhs, float4 rhs) => new float4(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y), System.Math.Max(lhs, rhs.z), System.Math.Max(lhs, rhs.w));
        
        /// <summary>
        /// Returns a float from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float4 Max(float lhs, float rhs) => new float4(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float4 Min(float4 lhs, float4 rhs) => new float4(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y), System.Math.Min(lhs.z, rhs.z), System.Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float4 Min(float4 lhs, float rhs) => new float4(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs), System.Math.Min(lhs.z, rhs), System.Math.Min(lhs.w, rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float4 Min(float lhs, float4 rhs) => new float4(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y), System.Math.Min(lhs, rhs.z), System.Math.Min(lhs, rhs.w));
        
        /// <summary>
        /// Returns a float from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float4 Min(float lhs, float rhs) => new float4(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float4 Pow(float4 lhs, float4 rhs) => new float4((float)System.Math.Pow((double)lhs.x, (double)rhs.x), (float)System.Math.Pow((double)lhs.y, (double)rhs.y), (float)System.Math.Pow((double)lhs.z, (double)rhs.z), (float)System.Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float4 Pow(float4 lhs, float rhs) => new float4((float)System.Math.Pow((double)lhs.x, (double)rhs), (float)System.Math.Pow((double)lhs.y, (double)rhs), (float)System.Math.Pow((double)lhs.z, (double)rhs), (float)System.Math.Pow((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float4 Pow(float lhs, float4 rhs) => new float4((float)System.Math.Pow((double)lhs, (double)rhs.x), (float)System.Math.Pow((double)lhs, (double)rhs.y), (float)System.Math.Pow((double)lhs, (double)rhs.z), (float)System.Math.Pow((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a float from the application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float4 Pow(float lhs, float rhs) => new float4((float)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float4 Log(float4 lhs, float4 rhs) => new float4((float)System.Math.Log((double)lhs.x, (double)rhs.x), (float)System.Math.Log((double)lhs.y, (double)rhs.y), (float)System.Math.Log((double)lhs.z, (double)rhs.z), (float)System.Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float4 Log(float4 lhs, float rhs) => new float4((float)System.Math.Log((double)lhs.x, (double)rhs), (float)System.Math.Log((double)lhs.y, (double)rhs), (float)System.Math.Log((double)lhs.z, (double)rhs), (float)System.Math.Log((double)lhs.w, (double)rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float4 Log(float lhs, float4 rhs) => new float4((float)System.Math.Log((double)lhs, (double)rhs.x), (float)System.Math.Log((double)lhs, (double)rhs.y), (float)System.Math.Log((double)lhs, (double)rhs.z), (float)System.Math.Log((double)lhs, (double)rhs.w));
        
        /// <summary>
        /// Returns a float from the application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float4 Log(float lhs, float rhs) => new float4((float)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float4 Clamp(float4 v, float4 min, float4 max) => new float4(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y), System.Math.Min(System.Math.Max(v.z, min.z), max.z), System.Math.Min(System.Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float4 Clamp(float4 v, float4 min, float max) => new float4(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max), System.Math.Min(System.Math.Max(v.z, min.z), max), System.Math.Min(System.Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float4 Clamp(float4 v, float min, float4 max) => new float4(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y), System.Math.Min(System.Math.Max(v.z, min), max.z), System.Math.Min(System.Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float4 Clamp(float4 v, float min, float max) => new float4(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max), System.Math.Min(System.Math.Max(v.z, min), max), System.Math.Min(System.Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float4 Clamp(float v, float4 min, float4 max) => new float4(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y), System.Math.Min(System.Math.Max(v, min.z), max.z), System.Math.Min(System.Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float4 Clamp(float v, float4 min, float max) => new float4(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max), System.Math.Min(System.Math.Max(v, min.z), max), System.Math.Min(System.Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float4 Clamp(float v, float min, float4 max) => new float4(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y), System.Math.Min(System.Math.Max(v, min), max.z), System.Math.Min(System.Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a float from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float4 Clamp(float v, float min, float max) => new float4(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float4 Mix(float4 min, float4 max, float4 a) => new float4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float4 Mix(float4 min, float4 max, float a) => new float4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float4 Mix(float4 min, float max, float4 a) => new float4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float4 Mix(float4 min, float max, float a) => new float4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float4 Mix(float min, float4 max, float4 a) => new float4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float4 Mix(float min, float4 max, float a) => new float4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float4 Mix(float min, float max, float4 a) => new float4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a float from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float4 Mix(float min, float max, float a) => new float4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float4 Lerp(float4 min, float4 max, float4 a) => new float4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float4 Lerp(float4 min, float4 max, float a) => new float4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float4 Lerp(float4 min, float max, float4 a) => new float4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float4 Lerp(float4 min, float max, float a) => new float4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float4 Lerp(float min, float4 max, float4 a) => new float4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float4 Lerp(float min, float4 max, float a) => new float4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float4 Lerp(float min, float max, float4 a) => new float4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a float from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float4 Lerp(float min, float max, float a) => new float4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float4 Smoothstep(float4 edge0, float4 edge1, float4 v) => new float4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float4 Smoothstep(float4 edge0, float4 edge1, float v) => new float4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float4 Smoothstep(float4 edge0, float edge1, float4 v) => new float4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float4 Smoothstep(float4 edge0, float edge1, float v) => new float4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float4 Smoothstep(float edge0, float4 edge1, float4 v) => new float4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float4 Smoothstep(float edge0, float4 edge1, float v) => new float4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float4 Smoothstep(float edge0, float edge1, float4 v) => new float4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float4 Smoothstep(float edge0, float edge1, float v) => new float4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float4 Smootherstep(float4 edge0, float4 edge1, float4 v) => new float4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float4 Smootherstep(float4 edge0, float4 edge1, float v) => new float4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float4 Smootherstep(float4 edge0, float edge1, float4 v) => new float4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float4 Smootherstep(float4 edge0, float edge1, float v) => new float4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float4 Smootherstep(float edge0, float4 edge1, float4 v) => new float4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float4 Smootherstep(float edge0, float4 edge1, float v) => new float4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float4 Smootherstep(float edge0, float edge1, float4 v) => new float4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float4 Smootherstep(float edge0, float edge1, float v) => new float4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float4 Fma(float4 a, float4 b, float4 c) => new float4(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z, a.w * b.w + c.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float4 Fma(float4 a, float4 b, float c) => new float4(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c, a.w * b.w + c);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float4 Fma(float4 a, float b, float4 c) => new float4(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z, a.w * b + c.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float4 Fma(float4 a, float b, float c) => new float4(a.x * b + c, a.y * b + c, a.z * b + c, a.w * b + c);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float4 Fma(float a, float4 b, float4 c) => new float4(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z, a * b.w + c.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float4 Fma(float a, float4 b, float c) => new float4(a * b.x + c, a * b.y + c, a * b.z + c, a * b.w + c);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float4 Fma(float a, float b, float4 c) => new float4(a * b + c.x, a * b + c.y, a * b + c.z, a * b + c.w);
        
        /// <summary>
        /// Returns a float from the application of Fma (a * b + c).
        /// </summary>
        public static float4 Fma(float a, float b, float c) => new float4(a * b + c);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float4 Add(float4 lhs, float4 rhs) => new float4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float4 Add(float4 lhs, float rhs) => new float4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float4 Add(float lhs, float4 rhs) => new float4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a float from the application of Add (lhs + rhs).
        /// </summary>
        public static float4 Add(float lhs, float rhs) => new float4(lhs + rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float4 Sub(float4 lhs, float4 rhs) => new float4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float4 Sub(float4 lhs, float rhs) => new float4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float4 Sub(float lhs, float4 rhs) => new float4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a float from the application of Sub (lhs - rhs).
        /// </summary>
        public static float4 Sub(float lhs, float rhs) => new float4(lhs - rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float4 Mul(float4 lhs, float4 rhs) => new float4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float4 Mul(float4 lhs, float rhs) => new float4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float4 Mul(float lhs, float4 rhs) => new float4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a float from the application of Mul (lhs * rhs).
        /// </summary>
        public static float4 Mul(float lhs, float rhs) => new float4(lhs * rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float4 Div(float4 lhs, float4 rhs) => new float4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float4 Div(float4 lhs, float rhs) => new float4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float4 Div(float lhs, float4 rhs) => new float4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a float from the application of Div (lhs / rhs).
        /// </summary>
        public static float4 Div(float lhs, float rhs) => new float4(lhs / rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float4 Modulo(float4 lhs, float4 rhs) => new float4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float4 Modulo(float4 lhs, float rhs) => new float4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float4 Modulo(float lhs, float4 rhs) => new float4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);
        
        /// <summary>
        /// Returns a float from the application of Modulo (lhs % rhs).
        /// </summary>
        public static float4 Modulo(float lhs, float rhs) => new float4(lhs % rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static float4 Degrees(float4 v) => new float4((float)(v.x * 57.295779513082320876798154814105170332405472466564321f), (float)(v.y * 57.295779513082320876798154814105170332405472466564321f), (float)(v.z * 57.295779513082320876798154814105170332405472466564321f), (float)(v.w * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a float from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static float4 Degrees(float v) => new float4((float)(v * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static float4 Radians(float4 v) => new float4((float)(v.x * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.y * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.z * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.w * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a float from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static float4 Radians(float v) => new float4((float)(v * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Acos ((float)System.Math.Acos((double)v)).
        /// </summary>
        public static float4 Acos(float4 v) => new float4((float)System.Math.Acos((double)v.x), (float)System.Math.Acos((double)v.y), (float)System.Math.Acos((double)v.z), (float)System.Math.Acos((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Acos ((float)System.Math.Acos((double)v)).
        /// </summary>
        public static float4 Acos(float v) => new float4((float)System.Math.Acos((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Asin ((float)System.Math.Asin((double)v)).
        /// </summary>
        public static float4 Asin(float4 v) => new float4((float)System.Math.Asin((double)v.x), (float)System.Math.Asin((double)v.y), (float)System.Math.Asin((double)v.z), (float)System.Math.Asin((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Asin ((float)System.Math.Asin((double)v)).
        /// </summary>
        public static float4 Asin(float v) => new float4((float)System.Math.Asin((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Atan ((float)System.Math.Atan((double)v)).
        /// </summary>
        public static float4 Atan(float4 v) => new float4((float)System.Math.Atan((double)v.x), (float)System.Math.Atan((double)v.y), (float)System.Math.Atan((double)v.z), (float)System.Math.Atan((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Atan ((float)System.Math.Atan((double)v)).
        /// </summary>
        public static float4 Atan(float v) => new float4((float)System.Math.Atan((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Cos ((float)System.Math.Cos((double)v)).
        /// </summary>
        public static float4 Cos(float4 v) => new float4((float)System.Math.Cos((double)v.x), (float)System.Math.Cos((double)v.y), (float)System.Math.Cos((double)v.z), (float)System.Math.Cos((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Cos ((float)System.Math.Cos((double)v)).
        /// </summary>
        public static float4 Cos(float v) => new float4((float)System.Math.Cos((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Cosh ((float)System.Math.Cosh((double)v)).
        /// </summary>
        public static float4 Cosh(float4 v) => new float4((float)System.Math.Cosh((double)v.x), (float)System.Math.Cosh((double)v.y), (float)System.Math.Cosh((double)v.z), (float)System.Math.Cosh((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Cosh ((float)System.Math.Cosh((double)v)).
        /// </summary>
        public static float4 Cosh(float v) => new float4((float)System.Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Exp ((float)System.Math.Exp((double)v)).
        /// </summary>
        public static float4 Exp(float4 v) => new float4((float)System.Math.Exp((double)v.x), (float)System.Math.Exp((double)v.y), (float)System.Math.Exp((double)v.z), (float)System.Math.Exp((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Exp ((float)System.Math.Exp((double)v)).
        /// </summary>
        public static float4 Exp(float v) => new float4((float)System.Math.Exp((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log ((float)System.Math.Log((double)v)).
        /// </summary>
        public static float4 Log(float4 v) => new float4((float)System.Math.Log((double)v.x), (float)System.Math.Log((double)v.y), (float)System.Math.Log((double)v.z), (float)System.Math.Log((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Log ((float)System.Math.Log((double)v)).
        /// </summary>
        public static float4 Log(float v) => new float4((float)System.Math.Log((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log2 ((float)System.Math.Log((double)v, 2)).
        /// </summary>
        public static float4 Log2(float4 v) => new float4((float)System.Math.Log((double)v.x, 2), (float)System.Math.Log((double)v.y, 2), (float)System.Math.Log((double)v.z, 2), (float)System.Math.Log((double)v.w, 2));
        
        /// <summary>
        /// Returns a float from the application of Log2 ((float)System.Math.Log((double)v, 2)).
        /// </summary>
        public static float4 Log2(float v) => new float4((float)System.Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Log10 ((float)System.Math.Log10((double)v)).
        /// </summary>
        public static float4 Log10(float4 v) => new float4((float)System.Math.Log10((double)v.x), (float)System.Math.Log10((double)v.y), (float)System.Math.Log10((double)v.z), (float)System.Math.Log10((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Log10 ((float)System.Math.Log10((double)v)).
        /// </summary>
        public static float4 Log10(float v) => new float4((float)System.Math.Log10((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Floor ((float)System.Math.Floor(v)).
        /// </summary>
        public static float4 Floor(float4 v) => new float4((float)System.Math.Floor(v.x), (float)System.Math.Floor(v.y), (float)System.Math.Floor(v.z), (float)System.Math.Floor(v.w));
        
        /// <summary>
        /// Returns a float from the application of Floor ((float)System.Math.Floor(v)).
        /// </summary>
        public static float4 Floor(float v) => new float4((float)System.Math.Floor(v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Ceiling ((float)System.Math.Ceiling(v)).
        /// </summary>
        public static float4 Ceiling(float4 v) => new float4((float)System.Math.Ceiling(v.x), (float)System.Math.Ceiling(v.y), (float)System.Math.Ceiling(v.z), (float)System.Math.Ceiling(v.w));
        
        /// <summary>
        /// Returns a float from the application of Ceiling ((float)System.Math.Ceiling(v)).
        /// </summary>
        public static float4 Ceiling(float v) => new float4((float)System.Math.Ceiling(v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Round ((float)System.Math.Round(v)).
        /// </summary>
        public static float4 Round(float4 v) => new float4((float)System.Math.Round(v.x), (float)System.Math.Round(v.y), (float)System.Math.Round(v.z), (float)System.Math.Round(v.w));
        
        /// <summary>
        /// Returns a float from the application of Round ((float)System.Math.Round(v)).
        /// </summary>
        public static float4 Round(float v) => new float4((float)System.Math.Round(v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sin ((float)System.Math.Sin((double)v)).
        /// </summary>
        public static float4 Sin(float4 v) => new float4((float)System.Math.Sin((double)v.x), (float)System.Math.Sin((double)v.y), (float)System.Math.Sin((double)v.z), (float)System.Math.Sin((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Sin ((float)System.Math.Sin((double)v)).
        /// </summary>
        public static float4 Sin(float v) => new float4((float)System.Math.Sin((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Sinh ((float)System.Math.Sinh((double)v)).
        /// </summary>
        public static float4 Sinh(float4 v) => new float4((float)System.Math.Sinh((double)v.x), (float)System.Math.Sinh((double)v.y), (float)System.Math.Sinh((double)v.z), (float)System.Math.Sinh((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Sinh ((float)System.Math.Sinh((double)v)).
        /// </summary>
        public static float4 Sinh(float v) => new float4((float)System.Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Tan ((float)System.Math.Tan((double)v)).
        /// </summary>
        public static float4 Tan(float4 v) => new float4((float)System.Math.Tan((double)v.x), (float)System.Math.Tan((double)v.y), (float)System.Math.Tan((double)v.z), (float)System.Math.Tan((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Tan ((float)System.Math.Tan((double)v)).
        /// </summary>
        public static float4 Tan(float v) => new float4((float)System.Math.Tan((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Tanh ((float)System.Math.Tanh((double)v)).
        /// </summary>
        public static float4 Tanh(float4 v) => new float4((float)System.Math.Tanh((double)v.x), (float)System.Math.Tanh((double)v.y), (float)System.Math.Tanh((double)v.z), (float)System.Math.Tanh((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Tanh ((float)System.Math.Tanh((double)v)).
        /// </summary>
        public static float4 Tanh(float v) => new float4((float)System.Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Truncate ((float)System.Math.Truncate((double)v)).
        /// </summary>
        public static float4 Truncate(float4 v) => new float4((float)System.Math.Truncate((double)v.x), (float)System.Math.Truncate((double)v.y), (float)System.Math.Truncate((double)v.z), (float)System.Math.Truncate((double)v.w));
        
        /// <summary>
        /// Returns a float from the application of Truncate ((float)System.Math.Truncate((double)v)).
        /// </summary>
        public static float4 Truncate(float v) => new float4((float)System.Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Fract ((float)(v - System.Math.Floor(v))).
        /// </summary>
        public static float4 Fract(float4 v) => new float4((float)(v.x - System.Math.Floor(v.x)), (float)(v.y - System.Math.Floor(v.y)), (float)(v.z - System.Math.Floor(v.z)), (float)(v.w - System.Math.Floor(v.w)));
        
        /// <summary>
        /// Returns a float from the application of Fract ((float)(v - System.Math.Floor(v))).
        /// </summary>
        public static float4 Fract(float v) => new float4((float)(v - System.Math.Floor(v)));
        
        /// <summary>
        /// Returns a float4 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static float4 Trunc(float4 v) => new float4((long)(v.x), (long)(v.y), (long)(v.z), (long)(v.w));
        
        /// <summary>
        /// Returns a float from the application of Trunc ((long)(v)).
        /// </summary>
        public static float4 Trunc(float v) => new float4((long)(v));
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float4 Random(Random random, float4 minValue, float4 maxValue) => new float4((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (float)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float4 Random(Random random, float4 minValue, float maxValue) => new float4((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (float)random.NextDouble() * (maxValue - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float4 Random(Random random, float minValue, float4 maxValue) => new float4((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue, (float)random.NextDouble() * (maxValue.z - minValue) + minValue, (float)random.NextDouble() * (maxValue.w - minValue) + minValue);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float4 Random(Random random, float minValue, float maxValue) => new float4((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float4 RandomUniform(Random random, float4 minValue, float4 maxValue) => new float4((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z, (float)random.NextDouble() * (maxValue.w - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float4 RandomUniform(Random random, float4 minValue, float maxValue) => new float4((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue - minValue.z) + minValue.z, (float)random.NextDouble() * (maxValue - minValue.w) + minValue.w);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float4 RandomUniform(Random random, float minValue, float4 maxValue) => new float4((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue, (float)random.NextDouble() * (maxValue.z - minValue) + minValue, (float)random.NextDouble() * (maxValue.w - minValue) + minValue);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float4 RandomUniform(Random random, float minValue, float maxValue) => new float4((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float4 RandomNormal(Random random, float4 mean, float4 variance) => new float4((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (float)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z, (float)(System.Math.Sqrt((double)variance.w) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float4 RandomNormal(Random random, float4 mean, float variance) => new float4((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float4 RandomNormal(Random random, float mean, float4 variance) => new float4((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.w) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float4 RandomNormal(Random random, float mean, float variance) => new float4((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float4 RandomGaussian(Random random, float4 mean, float4 variance) => new float4((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (float)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z, (float)(System.Math.Sqrt((double)variance.w) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float4 RandomGaussian(Random random, float4 mean, float variance) => new float4((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.z, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.w);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float4 RandomGaussian(Random random, float mean, float4 variance) => new float4((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.z) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.w) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float4 RandomGaussian(Random random, float mean, float variance) => new float4((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(float4 lhs, float4 rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(float4 lhs, float rhs) => new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(float lhs, float4 rhs) => new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(float4 lhs, float4 rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(float4 lhs, float rhs) => new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(float lhs, float4 rhs) => new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(float4 lhs, float4 rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(float4 lhs, float rhs) => new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(float lhs, float4 rhs) => new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(float4 lhs, float4 rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(float4 lhs, float rhs) => new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(float lhs, float4 rhs) => new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float4 operator+(float4 lhs, float4 rhs) => new float4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float4 operator+(float4 lhs, float rhs) => new float4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float4 operator+(float lhs, float4 rhs) => new float4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float4 operator-(float4 lhs, float4 rhs) => new float4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float4 operator-(float4 lhs, float rhs) => new float4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float4 operator-(float lhs, float4 rhs) => new float4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float4 operator*(float4 lhs, float4 rhs) => new float4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float4 operator*(float4 lhs, float rhs) => new float4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float4 operator*(float lhs, float4 rhs) => new float4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float4 operator/(float4 lhs, float4 rhs) => new float4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float4 operator/(float4 lhs, float rhs) => new float4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float4 operator/(float lhs, float4 rhs) => new float4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator+ (identity).
        /// </summary>
        public static float4 operator+(float4 v) => v;
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator- (-v).
        /// </summary>
        public static float4 operator-(float4 v) => new float4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float4 operator%(float4 lhs, float4 rhs) => new float4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float4 operator%(float4 lhs, float rhs) => new float4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Returns a float4 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float4 operator%(float lhs, float4 rhs) => new float4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);

        #endregion

    }
}
