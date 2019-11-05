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
        public static swizzle_int4 swizzle(int4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static int[] Values(int4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<int> GetEnumerator(int4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(int4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(int4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(int4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(int4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(int4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(int4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(int4 v, int4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(int4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(int4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(int4 lhs, int4 rhs) => int4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(int4 lhs, int4 rhs) => int4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool4 GreaterThan(int4 lhs, int4 rhs) => int4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool4 GreaterThanEqual(int4 lhs, int4 rhs) => int4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool4 LesserThan(int4 lhs, int4 rhs) => int4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool4 LesserThanEqual(int4 lhs, int4 rhs) => int4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Abs (System.Math.Abs(v)).
        /// </summary>
        public static int4 Abs(int4 v) => int4.Abs(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static int4 HermiteInterpolationOrder3(int4 v) => int4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static int4 HermiteInterpolationOrder5(int4 v) => int4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static int4 Sqr(int4 v) => int4.Sqr(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static int4 Pow2(int4 v) => int4.Pow2(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static int4 Pow3(int4 v) => int4.Pow3(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static int4 Step(int4 v) => int4.Step(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Sqrt ((int)System.Math.Sqrt((double)v)).
        /// </summary>
        public static int4 Sqrt(int4 v) => int4.Sqrt(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of InverseSqrt ((int)(1.0 / System.Math.Sqrt((double)v))).
        /// </summary>
        public static int4 InverseSqrt(int4 v) => int4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Sign (System.Math.Sign(v)).
        /// </summary>
        public static int4 Sign(int4 v) => int4.Sign(v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Max (System.Math.Max(lhs, rhs)).
        /// </summary>
        public static int4 Max(int4 lhs, int4 rhs) => int4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Min (System.Math.Min(lhs, rhs)).
        /// </summary>
        public static int4 Min(int4 lhs, int4 rhs) => int4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Pow ((int)System.Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static int4 Pow(int4 lhs, int4 rhs) => int4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Log ((int)System.Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static int4 Log(int4 lhs, int4 rhs) => int4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Clamp (System.Math.Min(System.Math.Max(v, min), max)).
        /// </summary>
        public static int4 Clamp(int4 v, int4 min, int4 max) => int4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int4 Mix(int4 min, int4 max, int4 a) => int4.Mix(min, max, a);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int4 Lerp(int4 min, int4 max, int4 a) => int4.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int4 Smoothstep(int4 edge0, int4 edge1, int4 v) => int4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int4 Smootherstep(int4 edge0, int4 edge1, int4 v) => int4.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int4 Fma(int4 a, int4 b, int4 c) => int4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static int2x4 OuterProduct(int4 c, int2 r) => int4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static int3x4 OuterProduct(int4 c, int3 r) => int4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static int4x4 OuterProduct(int4 c, int4 r) => int4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static int4 Add(int4 lhs, int4 rhs) => int4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static int4 Sub(int4 lhs, int4 rhs) => int4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static int4 Mul(int4 lhs, int4 rhs) => int4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static int4 Div(int4 lhs, int4 rhs) => int4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static int4 Xor(int4 lhs, int4 rhs) => int4.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static int4 BitwiseOr(int4 lhs, int4 rhs) => int4.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static int4 BitwiseAnd(int4 lhs, int4 rhs) => int4.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static int4 LeftShift(int4 lhs, int4 rhs) => int4.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a int4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static int4 RightShift(int4 lhs, int4 rhs) => int4.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static int MinElement(int4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static int MaxElement(int4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(int4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(int4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static int Sum(int4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(int4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(int4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(int4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(int4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(int4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static int Dot(int4 lhs, int4 rhs) => int4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(int4 lhs, int4 rhs) => int4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(int4 lhs, int4 rhs) => int4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static int4 Reflect(int4 I, int4 N) => int4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static int4 Refract(int4 I, int4 N, int eta) => int4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static int4 FaceForward(int4 N, int4 I, int4 Nref) => int4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a int4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static int4 Random(Random random, int4 maxValue) => int4.Random(random, maxValue);
        
        /// <summary>
        /// Returns a int4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int4 Random(Random random, int4 minValue, int4 maxValue) => int4.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a int4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int4 RandomUniform(Random random, int4 minValue, int4 maxValue) => int4.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a int4 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static int4 RandomPoisson(Random random, double4 lambda) => int4.RandomPoisson(random, lambda);

    }
}
