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
    /// Static class that contains static glm functions
    /// </summary>
    public static partial class glm
    {
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public static swizzle_long3 swizzle(long3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static long[] Values(long3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<long> GetEnumerator(long3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(long3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(long3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(long3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(long3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(long3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(long3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(long3 v, long3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(long3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(long3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool3 Equal(long3 lhs, long3 rhs) => long3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(long lhs, long rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool3 NotEqual(long3 lhs, long3 rhs) => long3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(long lhs, long rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool3 GreaterThan(long3 lhs, long3 rhs) => long3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool GreaterThan(long lhs, long rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool3 GreaterThanEqual(long3 lhs, long3 rhs) => long3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool GreaterThanEqual(long lhs, long rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool3 LesserThan(long3 lhs, long3 rhs) => long3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool LesserThan(long lhs, long rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool3 LesserThanEqual(long3 lhs, long3 rhs) => long3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool LesserThanEqual(long lhs, long rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static long3 Abs(long3 v) => long3.Abs(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static long Abs(long v) => System.Math.Abs(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static long3 HermiteInterpolationOrder3(long3 v) => long3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static long HermiteInterpolationOrder3(long v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a long3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static long3 HermiteInterpolationOrder5(long3 v) => long3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static long HermiteInterpolationOrder5(long v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static long3 Sqr(long3 v) => long3.Sqr(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static long Sqr(long v) => v * v;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static long3 Pow2(long3 v) => long3.Pow2(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static long Pow2(long v) => v * v;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static long3 Pow3(long3 v) => long3.Pow3(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static long Pow3(long v) => v * v * v;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static long3 Step(long3 v) => long3.Step(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static long Step(long v) => v >= 0 ? 1 : 0;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Sqrt ((long)System.Math.Sqrt((double)v)).
        /// </summary>
        public static long3 Sqrt(long3 v) => long3.Sqrt(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Sqrt ((long)System.Math.Sqrt((double)v)).
        /// </summary>
        public static long Sqrt(long v) => (long)System.Math.Sqrt((double)v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of InverseSqrt ((long)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static long3 InverseSqrt(long3 v) => long3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of InverseSqrt ((long)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static long InverseSqrt(long v) => (long)(1.0 / System.Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int3 Sign(long3 v) => long3.Sign(v);
        
        /// <summary>
        /// Returns a int3 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int Sign(long v) => System.Math.Sign(v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static long3 Max(long3 lhs, long3 rhs) => long3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static long Max(long lhs, long rhs) => System.Math.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static long3 Min(long3 lhs, long3 rhs) => long3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static long Min(long lhs, long rhs) => System.Math.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Pow ((long)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static long3 Pow(long3 lhs, long3 rhs) => long3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Pow ((long)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static long Pow(long lhs, long rhs) => (long)System.Math.Pow((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Log ((long)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static long3 Log(long3 lhs, long3 rhs) => long3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Log ((long)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static long Log(long lhs, long rhs) => (long)System.Math.Log((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long3 Clamp(long3 v, long3 min, long3 max) => long3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static long Clamp(long v, long min, long max) => System.Math.Min(System.Math.Max(v, min), max);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long3 Mix(long3 min, long3 max, long3 a) => long3.Mix(min, max, a);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long Mix(long min, long max, long a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long3 Lerp(long3 min, long3 max, long3 a) => long3.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long Lerp(long min, long max, long a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long3 Smoothstep(long3 edge0, long3 edge1, long3 v) => long3.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long Smoothstep(long edge0, long edge1, long v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3();
        
        /// <summary>
        /// Returns a long3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long3 Smootherstep(long3 edge0, long3 edge1, long3 v) => long3.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long Smootherstep(long edge0, long edge1, long v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5();
        
        /// <summary>
        /// Returns a long3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long3 Fma(long3 a, long3 b, long3 c) => long3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long Fma(long a, long b, long c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static long2x3 OuterProduct(long3 c, long2 r) => long3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static long3x3 OuterProduct(long3 c, long3 r) => long3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static long4x3 OuterProduct(long3 c, long4 r) => long3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static long3 Add(long3 lhs, long3 rhs) => long3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static long Add(long lhs, long rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static long3 Sub(long3 lhs, long3 rhs) => long3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static long Sub(long lhs, long rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static long3 Mul(long3 lhs, long3 rhs) => long3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static long Mul(long lhs, long rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static long3 Div(long3 lhs, long3 rhs) => long3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static long Div(long lhs, long rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static long3 Xor(long3 lhs, long3 rhs) => long3.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static long Xor(long lhs, long rhs) => lhs ^ rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static long3 BitwiseOr(long3 lhs, long3 rhs) => long3.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static long BitwiseOr(long lhs, long rhs) => lhs | rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static long3 BitwiseAnd(long3 lhs, long3 rhs) => long3.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static long BitwiseAnd(long lhs, long rhs) => lhs & rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static long3 LeftShift(long3 lhs, int3 rhs) => long3.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static long LeftShift(long lhs, int rhs) => lhs << rhs;
        
        /// <summary>
        /// Returns a long3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static long3 RightShift(long3 lhs, int3 rhs) => long3.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns a long3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static long RightShift(long lhs, int rhs) => lhs >> rhs;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static long MinElement(long3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static long MaxElement(long3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(long3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(long3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static long Sum(long3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(long3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(long3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(long3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(long3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(long3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static long Dot(long3 lhs, long3 rhs) => long3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(long3 lhs, long3 rhs) => long3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(long3 lhs, long3 rhs) => long3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static long3 Reflect(long3 I, long3 N) => long3.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static long3 Refract(long3 I, long3 N, long eta) => long3.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static long3 FaceForward(long3 N, long3 I, long3 Nref) => long3.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static long3 Cross(long3 l, long3 r) => long3.Cross(l, r);
        
        /// <summary>
        /// Returns a long3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static long3 Random(Random random, long3 maxValue) => long3.Random(random, maxValue);
        
        /// <summary>
        /// Returns a long3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static long Random(Random random, long maxValue) => (long)random.Next((int)maxValue);
        
        /// <summary>
        /// Returns a long3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long3 Random(Random random, long3 minValue, long3 maxValue) => long3.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a long3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long Random(Random random, long minValue, long maxValue) => (long)random.Next((int)minValue, (int)maxValue);
        
        /// <summary>
        /// Returns a long3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long3 RandomUniform(Random random, long3 minValue, long3 maxValue) => long3.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a long3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long RandomUniform(Random random, long minValue, long maxValue) => (long)random.Next((int)minValue, (int)maxValue);

    }
}
