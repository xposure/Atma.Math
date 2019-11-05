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
    /// Static class that contains static glm functions
    /// </summary>
    public static partial class glm
    {
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static bool[] Values(qbool q) => q.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<bool> GetEnumerator(qbool q) => q.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public static string ToString(qbool q) => q.ToString();
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public static string ToString(qbool q, string sep) => q.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(qbool q, string sep, IFormatProvider provider) => q.ToString(sep, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(qbool q) => q.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(qbool q, qbool rhs) => q.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(qbool q, object obj) => q.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(qbool q) => q.GetHashCode();
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(qbool lhs, qbool rhs) => qbool.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(qbool lhs, qbool rhs) => qbool.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Not (!v).
        /// </summary>
        public static bool4 Not(qbool v) => qbool.Not(v);
        
        /// <summary>
        /// Returns a qbool from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static qbool And(qbool lhs, qbool rhs) => qbool.And(lhs, rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static qbool Nand(qbool lhs, qbool rhs) => qbool.Nand(lhs, rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static qbool Or(qbool lhs, qbool rhs) => qbool.Or(lhs, rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static qbool Nor(qbool lhs, qbool rhs) => qbool.Nor(lhs, rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static qbool Xor(qbool lhs, qbool rhs) => qbool.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static qbool Xnor(qbool lhs, qbool rhs) => qbool.Xnor(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this quaternion.
        /// </summary>
        public static bool MinElement(qbool q) => q.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this quaternion.
        /// </summary>
        public static bool MaxElement(qbool q) => q.MaxElement;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public static bool All(qbool q) => q.All;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public static bool Any(qbool q) => q.Any;

    }
}
