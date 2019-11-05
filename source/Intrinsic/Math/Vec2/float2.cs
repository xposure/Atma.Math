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
    /// A vector of type float with 2 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct float2 : IReadOnlyList<float>, IEquatable<float2>
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public float2(float v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public float2(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public float2(float3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public float2(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float2(IReadOnlyList<float> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float2(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : (float)v[0];
            this.y = c < 1 ? 0f : (float)v[1];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float2(float[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float2(float[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0f : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0f : v[1 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public float2(IEnumerable<float> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a double2.
        /// </summary>
        public static implicit operator double2(float2 v) => new double2((double)v.x, (double)v.y);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(float2 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int3(float2 v) => new int3((int)v.x, (int)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a int4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int4(float2 v) => new int4((int)v.x, (int)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(float2 v) => new uint2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uint3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint3(float2 v) => new uint3((uint)v.x, (uint)v.y, 0u);
        
        /// <summary>
        /// Explicitly converts this to a uint4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint4(float2 v) => new uint4((uint)v.x, (uint)v.y, 0u, 0u);
        
        /// <summary>
        /// Explicitly converts this to a float3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float3(float2 v) => new float3((float)v.x, (float)v.y, 0f);
        
        /// <summary>
        /// Explicitly converts this to a float4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float4(float2 v) => new float4((float)v.x, (float)v.y, 0f, 0f);
        
        /// <summary>
        /// Explicitly converts this to a double3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double3(float2 v) => new double3((double)v.x, (double)v.y, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a double4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double4(float2 v) => new double4((double)v.x, (double)v.y, 0.0, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(float2 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a long3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long3(float2 v) => new long3((long)v.x, (long)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a long4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long4(float2 v) => new long4((long)v.x, (long)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(float2 v) => new bool2(v.x != 0f, v.y != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bool3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool3(float2 v) => new bool3(v.x != 0f, v.y != 0f, false);
        
        /// <summary>
        /// Explicitly converts this to a bool4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool4(float2 v) => new bool4(v.x != 0f, v.y != 0f, false, false);
        
        /// <summary>
        /// Explicitly converts this to a float array.
        /// </summary>
        public static explicit operator float[](float2 v) => new [] { v.x, v.y };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](float2 v) => new Object[] { v.x, v.y };

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
        public swizzle_float2 swizzle => new swizzle_float2(x, y);
        
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
        /// Returns an array with all values
        /// </summary>
        public float[] Values => new[] { x, y };
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public float MinElement => System.Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public float MaxElement => System.Math.Max(x, y);
        
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
        public float Sum => (x + y);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)System.Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => (System.Math.Abs(x) + System.Math.Abs(y));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)System.Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => System.Math.Max(System.Math.Abs(x), System.Math.Abs(y));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public float2 Normalized => this / (float)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public float2 NormalizedSafe => this == Zero ? Zero : this / (float)Length;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public double Angle => System.Math.Atan2((double)y, (double)x);
        
        /// <summary>
        /// Returns a perpendicular vector.
        /// </summary>
        public float2 Perpendicular => new float2(y, -x);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static float2 Zero { get; } = new float2(0f, 0f);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static float2 Ones { get; } = new float2(1f, 1f);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static float2 UnitX { get; } = new float2(1f, 0f);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static float2 UnitY { get; } = new float2(0f, 1f);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static float2 MaxValue { get; } = new float2(float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static float2 MinValue { get; } = new float2(float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static float2 Epsilon { get; } = new float2(float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static float2 NaN { get; } = new float2(float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static float2 NegativeInfinity { get; } = new float2(float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static float2 PositiveInfinity { get; } = new float2(float.PositiveInfinity, float.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(float2 lhs, float2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(float2 lhs, float2 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<float> GetEnumerator()
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
        public bool Equals(float2 rhs) => (x.Equals(rhs.x) && y.Equals(rhs.y));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is float2 && Equals((float2) obj);
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
        public double NormP(double p) => System.Math.Pow((System.Math.Pow((double)System.Math.Abs(x), p) + System.Math.Pow((double)System.Math.Abs(y), p)), 1 / p);
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public float2 Rotated(double angleInRad) => (float2)(double2.FromAngle(Angle + angleInRad) * (double)Length);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static float2 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static float2 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new float2(float.Parse(kvp[0].Trim()), float.Parse(kvp[1].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static float2 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new float2(float.Parse(kvp[0].Trim(), provider), float.Parse(kvp[1].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static float2 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new float2(float.Parse(kvp[0].Trim(), style), float.Parse(kvp[1].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static float2 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new float2(float.Parse(kvp[0].Trim(), style, provider), float.Parse(kvp[1].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out float2 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out float2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            float x = 0f, y = 0f;
            var ok = (float.TryParse(kvp[0].Trim(), out x) && float.TryParse(kvp[1].Trim(), out y));
            result = ok ? new float2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out float2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            float x = 0f, y = 0f;
            var ok = (float.TryParse(kvp[0].Trim(), style, provider, out x) && float.TryParse(kvp[1].Trim(), style, provider, out y));
            result = ok ? new float2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(float2 lhs, float2 rhs, float eps = 0.1f) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float2x2 OuterProduct(float2 c, float2 r) => new float2x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float2x3 OuterProduct(float3 c, float2 r) => new float2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float3x2 OuterProduct(float2 c, float3 r) => new float3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float2x4 OuterProduct(float4 c, float2 r) => new float2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static float4x2 OuterProduct(float2 c, float4 r) => new float4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).
        /// </summary>
        public static float2 FromAngle(double angleInRad) => new float2((float)System.Math.Cos(angleInRad), (float)System.Math.Sin(angleInRad));
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(float2 lhs, float2 rhs) => (lhs.x * rhs.x + lhs.y * rhs.y);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(float2 lhs, float2 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(float2 lhs, float2 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float2 Reflect(float2 I, float2 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static float2 Refract(float2 I, float2 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (float)System.Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static float2 FaceForward(float2 N, float2 I, float2 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static float Cross(float2 l, float2 r) => l.x * r.y - l.y * r.x;
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static float2 Random(Random random) => new float2((float)random.NextDouble(), (float)random.NextDouble());
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static float2 RandomSigned(Random random) => new float2((float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static float2 RandomNormal(Random random) => new float2((float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (float)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(float2 lhs, float2 rhs) => new bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(float2 lhs, float rhs) => new bool2(lhs.x == rhs, lhs.y == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(float lhs, float2 rhs) => new bool2(lhs == rhs.x, lhs == rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(float lhs, float rhs) => new bool2(lhs == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(float2 lhs, float2 rhs) => new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(float2 lhs, float rhs) => new bool2(lhs.x != rhs, lhs.y != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(float lhs, float2 rhs) => new bool2(lhs != rhs.x, lhs != rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(float lhs, float rhs) => new bool2(lhs != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(float2 lhs, float2 rhs) => new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(float2 lhs, float rhs) => new bool2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(float lhs, float2 rhs) => new bool2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(float lhs, float rhs) => new bool2(lhs > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(float2 lhs, float2 rhs) => new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(float2 lhs, float rhs) => new bool2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(float lhs, float2 rhs) => new bool2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(float lhs, float rhs) => new bool2(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(float2 lhs, float2 rhs) => new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(float2 lhs, float rhs) => new bool2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(float lhs, float2 rhs) => new bool2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(float lhs, float rhs) => new bool2(lhs < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(float2 lhs, float2 rhs) => new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(float2 lhs, float rhs) => new bool2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(float lhs, float2 rhs) => new bool2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(float lhs, float rhs) => new bool2(lhs <= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool2 IsInfinity(float2 v) => new bool2(float.IsInfinity(v.x), float.IsInfinity(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool2 IsInfinity(float v) => new bool2(float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool2 IsFinite(float2 v) => new bool2(!float.IsNaN(v.x) && !float.IsInfinity(v.x), !float.IsNaN(v.y) && !float.IsInfinity(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool2 IsFinite(float v) => new bool2(!float.IsNaN(v) && !float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool2 IsNaN(float2 v) => new bool2(float.IsNaN(v.x), float.IsNaN(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool2 IsNaN(float v) => new bool2(float.IsNaN(v));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool2 IsNegativeInfinity(float2 v) => new bool2(float.IsNegativeInfinity(v.x), float.IsNegativeInfinity(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool2 IsNegativeInfinity(float v) => new bool2(float.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool2 IsPositiveInfinity(float2 v) => new bool2(float.IsPositiveInfinity(v.x), float.IsPositiveInfinity(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool2 IsPositiveInfinity(float v) => new bool2(float.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static float2 Abs(float2 v) => new float2(System.Math.Abs(v.x), System.Math.Abs(v.y));
        
        /// <summary>
        /// Returns a float from the application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static float2 Abs(float v) => new float2(System.Math.Abs(v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static float2 HermiteInterpolationOrder3(float2 v) => new float2((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y);
        
        /// <summary>
        /// Returns a float from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static float2 HermiteInterpolationOrder3(float v) => new float2((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static float2 HermiteInterpolationOrder5(float2 v) => new float2(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a float from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static float2 HermiteInterpolationOrder5(float v) => new float2(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static float2 Sqr(float2 v) => new float2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a float from the application of Sqr (v * v).
        /// </summary>
        public static float2 Sqr(float v) => new float2(v * v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static float2 Pow2(float2 v) => new float2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a float from the application of Pow2 (v * v).
        /// </summary>
        public static float2 Pow2(float v) => new float2(v * v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static float2 Pow3(float2 v) => new float2(v.x * v.x * v.x, v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a float from the application of Pow3 (v * v * v).
        /// </summary>
        public static float2 Pow3(float v) => new float2(v * v * v);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static float2 Step(float2 v) => new float2(v.x >= 0f ? 1f : 0f, v.y >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a float from the application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static float2 Step(float v) => new float2(v >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sqrt ((float)System.Math.Sqrt((double)v)).
        /// </summary>
        public static float2 Sqrt(float2 v) => new float2((float)System.Math.Sqrt((double)v.x), (float)System.Math.Sqrt((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Sqrt ((float)System.Math.Sqrt((double)v)).
        /// </summary>
        public static float2 Sqrt(float v) => new float2((float)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of InverseSqrt ((float)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static float2 InverseSqrt(float2 v) => new float2((float)(1.0 / System.Math.Sqrt((double)v.x)), (float)(1.0 / System.Math.Sqrt((double)v.y)));
        
        /// <summary>
        /// Returns a float from the application of InverseSqrt ((float)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static float2 InverseSqrt(float v) => new float2((float)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int2 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int2 Sign(float2 v) => new int2(System.Math.Sign(v.x), System.Math.Sign(v.y));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int2 Sign(float v) => new int2(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float2 Max(float2 lhs, float2 rhs) => new float2(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float2 Max(float2 lhs, float rhs) => new float2(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float2 Max(float lhs, float2 rhs) => new float2(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y));
        
        /// <summary>
        /// Returns a float from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static float2 Max(float lhs, float rhs) => new float2(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float2 Min(float2 lhs, float2 rhs) => new float2(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float2 Min(float2 lhs, float rhs) => new float2(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float2 Min(float lhs, float2 rhs) => new float2(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y));
        
        /// <summary>
        /// Returns a float from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static float2 Min(float lhs, float rhs) => new float2(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float2 Pow(float2 lhs, float2 rhs) => new float2((float)System.Math.Pow((double)lhs.x, (double)rhs.x), (float)System.Math.Pow((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float2 Pow(float2 lhs, float rhs) => new float2((float)System.Math.Pow((double)lhs.x, (double)rhs), (float)System.Math.Pow((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float2 Pow(float lhs, float2 rhs) => new float2((float)System.Math.Pow((double)lhs, (double)rhs.x), (float)System.Math.Pow((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a float from the application of Pow ((float)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float2 Pow(float lhs, float rhs) => new float2((float)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float2 Log(float2 lhs, float2 rhs) => new float2((float)System.Math.Log((double)lhs.x, (double)rhs.x), (float)System.Math.Log((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float2 Log(float2 lhs, float rhs) => new float2((float)System.Math.Log((double)lhs.x, (double)rhs), (float)System.Math.Log((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float2 Log(float lhs, float2 rhs) => new float2((float)System.Math.Log((double)lhs, (double)rhs.x), (float)System.Math.Log((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a float from the application of Log ((float)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float2 Log(float lhs, float rhs) => new float2((float)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float2 Clamp(float2 v, float2 min, float2 max) => new float2(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float2 Clamp(float2 v, float2 min, float max) => new float2(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float2 Clamp(float2 v, float min, float2 max) => new float2(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float2 Clamp(float2 v, float min, float max) => new float2(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float2 Clamp(float v, float2 min, float2 max) => new float2(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float2 Clamp(float v, float2 min, float max) => new float2(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float2 Clamp(float v, float min, float2 max) => new float2(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y));
        
        /// <summary>
        /// Returns a float from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static float2 Clamp(float v, float min, float max) => new float2(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float2 Mix(float2 min, float2 max, float2 a) => new float2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float2 Mix(float2 min, float2 max, float a) => new float2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float2 Mix(float2 min, float max, float2 a) => new float2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float2 Mix(float2 min, float max, float a) => new float2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float2 Mix(float min, float2 max, float2 a) => new float2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float2 Mix(float min, float2 max, float a) => new float2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float2 Mix(float min, float max, float2 a) => new float2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a float from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float2 Mix(float min, float max, float a) => new float2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float2 Lerp(float2 min, float2 max, float2 a) => new float2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float2 Lerp(float2 min, float2 max, float a) => new float2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float2 Lerp(float2 min, float max, float2 a) => new float2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float2 Lerp(float2 min, float max, float a) => new float2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float2 Lerp(float min, float2 max, float2 a) => new float2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float2 Lerp(float min, float2 max, float a) => new float2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float2 Lerp(float min, float max, float2 a) => new float2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a float from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float2 Lerp(float min, float max, float a) => new float2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float2 Smoothstep(float2 edge0, float2 edge1, float2 v) => new float2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float2 Smoothstep(float2 edge0, float2 edge1, float v) => new float2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float2 Smoothstep(float2 edge0, float edge1, float2 v) => new float2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float2 Smoothstep(float2 edge0, float edge1, float v) => new float2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float2 Smoothstep(float edge0, float2 edge1, float2 v) => new float2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float2 Smoothstep(float edge0, float2 edge1, float v) => new float2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float2 Smoothstep(float edge0, float edge1, float2 v) => new float2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float2 Smoothstep(float edge0, float edge1, float v) => new float2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float2 Smootherstep(float2 edge0, float2 edge1, float2 v) => new float2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float2 Smootherstep(float2 edge0, float2 edge1, float v) => new float2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float2 Smootherstep(float2 edge0, float edge1, float2 v) => new float2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float2 Smootherstep(float2 edge0, float edge1, float v) => new float2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float2 Smootherstep(float edge0, float2 edge1, float2 v) => new float2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float2 Smootherstep(float edge0, float2 edge1, float v) => new float2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float2 Smootherstep(float edge0, float edge1, float2 v) => new float2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float2 Smootherstep(float edge0, float edge1, float v) => new float2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float2 Fma(float2 a, float2 b, float2 c) => new float2(a.x * b.x + c.x, a.y * b.y + c.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float2 Fma(float2 a, float2 b, float c) => new float2(a.x * b.x + c, a.y * b.y + c);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float2 Fma(float2 a, float b, float2 c) => new float2(a.x * b + c.x, a.y * b + c.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float2 Fma(float2 a, float b, float c) => new float2(a.x * b + c, a.y * b + c);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float2 Fma(float a, float2 b, float2 c) => new float2(a * b.x + c.x, a * b.y + c.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float2 Fma(float a, float2 b, float c) => new float2(a * b.x + c, a * b.y + c);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float2 Fma(float a, float b, float2 c) => new float2(a * b + c.x, a * b + c.y);
        
        /// <summary>
        /// Returns a float from the application of Fma (a * b + c).
        /// </summary>
        public static float2 Fma(float a, float b, float c) => new float2(a * b + c);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float2 Add(float2 lhs, float2 rhs) => new float2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float2 Add(float2 lhs, float rhs) => new float2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float2 Add(float lhs, float2 rhs) => new float2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a float from the application of Add (lhs + rhs).
        /// </summary>
        public static float2 Add(float lhs, float rhs) => new float2(lhs + rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float2 Sub(float2 lhs, float2 rhs) => new float2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float2 Sub(float2 lhs, float rhs) => new float2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float2 Sub(float lhs, float2 rhs) => new float2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a float from the application of Sub (lhs - rhs).
        /// </summary>
        public static float2 Sub(float lhs, float rhs) => new float2(lhs - rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float2 Mul(float2 lhs, float2 rhs) => new float2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float2 Mul(float2 lhs, float rhs) => new float2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float2 Mul(float lhs, float2 rhs) => new float2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a float from the application of Mul (lhs * rhs).
        /// </summary>
        public static float2 Mul(float lhs, float rhs) => new float2(lhs * rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float2 Div(float2 lhs, float2 rhs) => new float2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float2 Div(float2 lhs, float rhs) => new float2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float2 Div(float lhs, float2 rhs) => new float2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a float from the application of Div (lhs / rhs).
        /// </summary>
        public static float2 Div(float lhs, float rhs) => new float2(lhs / rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float2 Modulo(float2 lhs, float2 rhs) => new float2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float2 Modulo(float2 lhs, float rhs) => new float2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float2 Modulo(float lhs, float2 rhs) => new float2(lhs % rhs.x, lhs % rhs.y);
        
        /// <summary>
        /// Returns a float from the application of Modulo (lhs % rhs).
        /// </summary>
        public static float2 Modulo(float lhs, float rhs) => new float2(lhs % rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static float2 Degrees(float2 v) => new float2((float)(v.x * 57.295779513082320876798154814105170332405472466564321f), (float)(v.y * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a float from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static float2 Degrees(float v) => new float2((float)(v * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static float2 Radians(float2 v) => new float2((float)(v.x * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.y * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a float from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static float2 Radians(float v) => new float2((float)(v * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Acos ((float)System.Math.Acos((double)v)).
        /// </summary>
        public static float2 Acos(float2 v) => new float2((float)System.Math.Acos((double)v.x), (float)System.Math.Acos((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Acos ((float)System.Math.Acos((double)v)).
        /// </summary>
        public static float2 Acos(float v) => new float2((float)System.Math.Acos((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Asin ((float)System.Math.Asin((double)v)).
        /// </summary>
        public static float2 Asin(float2 v) => new float2((float)System.Math.Asin((double)v.x), (float)System.Math.Asin((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Asin ((float)System.Math.Asin((double)v)).
        /// </summary>
        public static float2 Asin(float v) => new float2((float)System.Math.Asin((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Atan ((float)System.Math.Atan((double)v)).
        /// </summary>
        public static float2 Atan(float2 v) => new float2((float)System.Math.Atan((double)v.x), (float)System.Math.Atan((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Atan ((float)System.Math.Atan((double)v)).
        /// </summary>
        public static float2 Atan(float v) => new float2((float)System.Math.Atan((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Cos ((float)System.Math.Cos((double)v)).
        /// </summary>
        public static float2 Cos(float2 v) => new float2((float)System.Math.Cos((double)v.x), (float)System.Math.Cos((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Cos ((float)System.Math.Cos((double)v)).
        /// </summary>
        public static float2 Cos(float v) => new float2((float)System.Math.Cos((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Cosh ((float)System.Math.Cosh((double)v)).
        /// </summary>
        public static float2 Cosh(float2 v) => new float2((float)System.Math.Cosh((double)v.x), (float)System.Math.Cosh((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Cosh ((float)System.Math.Cosh((double)v)).
        /// </summary>
        public static float2 Cosh(float v) => new float2((float)System.Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Exp ((float)System.Math.Exp((double)v)).
        /// </summary>
        public static float2 Exp(float2 v) => new float2((float)System.Math.Exp((double)v.x), (float)System.Math.Exp((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Exp ((float)System.Math.Exp((double)v)).
        /// </summary>
        public static float2 Exp(float v) => new float2((float)System.Math.Exp((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log ((float)System.Math.Log((double)v)).
        /// </summary>
        public static float2 Log(float2 v) => new float2((float)System.Math.Log((double)v.x), (float)System.Math.Log((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Log ((float)System.Math.Log((double)v)).
        /// </summary>
        public static float2 Log(float v) => new float2((float)System.Math.Log((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log2 ((float)System.Math.Log((double)v, 2)).
        /// </summary>
        public static float2 Log2(float2 v) => new float2((float)System.Math.Log((double)v.x, 2), (float)System.Math.Log((double)v.y, 2));
        
        /// <summary>
        /// Returns a float from the application of Log2 ((float)System.Math.Log((double)v, 2)).
        /// </summary>
        public static float2 Log2(float v) => new float2((float)System.Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Log10 ((float)System.Math.Log10((double)v)).
        /// </summary>
        public static float2 Log10(float2 v) => new float2((float)System.Math.Log10((double)v.x), (float)System.Math.Log10((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Log10 ((float)System.Math.Log10((double)v)).
        /// </summary>
        public static float2 Log10(float v) => new float2((float)System.Math.Log10((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Floor ((float)System.Math.Floor(v)).
        /// </summary>
        public static float2 Floor(float2 v) => new float2((float)System.Math.Floor(v.x), (float)System.Math.Floor(v.y));
        
        /// <summary>
        /// Returns a float from the application of Floor ((float)System.Math.Floor(v)).
        /// </summary>
        public static float2 Floor(float v) => new float2((float)System.Math.Floor(v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Ceiling ((float)System.Math.Ceiling(v)).
        /// </summary>
        public static float2 Ceiling(float2 v) => new float2((float)System.Math.Ceiling(v.x), (float)System.Math.Ceiling(v.y));
        
        /// <summary>
        /// Returns a float from the application of Ceiling ((float)System.Math.Ceiling(v)).
        /// </summary>
        public static float2 Ceiling(float v) => new float2((float)System.Math.Ceiling(v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Round ((float)System.Math.Round(v)).
        /// </summary>
        public static float2 Round(float2 v) => new float2((float)System.Math.Round(v.x), (float)System.Math.Round(v.y));
        
        /// <summary>
        /// Returns a float from the application of Round ((float)System.Math.Round(v)).
        /// </summary>
        public static float2 Round(float v) => new float2((float)System.Math.Round(v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sin ((float)System.Math.Sin((double)v)).
        /// </summary>
        public static float2 Sin(float2 v) => new float2((float)System.Math.Sin((double)v.x), (float)System.Math.Sin((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Sin ((float)System.Math.Sin((double)v)).
        /// </summary>
        public static float2 Sin(float v) => new float2((float)System.Math.Sin((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Sinh ((float)System.Math.Sinh((double)v)).
        /// </summary>
        public static float2 Sinh(float2 v) => new float2((float)System.Math.Sinh((double)v.x), (float)System.Math.Sinh((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Sinh ((float)System.Math.Sinh((double)v)).
        /// </summary>
        public static float2 Sinh(float v) => new float2((float)System.Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Tan ((float)System.Math.Tan((double)v)).
        /// </summary>
        public static float2 Tan(float2 v) => new float2((float)System.Math.Tan((double)v.x), (float)System.Math.Tan((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Tan ((float)System.Math.Tan((double)v)).
        /// </summary>
        public static float2 Tan(float v) => new float2((float)System.Math.Tan((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Tanh ((float)System.Math.Tanh((double)v)).
        /// </summary>
        public static float2 Tanh(float2 v) => new float2((float)System.Math.Tanh((double)v.x), (float)System.Math.Tanh((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Tanh ((float)System.Math.Tanh((double)v)).
        /// </summary>
        public static float2 Tanh(float v) => new float2((float)System.Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Truncate ((float)System.Math.Truncate((double)v)).
        /// </summary>
        public static float2 Truncate(float2 v) => new float2((float)System.Math.Truncate((double)v.x), (float)System.Math.Truncate((double)v.y));
        
        /// <summary>
        /// Returns a float from the application of Truncate ((float)System.Math.Truncate((double)v)).
        /// </summary>
        public static float2 Truncate(float v) => new float2((float)System.Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Fract ((float)(v - System.Math.Floor(v))).
        /// </summary>
        public static float2 Fract(float2 v) => new float2((float)(v.x - System.Math.Floor(v.x)), (float)(v.y - System.Math.Floor(v.y)));
        
        /// <summary>
        /// Returns a float from the application of Fract ((float)(v - System.Math.Floor(v))).
        /// </summary>
        public static float2 Fract(float v) => new float2((float)(v - System.Math.Floor(v)));
        
        /// <summary>
        /// Returns a float2 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static float2 Trunc(float2 v) => new float2((long)(v.x), (long)(v.y));
        
        /// <summary>
        /// Returns a float from the application of Trunc ((long)(v)).
        /// </summary>
        public static float2 Trunc(float v) => new float2((long)(v));
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float2 Random(Random random, float2 minValue, float2 maxValue) => new float2((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float2 Random(Random random, float2 minValue, float maxValue) => new float2((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float2 Random(Random random, float minValue, float2 maxValue) => new float2((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float2 Random(Random random, float minValue, float maxValue) => new float2((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float2 RandomUniform(Random random, float2 minValue, float2 maxValue) => new float2((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float2 RandomUniform(Random random, float2 minValue, float maxValue) => new float2((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float2 RandomUniform(Random random, float minValue, float2 maxValue) => new float2((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float2 RandomUniform(Random random, float minValue, float maxValue) => new float2((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float2 RandomNormal(Random random, float2 mean, float2 variance) => new float2((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float2 RandomNormal(Random random, float2 mean, float variance) => new float2((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float2 RandomNormal(Random random, float mean, float2 variance) => new float2((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float2 RandomNormal(Random random, float mean, float variance) => new float2((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float2 RandomGaussian(Random random, float2 mean, float2 variance) => new float2((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float2 RandomGaussian(Random random, float2 mean, float variance) => new float2((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float2 RandomGaussian(Random random, float mean, float2 variance) => new float2((float)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (float)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a float2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float2 RandomGaussian(Random random, float mean, float variance) => new float2((float)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(float2 lhs, float2 rhs) => new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(float2 lhs, float rhs) => new bool2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(float lhs, float2 rhs) => new bool2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(float2 lhs, float2 rhs) => new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(float2 lhs, float rhs) => new bool2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(float lhs, float2 rhs) => new bool2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(float2 lhs, float2 rhs) => new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(float2 lhs, float rhs) => new bool2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(float lhs, float2 rhs) => new bool2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(float2 lhs, float2 rhs) => new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(float2 lhs, float rhs) => new bool2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(float lhs, float2 rhs) => new bool2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float2 operator+(float2 lhs, float2 rhs) => new float2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float2 operator+(float2 lhs, float rhs) => new float2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static float2 operator+(float lhs, float2 rhs) => new float2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float2 operator-(float2 lhs, float2 rhs) => new float2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float2 operator-(float2 lhs, float rhs) => new float2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static float2 operator-(float lhs, float2 rhs) => new float2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float2 operator*(float2 lhs, float2 rhs) => new float2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float2 operator*(float2 lhs, float rhs) => new float2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static float2 operator*(float lhs, float2 rhs) => new float2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float2 operator/(float2 lhs, float2 rhs) => new float2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float2 operator/(float2 lhs, float rhs) => new float2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static float2 operator/(float lhs, float2 rhs) => new float2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator+ (identity).
        /// </summary>
        public static float2 operator+(float2 v) => v;
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator- (-v).
        /// </summary>
        public static float2 operator-(float2 v) => new float2(-v.x, -v.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float2 operator%(float2 lhs, float2 rhs) => new float2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float2 operator%(float2 lhs, float rhs) => new float2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Returns a float2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static float2 operator%(float lhs, float2 rhs) => new float2(lhs % rhs.x, lhs % rhs.y);

        #endregion

    }
}
