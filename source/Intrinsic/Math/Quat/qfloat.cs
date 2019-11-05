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
    /// A quaternion of type float.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct qfloat : IReadOnlyList<float>, IEquatable<qfloat>
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
        public qfloat(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public qfloat(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// copy constructor
        /// </summary>
        public qfloat(qfloat q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)
        /// </summary>
        public qfloat(float3 v, float s)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = s;
        }
        
        /// <summary>
        /// Create a quaternion from two normalized axis (http://lolengine.net/blog/2013/09/18/beautiful-maths-quaternion-from-vectors)
        /// </summary>
        public qfloat(float3 u, float3 v)
        {
            var localW = float3.Cross(u, v);
            var dot = float3.Dot(u, v);
            var q = new qfloat(localW.x, localW.y, localW.z, 1f + dot).Normalized;
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// Create a quaternion from two normalized axis (http://lolengine.net/blog/2013/09/18/beautiful-maths-quaternion-from-vectors)
        /// </summary>
        public qfloat(float3 eulerAngle)
        {
            var c = float3.Cos(eulerAngle / 2);
            var s = float3.Sin(eulerAngle / 2);
            this.x = s.x * c.y * c.z - c.x * s.y * s.z;
            this.y = c.x * s.y * c.z + s.x * c.y * s.z;
            this.z = c.x * c.y * s.z - s.x * s.y * c.z;
            this.w = c.x * c.y * c.z + s.x * s.y * s.z;
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a float3x3.
        /// </summary>
        public qfloat(float3x3 m)
            : this(FromMat3(m))
        {
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a float4x4.
        /// </summary>
        public qfloat(float4x4 m)
            : this(FromMat4(m))
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a qdouble.
        /// </summary>
        public static implicit operator qdouble(qfloat v) => new qdouble((double)v.x, (double)v.y, (double)v.z, (double)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int4.
        /// </summary>
        public static explicit operator int4(qfloat v) => new int4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a qint.
        /// </summary>
        public static explicit operator qint(qfloat v) => new qint((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uint4.
        /// </summary>
        public static explicit operator uint4(qfloat v) => new uint4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a quint.
        /// </summary>
        public static explicit operator quint(qfloat v) => new quint((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a float4.
        /// </summary>
        public static explicit operator float4(qfloat v) => new float4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a double4.
        /// </summary>
        public static explicit operator double4(qfloat v) => new double4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a long4.
        /// </summary>
        public static explicit operator long4(qfloat v) => new long4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a qlong.
        /// </summary>
        public static explicit operator qlong(qfloat v) => new qlong((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bool4.
        /// </summary>
        public static explicit operator bool4(qfloat v) => new bool4(v.x != 0f, v.y != 0f, v.z != 0f, v.w != 0f);
        
        /// <summary>
        /// Explicitly converts this to a qbool.
        /// </summary>
        public static explicit operator qbool(qfloat v) => new qbool(v.x != 0f, v.y != 0f, v.z != 0f, v.w != 0f);
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a float3x3.
        /// </summary>
        public static explicit operator qfloat(float3x3 m) => FromMat3(m);
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a float4x4.
        /// </summary>
        public static explicit operator qfloat(float4x4 m) => FromMat4(m);

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
        /// Returns an array with all values
        /// </summary>
        public float[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the euclidean length of this quaternion.
        /// </summary>
        public float Length => (float)System.Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the squared euclidean length of this quaternion.
        /// </summary>
        public float LengthSqr => ((x*x + y*y) + (z*z + w*w));
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (undefined if this has zero length).
        /// </summary>
        public qfloat Normalized => this / (float)Length;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (returns zero if length is zero).
        /// </summary>
        public qfloat NormalizedSafe => this == Zero ? Identity : this / (float)Length;
        
        /// <summary>
        /// Returns the represented angle of this quaternion.
        /// </summary>
        public double Angle => System.Math.Acos((double)w) * 2.0;
        
        /// <summary>
        /// Returns the represented axis of this quaternion.
        /// </summary>
        public float3 Axis
        {
            get
            {
                var s1 = 1 - w * w;
                if (s1 < 0) return float3.UnitZ;
                var s2 = 1 / System.Math.Sqrt(s1);
                return new float3((float)(x * s2), (float)(y * s2), (float)(z * s2));
            }
        }
        
        /// <summary>
        /// Returns the represented yaw angle of this quaternion.
        /// </summary>
        public double Yaw => System.Math.Asin(-2.0 * (double)(x * z - w * y));
        
        /// <summary>
        /// Returns the represented pitch angle of this quaternion.
        /// </summary>
        public double Pitch => System.Math.Atan2(2.0 * (double)(y * z + w * x), (double)(w * w - x * x - y * y + z * z));
        
        /// <summary>
        /// Returns the represented roll angle of this quaternion.
        /// </summary>
        public double Roll => System.Math.Atan2(2.0 * (double)(x * y + w * z), (double)(w * w + x * x - y * y - z * z));
        
        /// <summary>
        /// Returns the represented euler angles (pitch, yaw, roll) of this quaternion.
        /// </summary>
        public double3 EulerAngles => new double3(Pitch, Yaw, Roll);
        
        /// <summary>
        /// Creates a float3x3 that realizes the rotation of this quaternion
        /// </summary>
        public float3x3 ToMat3 => new float3x3(1 - 2 * (y*y + z*z), 2 * (x*y + w*z), 2 * (x*z - w*y), 2 * (x*y - w*z), 1 - 2 * (x*x + z*z), 2 * (y*z + w*x), 2 * (x*z + w*y), 2 * (y*z - w*x), 1 - 2 * (x*x + y*y));
        
        /// <summary>
        /// Creates a float4x4 that realizes the rotation of this quaternion
        /// </summary>
        public float4x4 ToMat4 => new float4x4(ToMat3);
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public qfloat Conjugate => new qfloat(-x, -y, -z, w);
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public qfloat Inverse => Conjugate / LengthSqr;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero quaternion
        /// </summary>
        public static qfloat Zero { get; } = new qfloat(0f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-ones quaternion
        /// </summary>
        public static qfloat Ones { get; } = new qfloat(1f, 1f, 1f, 1f);
        
        /// <summary>
        /// Predefined identity quaternion
        /// </summary>
        public static qfloat Identity { get; } = new qfloat(0f, 0f, 0f, 1f);
        
        /// <summary>
        /// Predefined unit-X quaternion
        /// </summary>
        public static qfloat UnitX { get; } = new qfloat(1f, 0f, 0f, 0f);
        
        /// <summary>
        /// Predefined unit-Y quaternion
        /// </summary>
        public static qfloat UnitY { get; } = new qfloat(0f, 1f, 0f, 0f);
        
        /// <summary>
        /// Predefined unit-Z quaternion
        /// </summary>
        public static qfloat UnitZ { get; } = new qfloat(0f, 0f, 1f, 0f);
        
        /// <summary>
        /// Predefined unit-W quaternion
        /// </summary>
        public static qfloat UnitW { get; } = new qfloat(0f, 0f, 0f, 1f);
        
        /// <summary>
        /// Predefined all-MaxValue quaternion
        /// </summary>
        public static qfloat MaxValue { get; } = new qfloat(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue quaternion
        /// </summary>
        public static qfloat MinValue { get; } = new qfloat(float.MinValue, float.MinValue, float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon quaternion
        /// </summary>
        public static qfloat Epsilon { get; } = new qfloat(float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN quaternion
        /// </summary>
        public static qfloat NaN { get; } = new qfloat(float.NaN, float.NaN, float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity quaternion
        /// </summary>
        public static qfloat NegativeInfinity { get; } = new qfloat(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity quaternion
        /// </summary>
        public static qfloat PositiveInfinity { get; } = new qfloat(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(qfloat lhs, qfloat rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(qfloat lhs, qfloat rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns proper multiplication of two quaternions.
        /// </summary>
        public static qfloat operator*(qfloat p, qfloat q) => new qfloat(p.w * q.x + p.x * q.w + p.y * q.z - p.z * q.y, p.w * q.y + p.y * q.w + p.z * q.x - p.x * q.z, p.w * q.z + p.z * q.w + p.x * q.y - p.y * q.x, p.w * q.w - p.x * q.x - p.y * q.y - p.z * q.z);
        
        /// <summary>
        /// Returns a vector rotated by the quaternion.
        /// </summary>
        public static float3 operator*(qfloat q, float3 v)
        {
            var qv = new float3(q.x, q.y, q.z);
            var uv = float3.Cross(qv, v);
            var uuv = float3.Cross(qv, uv);
            return v + ((uv * q.w) + uuv) * 2;
        }
        
        /// <summary>
        /// Returns a vector rotated by the quaternion (preserves v.w).
        /// </summary>
        public static float4 operator*(qfloat q, float4 v) => new float4(q * new float3(v), v.w);
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion.
        /// </summary>
        public static float3 operator*(float3 v, qfloat q) => q.Inverse * v;
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion (preserves v.w).
        /// </summary>
        public static float4 operator*(float4 v, qfloat q) => q.Inverse * v;

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
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public string ToString(string sep) => ((x + sep + y) + sep + (z + sep + w));
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => ((x.ToString(provider) + sep + y.ToString(provider)) + sep + (z.ToString(provider) + sep + w.ToString(provider)));
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => ((x.ToString(format) + sep + y.ToString(format)) + sep + (z.ToString(format) + sep + w.ToString(format)));
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => ((x.ToString(format, provider) + sep + y.ToString(format, provider)) + sep + (z.ToString(format, provider) + sep + w.ToString(format, provider)));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(qfloat rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is qfloat && Equals((qfloat) obj);
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
        /// Rotates this quaternion from an axis and an angle (in radians).
        /// </summary>
        public qfloat Rotated(float angle, float3 v) => this * FromAxisAngle(angle, v);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using ', ' as a separator).
        /// </summary>
        public static qfloat Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator).
        /// </summary>
        public static qfloat Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new qfloat(float.Parse(kvp[0].Trim()), float.Parse(kvp[1].Trim()), float.Parse(kvp[2].Trim()), float.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a type provider).
        /// </summary>
        public static qfloat Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new qfloat(float.Parse(kvp[0].Trim(), provider), float.Parse(kvp[1].Trim(), provider), float.Parse(kvp[2].Trim(), provider), float.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style).
        /// </summary>
        public static qfloat Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new qfloat(float.Parse(kvp[0].Trim(), style), float.Parse(kvp[1].Trim(), style), float.Parse(kvp[2].Trim(), style), float.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static qfloat Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new qfloat(float.Parse(kvp[0].Trim(), style, provider), float.Parse(kvp[1].Trim(), style, provider), float.Parse(kvp[2].Trim(), style, provider), float.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out qfloat result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out qfloat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            float x = 0f, y = 0f, z = 0f, w = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), out x) && float.TryParse(kvp[1].Trim(), out y)) && (float.TryParse(kvp[2].Trim(), out z) && float.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new qfloat(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out qfloat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            float x = 0f, y = 0f, z = 0f, w = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), style, provider, out x) && float.TryParse(kvp[1].Trim(), style, provider, out y)) && (float.TryParse(kvp[2].Trim(), style, provider, out z) && float.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new qfloat(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static float Dot(qfloat lhs, qfloat rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Creates a quaternion from an axis and an angle (in radians).
        /// </summary>
        public static qfloat FromAxisAngle(float angle, float3 v)
        {
            var s = System.Math.Sin((double)angle * 0.5);
            var c = System.Math.Cos((double)angle * 0.5);
            return new qfloat((float)((double)v.x * s), (float)((double)v.y * s), (float)((double)v.z * s), (float)c);
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a float4x4.
        /// </summary>
        public static qfloat FromMat3(float3x3 m)
        {
            var fourXSquaredMinus1 = m.m00 - m.m11 - m.m22;
            var fourYSquaredMinus1 = m.m11 - m.m00 - m.m22;
            var fourZSquaredMinus1 = m.m22 - m.m00 - m.m11;
            var fourWSquaredMinus1 = m.m00 + m.m11 + m.m22;
            var biggestIndex = 0;
            var fourBiggestSquaredMinus1 = fourWSquaredMinus1;
            if(fourXSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourXSquaredMinus1;
                biggestIndex = 1;
            }
            if(fourYSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourYSquaredMinus1;
                biggestIndex = 2;
            }
            if(fourZSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourZSquaredMinus1;
                biggestIndex = 3;
            }
            var biggestVal = System.Math.Sqrt((double)fourBiggestSquaredMinus1 + 1.0) * 0.5;
            var mult = 0.25 / biggestVal;
            switch(biggestIndex)
            {
                case 0: return new qfloat((float)((double)(m.m12 - m.m21) * mult), (float)((double)(m.m20 - m.m02) * mult), (float)((double)(m.m01 - m.m10) * mult), (float)(biggestVal));
                case 1: return new qfloat((float)(biggestVal), (float)((double)(m.m01 + m.m10) * mult), (float)((double)(m.m20 + m.m02) * mult), (float)((double)(m.m12 - m.m21) * mult));
                case 2: return new qfloat((float)((double)(m.m01 + m.m10) * mult), (float)(biggestVal), (float)((double)(m.m12 + m.m21) * mult), (float)((double)(m.m20 - m.m02) * mult));
                default: return new qfloat((float)((double)(m.m20 + m.m02) * mult), (float)((double)(m.m12 + m.m21) * mult), (float)(biggestVal), (float)((double)(m.m01 - m.m10) * mult));
            }
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a float3x3.
        /// </summary>
        public static qfloat FromMat4(float4x4 m) => FromMat3(new float3x3(m));
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static qfloat Cross(qfloat q1, qfloat q2) => new qfloat(q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y, q1.w * q2.y + q1.y * q2.w + q1.z * q2.x - q1.x * q2.z, q1.w * q2.z + q1.z * q2.w + q1.x * q2.y - q1.y * q2.x, q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static qfloat Mix(qfloat x, qfloat y, float a)
        {
            var cosTheta = (double)Dot(x, y);
            if (cosTheta > 1 - float.Epsilon)
                return Lerp(x, y, a);
            else
            {
                var angle = System.Math.Acos((double)cosTheta);
                return (qfloat)( (System.Math.Sin((1 - (double)a) * angle) * (qdouble)x + System.Math.Sin((double)a * angle) * (qdouble)y) / System.Math.Sin(angle) );
            }
        }
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static qfloat SLerp(qfloat x, qfloat y, float a)
        {
            var z = y;
            var cosTheta = (double)Dot(x, y);
            if (cosTheta < 0) { z = -y; cosTheta = -cosTheta; }
            if (cosTheta > 1 - float.Epsilon)
                return Lerp(x, z, a);
            else
            {
                var angle = System.Math.Acos((double)cosTheta);
                return (qfloat)( (System.Math.Sin((1 - (double)a) * angle) * (qdouble)x + System.Math.Sin((double)a * angle) * (qdouble)z) / System.Math.Sin(angle) );
            }
        }
        
        /// <summary>
        /// Applies squad interpolation of these quaternions
        /// </summary>
        public static qfloat Squad(qfloat q1, qfloat q2, qfloat s1, qfloat s2, float h) => Mix(Mix(q1, q2, h), Mix(s1, s2, h), 2 * (1 - h) * h);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(qfloat v) => new bool4(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z), float.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsInfinity(float v) => new bool4(float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsFinite(qfloat v) => new bool4(!float.IsNaN(v.x) && !float.IsInfinity(v.x), !float.IsNaN(v.y) && !float.IsInfinity(v.y), !float.IsNaN(v.z) && !float.IsInfinity(v.z), !float.IsNaN(v.w) && !float.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool4 IsFinite(float v) => new bool4(!float.IsNaN(v) && !float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(qfloat v) => new bool4(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z), float.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool4 IsNaN(float v) => new bool4(float.IsNaN(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool4 IsNegativeInfinity(qfloat v) => new bool4(float.IsNegativeInfinity(v.x), float.IsNegativeInfinity(v.y), float.IsNegativeInfinity(v.z), float.IsNegativeInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool4 IsNegativeInfinity(float v) => new bool4(float.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool4 IsPositiveInfinity(qfloat v) => new bool4(float.IsPositiveInfinity(v.x), float.IsPositiveInfinity(v.y), float.IsPositiveInfinity(v.z), float.IsPositiveInfinity(v.w));
        
        /// <summary>
        /// Returns a bool from the application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool4 IsPositiveInfinity(float v) => new bool4(float.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(qfloat lhs, qfloat rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(qfloat lhs, float rhs) => new bool4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(float lhs, qfloat rhs) => new bool4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(float lhs, float rhs) => new bool4(lhs == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(qfloat lhs, qfloat rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(qfloat lhs, float rhs) => new bool4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(float lhs, qfloat rhs) => new bool4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(float lhs, float rhs) => new bool4(lhs != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(qfloat lhs, qfloat rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(qfloat lhs, float rhs) => new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(float lhs, qfloat rhs) => new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(float lhs, float rhs) => new bool4(lhs > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(qfloat lhs, qfloat rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(qfloat lhs, float rhs) => new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(float lhs, qfloat rhs) => new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(float lhs, float rhs) => new bool4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(qfloat lhs, qfloat rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(qfloat lhs, float rhs) => new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(float lhs, qfloat rhs) => new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(float lhs, float rhs) => new bool4(lhs < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(qfloat lhs, qfloat rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(qfloat lhs, float rhs) => new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(float lhs, qfloat rhs) => new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(float lhs, float rhs) => new bool4(lhs <= rhs);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static qfloat Lerp(qfloat min, qfloat max, qfloat a) => new qfloat(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static qfloat Lerp(qfloat min, qfloat max, float a) => new qfloat(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static qfloat Lerp(qfloat min, float max, qfloat a) => new qfloat(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static qfloat Lerp(qfloat min, float max, float a) => new qfloat(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static qfloat Lerp(float min, qfloat max, qfloat a) => new qfloat(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static qfloat Lerp(float min, qfloat max, float a) => new qfloat(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static qfloat Lerp(float min, float max, qfloat a) => new qfloat(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a qfloat from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static qfloat Lerp(float min, float max, float a) => new qfloat(min * (1-a) + max * a);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(qfloat lhs, qfloat rhs) => new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(qfloat lhs, float rhs) => new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bool4 operator<(float lhs, qfloat rhs) => new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(qfloat lhs, qfloat rhs) => new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(qfloat lhs, float rhs) => new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bool4 operator<=(float lhs, qfloat rhs) => new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(qfloat lhs, qfloat rhs) => new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(qfloat lhs, float rhs) => new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bool4 operator>(float lhs, qfloat rhs) => new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(qfloat lhs, qfloat rhs) => new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(qfloat lhs, float rhs) => new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bool4 operator>=(float lhs, qfloat rhs) => new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator+ (identity).
        /// </summary>
        public static qfloat operator+(qfloat v) => v;
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator- (-v).
        /// </summary>
        public static qfloat operator-(qfloat v) => new qfloat(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static qfloat operator+(qfloat lhs, qfloat rhs) => new qfloat(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static qfloat operator+(qfloat lhs, float rhs) => new qfloat(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static qfloat operator+(float lhs, qfloat rhs) => new qfloat(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static qfloat operator-(qfloat lhs, qfloat rhs) => new qfloat(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static qfloat operator-(qfloat lhs, float rhs) => new qfloat(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static qfloat operator-(float lhs, qfloat rhs) => new qfloat(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static qfloat operator*(qfloat lhs, float rhs) => new qfloat(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static qfloat operator*(float lhs, qfloat rhs) => new qfloat(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a qfloat from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static qfloat operator/(qfloat lhs, float rhs) => new qfloat(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        #endregion

    }
}
