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
    /// A quaternion of type bool.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct qbool : IReadOnlyList<bool>, IEquatable<qbool>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public bool z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public bool w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public qbool(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public qbool(bool v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// copy constructor
        /// </summary>
        public qbool(qbool q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)
        /// </summary>
        public qbool(bool3 v, bool s)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = s;
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a int4.
        /// </summary>
        public static explicit operator int4(qbool v) => new int4(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a qint.
        /// </summary>
        public static explicit operator qint(qbool v) => new qint(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a uint4.
        /// </summary>
        public static explicit operator uint4(qbool v) => new uint4(v.x ? 1u : 0u, v.y ? 1u : 0u, v.z ? 1u : 0u, v.w ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a quint.
        /// </summary>
        public static explicit operator quint(qbool v) => new quint(v.x ? 1u : 0u, v.y ? 1u : 0u, v.z ? 1u : 0u, v.w ? 1u : 0u);
        
        /// <summary>
        /// Explicitly converts this to a float4.
        /// </summary>
        public static explicit operator float4(qbool v) => new float4(v.x ? 1f : 0f, v.y ? 1f : 0f, v.z ? 1f : 0f, v.w ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a qfloat.
        /// </summary>
        public static explicit operator qfloat(qbool v) => new qfloat(v.x ? 1f : 0f, v.y ? 1f : 0f, v.z ? 1f : 0f, v.w ? 1f : 0f);
        
        /// <summary>
        /// Explicitly converts this to a double4.
        /// </summary>
        public static explicit operator double4(qbool v) => new double4(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, v.z ? 1.0 : 0.0, v.w ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a qdouble.
        /// </summary>
        public static explicit operator qdouble(qbool v) => new qdouble(v.x ? 1.0 : 0.0, v.y ? 1.0 : 0.0, v.z ? 1.0 : 0.0, v.w ? 1.0 : 0.0);
        
        /// <summary>
        /// Explicitly converts this to a long4.
        /// </summary>
        public static explicit operator long4(qbool v) => new long4(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a qlong.
        /// </summary>
        public static explicit operator qlong(qbool v) => new qlong(v.x ? 1 : 0, v.y ? 1 : 0, v.z ? 1 : 0, v.w ? 1 : 0);
        
        /// <summary>
        /// Explicitly converts this to a bool4.
        /// </summary>
        public static explicit operator bool4(qbool v) => new bool4((bool)v.x, (bool)v.y, (bool)v.z, (bool)v.w);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int index]
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
        public bool[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the minimal component of this quaternion.
        /// </summary>
        public bool MinElement => ((x && y) && (z && w));
        
        /// <summary>
        /// Returns the maximal component of this quaternion.
        /// </summary>
        public bool MaxElement => ((x || y) || (z || w));
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => ((x && y) && (z && w));
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => ((x || y) || (z || w));

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero quaternion
        /// </summary>
        public static qbool Zero { get; } = new qbool(false, false, false, false);
        
        /// <summary>
        /// Predefined all-ones quaternion
        /// </summary>
        public static qbool Ones { get; } = new qbool(true, true, true, true);
        
        /// <summary>
        /// Predefined identity quaternion
        /// </summary>
        public static qbool Identity { get; } = new qbool(false, false, false, true);
        
        /// <summary>
        /// Predefined unit-X quaternion
        /// </summary>
        public static qbool UnitX { get; } = new qbool(true, false, false, false);
        
        /// <summary>
        /// Predefined unit-Y quaternion
        /// </summary>
        public static qbool UnitY { get; } = new qbool(false, true, false, false);
        
        /// <summary>
        /// Predefined unit-Z quaternion
        /// </summary>
        public static qbool UnitZ { get; } = new qbool(false, false, true, false);
        
        /// <summary>
        /// Predefined unit-W quaternion
        /// </summary>
        public static qbool UnitW { get; } = new qbool(false, false, false, true);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(qbool lhs, qbool rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(qbool lhs, qbool rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
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
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(qbool rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is qbool && Equals((qbool) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((x.GetHashCode()) * 2) ^ y.GetHashCode()) * 2) ^ z.GetHashCode()) * 2) ^ w.GetHashCode();
            }
        }

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using ', ' as a separator).
        /// </summary>
        public static qbool Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator).
        /// </summary>
        public static qbool Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new qbool(bool.Parse(kvp[0].Trim()), bool.Parse(kvp[1].Trim()), bool.Parse(kvp[2].Trim()), bool.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out qbool result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out qbool result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            bool x = false, y = false, z = false, w = false;
            var ok = ((bool.TryParse(kvp[0].Trim(), out x) && bool.TryParse(kvp[1].Trim(), out y)) && (bool.TryParse(kvp[2].Trim(), out z) && bool.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new qbool(x, y, z, w) : Zero;
            return ok;
        }

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(qbool lhs, qbool rhs) => new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(qbool lhs, bool rhs) => new bool4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(bool lhs, qbool rhs) => new bool4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of Equal (lhs == rhs).
        /// </summary>
        public static bool4 Equal(bool lhs, bool rhs) => new bool4(lhs == rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(qbool lhs, qbool rhs) => new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(qbool lhs, bool rhs) => new bool4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(bool lhs, qbool rhs) => new bool4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bool from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool4 NotEqual(bool lhs, bool rhs) => new bool4(lhs != rhs);
        
        /// <summary>
        /// Returns a bool4 from component-wise application of Not (!v).
        /// </summary>
        public static bool4 Not(qbool v) => new bool4(!v.x, !v.y, !v.z, !v.w);
        
        /// <summary>
        /// Returns a bool from the application of Not (!v).
        /// </summary>
        public static bool4 Not(bool v) => new bool4(!v);
        
        /// <summary>
        /// Returns a qbool from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static qbool And(qbool lhs, qbool rhs) => new qbool(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z, lhs.w && rhs.w);
        
        /// <summary>
        /// Returns a qbool from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static qbool And(qbool lhs, bool rhs) => new qbool(lhs.x && rhs, lhs.y && rhs, lhs.z && rhs, lhs.w && rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static qbool And(bool lhs, qbool rhs) => new qbool(lhs && rhs.x, lhs && rhs.y, lhs && rhs.z, lhs && rhs.w);
        
        /// <summary>
        /// Returns a qbool from the application of And (lhs &amp;&amp; rhs).
        /// </summary>
        public static qbool And(bool lhs, bool rhs) => new qbool(lhs && rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static qbool Nand(qbool lhs, qbool rhs) => new qbool(!(lhs.x && rhs.x), !(lhs.y && rhs.y), !(lhs.z && rhs.z), !(lhs.w && rhs.w));
        
        /// <summary>
        /// Returns a qbool from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static qbool Nand(qbool lhs, bool rhs) => new qbool(!(lhs.x && rhs), !(lhs.y && rhs), !(lhs.z && rhs), !(lhs.w && rhs));
        
        /// <summary>
        /// Returns a qbool from component-wise application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static qbool Nand(bool lhs, qbool rhs) => new qbool(!(lhs && rhs.x), !(lhs && rhs.y), !(lhs && rhs.z), !(lhs && rhs.w));
        
        /// <summary>
        /// Returns a qbool from the application of Nand (!(lhs &amp;&amp; rhs)).
        /// </summary>
        public static qbool Nand(bool lhs, bool rhs) => new qbool(!(lhs && rhs));
        
        /// <summary>
        /// Returns a qbool from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static qbool Or(qbool lhs, qbool rhs) => new qbool(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z, lhs.w || rhs.w);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static qbool Or(qbool lhs, bool rhs) => new qbool(lhs.x || rhs, lhs.y || rhs, lhs.z || rhs, lhs.w || rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Or (lhs || rhs).
        /// </summary>
        public static qbool Or(bool lhs, qbool rhs) => new qbool(lhs || rhs.x, lhs || rhs.y, lhs || rhs.z, lhs || rhs.w);
        
        /// <summary>
        /// Returns a qbool from the application of Or (lhs || rhs).
        /// </summary>
        public static qbool Or(bool lhs, bool rhs) => new qbool(lhs || rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static qbool Nor(qbool lhs, qbool rhs) => new qbool(!(lhs.x || rhs.x), !(lhs.y || rhs.y), !(lhs.z || rhs.z), !(lhs.w || rhs.w));
        
        /// <summary>
        /// Returns a qbool from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static qbool Nor(qbool lhs, bool rhs) => new qbool(!(lhs.x || rhs), !(lhs.y || rhs), !(lhs.z || rhs), !(lhs.w || rhs));
        
        /// <summary>
        /// Returns a qbool from component-wise application of Nor (!(lhs || rhs)).
        /// </summary>
        public static qbool Nor(bool lhs, qbool rhs) => new qbool(!(lhs || rhs.x), !(lhs || rhs.y), !(lhs || rhs.z), !(lhs || rhs.w));
        
        /// <summary>
        /// Returns a qbool from the application of Nor (!(lhs || rhs)).
        /// </summary>
        public static qbool Nor(bool lhs, bool rhs) => new qbool(!(lhs || rhs));
        
        /// <summary>
        /// Returns a qbool from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static qbool Xor(qbool lhs, qbool rhs) => new qbool(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static qbool Xor(qbool lhs, bool rhs) => new qbool(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Xor (lhs != rhs).
        /// </summary>
        public static qbool Xor(bool lhs, qbool rhs) => new qbool(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a qbool from the application of Xor (lhs != rhs).
        /// </summary>
        public static qbool Xor(bool lhs, bool rhs) => new qbool(lhs != rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static qbool Xnor(qbool lhs, qbool rhs) => new qbool(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static qbool Xnor(qbool lhs, bool rhs) => new qbool(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of Xnor (lhs == rhs).
        /// </summary>
        public static qbool Xnor(bool lhs, qbool rhs) => new qbool(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a qbool from the application of Xnor (lhs == rhs).
        /// </summary>
        public static qbool Xnor(bool lhs, bool rhs) => new qbool(lhs == rhs);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a qbool from component-wise application of operator! (!v).
        /// </summary>
        public static qbool operator!(qbool v) => new qbool(!v.x, !v.y, !v.z, !v.w);
        
        /// <summary>
        /// Returns a qbool from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static qbool operator&(qbool lhs, qbool rhs) => new qbool(lhs.x && rhs.x, lhs.y && rhs.y, lhs.z && rhs.z, lhs.w && rhs.w);
        
        /// <summary>
        /// Returns a qbool from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static qbool operator&(qbool lhs, bool rhs) => new qbool(lhs.x && rhs, lhs.y && rhs, lhs.z && rhs, lhs.w && rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of operator&amp; (lhs &amp;&amp; rhs).
        /// </summary>
        public static qbool operator&(bool lhs, qbool rhs) => new qbool(lhs && rhs.x, lhs && rhs.y, lhs && rhs.z, lhs && rhs.w);
        
        /// <summary>
        /// Returns a qbool from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static qbool operator|(qbool lhs, qbool rhs) => new qbool(lhs.x || rhs.x, lhs.y || rhs.y, lhs.z || rhs.z, lhs.w || rhs.w);
        
        /// <summary>
        /// Returns a qbool from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static qbool operator|(qbool lhs, bool rhs) => new qbool(lhs.x || rhs, lhs.y || rhs, lhs.z || rhs, lhs.w || rhs);
        
        /// <summary>
        /// Returns a qbool from component-wise application of operator| (lhs || rhs).
        /// </summary>
        public static qbool operator|(bool lhs, qbool rhs) => new qbool(lhs || rhs.x, lhs || rhs.y, lhs || rhs.z, lhs || rhs.w);

        #endregion

    }
}
