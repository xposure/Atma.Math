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
    /// A vector of type double with 2 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct double2 : IReadOnlyList<double>, IEquatable<double2>
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public double2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public double2(double v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public double2(double2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public double2(double3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public double2(double4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double2(IReadOnlyList<double> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double2(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : (double)v[0];
            this.y = c < 1 ? 0.0 : (double)v[1];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double2(double[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double2(double[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0.0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0.0 : v[1 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public double2(IEnumerable<double> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int2.
        /// </summary>
        public static explicit operator int2(double2 v) => new int2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a int3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int3(double2 v) => new int3((int)v.x, (int)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a int4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator int4(double2 v) => new int4((int)v.x, (int)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a uint2.
        /// </summary>
        public static explicit operator uint2(double2 v) => new uint2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uint3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint3(double2 v) => new uint3((uint)v.x, (uint)v.y, 0u);
        
        /// <summary>
        /// Explicitly converts this to a uint4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uint4(double2 v) => new uint4((uint)v.x, (uint)v.y, 0u, 0u);
        
        /// <summary>
        /// Explicitly converts this to a float2.
        /// </summary>
        public static explicit operator float2(double2 v) => new float2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a float3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float3(double2 v) => new float3((float)v.x, (float)v.y, 0f);
        
        /// <summary>
        /// Explicitly converts this to a float4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator float4(double2 v) => new float4((float)v.x, (float)v.y, 0f, 0f);
        
        /// <summary>
        /// Explicitly converts this to a double3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double3(double2 v) => new double3((double)v.x, (double)v.y, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a double4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator double4(double2 v) => new double4((double)v.x, (double)v.y, 0.0, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a long2.
        /// </summary>
        public static explicit operator long2(double2 v) => new long2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a long3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long3(double2 v) => new long3((long)v.x, (long)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a long4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator long4(double2 v) => new long4((long)v.x, (long)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a bool2.
        /// </summary>
        public static explicit operator bool2(double2 v) => new bool2(v.x != 0.0, v.y != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bool3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool3(double2 v) => new bool3(v.x != 0.0, v.y != 0.0, false);
        
        /// <summary>
        /// Explicitly converts this to a bool4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bool4(double2 v) => new bool4(v.x != 0.0, v.y != 0.0, false, false);
        
        /// <summary>
        /// Explicitly converts this to a double array.
        /// </summary>
        public static explicit operator double[](double2 v) => new [] { v.x, v.y };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](double2 v) => new Object[] { v.x, v.y };

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
        public swizzle_double2 swizzle => new swizzle_double2(x, y);
        
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
        /// Returns an array with all values
        /// </summary>
        public double[] Values => new[] { x, y };
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public double MinElement => System.Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public double MaxElement => System.Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)System.Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => (x*x + y*y);
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public double Sum => (x + y);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)System.Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => (System.Math.Abs(x) + System.Math.Abs(y));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public double Norm2 => (double)System.Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => System.Math.Max(System.Math.Abs(x), System.Math.Abs(y));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public double2 Normalized => this / (double)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public double2 NormalizedSafe => this == Zero ? Zero : this / (double)Length;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public double Angle => System.Math.Atan2((double)y, (double)x);
        
        /// <summary>
        /// Returns a perpendicular vector.
        /// </summary>
        public double2 Perpendicular => new double2(y, -x);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static double2 Zero { get; } = new double2(0.0, 0.0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static double2 Ones { get; } = new double2(1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static double2 UnitX { get; } = new double2(1.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static double2 UnitY { get; } = new double2(0.0, 1.0);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static double2 MaxValue { get; } = new double2(double.MaxValue, double.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static double2 MinValue { get; } = new double2(double.MinValue, double.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static double2 Epsilon { get; } = new double2(double.Epsilon, double.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static double2 NaN { get; } = new double2(double.NaN, double.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static double2 NegativeInfinity { get; } = new double2(double.NegativeInfinity, double.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static double2 PositiveInfinity { get; } = new double2(double.PositiveInfinity, double.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(double2 lhs, double2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(double2 lhs, double2 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
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
        public bool Equals(double2 rhs) => (x.Equals(rhs.x) && y.Equals(rhs.y));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is double2 && Equals((double2) obj);
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
        public double2 Rotated(double angleInRad) => (double2)(double2.FromAngle(Angle + angleInRad) * (double)Length);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static double2 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static double2 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new double2(double.Parse(kvp[0].Trim()), double.Parse(kvp[1].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static double2 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new double2(double.Parse(kvp[0].Trim(), provider), double.Parse(kvp[1].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static double2 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new double2(double.Parse(kvp[0].Trim(), style), double.Parse(kvp[1].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static double2 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new double2(double.Parse(kvp[0].Trim(), style, provider), double.Parse(kvp[1].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out double2 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out double2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            double x = 0.0, y = 0.0;
            var ok = (double.TryParse(kvp[0].Trim(), out x) && double.TryParse(kvp[1].Trim(), out y));
            result = ok ? new double2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out double2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            double x = 0.0, y = 0.0;
            var ok = (double.TryParse(kvp[0].Trim(), style, provider, out x) && double.TryParse(kvp[1].Trim(), style, provider, out y));
            result = ok ? new double2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(double2 lhs, double2 rhs, double eps = 0.1d) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double2x2 OuterProduct(double2 c, double2 r) => new double2x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double2x3 OuterProduct(double3 c, double2 r) => new double2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double3x2 OuterProduct(double2 c, double3 r) => new double3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double2x4 OuterProduct(double4 c, double2 r) => new double2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static double4x2 OuterProduct(double2 c, double4 r) => new double4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).
        /// </summary>
        public static double2 FromAngle(double angleInRad) => new double2((double)System.Math.Cos(angleInRad), (double)System.Math.Sin(angleInRad));
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(double2 lhs, double2 rhs) => (lhs.x * rhs.x + lhs.y * rhs.y);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(double2 lhs, double2 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(double2 lhs, double2 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static double2 Reflect(double2 I, double2 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static double2 Refract(double2 I, double2 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (double)System.Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static double2 FaceForward(double2 N, double2 I, double2 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static double Cross(double2 l, double2 r) => l.x * r.y - l.y * r.x;
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static double2 Random(Random random) => new double2((double)random.NextDouble(), (double)random.NextDouble());
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static double2 RandomSigned(Random random) => new double2((double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static double2 RandomNormal(Random random) => new double2((double)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))), (double)(System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(double2 lhs, double2 rhs) => new bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(double2 lhs, double rhs) => new bool2(lhs.x == rhs, lhs.y == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(double lhs, double2 rhs) => new bool2(lhs == rhs.x, lhs == rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool2 Equal(double lhs, double rhs) => new bool2(lhs == rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(double2 lhs, double2 rhs) => new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(double2 lhs, double rhs) => new bool2(lhs.x != rhs, lhs.y != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(double lhs, double2 rhs) => new bool2(lhs != rhs.x, lhs != rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool2 NotEqual(double lhs, double rhs) => new bool2(lhs != rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(double2 lhs, double2 rhs) => new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(double2 lhs, double rhs) => new bool2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(double lhs, double2 rhs) => new bool2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool2 GreaterThan(double lhs, double rhs) => new bool2(lhs > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(double2 lhs, double2 rhs) => new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(double2 lhs, double rhs) => new bool2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(double lhs, double2 rhs) => new bool2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool2 GreaterThanEqual(double lhs, double rhs) => new bool2(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(double2 lhs, double2 rhs) => new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(double2 lhs, double rhs) => new bool2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(double lhs, double2 rhs) => new bool2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool2 LesserThan(double lhs, double rhs) => new bool2(lhs < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(double2 lhs, double2 rhs) => new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(double2 lhs, double rhs) => new bool2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(double lhs, double2 rhs) => new bool2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool2 LesserThanEqual(double lhs, double rhs) => new bool2(lhs <= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bool2 IsInfinity(double2 v) => new bool2(double.IsInfinity(v.x), double.IsInfinity(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bool2 IsInfinity(double v) => new bool2(double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bool2 IsFinite(double2 v) => new bool2(!double.IsNaN(v.x) && !double.IsInfinity(v.x), !double.IsNaN(v.y) && !double.IsInfinity(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bool2 IsFinite(double v) => new bool2(!double.IsNaN(v) && !double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bool2 IsNaN(double2 v) => new bool2(double.IsNaN(v.x), double.IsNaN(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bool2 IsNaN(double v) => new bool2(double.IsNaN(v));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bool2 IsNegativeInfinity(double2 v) => new bool2(double.IsNegativeInfinity(v.x), double.IsNegativeInfinity(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bool2 IsNegativeInfinity(double v) => new bool2(double.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bool2 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bool2 IsPositiveInfinity(double2 v) => new bool2(double.IsPositiveInfinity(v.x), double.IsPositiveInfinity(v.y));
        
        /// <summary>
        /// Returns a bool from the application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bool2 IsPositiveInfinity(double v) => new bool2(double.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static double2 Abs(double2 v) => new double2(System.Math.Abs(v.x), System.Math.Abs(v.y));
        
        /// <summary>
        /// Returns a double from the application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static double2 Abs(double v) => new double2(System.Math.Abs(v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static double2 HermiteInterpolationOrder3(double2 v) => new double2((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y);
        
        /// <summary>
        /// Returns a double from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static double2 HermiteInterpolationOrder3(double v) => new double2((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a double2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static double2 HermiteInterpolationOrder5(double2 v) => new double2(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a double from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static double2 HermiteInterpolationOrder5(double v) => new double2(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static double2 Sqr(double2 v) => new double2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a double from the application of Sqr (v * v).
        /// </summary>
        public static double2 Sqr(double v) => new double2(v * v);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static double2 Pow2(double2 v) => new double2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a double from the application of Pow2 (v * v).
        /// </summary>
        public static double2 Pow2(double v) => new double2(v * v);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static double2 Pow3(double2 v) => new double2(v.x * v.x * v.x, v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a double from the application of Pow3 (v * v * v).
        /// </summary>
        public static double2 Pow3(double v) => new double2(v * v * v);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static double2 Step(double2 v) => new double2(v.x >= 0.0 ? 1.0 : 0.0, v.y >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a double from the application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static double2 Step(double v) => new double2(v >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Sqrt ((double)System.Math.Sqrt((double)v)).
        /// </summary>
        public static double2 Sqrt(double2 v) => new double2((double)System.Math.Sqrt((double)v.x), (double)System.Math.Sqrt((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Sqrt ((double)System.Math.Sqrt((double)v)).
        /// </summary>
        public static double2 Sqrt(double v) => new double2((double)System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of InverseSqrt ((double)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static double2 InverseSqrt(double2 v) => new double2((double)(1.0 / System.Math.Sqrt((double)v.x)), (double)(1.0 / System.Math.Sqrt((double)v.y)));
        
        /// <summary>
        /// Returns a double from the application of InverseSqrt ((double)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static double2 InverseSqrt(double v) => new double2((double)(1.0 / System.Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a int2 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int2 Sign(double2 v) => new int2(System.Math.Sign(v.x), System.Math.Sign(v.y));
        
        /// <summary>
        /// Returns a int from the application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int2 Sign(double v) => new int2(System.Math.Sign(v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static double2 Max(double2 lhs, double2 rhs) => new double2(System.Math.Max(lhs.x, rhs.x), System.Math.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static double2 Max(double2 lhs, double rhs) => new double2(System.Math.Max(lhs.x, rhs), System.Math.Max(lhs.y, rhs));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static double2 Max(double lhs, double2 rhs) => new double2(System.Math.Max(lhs, rhs.x), System.Math.Max(lhs, rhs.y));
        
        /// <summary>
        /// Returns a double from the application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static double2 Max(double lhs, double rhs) => new double2(System.Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static double2 Min(double2 lhs, double2 rhs) => new double2(System.Math.Min(lhs.x, rhs.x), System.Math.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static double2 Min(double2 lhs, double rhs) => new double2(System.Math.Min(lhs.x, rhs), System.Math.Min(lhs.y, rhs));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static double2 Min(double lhs, double2 rhs) => new double2(System.Math.Min(lhs, rhs.x), System.Math.Min(lhs, rhs.y));
        
        /// <summary>
        /// Returns a double from the application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static double2 Min(double lhs, double rhs) => new double2(System.Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Pow ((double)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double2 Pow(double2 lhs, double2 rhs) => new double2((double)System.Math.Pow((double)lhs.x, (double)rhs.x), (double)System.Math.Pow((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Pow ((double)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double2 Pow(double2 lhs, double rhs) => new double2((double)System.Math.Pow((double)lhs.x, (double)rhs), (double)System.Math.Pow((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Pow ((double)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double2 Pow(double lhs, double2 rhs) => new double2((double)System.Math.Pow((double)lhs, (double)rhs.x), (double)System.Math.Pow((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a double from the application of Pow ((double)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double2 Pow(double lhs, double rhs) => new double2((double)System.Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Log ((double)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double2 Log(double2 lhs, double2 rhs) => new double2((double)System.Math.Log((double)lhs.x, (double)rhs.x), (double)System.Math.Log((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Log ((double)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double2 Log(double2 lhs, double rhs) => new double2((double)System.Math.Log((double)lhs.x, (double)rhs), (double)System.Math.Log((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Log ((double)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double2 Log(double lhs, double2 rhs) => new double2((double)System.Math.Log((double)lhs, (double)rhs.x), (double)System.Math.Log((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a double from the application of Log ((double)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double2 Log(double lhs, double rhs) => new double2((double)System.Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double2 Clamp(double2 v, double2 min, double2 max) => new double2(System.Math.Min(System.Math.Max(v.x, min.x), max.x), System.Math.Min(System.Math.Max(v.y, min.y), max.y));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double2 Clamp(double2 v, double2 min, double max) => new double2(System.Math.Min(System.Math.Max(v.x, min.x), max), System.Math.Min(System.Math.Max(v.y, min.y), max));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double2 Clamp(double2 v, double min, double2 max) => new double2(System.Math.Min(System.Math.Max(v.x, min), max.x), System.Math.Min(System.Math.Max(v.y, min), max.y));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double2 Clamp(double2 v, double min, double max) => new double2(System.Math.Min(System.Math.Max(v.x, min), max), System.Math.Min(System.Math.Max(v.y, min), max));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double2 Clamp(double v, double2 min, double2 max) => new double2(System.Math.Min(System.Math.Max(v, min.x), max.x), System.Math.Min(System.Math.Max(v, min.y), max.y));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double2 Clamp(double v, double2 min, double max) => new double2(System.Math.Min(System.Math.Max(v, min.x), max), System.Math.Min(System.Math.Max(v, min.y), max));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double2 Clamp(double v, double min, double2 max) => new double2(System.Math.Min(System.Math.Max(v, min), max.x), System.Math.Min(System.Math.Max(v, min), max.y));
        
        /// <summary>
        /// Returns a double from the application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static double2 Clamp(double v, double min, double max) => new double2(System.Math.Min(System.Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double2 Mix(double2 min, double2 max, double2 a) => new double2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double2 Mix(double2 min, double2 max, double a) => new double2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double2 Mix(double2 min, double max, double2 a) => new double2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double2 Mix(double2 min, double max, double a) => new double2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double2 Mix(double min, double2 max, double2 a) => new double2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double2 Mix(double min, double2 max, double a) => new double2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double2 Mix(double min, double max, double2 a) => new double2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a double from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double2 Mix(double min, double max, double a) => new double2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double2 Lerp(double2 min, double2 max, double2 a) => new double2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double2 Lerp(double2 min, double2 max, double a) => new double2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double2 Lerp(double2 min, double max, double2 a) => new double2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double2 Lerp(double2 min, double max, double a) => new double2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double2 Lerp(double min, double2 max, double2 a) => new double2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double2 Lerp(double min, double2 max, double a) => new double2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double2 Lerp(double min, double max, double2 a) => new double2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a double from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double2 Lerp(double min, double max, double a) => new double2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double2 Smoothstep(double2 edge0, double2 edge1, double2 v) => new double2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double2 Smoothstep(double2 edge0, double2 edge1, double v) => new double2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double2 Smoothstep(double2 edge0, double edge1, double2 v) => new double2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double2 Smoothstep(double2 edge0, double edge1, double v) => new double2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double2 Smoothstep(double edge0, double2 edge1, double2 v) => new double2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double2 Smoothstep(double edge0, double2 edge1, double v) => new double2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double2 Smoothstep(double edge0, double edge1, double2 v) => new double2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double2 Smoothstep(double edge0, double edge1, double v) => new double2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double2 Smootherstep(double2 edge0, double2 edge1, double2 v) => new double2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double2 Smootherstep(double2 edge0, double2 edge1, double v) => new double2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double2 Smootherstep(double2 edge0, double edge1, double2 v) => new double2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double2 Smootherstep(double2 edge0, double edge1, double v) => new double2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double2 Smootherstep(double edge0, double2 edge1, double2 v) => new double2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double2 Smootherstep(double edge0, double2 edge1, double v) => new double2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double2 Smootherstep(double edge0, double edge1, double2 v) => new double2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double2 Smootherstep(double edge0, double edge1, double v) => new double2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a double2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double2 Fma(double2 a, double2 b, double2 c) => new double2(a.x * b.x + c.x, a.y * b.y + c.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double2 Fma(double2 a, double2 b, double c) => new double2(a.x * b.x + c, a.y * b.y + c);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double2 Fma(double2 a, double b, double2 c) => new double2(a.x * b + c.x, a.y * b + c.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double2 Fma(double2 a, double b, double c) => new double2(a.x * b + c, a.y * b + c);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double2 Fma(double a, double2 b, double2 c) => new double2(a * b.x + c.x, a * b.y + c.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double2 Fma(double a, double2 b, double c) => new double2(a * b.x + c, a * b.y + c);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double2 Fma(double a, double b, double2 c) => new double2(a * b + c.x, a * b + c.y);
        
        /// <summary>
        /// Returns a double from the application of Fma (a * b + c).
        /// </summary>
        public static double2 Fma(double a, double b, double c) => new double2(a * b + c);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static double2 Add(double2 lhs, double2 rhs) => new double2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static double2 Add(double2 lhs, double rhs) => new double2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static double2 Add(double lhs, double2 rhs) => new double2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a double from the application of Add (lhs + rhs).
        /// </summary>
        public static double2 Add(double lhs, double rhs) => new double2(lhs + rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static double2 Sub(double2 lhs, double2 rhs) => new double2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static double2 Sub(double2 lhs, double rhs) => new double2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static double2 Sub(double lhs, double2 rhs) => new double2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a double from the application of Sub (lhs - rhs).
        /// </summary>
        public static double2 Sub(double lhs, double rhs) => new double2(lhs - rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static double2 Mul(double2 lhs, double2 rhs) => new double2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static double2 Mul(double2 lhs, double rhs) => new double2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static double2 Mul(double lhs, double2 rhs) => new double2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a double from the application of Mul (lhs * rhs).
        /// </summary>
        public static double2 Mul(double lhs, double rhs) => new double2(lhs * rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static double2 Div(double2 lhs, double2 rhs) => new double2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static double2 Div(double2 lhs, double rhs) => new double2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static double2 Div(double lhs, double2 rhs) => new double2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a double from the application of Div (lhs / rhs).
        /// </summary>
        public static double2 Div(double lhs, double rhs) => new double2(lhs / rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static double2 Modulo(double2 lhs, double2 rhs) => new double2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static double2 Modulo(double2 lhs, double rhs) => new double2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static double2 Modulo(double lhs, double2 rhs) => new double2(lhs % rhs.x, lhs % rhs.y);
        
        /// <summary>
        /// Returns a double from the application of Modulo (lhs % rhs).
        /// </summary>
        public static double2 Modulo(double lhs, double rhs) => new double2(lhs % rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static double2 Degrees(double2 v) => new double2((double)(v.x * 57.295779513082320876798154814105170332405472466564321d), (double)(v.y * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a double from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static double2 Degrees(double v) => new double2((double)(v * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static double2 Radians(double2 v) => new double2((double)(v.x * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.y * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a double from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static double2 Radians(double v) => new double2((double)(v * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Acos ((double)System.Math.Acos((double)v)).
        /// </summary>
        public static double2 Acos(double2 v) => new double2((double)System.Math.Acos((double)v.x), (double)System.Math.Acos((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Acos ((double)System.Math.Acos((double)v)).
        /// </summary>
        public static double2 Acos(double v) => new double2((double)System.Math.Acos((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Asin ((double)System.Math.Asin((double)v)).
        /// </summary>
        public static double2 Asin(double2 v) => new double2((double)System.Math.Asin((double)v.x), (double)System.Math.Asin((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Asin ((double)System.Math.Asin((double)v)).
        /// </summary>
        public static double2 Asin(double v) => new double2((double)System.Math.Asin((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Atan ((double)System.Math.Atan((double)v)).
        /// </summary>
        public static double2 Atan(double2 v) => new double2((double)System.Math.Atan((double)v.x), (double)System.Math.Atan((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Atan ((double)System.Math.Atan((double)v)).
        /// </summary>
        public static double2 Atan(double v) => new double2((double)System.Math.Atan((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Cos ((double)System.Math.Cos((double)v)).
        /// </summary>
        public static double2 Cos(double2 v) => new double2((double)System.Math.Cos((double)v.x), (double)System.Math.Cos((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Cos ((double)System.Math.Cos((double)v)).
        /// </summary>
        public static double2 Cos(double v) => new double2((double)System.Math.Cos((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Cosh ((double)System.Math.Cosh((double)v)).
        /// </summary>
        public static double2 Cosh(double2 v) => new double2((double)System.Math.Cosh((double)v.x), (double)System.Math.Cosh((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Cosh ((double)System.Math.Cosh((double)v)).
        /// </summary>
        public static double2 Cosh(double v) => new double2((double)System.Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Exp ((double)System.Math.Exp((double)v)).
        /// </summary>
        public static double2 Exp(double2 v) => new double2((double)System.Math.Exp((double)v.x), (double)System.Math.Exp((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Exp ((double)System.Math.Exp((double)v)).
        /// </summary>
        public static double2 Exp(double v) => new double2((double)System.Math.Exp((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Log ((double)System.Math.Log((double)v)).
        /// </summary>
        public static double2 Log(double2 v) => new double2((double)System.Math.Log((double)v.x), (double)System.Math.Log((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Log ((double)System.Math.Log((double)v)).
        /// </summary>
        public static double2 Log(double v) => new double2((double)System.Math.Log((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Log2 ((double)System.Math.Log((double)v, 2)).
        /// </summary>
        public static double2 Log2(double2 v) => new double2((double)System.Math.Log((double)v.x, 2), (double)System.Math.Log((double)v.y, 2));
        
        /// <summary>
        /// Returns a double from the application of Log2 ((double)System.Math.Log((double)v, 2)).
        /// </summary>
        public static double2 Log2(double v) => new double2((double)System.Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Log10 ((double)System.Math.Log10((double)v)).
        /// </summary>
        public static double2 Log10(double2 v) => new double2((double)System.Math.Log10((double)v.x), (double)System.Math.Log10((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Log10 ((double)System.Math.Log10((double)v)).
        /// </summary>
        public static double2 Log10(double v) => new double2((double)System.Math.Log10((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Floor ((double)System.Math.Floor(v)).
        /// </summary>
        public static double2 Floor(double2 v) => new double2((double)System.Math.Floor(v.x), (double)System.Math.Floor(v.y));
        
        /// <summary>
        /// Returns a double from the application of Floor ((double)System.Math.Floor(v)).
        /// </summary>
        public static double2 Floor(double v) => new double2((double)System.Math.Floor(v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Ceiling ((double)System.Math.Ceiling(v)).
        /// </summary>
        public static double2 Ceiling(double2 v) => new double2((double)System.Math.Ceiling(v.x), (double)System.Math.Ceiling(v.y));
        
        /// <summary>
        /// Returns a double from the application of Ceiling ((double)System.Math.Ceiling(v)).
        /// </summary>
        public static double2 Ceiling(double v) => new double2((double)System.Math.Ceiling(v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Round ((double)System.Math.Round(v)).
        /// </summary>
        public static double2 Round(double2 v) => new double2((double)System.Math.Round(v.x), (double)System.Math.Round(v.y));
        
        /// <summary>
        /// Returns a double from the application of Round ((double)System.Math.Round(v)).
        /// </summary>
        public static double2 Round(double v) => new double2((double)System.Math.Round(v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Sin ((double)System.Math.Sin((double)v)).
        /// </summary>
        public static double2 Sin(double2 v) => new double2((double)System.Math.Sin((double)v.x), (double)System.Math.Sin((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Sin ((double)System.Math.Sin((double)v)).
        /// </summary>
        public static double2 Sin(double v) => new double2((double)System.Math.Sin((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Sinh ((double)System.Math.Sinh((double)v)).
        /// </summary>
        public static double2 Sinh(double2 v) => new double2((double)System.Math.Sinh((double)v.x), (double)System.Math.Sinh((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Sinh ((double)System.Math.Sinh((double)v)).
        /// </summary>
        public static double2 Sinh(double v) => new double2((double)System.Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Tan ((double)System.Math.Tan((double)v)).
        /// </summary>
        public static double2 Tan(double2 v) => new double2((double)System.Math.Tan((double)v.x), (double)System.Math.Tan((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Tan ((double)System.Math.Tan((double)v)).
        /// </summary>
        public static double2 Tan(double v) => new double2((double)System.Math.Tan((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Tanh ((double)System.Math.Tanh((double)v)).
        /// </summary>
        public static double2 Tanh(double2 v) => new double2((double)System.Math.Tanh((double)v.x), (double)System.Math.Tanh((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Tanh ((double)System.Math.Tanh((double)v)).
        /// </summary>
        public static double2 Tanh(double v) => new double2((double)System.Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Truncate ((double)System.Math.Truncate((double)v)).
        /// </summary>
        public static double2 Truncate(double2 v) => new double2((double)System.Math.Truncate((double)v.x), (double)System.Math.Truncate((double)v.y));
        
        /// <summary>
        /// Returns a double from the application of Truncate ((double)System.Math.Truncate((double)v)).
        /// </summary>
        public static double2 Truncate(double v) => new double2((double)System.Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Fract ((double)(v - System.Math.Floor(v))).
        /// </summary>
        public static double2 Fract(double2 v) => new double2((double)(v.x - System.Math.Floor(v.x)), (double)(v.y - System.Math.Floor(v.y)));
        
        /// <summary>
        /// Returns a double from the application of Fract ((double)(v - System.Math.Floor(v))).
        /// </summary>
        public static double2 Fract(double v) => new double2((double)(v - System.Math.Floor(v)));
        
        /// <summary>
        /// Returns a double2 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static double2 Trunc(double2 v) => new double2((long)(v.x), (long)(v.y));
        
        /// <summary>
        /// Returns a double from the application of Trunc ((long)(v)).
        /// </summary>
        public static double2 Trunc(double v) => new double2((long)(v));
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double2 Random(Random random, double2 minValue, double2 maxValue) => new double2((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double2 Random(Random random, double2 minValue, double maxValue) => new double2((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double2 Random(Random random, double minValue, double2 maxValue) => new double2((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double2 Random(Random random, double minValue, double maxValue) => new double2((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double2 RandomUniform(Random random, double2 minValue, double2 maxValue) => new double2((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double2 RandomUniform(Random random, double2 minValue, double maxValue) => new double2((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double2 RandomUniform(Random random, double minValue, double2 maxValue) => new double2((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double2 RandomUniform(Random random, double minValue, double maxValue) => new double2((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double2 RandomNormal(Random random, double2 mean, double2 variance) => new double2((double)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (double)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double2 RandomNormal(Random random, double2 mean, double variance) => new double2((double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double2 RandomNormal(Random random, double mean, double2 variance) => new double2((double)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (double)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double2 RandomNormal(Random random, double mean, double variance) => new double2((double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double2 RandomGaussian(Random random, double2 mean, double2 variance) => new double2((double)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (double)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double2 RandomGaussian(Random random, double2 mean, double variance) => new double2((double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.x, (double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double2 RandomGaussian(Random random, double mean, double2 variance) => new double2((double)(System.Math.Sqrt((double)variance.x) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean, (double)(System.Math.Sqrt((double)variance.y) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a double2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double2 RandomGaussian(Random random, double mean, double variance) => new double2((double)(System.Math.Sqrt((double)variance) * System.Math.Cos(2 * System.Math.PI * random.NextDouble()) * System.Math.Sqrt(-2.0 * System.Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(double2 lhs, double2 rhs) => new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(double2 lhs, double rhs) => new bool2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool2 operator<(double lhs, double2 rhs) => new bool2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(double2 lhs, double2 rhs) => new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(double2 lhs, double rhs) => new bool2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool2 operator<=(double lhs, double2 rhs) => new bool2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(double2 lhs, double2 rhs) => new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(double2 lhs, double rhs) => new bool2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool2 operator>(double lhs, double2 rhs) => new bool2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(double2 lhs, double2 rhs) => new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(double2 lhs, double rhs) => new bool2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bool2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool2 operator>=(double lhs, double2 rhs) => new bool2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double2 operator+(double2 lhs, double2 rhs) => new double2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double2 operator+(double2 lhs, double rhs) => new double2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static double2 operator+(double lhs, double2 rhs) => new double2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double2 operator-(double2 lhs, double2 rhs) => new double2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double2 operator-(double2 lhs, double rhs) => new double2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static double2 operator-(double lhs, double2 rhs) => new double2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double2 operator*(double2 lhs, double2 rhs) => new double2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double2 operator*(double2 lhs, double rhs) => new double2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static double2 operator*(double lhs, double2 rhs) => new double2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double2 operator/(double2 lhs, double2 rhs) => new double2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double2 operator/(double2 lhs, double rhs) => new double2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static double2 operator/(double lhs, double2 rhs) => new double2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator+ (identity).
        /// </summary>
        public static double2 operator+(double2 v) => v;
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator- (-v).
        /// </summary>
        public static double2 operator-(double2 v) => new double2(-v.x, -v.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static double2 operator%(double2 lhs, double2 rhs) => new double2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static double2 operator%(double2 lhs, double rhs) => new double2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Returns a double2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static double2 operator%(double lhs, double2 rhs) => new double2(lhs % rhs.x, lhs % rhs.y);

        #endregion

    }
}
