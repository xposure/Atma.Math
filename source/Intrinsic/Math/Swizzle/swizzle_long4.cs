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

namespace Intrinsic.Math.Swizzle
{
    
    /// <summary>
    /// Temporary vector of type long with 4 components, used for implementing swizzling for long4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_long4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly long x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly long y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly long z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly long w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_long4.
        /// </summary>
        internal swizzle_long4(long x, long y, long z, long w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns long4.xx swizzling.
        /// </summary>
        public long2 xx => new long2(x, x);
        
        /// <summary>
        /// Returns long4.rr swizzling (equivalent to long4.xx).
        /// </summary>
        public long2 rr => new long2(x, x);
        
        /// <summary>
        /// Returns long4.xxx swizzling.
        /// </summary>
        public long3 xxx => new long3(x, x, x);
        
        /// <summary>
        /// Returns long4.rrr swizzling (equivalent to long4.xxx).
        /// </summary>
        public long3 rrr => new long3(x, x, x);
        
        /// <summary>
        /// Returns long4.xxxx swizzling.
        /// </summary>
        public long4 xxxx => new long4(x, x, x, x);
        
        /// <summary>
        /// Returns long4.rrrr swizzling (equivalent to long4.xxxx).
        /// </summary>
        public long4 rrrr => new long4(x, x, x, x);
        
        /// <summary>
        /// Returns long4.xxxy swizzling.
        /// </summary>
        public long4 xxxy => new long4(x, x, x, y);
        
        /// <summary>
        /// Returns long4.rrrg swizzling (equivalent to long4.xxxy).
        /// </summary>
        public long4 rrrg => new long4(x, x, x, y);
        
        /// <summary>
        /// Returns long4.xxxz swizzling.
        /// </summary>
        public long4 xxxz => new long4(x, x, x, z);
        
        /// <summary>
        /// Returns long4.rrrb swizzling (equivalent to long4.xxxz).
        /// </summary>
        public long4 rrrb => new long4(x, x, x, z);
        
        /// <summary>
        /// Returns long4.xxxw swizzling.
        /// </summary>
        public long4 xxxw => new long4(x, x, x, w);
        
        /// <summary>
        /// Returns long4.rrra swizzling (equivalent to long4.xxxw).
        /// </summary>
        public long4 rrra => new long4(x, x, x, w);
        
        /// <summary>
        /// Returns long4.xxy swizzling.
        /// </summary>
        public long3 xxy => new long3(x, x, y);
        
        /// <summary>
        /// Returns long4.rrg swizzling (equivalent to long4.xxy).
        /// </summary>
        public long3 rrg => new long3(x, x, y);
        
        /// <summary>
        /// Returns long4.xxyx swizzling.
        /// </summary>
        public long4 xxyx => new long4(x, x, y, x);
        
        /// <summary>
        /// Returns long4.rrgr swizzling (equivalent to long4.xxyx).
        /// </summary>
        public long4 rrgr => new long4(x, x, y, x);
        
        /// <summary>
        /// Returns long4.xxyy swizzling.
        /// </summary>
        public long4 xxyy => new long4(x, x, y, y);
        
        /// <summary>
        /// Returns long4.rrgg swizzling (equivalent to long4.xxyy).
        /// </summary>
        public long4 rrgg => new long4(x, x, y, y);
        
        /// <summary>
        /// Returns long4.xxyz swizzling.
        /// </summary>
        public long4 xxyz => new long4(x, x, y, z);
        
        /// <summary>
        /// Returns long4.rrgb swizzling (equivalent to long4.xxyz).
        /// </summary>
        public long4 rrgb => new long4(x, x, y, z);
        
        /// <summary>
        /// Returns long4.xxyw swizzling.
        /// </summary>
        public long4 xxyw => new long4(x, x, y, w);
        
        /// <summary>
        /// Returns long4.rrga swizzling (equivalent to long4.xxyw).
        /// </summary>
        public long4 rrga => new long4(x, x, y, w);
        
        /// <summary>
        /// Returns long4.xxz swizzling.
        /// </summary>
        public long3 xxz => new long3(x, x, z);
        
        /// <summary>
        /// Returns long4.rrb swizzling (equivalent to long4.xxz).
        /// </summary>
        public long3 rrb => new long3(x, x, z);
        
        /// <summary>
        /// Returns long4.xxzx swizzling.
        /// </summary>
        public long4 xxzx => new long4(x, x, z, x);
        
        /// <summary>
        /// Returns long4.rrbr swizzling (equivalent to long4.xxzx).
        /// </summary>
        public long4 rrbr => new long4(x, x, z, x);
        
        /// <summary>
        /// Returns long4.xxzy swizzling.
        /// </summary>
        public long4 xxzy => new long4(x, x, z, y);
        
        /// <summary>
        /// Returns long4.rrbg swizzling (equivalent to long4.xxzy).
        /// </summary>
        public long4 rrbg => new long4(x, x, z, y);
        
        /// <summary>
        /// Returns long4.xxzz swizzling.
        /// </summary>
        public long4 xxzz => new long4(x, x, z, z);
        
        /// <summary>
        /// Returns long4.rrbb swizzling (equivalent to long4.xxzz).
        /// </summary>
        public long4 rrbb => new long4(x, x, z, z);
        
        /// <summary>
        /// Returns long4.xxzw swizzling.
        /// </summary>
        public long4 xxzw => new long4(x, x, z, w);
        
        /// <summary>
        /// Returns long4.rrba swizzling (equivalent to long4.xxzw).
        /// </summary>
        public long4 rrba => new long4(x, x, z, w);
        
        /// <summary>
        /// Returns long4.xxw swizzling.
        /// </summary>
        public long3 xxw => new long3(x, x, w);
        
        /// <summary>
        /// Returns long4.rra swizzling (equivalent to long4.xxw).
        /// </summary>
        public long3 rra => new long3(x, x, w);
        
        /// <summary>
        /// Returns long4.xxwx swizzling.
        /// </summary>
        public long4 xxwx => new long4(x, x, w, x);
        
        /// <summary>
        /// Returns long4.rrar swizzling (equivalent to long4.xxwx).
        /// </summary>
        public long4 rrar => new long4(x, x, w, x);
        
        /// <summary>
        /// Returns long4.xxwy swizzling.
        /// </summary>
        public long4 xxwy => new long4(x, x, w, y);
        
        /// <summary>
        /// Returns long4.rrag swizzling (equivalent to long4.xxwy).
        /// </summary>
        public long4 rrag => new long4(x, x, w, y);
        
        /// <summary>
        /// Returns long4.xxwz swizzling.
        /// </summary>
        public long4 xxwz => new long4(x, x, w, z);
        
        /// <summary>
        /// Returns long4.rrab swizzling (equivalent to long4.xxwz).
        /// </summary>
        public long4 rrab => new long4(x, x, w, z);
        
        /// <summary>
        /// Returns long4.xxww swizzling.
        /// </summary>
        public long4 xxww => new long4(x, x, w, w);
        
        /// <summary>
        /// Returns long4.rraa swizzling (equivalent to long4.xxww).
        /// </summary>
        public long4 rraa => new long4(x, x, w, w);
        
        /// <summary>
        /// Returns long4.xy swizzling.
        /// </summary>
        public long2 xy => new long2(x, y);
        
        /// <summary>
        /// Returns long4.rg swizzling (equivalent to long4.xy).
        /// </summary>
        public long2 rg => new long2(x, y);
        
        /// <summary>
        /// Returns long4.xyx swizzling.
        /// </summary>
        public long3 xyx => new long3(x, y, x);
        
        /// <summary>
        /// Returns long4.rgr swizzling (equivalent to long4.xyx).
        /// </summary>
        public long3 rgr => new long3(x, y, x);
        
        /// <summary>
        /// Returns long4.xyxx swizzling.
        /// </summary>
        public long4 xyxx => new long4(x, y, x, x);
        
        /// <summary>
        /// Returns long4.rgrr swizzling (equivalent to long4.xyxx).
        /// </summary>
        public long4 rgrr => new long4(x, y, x, x);
        
        /// <summary>
        /// Returns long4.xyxy swizzling.
        /// </summary>
        public long4 xyxy => new long4(x, y, x, y);
        
        /// <summary>
        /// Returns long4.rgrg swizzling (equivalent to long4.xyxy).
        /// </summary>
        public long4 rgrg => new long4(x, y, x, y);
        
        /// <summary>
        /// Returns long4.xyxz swizzling.
        /// </summary>
        public long4 xyxz => new long4(x, y, x, z);
        
        /// <summary>
        /// Returns long4.rgrb swizzling (equivalent to long4.xyxz).
        /// </summary>
        public long4 rgrb => new long4(x, y, x, z);
        
        /// <summary>
        /// Returns long4.xyxw swizzling.
        /// </summary>
        public long4 xyxw => new long4(x, y, x, w);
        
        /// <summary>
        /// Returns long4.rgra swizzling (equivalent to long4.xyxw).
        /// </summary>
        public long4 rgra => new long4(x, y, x, w);
        
        /// <summary>
        /// Returns long4.xyy swizzling.
        /// </summary>
        public long3 xyy => new long3(x, y, y);
        
        /// <summary>
        /// Returns long4.rgg swizzling (equivalent to long4.xyy).
        /// </summary>
        public long3 rgg => new long3(x, y, y);
        
        /// <summary>
        /// Returns long4.xyyx swizzling.
        /// </summary>
        public long4 xyyx => new long4(x, y, y, x);
        
        /// <summary>
        /// Returns long4.rggr swizzling (equivalent to long4.xyyx).
        /// </summary>
        public long4 rggr => new long4(x, y, y, x);
        
        /// <summary>
        /// Returns long4.xyyy swizzling.
        /// </summary>
        public long4 xyyy => new long4(x, y, y, y);
        
        /// <summary>
        /// Returns long4.rggg swizzling (equivalent to long4.xyyy).
        /// </summary>
        public long4 rggg => new long4(x, y, y, y);
        
        /// <summary>
        /// Returns long4.xyyz swizzling.
        /// </summary>
        public long4 xyyz => new long4(x, y, y, z);
        
        /// <summary>
        /// Returns long4.rggb swizzling (equivalent to long4.xyyz).
        /// </summary>
        public long4 rggb => new long4(x, y, y, z);
        
        /// <summary>
        /// Returns long4.xyyw swizzling.
        /// </summary>
        public long4 xyyw => new long4(x, y, y, w);
        
        /// <summary>
        /// Returns long4.rgga swizzling (equivalent to long4.xyyw).
        /// </summary>
        public long4 rgga => new long4(x, y, y, w);
        
        /// <summary>
        /// Returns long4.xyz swizzling.
        /// </summary>
        public long3 xyz => new long3(x, y, z);
        
        /// <summary>
        /// Returns long4.rgb swizzling (equivalent to long4.xyz).
        /// </summary>
        public long3 rgb => new long3(x, y, z);
        
        /// <summary>
        /// Returns long4.xyzx swizzling.
        /// </summary>
        public long4 xyzx => new long4(x, y, z, x);
        
        /// <summary>
        /// Returns long4.rgbr swizzling (equivalent to long4.xyzx).
        /// </summary>
        public long4 rgbr => new long4(x, y, z, x);
        
        /// <summary>
        /// Returns long4.xyzy swizzling.
        /// </summary>
        public long4 xyzy => new long4(x, y, z, y);
        
        /// <summary>
        /// Returns long4.rgbg swizzling (equivalent to long4.xyzy).
        /// </summary>
        public long4 rgbg => new long4(x, y, z, y);
        
        /// <summary>
        /// Returns long4.xyzz swizzling.
        /// </summary>
        public long4 xyzz => new long4(x, y, z, z);
        
        /// <summary>
        /// Returns long4.rgbb swizzling (equivalent to long4.xyzz).
        /// </summary>
        public long4 rgbb => new long4(x, y, z, z);
        
        /// <summary>
        /// Returns long4.xyzw swizzling.
        /// </summary>
        public long4 xyzw => new long4(x, y, z, w);
        
        /// <summary>
        /// Returns long4.rgba swizzling (equivalent to long4.xyzw).
        /// </summary>
        public long4 rgba => new long4(x, y, z, w);
        
        /// <summary>
        /// Returns long4.xyw swizzling.
        /// </summary>
        public long3 xyw => new long3(x, y, w);
        
        /// <summary>
        /// Returns long4.rga swizzling (equivalent to long4.xyw).
        /// </summary>
        public long3 rga => new long3(x, y, w);
        
        /// <summary>
        /// Returns long4.xywx swizzling.
        /// </summary>
        public long4 xywx => new long4(x, y, w, x);
        
        /// <summary>
        /// Returns long4.rgar swizzling (equivalent to long4.xywx).
        /// </summary>
        public long4 rgar => new long4(x, y, w, x);
        
        /// <summary>
        /// Returns long4.xywy swizzling.
        /// </summary>
        public long4 xywy => new long4(x, y, w, y);
        
        /// <summary>
        /// Returns long4.rgag swizzling (equivalent to long4.xywy).
        /// </summary>
        public long4 rgag => new long4(x, y, w, y);
        
        /// <summary>
        /// Returns long4.xywz swizzling.
        /// </summary>
        public long4 xywz => new long4(x, y, w, z);
        
        /// <summary>
        /// Returns long4.rgab swizzling (equivalent to long4.xywz).
        /// </summary>
        public long4 rgab => new long4(x, y, w, z);
        
        /// <summary>
        /// Returns long4.xyww swizzling.
        /// </summary>
        public long4 xyww => new long4(x, y, w, w);
        
        /// <summary>
        /// Returns long4.rgaa swizzling (equivalent to long4.xyww).
        /// </summary>
        public long4 rgaa => new long4(x, y, w, w);
        
        /// <summary>
        /// Returns long4.xz swizzling.
        /// </summary>
        public long2 xz => new long2(x, z);
        
        /// <summary>
        /// Returns long4.rb swizzling (equivalent to long4.xz).
        /// </summary>
        public long2 rb => new long2(x, z);
        
        /// <summary>
        /// Returns long4.xzx swizzling.
        /// </summary>
        public long3 xzx => new long3(x, z, x);
        
        /// <summary>
        /// Returns long4.rbr swizzling (equivalent to long4.xzx).
        /// </summary>
        public long3 rbr => new long3(x, z, x);
        
        /// <summary>
        /// Returns long4.xzxx swizzling.
        /// </summary>
        public long4 xzxx => new long4(x, z, x, x);
        
        /// <summary>
        /// Returns long4.rbrr swizzling (equivalent to long4.xzxx).
        /// </summary>
        public long4 rbrr => new long4(x, z, x, x);
        
        /// <summary>
        /// Returns long4.xzxy swizzling.
        /// </summary>
        public long4 xzxy => new long4(x, z, x, y);
        
        /// <summary>
        /// Returns long4.rbrg swizzling (equivalent to long4.xzxy).
        /// </summary>
        public long4 rbrg => new long4(x, z, x, y);
        
        /// <summary>
        /// Returns long4.xzxz swizzling.
        /// </summary>
        public long4 xzxz => new long4(x, z, x, z);
        
        /// <summary>
        /// Returns long4.rbrb swizzling (equivalent to long4.xzxz).
        /// </summary>
        public long4 rbrb => new long4(x, z, x, z);
        
        /// <summary>
        /// Returns long4.xzxw swizzling.
        /// </summary>
        public long4 xzxw => new long4(x, z, x, w);
        
        /// <summary>
        /// Returns long4.rbra swizzling (equivalent to long4.xzxw).
        /// </summary>
        public long4 rbra => new long4(x, z, x, w);
        
        /// <summary>
        /// Returns long4.xzy swizzling.
        /// </summary>
        public long3 xzy => new long3(x, z, y);
        
        /// <summary>
        /// Returns long4.rbg swizzling (equivalent to long4.xzy).
        /// </summary>
        public long3 rbg => new long3(x, z, y);
        
        /// <summary>
        /// Returns long4.xzyx swizzling.
        /// </summary>
        public long4 xzyx => new long4(x, z, y, x);
        
        /// <summary>
        /// Returns long4.rbgr swizzling (equivalent to long4.xzyx).
        /// </summary>
        public long4 rbgr => new long4(x, z, y, x);
        
        /// <summary>
        /// Returns long4.xzyy swizzling.
        /// </summary>
        public long4 xzyy => new long4(x, z, y, y);
        
        /// <summary>
        /// Returns long4.rbgg swizzling (equivalent to long4.xzyy).
        /// </summary>
        public long4 rbgg => new long4(x, z, y, y);
        
        /// <summary>
        /// Returns long4.xzyz swizzling.
        /// </summary>
        public long4 xzyz => new long4(x, z, y, z);
        
        /// <summary>
        /// Returns long4.rbgb swizzling (equivalent to long4.xzyz).
        /// </summary>
        public long4 rbgb => new long4(x, z, y, z);
        
        /// <summary>
        /// Returns long4.xzyw swizzling.
        /// </summary>
        public long4 xzyw => new long4(x, z, y, w);
        
        /// <summary>
        /// Returns long4.rbga swizzling (equivalent to long4.xzyw).
        /// </summary>
        public long4 rbga => new long4(x, z, y, w);
        
        /// <summary>
        /// Returns long4.xzz swizzling.
        /// </summary>
        public long3 xzz => new long3(x, z, z);
        
        /// <summary>
        /// Returns long4.rbb swizzling (equivalent to long4.xzz).
        /// </summary>
        public long3 rbb => new long3(x, z, z);
        
        /// <summary>
        /// Returns long4.xzzx swizzling.
        /// </summary>
        public long4 xzzx => new long4(x, z, z, x);
        
        /// <summary>
        /// Returns long4.rbbr swizzling (equivalent to long4.xzzx).
        /// </summary>
        public long4 rbbr => new long4(x, z, z, x);
        
        /// <summary>
        /// Returns long4.xzzy swizzling.
        /// </summary>
        public long4 xzzy => new long4(x, z, z, y);
        
        /// <summary>
        /// Returns long4.rbbg swizzling (equivalent to long4.xzzy).
        /// </summary>
        public long4 rbbg => new long4(x, z, z, y);
        
        /// <summary>
        /// Returns long4.xzzz swizzling.
        /// </summary>
        public long4 xzzz => new long4(x, z, z, z);
        
        /// <summary>
        /// Returns long4.rbbb swizzling (equivalent to long4.xzzz).
        /// </summary>
        public long4 rbbb => new long4(x, z, z, z);
        
        /// <summary>
        /// Returns long4.xzzw swizzling.
        /// </summary>
        public long4 xzzw => new long4(x, z, z, w);
        
        /// <summary>
        /// Returns long4.rbba swizzling (equivalent to long4.xzzw).
        /// </summary>
        public long4 rbba => new long4(x, z, z, w);
        
        /// <summary>
        /// Returns long4.xzw swizzling.
        /// </summary>
        public long3 xzw => new long3(x, z, w);
        
        /// <summary>
        /// Returns long4.rba swizzling (equivalent to long4.xzw).
        /// </summary>
        public long3 rba => new long3(x, z, w);
        
        /// <summary>
        /// Returns long4.xzwx swizzling.
        /// </summary>
        public long4 xzwx => new long4(x, z, w, x);
        
        /// <summary>
        /// Returns long4.rbar swizzling (equivalent to long4.xzwx).
        /// </summary>
        public long4 rbar => new long4(x, z, w, x);
        
        /// <summary>
        /// Returns long4.xzwy swizzling.
        /// </summary>
        public long4 xzwy => new long4(x, z, w, y);
        
        /// <summary>
        /// Returns long4.rbag swizzling (equivalent to long4.xzwy).
        /// </summary>
        public long4 rbag => new long4(x, z, w, y);
        
        /// <summary>
        /// Returns long4.xzwz swizzling.
        /// </summary>
        public long4 xzwz => new long4(x, z, w, z);
        
        /// <summary>
        /// Returns long4.rbab swizzling (equivalent to long4.xzwz).
        /// </summary>
        public long4 rbab => new long4(x, z, w, z);
        
        /// <summary>
        /// Returns long4.xzww swizzling.
        /// </summary>
        public long4 xzww => new long4(x, z, w, w);
        
        /// <summary>
        /// Returns long4.rbaa swizzling (equivalent to long4.xzww).
        /// </summary>
        public long4 rbaa => new long4(x, z, w, w);
        
        /// <summary>
        /// Returns long4.xw swizzling.
        /// </summary>
        public long2 xw => new long2(x, w);
        
        /// <summary>
        /// Returns long4.ra swizzling (equivalent to long4.xw).
        /// </summary>
        public long2 ra => new long2(x, w);
        
        /// <summary>
        /// Returns long4.xwx swizzling.
        /// </summary>
        public long3 xwx => new long3(x, w, x);
        
        /// <summary>
        /// Returns long4.rar swizzling (equivalent to long4.xwx).
        /// </summary>
        public long3 rar => new long3(x, w, x);
        
        /// <summary>
        /// Returns long4.xwxx swizzling.
        /// </summary>
        public long4 xwxx => new long4(x, w, x, x);
        
        /// <summary>
        /// Returns long4.rarr swizzling (equivalent to long4.xwxx).
        /// </summary>
        public long4 rarr => new long4(x, w, x, x);
        
        /// <summary>
        /// Returns long4.xwxy swizzling.
        /// </summary>
        public long4 xwxy => new long4(x, w, x, y);
        
        /// <summary>
        /// Returns long4.rarg swizzling (equivalent to long4.xwxy).
        /// </summary>
        public long4 rarg => new long4(x, w, x, y);
        
        /// <summary>
        /// Returns long4.xwxz swizzling.
        /// </summary>
        public long4 xwxz => new long4(x, w, x, z);
        
        /// <summary>
        /// Returns long4.rarb swizzling (equivalent to long4.xwxz).
        /// </summary>
        public long4 rarb => new long4(x, w, x, z);
        
        /// <summary>
        /// Returns long4.xwxw swizzling.
        /// </summary>
        public long4 xwxw => new long4(x, w, x, w);
        
        /// <summary>
        /// Returns long4.rara swizzling (equivalent to long4.xwxw).
        /// </summary>
        public long4 rara => new long4(x, w, x, w);
        
        /// <summary>
        /// Returns long4.xwy swizzling.
        /// </summary>
        public long3 xwy => new long3(x, w, y);
        
        /// <summary>
        /// Returns long4.rag swizzling (equivalent to long4.xwy).
        /// </summary>
        public long3 rag => new long3(x, w, y);
        
        /// <summary>
        /// Returns long4.xwyx swizzling.
        /// </summary>
        public long4 xwyx => new long4(x, w, y, x);
        
        /// <summary>
        /// Returns long4.ragr swizzling (equivalent to long4.xwyx).
        /// </summary>
        public long4 ragr => new long4(x, w, y, x);
        
        /// <summary>
        /// Returns long4.xwyy swizzling.
        /// </summary>
        public long4 xwyy => new long4(x, w, y, y);
        
        /// <summary>
        /// Returns long4.ragg swizzling (equivalent to long4.xwyy).
        /// </summary>
        public long4 ragg => new long4(x, w, y, y);
        
        /// <summary>
        /// Returns long4.xwyz swizzling.
        /// </summary>
        public long4 xwyz => new long4(x, w, y, z);
        
        /// <summary>
        /// Returns long4.ragb swizzling (equivalent to long4.xwyz).
        /// </summary>
        public long4 ragb => new long4(x, w, y, z);
        
        /// <summary>
        /// Returns long4.xwyw swizzling.
        /// </summary>
        public long4 xwyw => new long4(x, w, y, w);
        
        /// <summary>
        /// Returns long4.raga swizzling (equivalent to long4.xwyw).
        /// </summary>
        public long4 raga => new long4(x, w, y, w);
        
        /// <summary>
        /// Returns long4.xwz swizzling.
        /// </summary>
        public long3 xwz => new long3(x, w, z);
        
        /// <summary>
        /// Returns long4.rab swizzling (equivalent to long4.xwz).
        /// </summary>
        public long3 rab => new long3(x, w, z);
        
        /// <summary>
        /// Returns long4.xwzx swizzling.
        /// </summary>
        public long4 xwzx => new long4(x, w, z, x);
        
        /// <summary>
        /// Returns long4.rabr swizzling (equivalent to long4.xwzx).
        /// </summary>
        public long4 rabr => new long4(x, w, z, x);
        
        /// <summary>
        /// Returns long4.xwzy swizzling.
        /// </summary>
        public long4 xwzy => new long4(x, w, z, y);
        
        /// <summary>
        /// Returns long4.rabg swizzling (equivalent to long4.xwzy).
        /// </summary>
        public long4 rabg => new long4(x, w, z, y);
        
        /// <summary>
        /// Returns long4.xwzz swizzling.
        /// </summary>
        public long4 xwzz => new long4(x, w, z, z);
        
        /// <summary>
        /// Returns long4.rabb swizzling (equivalent to long4.xwzz).
        /// </summary>
        public long4 rabb => new long4(x, w, z, z);
        
        /// <summary>
        /// Returns long4.xwzw swizzling.
        /// </summary>
        public long4 xwzw => new long4(x, w, z, w);
        
        /// <summary>
        /// Returns long4.raba swizzling (equivalent to long4.xwzw).
        /// </summary>
        public long4 raba => new long4(x, w, z, w);
        
        /// <summary>
        /// Returns long4.xww swizzling.
        /// </summary>
        public long3 xww => new long3(x, w, w);
        
        /// <summary>
        /// Returns long4.raa swizzling (equivalent to long4.xww).
        /// </summary>
        public long3 raa => new long3(x, w, w);
        
        /// <summary>
        /// Returns long4.xwwx swizzling.
        /// </summary>
        public long4 xwwx => new long4(x, w, w, x);
        
        /// <summary>
        /// Returns long4.raar swizzling (equivalent to long4.xwwx).
        /// </summary>
        public long4 raar => new long4(x, w, w, x);
        
        /// <summary>
        /// Returns long4.xwwy swizzling.
        /// </summary>
        public long4 xwwy => new long4(x, w, w, y);
        
        /// <summary>
        /// Returns long4.raag swizzling (equivalent to long4.xwwy).
        /// </summary>
        public long4 raag => new long4(x, w, w, y);
        
        /// <summary>
        /// Returns long4.xwwz swizzling.
        /// </summary>
        public long4 xwwz => new long4(x, w, w, z);
        
        /// <summary>
        /// Returns long4.raab swizzling (equivalent to long4.xwwz).
        /// </summary>
        public long4 raab => new long4(x, w, w, z);
        
        /// <summary>
        /// Returns long4.xwww swizzling.
        /// </summary>
        public long4 xwww => new long4(x, w, w, w);
        
        /// <summary>
        /// Returns long4.raaa swizzling (equivalent to long4.xwww).
        /// </summary>
        public long4 raaa => new long4(x, w, w, w);
        
        /// <summary>
        /// Returns long4.yx swizzling.
        /// </summary>
        public long2 yx => new long2(y, x);
        
        /// <summary>
        /// Returns long4.gr swizzling (equivalent to long4.yx).
        /// </summary>
        public long2 gr => new long2(y, x);
        
        /// <summary>
        /// Returns long4.yxx swizzling.
        /// </summary>
        public long3 yxx => new long3(y, x, x);
        
        /// <summary>
        /// Returns long4.grr swizzling (equivalent to long4.yxx).
        /// </summary>
        public long3 grr => new long3(y, x, x);
        
        /// <summary>
        /// Returns long4.yxxx swizzling.
        /// </summary>
        public long4 yxxx => new long4(y, x, x, x);
        
        /// <summary>
        /// Returns long4.grrr swizzling (equivalent to long4.yxxx).
        /// </summary>
        public long4 grrr => new long4(y, x, x, x);
        
        /// <summary>
        /// Returns long4.yxxy swizzling.
        /// </summary>
        public long4 yxxy => new long4(y, x, x, y);
        
        /// <summary>
        /// Returns long4.grrg swizzling (equivalent to long4.yxxy).
        /// </summary>
        public long4 grrg => new long4(y, x, x, y);
        
        /// <summary>
        /// Returns long4.yxxz swizzling.
        /// </summary>
        public long4 yxxz => new long4(y, x, x, z);
        
        /// <summary>
        /// Returns long4.grrb swizzling (equivalent to long4.yxxz).
        /// </summary>
        public long4 grrb => new long4(y, x, x, z);
        
        /// <summary>
        /// Returns long4.yxxw swizzling.
        /// </summary>
        public long4 yxxw => new long4(y, x, x, w);
        
        /// <summary>
        /// Returns long4.grra swizzling (equivalent to long4.yxxw).
        /// </summary>
        public long4 grra => new long4(y, x, x, w);
        
        /// <summary>
        /// Returns long4.yxy swizzling.
        /// </summary>
        public long3 yxy => new long3(y, x, y);
        
        /// <summary>
        /// Returns long4.grg swizzling (equivalent to long4.yxy).
        /// </summary>
        public long3 grg => new long3(y, x, y);
        
        /// <summary>
        /// Returns long4.yxyx swizzling.
        /// </summary>
        public long4 yxyx => new long4(y, x, y, x);
        
        /// <summary>
        /// Returns long4.grgr swizzling (equivalent to long4.yxyx).
        /// </summary>
        public long4 grgr => new long4(y, x, y, x);
        
        /// <summary>
        /// Returns long4.yxyy swizzling.
        /// </summary>
        public long4 yxyy => new long4(y, x, y, y);
        
        /// <summary>
        /// Returns long4.grgg swizzling (equivalent to long4.yxyy).
        /// </summary>
        public long4 grgg => new long4(y, x, y, y);
        
        /// <summary>
        /// Returns long4.yxyz swizzling.
        /// </summary>
        public long4 yxyz => new long4(y, x, y, z);
        
        /// <summary>
        /// Returns long4.grgb swizzling (equivalent to long4.yxyz).
        /// </summary>
        public long4 grgb => new long4(y, x, y, z);
        
        /// <summary>
        /// Returns long4.yxyw swizzling.
        /// </summary>
        public long4 yxyw => new long4(y, x, y, w);
        
        /// <summary>
        /// Returns long4.grga swizzling (equivalent to long4.yxyw).
        /// </summary>
        public long4 grga => new long4(y, x, y, w);
        
        /// <summary>
        /// Returns long4.yxz swizzling.
        /// </summary>
        public long3 yxz => new long3(y, x, z);
        
        /// <summary>
        /// Returns long4.grb swizzling (equivalent to long4.yxz).
        /// </summary>
        public long3 grb => new long3(y, x, z);
        
        /// <summary>
        /// Returns long4.yxzx swizzling.
        /// </summary>
        public long4 yxzx => new long4(y, x, z, x);
        
        /// <summary>
        /// Returns long4.grbr swizzling (equivalent to long4.yxzx).
        /// </summary>
        public long4 grbr => new long4(y, x, z, x);
        
        /// <summary>
        /// Returns long4.yxzy swizzling.
        /// </summary>
        public long4 yxzy => new long4(y, x, z, y);
        
        /// <summary>
        /// Returns long4.grbg swizzling (equivalent to long4.yxzy).
        /// </summary>
        public long4 grbg => new long4(y, x, z, y);
        
        /// <summary>
        /// Returns long4.yxzz swizzling.
        /// </summary>
        public long4 yxzz => new long4(y, x, z, z);
        
        /// <summary>
        /// Returns long4.grbb swizzling (equivalent to long4.yxzz).
        /// </summary>
        public long4 grbb => new long4(y, x, z, z);
        
        /// <summary>
        /// Returns long4.yxzw swizzling.
        /// </summary>
        public long4 yxzw => new long4(y, x, z, w);
        
        /// <summary>
        /// Returns long4.grba swizzling (equivalent to long4.yxzw).
        /// </summary>
        public long4 grba => new long4(y, x, z, w);
        
        /// <summary>
        /// Returns long4.yxw swizzling.
        /// </summary>
        public long3 yxw => new long3(y, x, w);
        
        /// <summary>
        /// Returns long4.gra swizzling (equivalent to long4.yxw).
        /// </summary>
        public long3 gra => new long3(y, x, w);
        
        /// <summary>
        /// Returns long4.yxwx swizzling.
        /// </summary>
        public long4 yxwx => new long4(y, x, w, x);
        
        /// <summary>
        /// Returns long4.grar swizzling (equivalent to long4.yxwx).
        /// </summary>
        public long4 grar => new long4(y, x, w, x);
        
        /// <summary>
        /// Returns long4.yxwy swizzling.
        /// </summary>
        public long4 yxwy => new long4(y, x, w, y);
        
        /// <summary>
        /// Returns long4.grag swizzling (equivalent to long4.yxwy).
        /// </summary>
        public long4 grag => new long4(y, x, w, y);
        
        /// <summary>
        /// Returns long4.yxwz swizzling.
        /// </summary>
        public long4 yxwz => new long4(y, x, w, z);
        
        /// <summary>
        /// Returns long4.grab swizzling (equivalent to long4.yxwz).
        /// </summary>
        public long4 grab => new long4(y, x, w, z);
        
        /// <summary>
        /// Returns long4.yxww swizzling.
        /// </summary>
        public long4 yxww => new long4(y, x, w, w);
        
        /// <summary>
        /// Returns long4.graa swizzling (equivalent to long4.yxww).
        /// </summary>
        public long4 graa => new long4(y, x, w, w);
        
        /// <summary>
        /// Returns long4.yy swizzling.
        /// </summary>
        public long2 yy => new long2(y, y);
        
        /// <summary>
        /// Returns long4.gg swizzling (equivalent to long4.yy).
        /// </summary>
        public long2 gg => new long2(y, y);
        
        /// <summary>
        /// Returns long4.yyx swizzling.
        /// </summary>
        public long3 yyx => new long3(y, y, x);
        
        /// <summary>
        /// Returns long4.ggr swizzling (equivalent to long4.yyx).
        /// </summary>
        public long3 ggr => new long3(y, y, x);
        
        /// <summary>
        /// Returns long4.yyxx swizzling.
        /// </summary>
        public long4 yyxx => new long4(y, y, x, x);
        
        /// <summary>
        /// Returns long4.ggrr swizzling (equivalent to long4.yyxx).
        /// </summary>
        public long4 ggrr => new long4(y, y, x, x);
        
        /// <summary>
        /// Returns long4.yyxy swizzling.
        /// </summary>
        public long4 yyxy => new long4(y, y, x, y);
        
        /// <summary>
        /// Returns long4.ggrg swizzling (equivalent to long4.yyxy).
        /// </summary>
        public long4 ggrg => new long4(y, y, x, y);
        
        /// <summary>
        /// Returns long4.yyxz swizzling.
        /// </summary>
        public long4 yyxz => new long4(y, y, x, z);
        
        /// <summary>
        /// Returns long4.ggrb swizzling (equivalent to long4.yyxz).
        /// </summary>
        public long4 ggrb => new long4(y, y, x, z);
        
        /// <summary>
        /// Returns long4.yyxw swizzling.
        /// </summary>
        public long4 yyxw => new long4(y, y, x, w);
        
        /// <summary>
        /// Returns long4.ggra swizzling (equivalent to long4.yyxw).
        /// </summary>
        public long4 ggra => new long4(y, y, x, w);
        
        /// <summary>
        /// Returns long4.yyy swizzling.
        /// </summary>
        public long3 yyy => new long3(y, y, y);
        
        /// <summary>
        /// Returns long4.ggg swizzling (equivalent to long4.yyy).
        /// </summary>
        public long3 ggg => new long3(y, y, y);
        
        /// <summary>
        /// Returns long4.yyyx swizzling.
        /// </summary>
        public long4 yyyx => new long4(y, y, y, x);
        
        /// <summary>
        /// Returns long4.gggr swizzling (equivalent to long4.yyyx).
        /// </summary>
        public long4 gggr => new long4(y, y, y, x);
        
        /// <summary>
        /// Returns long4.yyyy swizzling.
        /// </summary>
        public long4 yyyy => new long4(y, y, y, y);
        
        /// <summary>
        /// Returns long4.gggg swizzling (equivalent to long4.yyyy).
        /// </summary>
        public long4 gggg => new long4(y, y, y, y);
        
        /// <summary>
        /// Returns long4.yyyz swizzling.
        /// </summary>
        public long4 yyyz => new long4(y, y, y, z);
        
        /// <summary>
        /// Returns long4.gggb swizzling (equivalent to long4.yyyz).
        /// </summary>
        public long4 gggb => new long4(y, y, y, z);
        
        /// <summary>
        /// Returns long4.yyyw swizzling.
        /// </summary>
        public long4 yyyw => new long4(y, y, y, w);
        
        /// <summary>
        /// Returns long4.ggga swizzling (equivalent to long4.yyyw).
        /// </summary>
        public long4 ggga => new long4(y, y, y, w);
        
        /// <summary>
        /// Returns long4.yyz swizzling.
        /// </summary>
        public long3 yyz => new long3(y, y, z);
        
        /// <summary>
        /// Returns long4.ggb swizzling (equivalent to long4.yyz).
        /// </summary>
        public long3 ggb => new long3(y, y, z);
        
        /// <summary>
        /// Returns long4.yyzx swizzling.
        /// </summary>
        public long4 yyzx => new long4(y, y, z, x);
        
        /// <summary>
        /// Returns long4.ggbr swizzling (equivalent to long4.yyzx).
        /// </summary>
        public long4 ggbr => new long4(y, y, z, x);
        
        /// <summary>
        /// Returns long4.yyzy swizzling.
        /// </summary>
        public long4 yyzy => new long4(y, y, z, y);
        
        /// <summary>
        /// Returns long4.ggbg swizzling (equivalent to long4.yyzy).
        /// </summary>
        public long4 ggbg => new long4(y, y, z, y);
        
        /// <summary>
        /// Returns long4.yyzz swizzling.
        /// </summary>
        public long4 yyzz => new long4(y, y, z, z);
        
        /// <summary>
        /// Returns long4.ggbb swizzling (equivalent to long4.yyzz).
        /// </summary>
        public long4 ggbb => new long4(y, y, z, z);
        
        /// <summary>
        /// Returns long4.yyzw swizzling.
        /// </summary>
        public long4 yyzw => new long4(y, y, z, w);
        
        /// <summary>
        /// Returns long4.ggba swizzling (equivalent to long4.yyzw).
        /// </summary>
        public long4 ggba => new long4(y, y, z, w);
        
        /// <summary>
        /// Returns long4.yyw swizzling.
        /// </summary>
        public long3 yyw => new long3(y, y, w);
        
        /// <summary>
        /// Returns long4.gga swizzling (equivalent to long4.yyw).
        /// </summary>
        public long3 gga => new long3(y, y, w);
        
        /// <summary>
        /// Returns long4.yywx swizzling.
        /// </summary>
        public long4 yywx => new long4(y, y, w, x);
        
        /// <summary>
        /// Returns long4.ggar swizzling (equivalent to long4.yywx).
        /// </summary>
        public long4 ggar => new long4(y, y, w, x);
        
        /// <summary>
        /// Returns long4.yywy swizzling.
        /// </summary>
        public long4 yywy => new long4(y, y, w, y);
        
        /// <summary>
        /// Returns long4.ggag swizzling (equivalent to long4.yywy).
        /// </summary>
        public long4 ggag => new long4(y, y, w, y);
        
        /// <summary>
        /// Returns long4.yywz swizzling.
        /// </summary>
        public long4 yywz => new long4(y, y, w, z);
        
        /// <summary>
        /// Returns long4.ggab swizzling (equivalent to long4.yywz).
        /// </summary>
        public long4 ggab => new long4(y, y, w, z);
        
        /// <summary>
        /// Returns long4.yyww swizzling.
        /// </summary>
        public long4 yyww => new long4(y, y, w, w);
        
        /// <summary>
        /// Returns long4.ggaa swizzling (equivalent to long4.yyww).
        /// </summary>
        public long4 ggaa => new long4(y, y, w, w);
        
        /// <summary>
        /// Returns long4.yz swizzling.
        /// </summary>
        public long2 yz => new long2(y, z);
        
        /// <summary>
        /// Returns long4.gb swizzling (equivalent to long4.yz).
        /// </summary>
        public long2 gb => new long2(y, z);
        
        /// <summary>
        /// Returns long4.yzx swizzling.
        /// </summary>
        public long3 yzx => new long3(y, z, x);
        
        /// <summary>
        /// Returns long4.gbr swizzling (equivalent to long4.yzx).
        /// </summary>
        public long3 gbr => new long3(y, z, x);
        
        /// <summary>
        /// Returns long4.yzxx swizzling.
        /// </summary>
        public long4 yzxx => new long4(y, z, x, x);
        
        /// <summary>
        /// Returns long4.gbrr swizzling (equivalent to long4.yzxx).
        /// </summary>
        public long4 gbrr => new long4(y, z, x, x);
        
        /// <summary>
        /// Returns long4.yzxy swizzling.
        /// </summary>
        public long4 yzxy => new long4(y, z, x, y);
        
        /// <summary>
        /// Returns long4.gbrg swizzling (equivalent to long4.yzxy).
        /// </summary>
        public long4 gbrg => new long4(y, z, x, y);
        
        /// <summary>
        /// Returns long4.yzxz swizzling.
        /// </summary>
        public long4 yzxz => new long4(y, z, x, z);
        
        /// <summary>
        /// Returns long4.gbrb swizzling (equivalent to long4.yzxz).
        /// </summary>
        public long4 gbrb => new long4(y, z, x, z);
        
        /// <summary>
        /// Returns long4.yzxw swizzling.
        /// </summary>
        public long4 yzxw => new long4(y, z, x, w);
        
        /// <summary>
        /// Returns long4.gbra swizzling (equivalent to long4.yzxw).
        /// </summary>
        public long4 gbra => new long4(y, z, x, w);
        
        /// <summary>
        /// Returns long4.yzy swizzling.
        /// </summary>
        public long3 yzy => new long3(y, z, y);
        
        /// <summary>
        /// Returns long4.gbg swizzling (equivalent to long4.yzy).
        /// </summary>
        public long3 gbg => new long3(y, z, y);
        
        /// <summary>
        /// Returns long4.yzyx swizzling.
        /// </summary>
        public long4 yzyx => new long4(y, z, y, x);
        
        /// <summary>
        /// Returns long4.gbgr swizzling (equivalent to long4.yzyx).
        /// </summary>
        public long4 gbgr => new long4(y, z, y, x);
        
        /// <summary>
        /// Returns long4.yzyy swizzling.
        /// </summary>
        public long4 yzyy => new long4(y, z, y, y);
        
        /// <summary>
        /// Returns long4.gbgg swizzling (equivalent to long4.yzyy).
        /// </summary>
        public long4 gbgg => new long4(y, z, y, y);
        
        /// <summary>
        /// Returns long4.yzyz swizzling.
        /// </summary>
        public long4 yzyz => new long4(y, z, y, z);
        
        /// <summary>
        /// Returns long4.gbgb swizzling (equivalent to long4.yzyz).
        /// </summary>
        public long4 gbgb => new long4(y, z, y, z);
        
        /// <summary>
        /// Returns long4.yzyw swizzling.
        /// </summary>
        public long4 yzyw => new long4(y, z, y, w);
        
        /// <summary>
        /// Returns long4.gbga swizzling (equivalent to long4.yzyw).
        /// </summary>
        public long4 gbga => new long4(y, z, y, w);
        
        /// <summary>
        /// Returns long4.yzz swizzling.
        /// </summary>
        public long3 yzz => new long3(y, z, z);
        
        /// <summary>
        /// Returns long4.gbb swizzling (equivalent to long4.yzz).
        /// </summary>
        public long3 gbb => new long3(y, z, z);
        
        /// <summary>
        /// Returns long4.yzzx swizzling.
        /// </summary>
        public long4 yzzx => new long4(y, z, z, x);
        
        /// <summary>
        /// Returns long4.gbbr swizzling (equivalent to long4.yzzx).
        /// </summary>
        public long4 gbbr => new long4(y, z, z, x);
        
        /// <summary>
        /// Returns long4.yzzy swizzling.
        /// </summary>
        public long4 yzzy => new long4(y, z, z, y);
        
        /// <summary>
        /// Returns long4.gbbg swizzling (equivalent to long4.yzzy).
        /// </summary>
        public long4 gbbg => new long4(y, z, z, y);
        
        /// <summary>
        /// Returns long4.yzzz swizzling.
        /// </summary>
        public long4 yzzz => new long4(y, z, z, z);
        
        /// <summary>
        /// Returns long4.gbbb swizzling (equivalent to long4.yzzz).
        /// </summary>
        public long4 gbbb => new long4(y, z, z, z);
        
        /// <summary>
        /// Returns long4.yzzw swizzling.
        /// </summary>
        public long4 yzzw => new long4(y, z, z, w);
        
        /// <summary>
        /// Returns long4.gbba swizzling (equivalent to long4.yzzw).
        /// </summary>
        public long4 gbba => new long4(y, z, z, w);
        
        /// <summary>
        /// Returns long4.yzw swizzling.
        /// </summary>
        public long3 yzw => new long3(y, z, w);
        
        /// <summary>
        /// Returns long4.gba swizzling (equivalent to long4.yzw).
        /// </summary>
        public long3 gba => new long3(y, z, w);
        
        /// <summary>
        /// Returns long4.yzwx swizzling.
        /// </summary>
        public long4 yzwx => new long4(y, z, w, x);
        
        /// <summary>
        /// Returns long4.gbar swizzling (equivalent to long4.yzwx).
        /// </summary>
        public long4 gbar => new long4(y, z, w, x);
        
        /// <summary>
        /// Returns long4.yzwy swizzling.
        /// </summary>
        public long4 yzwy => new long4(y, z, w, y);
        
        /// <summary>
        /// Returns long4.gbag swizzling (equivalent to long4.yzwy).
        /// </summary>
        public long4 gbag => new long4(y, z, w, y);
        
        /// <summary>
        /// Returns long4.yzwz swizzling.
        /// </summary>
        public long4 yzwz => new long4(y, z, w, z);
        
        /// <summary>
        /// Returns long4.gbab swizzling (equivalent to long4.yzwz).
        /// </summary>
        public long4 gbab => new long4(y, z, w, z);
        
        /// <summary>
        /// Returns long4.yzww swizzling.
        /// </summary>
        public long4 yzww => new long4(y, z, w, w);
        
        /// <summary>
        /// Returns long4.gbaa swizzling (equivalent to long4.yzww).
        /// </summary>
        public long4 gbaa => new long4(y, z, w, w);
        
        /// <summary>
        /// Returns long4.yw swizzling.
        /// </summary>
        public long2 yw => new long2(y, w);
        
        /// <summary>
        /// Returns long4.ga swizzling (equivalent to long4.yw).
        /// </summary>
        public long2 ga => new long2(y, w);
        
        /// <summary>
        /// Returns long4.ywx swizzling.
        /// </summary>
        public long3 ywx => new long3(y, w, x);
        
        /// <summary>
        /// Returns long4.gar swizzling (equivalent to long4.ywx).
        /// </summary>
        public long3 gar => new long3(y, w, x);
        
        /// <summary>
        /// Returns long4.ywxx swizzling.
        /// </summary>
        public long4 ywxx => new long4(y, w, x, x);
        
        /// <summary>
        /// Returns long4.garr swizzling (equivalent to long4.ywxx).
        /// </summary>
        public long4 garr => new long4(y, w, x, x);
        
        /// <summary>
        /// Returns long4.ywxy swizzling.
        /// </summary>
        public long4 ywxy => new long4(y, w, x, y);
        
        /// <summary>
        /// Returns long4.garg swizzling (equivalent to long4.ywxy).
        /// </summary>
        public long4 garg => new long4(y, w, x, y);
        
        /// <summary>
        /// Returns long4.ywxz swizzling.
        /// </summary>
        public long4 ywxz => new long4(y, w, x, z);
        
        /// <summary>
        /// Returns long4.garb swizzling (equivalent to long4.ywxz).
        /// </summary>
        public long4 garb => new long4(y, w, x, z);
        
        /// <summary>
        /// Returns long4.ywxw swizzling.
        /// </summary>
        public long4 ywxw => new long4(y, w, x, w);
        
        /// <summary>
        /// Returns long4.gara swizzling (equivalent to long4.ywxw).
        /// </summary>
        public long4 gara => new long4(y, w, x, w);
        
        /// <summary>
        /// Returns long4.ywy swizzling.
        /// </summary>
        public long3 ywy => new long3(y, w, y);
        
        /// <summary>
        /// Returns long4.gag swizzling (equivalent to long4.ywy).
        /// </summary>
        public long3 gag => new long3(y, w, y);
        
        /// <summary>
        /// Returns long4.ywyx swizzling.
        /// </summary>
        public long4 ywyx => new long4(y, w, y, x);
        
        /// <summary>
        /// Returns long4.gagr swizzling (equivalent to long4.ywyx).
        /// </summary>
        public long4 gagr => new long4(y, w, y, x);
        
        /// <summary>
        /// Returns long4.ywyy swizzling.
        /// </summary>
        public long4 ywyy => new long4(y, w, y, y);
        
        /// <summary>
        /// Returns long4.gagg swizzling (equivalent to long4.ywyy).
        /// </summary>
        public long4 gagg => new long4(y, w, y, y);
        
        /// <summary>
        /// Returns long4.ywyz swizzling.
        /// </summary>
        public long4 ywyz => new long4(y, w, y, z);
        
        /// <summary>
        /// Returns long4.gagb swizzling (equivalent to long4.ywyz).
        /// </summary>
        public long4 gagb => new long4(y, w, y, z);
        
        /// <summary>
        /// Returns long4.ywyw swizzling.
        /// </summary>
        public long4 ywyw => new long4(y, w, y, w);
        
        /// <summary>
        /// Returns long4.gaga swizzling (equivalent to long4.ywyw).
        /// </summary>
        public long4 gaga => new long4(y, w, y, w);
        
        /// <summary>
        /// Returns long4.ywz swizzling.
        /// </summary>
        public long3 ywz => new long3(y, w, z);
        
        /// <summary>
        /// Returns long4.gab swizzling (equivalent to long4.ywz).
        /// </summary>
        public long3 gab => new long3(y, w, z);
        
        /// <summary>
        /// Returns long4.ywzx swizzling.
        /// </summary>
        public long4 ywzx => new long4(y, w, z, x);
        
        /// <summary>
        /// Returns long4.gabr swizzling (equivalent to long4.ywzx).
        /// </summary>
        public long4 gabr => new long4(y, w, z, x);
        
        /// <summary>
        /// Returns long4.ywzy swizzling.
        /// </summary>
        public long4 ywzy => new long4(y, w, z, y);
        
        /// <summary>
        /// Returns long4.gabg swizzling (equivalent to long4.ywzy).
        /// </summary>
        public long4 gabg => new long4(y, w, z, y);
        
        /// <summary>
        /// Returns long4.ywzz swizzling.
        /// </summary>
        public long4 ywzz => new long4(y, w, z, z);
        
        /// <summary>
        /// Returns long4.gabb swizzling (equivalent to long4.ywzz).
        /// </summary>
        public long4 gabb => new long4(y, w, z, z);
        
        /// <summary>
        /// Returns long4.ywzw swizzling.
        /// </summary>
        public long4 ywzw => new long4(y, w, z, w);
        
        /// <summary>
        /// Returns long4.gaba swizzling (equivalent to long4.ywzw).
        /// </summary>
        public long4 gaba => new long4(y, w, z, w);
        
        /// <summary>
        /// Returns long4.yww swizzling.
        /// </summary>
        public long3 yww => new long3(y, w, w);
        
        /// <summary>
        /// Returns long4.gaa swizzling (equivalent to long4.yww).
        /// </summary>
        public long3 gaa => new long3(y, w, w);
        
        /// <summary>
        /// Returns long4.ywwx swizzling.
        /// </summary>
        public long4 ywwx => new long4(y, w, w, x);
        
        /// <summary>
        /// Returns long4.gaar swizzling (equivalent to long4.ywwx).
        /// </summary>
        public long4 gaar => new long4(y, w, w, x);
        
        /// <summary>
        /// Returns long4.ywwy swizzling.
        /// </summary>
        public long4 ywwy => new long4(y, w, w, y);
        
        /// <summary>
        /// Returns long4.gaag swizzling (equivalent to long4.ywwy).
        /// </summary>
        public long4 gaag => new long4(y, w, w, y);
        
        /// <summary>
        /// Returns long4.ywwz swizzling.
        /// </summary>
        public long4 ywwz => new long4(y, w, w, z);
        
        /// <summary>
        /// Returns long4.gaab swizzling (equivalent to long4.ywwz).
        /// </summary>
        public long4 gaab => new long4(y, w, w, z);
        
        /// <summary>
        /// Returns long4.ywww swizzling.
        /// </summary>
        public long4 ywww => new long4(y, w, w, w);
        
        /// <summary>
        /// Returns long4.gaaa swizzling (equivalent to long4.ywww).
        /// </summary>
        public long4 gaaa => new long4(y, w, w, w);
        
        /// <summary>
        /// Returns long4.zx swizzling.
        /// </summary>
        public long2 zx => new long2(z, x);
        
        /// <summary>
        /// Returns long4.br swizzling (equivalent to long4.zx).
        /// </summary>
        public long2 br => new long2(z, x);
        
        /// <summary>
        /// Returns long4.zxx swizzling.
        /// </summary>
        public long3 zxx => new long3(z, x, x);
        
        /// <summary>
        /// Returns long4.brr swizzling (equivalent to long4.zxx).
        /// </summary>
        public long3 brr => new long3(z, x, x);
        
        /// <summary>
        /// Returns long4.zxxx swizzling.
        /// </summary>
        public long4 zxxx => new long4(z, x, x, x);
        
        /// <summary>
        /// Returns long4.brrr swizzling (equivalent to long4.zxxx).
        /// </summary>
        public long4 brrr => new long4(z, x, x, x);
        
        /// <summary>
        /// Returns long4.zxxy swizzling.
        /// </summary>
        public long4 zxxy => new long4(z, x, x, y);
        
        /// <summary>
        /// Returns long4.brrg swizzling (equivalent to long4.zxxy).
        /// </summary>
        public long4 brrg => new long4(z, x, x, y);
        
        /// <summary>
        /// Returns long4.zxxz swizzling.
        /// </summary>
        public long4 zxxz => new long4(z, x, x, z);
        
        /// <summary>
        /// Returns long4.brrb swizzling (equivalent to long4.zxxz).
        /// </summary>
        public long4 brrb => new long4(z, x, x, z);
        
        /// <summary>
        /// Returns long4.zxxw swizzling.
        /// </summary>
        public long4 zxxw => new long4(z, x, x, w);
        
        /// <summary>
        /// Returns long4.brra swizzling (equivalent to long4.zxxw).
        /// </summary>
        public long4 brra => new long4(z, x, x, w);
        
        /// <summary>
        /// Returns long4.zxy swizzling.
        /// </summary>
        public long3 zxy => new long3(z, x, y);
        
        /// <summary>
        /// Returns long4.brg swizzling (equivalent to long4.zxy).
        /// </summary>
        public long3 brg => new long3(z, x, y);
        
        /// <summary>
        /// Returns long4.zxyx swizzling.
        /// </summary>
        public long4 zxyx => new long4(z, x, y, x);
        
        /// <summary>
        /// Returns long4.brgr swizzling (equivalent to long4.zxyx).
        /// </summary>
        public long4 brgr => new long4(z, x, y, x);
        
        /// <summary>
        /// Returns long4.zxyy swizzling.
        /// </summary>
        public long4 zxyy => new long4(z, x, y, y);
        
        /// <summary>
        /// Returns long4.brgg swizzling (equivalent to long4.zxyy).
        /// </summary>
        public long4 brgg => new long4(z, x, y, y);
        
        /// <summary>
        /// Returns long4.zxyz swizzling.
        /// </summary>
        public long4 zxyz => new long4(z, x, y, z);
        
        /// <summary>
        /// Returns long4.brgb swizzling (equivalent to long4.zxyz).
        /// </summary>
        public long4 brgb => new long4(z, x, y, z);
        
        /// <summary>
        /// Returns long4.zxyw swizzling.
        /// </summary>
        public long4 zxyw => new long4(z, x, y, w);
        
        /// <summary>
        /// Returns long4.brga swizzling (equivalent to long4.zxyw).
        /// </summary>
        public long4 brga => new long4(z, x, y, w);
        
        /// <summary>
        /// Returns long4.zxz swizzling.
        /// </summary>
        public long3 zxz => new long3(z, x, z);
        
        /// <summary>
        /// Returns long4.brb swizzling (equivalent to long4.zxz).
        /// </summary>
        public long3 brb => new long3(z, x, z);
        
        /// <summary>
        /// Returns long4.zxzx swizzling.
        /// </summary>
        public long4 zxzx => new long4(z, x, z, x);
        
        /// <summary>
        /// Returns long4.brbr swizzling (equivalent to long4.zxzx).
        /// </summary>
        public long4 brbr => new long4(z, x, z, x);
        
        /// <summary>
        /// Returns long4.zxzy swizzling.
        /// </summary>
        public long4 zxzy => new long4(z, x, z, y);
        
        /// <summary>
        /// Returns long4.brbg swizzling (equivalent to long4.zxzy).
        /// </summary>
        public long4 brbg => new long4(z, x, z, y);
        
        /// <summary>
        /// Returns long4.zxzz swizzling.
        /// </summary>
        public long4 zxzz => new long4(z, x, z, z);
        
        /// <summary>
        /// Returns long4.brbb swizzling (equivalent to long4.zxzz).
        /// </summary>
        public long4 brbb => new long4(z, x, z, z);
        
        /// <summary>
        /// Returns long4.zxzw swizzling.
        /// </summary>
        public long4 zxzw => new long4(z, x, z, w);
        
        /// <summary>
        /// Returns long4.brba swizzling (equivalent to long4.zxzw).
        /// </summary>
        public long4 brba => new long4(z, x, z, w);
        
        /// <summary>
        /// Returns long4.zxw swizzling.
        /// </summary>
        public long3 zxw => new long3(z, x, w);
        
        /// <summary>
        /// Returns long4.bra swizzling (equivalent to long4.zxw).
        /// </summary>
        public long3 bra => new long3(z, x, w);
        
        /// <summary>
        /// Returns long4.zxwx swizzling.
        /// </summary>
        public long4 zxwx => new long4(z, x, w, x);
        
        /// <summary>
        /// Returns long4.brar swizzling (equivalent to long4.zxwx).
        /// </summary>
        public long4 brar => new long4(z, x, w, x);
        
        /// <summary>
        /// Returns long4.zxwy swizzling.
        /// </summary>
        public long4 zxwy => new long4(z, x, w, y);
        
        /// <summary>
        /// Returns long4.brag swizzling (equivalent to long4.zxwy).
        /// </summary>
        public long4 brag => new long4(z, x, w, y);
        
        /// <summary>
        /// Returns long4.zxwz swizzling.
        /// </summary>
        public long4 zxwz => new long4(z, x, w, z);
        
        /// <summary>
        /// Returns long4.brab swizzling (equivalent to long4.zxwz).
        /// </summary>
        public long4 brab => new long4(z, x, w, z);
        
        /// <summary>
        /// Returns long4.zxww swizzling.
        /// </summary>
        public long4 zxww => new long4(z, x, w, w);
        
        /// <summary>
        /// Returns long4.braa swizzling (equivalent to long4.zxww).
        /// </summary>
        public long4 braa => new long4(z, x, w, w);
        
        /// <summary>
        /// Returns long4.zy swizzling.
        /// </summary>
        public long2 zy => new long2(z, y);
        
        /// <summary>
        /// Returns long4.bg swizzling (equivalent to long4.zy).
        /// </summary>
        public long2 bg => new long2(z, y);
        
        /// <summary>
        /// Returns long4.zyx swizzling.
        /// </summary>
        public long3 zyx => new long3(z, y, x);
        
        /// <summary>
        /// Returns long4.bgr swizzling (equivalent to long4.zyx).
        /// </summary>
        public long3 bgr => new long3(z, y, x);
        
        /// <summary>
        /// Returns long4.zyxx swizzling.
        /// </summary>
        public long4 zyxx => new long4(z, y, x, x);
        
        /// <summary>
        /// Returns long4.bgrr swizzling (equivalent to long4.zyxx).
        /// </summary>
        public long4 bgrr => new long4(z, y, x, x);
        
        /// <summary>
        /// Returns long4.zyxy swizzling.
        /// </summary>
        public long4 zyxy => new long4(z, y, x, y);
        
        /// <summary>
        /// Returns long4.bgrg swizzling (equivalent to long4.zyxy).
        /// </summary>
        public long4 bgrg => new long4(z, y, x, y);
        
        /// <summary>
        /// Returns long4.zyxz swizzling.
        /// </summary>
        public long4 zyxz => new long4(z, y, x, z);
        
        /// <summary>
        /// Returns long4.bgrb swizzling (equivalent to long4.zyxz).
        /// </summary>
        public long4 bgrb => new long4(z, y, x, z);
        
        /// <summary>
        /// Returns long4.zyxw swizzling.
        /// </summary>
        public long4 zyxw => new long4(z, y, x, w);
        
        /// <summary>
        /// Returns long4.bgra swizzling (equivalent to long4.zyxw).
        /// </summary>
        public long4 bgra => new long4(z, y, x, w);
        
        /// <summary>
        /// Returns long4.zyy swizzling.
        /// </summary>
        public long3 zyy => new long3(z, y, y);
        
        /// <summary>
        /// Returns long4.bgg swizzling (equivalent to long4.zyy).
        /// </summary>
        public long3 bgg => new long3(z, y, y);
        
        /// <summary>
        /// Returns long4.zyyx swizzling.
        /// </summary>
        public long4 zyyx => new long4(z, y, y, x);
        
        /// <summary>
        /// Returns long4.bggr swizzling (equivalent to long4.zyyx).
        /// </summary>
        public long4 bggr => new long4(z, y, y, x);
        
        /// <summary>
        /// Returns long4.zyyy swizzling.
        /// </summary>
        public long4 zyyy => new long4(z, y, y, y);
        
        /// <summary>
        /// Returns long4.bggg swizzling (equivalent to long4.zyyy).
        /// </summary>
        public long4 bggg => new long4(z, y, y, y);
        
        /// <summary>
        /// Returns long4.zyyz swizzling.
        /// </summary>
        public long4 zyyz => new long4(z, y, y, z);
        
        /// <summary>
        /// Returns long4.bggb swizzling (equivalent to long4.zyyz).
        /// </summary>
        public long4 bggb => new long4(z, y, y, z);
        
        /// <summary>
        /// Returns long4.zyyw swizzling.
        /// </summary>
        public long4 zyyw => new long4(z, y, y, w);
        
        /// <summary>
        /// Returns long4.bgga swizzling (equivalent to long4.zyyw).
        /// </summary>
        public long4 bgga => new long4(z, y, y, w);
        
        /// <summary>
        /// Returns long4.zyz swizzling.
        /// </summary>
        public long3 zyz => new long3(z, y, z);
        
        /// <summary>
        /// Returns long4.bgb swizzling (equivalent to long4.zyz).
        /// </summary>
        public long3 bgb => new long3(z, y, z);
        
        /// <summary>
        /// Returns long4.zyzx swizzling.
        /// </summary>
        public long4 zyzx => new long4(z, y, z, x);
        
        /// <summary>
        /// Returns long4.bgbr swizzling (equivalent to long4.zyzx).
        /// </summary>
        public long4 bgbr => new long4(z, y, z, x);
        
        /// <summary>
        /// Returns long4.zyzy swizzling.
        /// </summary>
        public long4 zyzy => new long4(z, y, z, y);
        
        /// <summary>
        /// Returns long4.bgbg swizzling (equivalent to long4.zyzy).
        /// </summary>
        public long4 bgbg => new long4(z, y, z, y);
        
        /// <summary>
        /// Returns long4.zyzz swizzling.
        /// </summary>
        public long4 zyzz => new long4(z, y, z, z);
        
        /// <summary>
        /// Returns long4.bgbb swizzling (equivalent to long4.zyzz).
        /// </summary>
        public long4 bgbb => new long4(z, y, z, z);
        
        /// <summary>
        /// Returns long4.zyzw swizzling.
        /// </summary>
        public long4 zyzw => new long4(z, y, z, w);
        
        /// <summary>
        /// Returns long4.bgba swizzling (equivalent to long4.zyzw).
        /// </summary>
        public long4 bgba => new long4(z, y, z, w);
        
        /// <summary>
        /// Returns long4.zyw swizzling.
        /// </summary>
        public long3 zyw => new long3(z, y, w);
        
        /// <summary>
        /// Returns long4.bga swizzling (equivalent to long4.zyw).
        /// </summary>
        public long3 bga => new long3(z, y, w);
        
        /// <summary>
        /// Returns long4.zywx swizzling.
        /// </summary>
        public long4 zywx => new long4(z, y, w, x);
        
        /// <summary>
        /// Returns long4.bgar swizzling (equivalent to long4.zywx).
        /// </summary>
        public long4 bgar => new long4(z, y, w, x);
        
        /// <summary>
        /// Returns long4.zywy swizzling.
        /// </summary>
        public long4 zywy => new long4(z, y, w, y);
        
        /// <summary>
        /// Returns long4.bgag swizzling (equivalent to long4.zywy).
        /// </summary>
        public long4 bgag => new long4(z, y, w, y);
        
        /// <summary>
        /// Returns long4.zywz swizzling.
        /// </summary>
        public long4 zywz => new long4(z, y, w, z);
        
        /// <summary>
        /// Returns long4.bgab swizzling (equivalent to long4.zywz).
        /// </summary>
        public long4 bgab => new long4(z, y, w, z);
        
        /// <summary>
        /// Returns long4.zyww swizzling.
        /// </summary>
        public long4 zyww => new long4(z, y, w, w);
        
        /// <summary>
        /// Returns long4.bgaa swizzling (equivalent to long4.zyww).
        /// </summary>
        public long4 bgaa => new long4(z, y, w, w);
        
        /// <summary>
        /// Returns long4.zz swizzling.
        /// </summary>
        public long2 zz => new long2(z, z);
        
        /// <summary>
        /// Returns long4.bb swizzling (equivalent to long4.zz).
        /// </summary>
        public long2 bb => new long2(z, z);
        
        /// <summary>
        /// Returns long4.zzx swizzling.
        /// </summary>
        public long3 zzx => new long3(z, z, x);
        
        /// <summary>
        /// Returns long4.bbr swizzling (equivalent to long4.zzx).
        /// </summary>
        public long3 bbr => new long3(z, z, x);
        
        /// <summary>
        /// Returns long4.zzxx swizzling.
        /// </summary>
        public long4 zzxx => new long4(z, z, x, x);
        
        /// <summary>
        /// Returns long4.bbrr swizzling (equivalent to long4.zzxx).
        /// </summary>
        public long4 bbrr => new long4(z, z, x, x);
        
        /// <summary>
        /// Returns long4.zzxy swizzling.
        /// </summary>
        public long4 zzxy => new long4(z, z, x, y);
        
        /// <summary>
        /// Returns long4.bbrg swizzling (equivalent to long4.zzxy).
        /// </summary>
        public long4 bbrg => new long4(z, z, x, y);
        
        /// <summary>
        /// Returns long4.zzxz swizzling.
        /// </summary>
        public long4 zzxz => new long4(z, z, x, z);
        
        /// <summary>
        /// Returns long4.bbrb swizzling (equivalent to long4.zzxz).
        /// </summary>
        public long4 bbrb => new long4(z, z, x, z);
        
        /// <summary>
        /// Returns long4.zzxw swizzling.
        /// </summary>
        public long4 zzxw => new long4(z, z, x, w);
        
        /// <summary>
        /// Returns long4.bbra swizzling (equivalent to long4.zzxw).
        /// </summary>
        public long4 bbra => new long4(z, z, x, w);
        
        /// <summary>
        /// Returns long4.zzy swizzling.
        /// </summary>
        public long3 zzy => new long3(z, z, y);
        
        /// <summary>
        /// Returns long4.bbg swizzling (equivalent to long4.zzy).
        /// </summary>
        public long3 bbg => new long3(z, z, y);
        
        /// <summary>
        /// Returns long4.zzyx swizzling.
        /// </summary>
        public long4 zzyx => new long4(z, z, y, x);
        
        /// <summary>
        /// Returns long4.bbgr swizzling (equivalent to long4.zzyx).
        /// </summary>
        public long4 bbgr => new long4(z, z, y, x);
        
        /// <summary>
        /// Returns long4.zzyy swizzling.
        /// </summary>
        public long4 zzyy => new long4(z, z, y, y);
        
        /// <summary>
        /// Returns long4.bbgg swizzling (equivalent to long4.zzyy).
        /// </summary>
        public long4 bbgg => new long4(z, z, y, y);
        
        /// <summary>
        /// Returns long4.zzyz swizzling.
        /// </summary>
        public long4 zzyz => new long4(z, z, y, z);
        
        /// <summary>
        /// Returns long4.bbgb swizzling (equivalent to long4.zzyz).
        /// </summary>
        public long4 bbgb => new long4(z, z, y, z);
        
        /// <summary>
        /// Returns long4.zzyw swizzling.
        /// </summary>
        public long4 zzyw => new long4(z, z, y, w);
        
        /// <summary>
        /// Returns long4.bbga swizzling (equivalent to long4.zzyw).
        /// </summary>
        public long4 bbga => new long4(z, z, y, w);
        
        /// <summary>
        /// Returns long4.zzz swizzling.
        /// </summary>
        public long3 zzz => new long3(z, z, z);
        
        /// <summary>
        /// Returns long4.bbb swizzling (equivalent to long4.zzz).
        /// </summary>
        public long3 bbb => new long3(z, z, z);
        
        /// <summary>
        /// Returns long4.zzzx swizzling.
        /// </summary>
        public long4 zzzx => new long4(z, z, z, x);
        
        /// <summary>
        /// Returns long4.bbbr swizzling (equivalent to long4.zzzx).
        /// </summary>
        public long4 bbbr => new long4(z, z, z, x);
        
        /// <summary>
        /// Returns long4.zzzy swizzling.
        /// </summary>
        public long4 zzzy => new long4(z, z, z, y);
        
        /// <summary>
        /// Returns long4.bbbg swizzling (equivalent to long4.zzzy).
        /// </summary>
        public long4 bbbg => new long4(z, z, z, y);
        
        /// <summary>
        /// Returns long4.zzzz swizzling.
        /// </summary>
        public long4 zzzz => new long4(z, z, z, z);
        
        /// <summary>
        /// Returns long4.bbbb swizzling (equivalent to long4.zzzz).
        /// </summary>
        public long4 bbbb => new long4(z, z, z, z);
        
        /// <summary>
        /// Returns long4.zzzw swizzling.
        /// </summary>
        public long4 zzzw => new long4(z, z, z, w);
        
        /// <summary>
        /// Returns long4.bbba swizzling (equivalent to long4.zzzw).
        /// </summary>
        public long4 bbba => new long4(z, z, z, w);
        
        /// <summary>
        /// Returns long4.zzw swizzling.
        /// </summary>
        public long3 zzw => new long3(z, z, w);
        
        /// <summary>
        /// Returns long4.bba swizzling (equivalent to long4.zzw).
        /// </summary>
        public long3 bba => new long3(z, z, w);
        
        /// <summary>
        /// Returns long4.zzwx swizzling.
        /// </summary>
        public long4 zzwx => new long4(z, z, w, x);
        
        /// <summary>
        /// Returns long4.bbar swizzling (equivalent to long4.zzwx).
        /// </summary>
        public long4 bbar => new long4(z, z, w, x);
        
        /// <summary>
        /// Returns long4.zzwy swizzling.
        /// </summary>
        public long4 zzwy => new long4(z, z, w, y);
        
        /// <summary>
        /// Returns long4.bbag swizzling (equivalent to long4.zzwy).
        /// </summary>
        public long4 bbag => new long4(z, z, w, y);
        
        /// <summary>
        /// Returns long4.zzwz swizzling.
        /// </summary>
        public long4 zzwz => new long4(z, z, w, z);
        
        /// <summary>
        /// Returns long4.bbab swizzling (equivalent to long4.zzwz).
        /// </summary>
        public long4 bbab => new long4(z, z, w, z);
        
        /// <summary>
        /// Returns long4.zzww swizzling.
        /// </summary>
        public long4 zzww => new long4(z, z, w, w);
        
        /// <summary>
        /// Returns long4.bbaa swizzling (equivalent to long4.zzww).
        /// </summary>
        public long4 bbaa => new long4(z, z, w, w);
        
        /// <summary>
        /// Returns long4.zw swizzling.
        /// </summary>
        public long2 zw => new long2(z, w);
        
        /// <summary>
        /// Returns long4.ba swizzling (equivalent to long4.zw).
        /// </summary>
        public long2 ba => new long2(z, w);
        
        /// <summary>
        /// Returns long4.zwx swizzling.
        /// </summary>
        public long3 zwx => new long3(z, w, x);
        
        /// <summary>
        /// Returns long4.bar swizzling (equivalent to long4.zwx).
        /// </summary>
        public long3 bar => new long3(z, w, x);
        
        /// <summary>
        /// Returns long4.zwxx swizzling.
        /// </summary>
        public long4 zwxx => new long4(z, w, x, x);
        
        /// <summary>
        /// Returns long4.barr swizzling (equivalent to long4.zwxx).
        /// </summary>
        public long4 barr => new long4(z, w, x, x);
        
        /// <summary>
        /// Returns long4.zwxy swizzling.
        /// </summary>
        public long4 zwxy => new long4(z, w, x, y);
        
        /// <summary>
        /// Returns long4.barg swizzling (equivalent to long4.zwxy).
        /// </summary>
        public long4 barg => new long4(z, w, x, y);
        
        /// <summary>
        /// Returns long4.zwxz swizzling.
        /// </summary>
        public long4 zwxz => new long4(z, w, x, z);
        
        /// <summary>
        /// Returns long4.barb swizzling (equivalent to long4.zwxz).
        /// </summary>
        public long4 barb => new long4(z, w, x, z);
        
        /// <summary>
        /// Returns long4.zwxw swizzling.
        /// </summary>
        public long4 zwxw => new long4(z, w, x, w);
        
        /// <summary>
        /// Returns long4.bara swizzling (equivalent to long4.zwxw).
        /// </summary>
        public long4 bara => new long4(z, w, x, w);
        
        /// <summary>
        /// Returns long4.zwy swizzling.
        /// </summary>
        public long3 zwy => new long3(z, w, y);
        
        /// <summary>
        /// Returns long4.bag swizzling (equivalent to long4.zwy).
        /// </summary>
        public long3 bag => new long3(z, w, y);
        
        /// <summary>
        /// Returns long4.zwyx swizzling.
        /// </summary>
        public long4 zwyx => new long4(z, w, y, x);
        
        /// <summary>
        /// Returns long4.bagr swizzling (equivalent to long4.zwyx).
        /// </summary>
        public long4 bagr => new long4(z, w, y, x);
        
        /// <summary>
        /// Returns long4.zwyy swizzling.
        /// </summary>
        public long4 zwyy => new long4(z, w, y, y);
        
        /// <summary>
        /// Returns long4.bagg swizzling (equivalent to long4.zwyy).
        /// </summary>
        public long4 bagg => new long4(z, w, y, y);
        
        /// <summary>
        /// Returns long4.zwyz swizzling.
        /// </summary>
        public long4 zwyz => new long4(z, w, y, z);
        
        /// <summary>
        /// Returns long4.bagb swizzling (equivalent to long4.zwyz).
        /// </summary>
        public long4 bagb => new long4(z, w, y, z);
        
        /// <summary>
        /// Returns long4.zwyw swizzling.
        /// </summary>
        public long4 zwyw => new long4(z, w, y, w);
        
        /// <summary>
        /// Returns long4.baga swizzling (equivalent to long4.zwyw).
        /// </summary>
        public long4 baga => new long4(z, w, y, w);
        
        /// <summary>
        /// Returns long4.zwz swizzling.
        /// </summary>
        public long3 zwz => new long3(z, w, z);
        
        /// <summary>
        /// Returns long4.bab swizzling (equivalent to long4.zwz).
        /// </summary>
        public long3 bab => new long3(z, w, z);
        
        /// <summary>
        /// Returns long4.zwzx swizzling.
        /// </summary>
        public long4 zwzx => new long4(z, w, z, x);
        
        /// <summary>
        /// Returns long4.babr swizzling (equivalent to long4.zwzx).
        /// </summary>
        public long4 babr => new long4(z, w, z, x);
        
        /// <summary>
        /// Returns long4.zwzy swizzling.
        /// </summary>
        public long4 zwzy => new long4(z, w, z, y);
        
        /// <summary>
        /// Returns long4.babg swizzling (equivalent to long4.zwzy).
        /// </summary>
        public long4 babg => new long4(z, w, z, y);
        
        /// <summary>
        /// Returns long4.zwzz swizzling.
        /// </summary>
        public long4 zwzz => new long4(z, w, z, z);
        
        /// <summary>
        /// Returns long4.babb swizzling (equivalent to long4.zwzz).
        /// </summary>
        public long4 babb => new long4(z, w, z, z);
        
        /// <summary>
        /// Returns long4.zwzw swizzling.
        /// </summary>
        public long4 zwzw => new long4(z, w, z, w);
        
        /// <summary>
        /// Returns long4.baba swizzling (equivalent to long4.zwzw).
        /// </summary>
        public long4 baba => new long4(z, w, z, w);
        
        /// <summary>
        /// Returns long4.zww swizzling.
        /// </summary>
        public long3 zww => new long3(z, w, w);
        
        /// <summary>
        /// Returns long4.baa swizzling (equivalent to long4.zww).
        /// </summary>
        public long3 baa => new long3(z, w, w);
        
        /// <summary>
        /// Returns long4.zwwx swizzling.
        /// </summary>
        public long4 zwwx => new long4(z, w, w, x);
        
        /// <summary>
        /// Returns long4.baar swizzling (equivalent to long4.zwwx).
        /// </summary>
        public long4 baar => new long4(z, w, w, x);
        
        /// <summary>
        /// Returns long4.zwwy swizzling.
        /// </summary>
        public long4 zwwy => new long4(z, w, w, y);
        
        /// <summary>
        /// Returns long4.baag swizzling (equivalent to long4.zwwy).
        /// </summary>
        public long4 baag => new long4(z, w, w, y);
        
        /// <summary>
        /// Returns long4.zwwz swizzling.
        /// </summary>
        public long4 zwwz => new long4(z, w, w, z);
        
        /// <summary>
        /// Returns long4.baab swizzling (equivalent to long4.zwwz).
        /// </summary>
        public long4 baab => new long4(z, w, w, z);
        
        /// <summary>
        /// Returns long4.zwww swizzling.
        /// </summary>
        public long4 zwww => new long4(z, w, w, w);
        
        /// <summary>
        /// Returns long4.baaa swizzling (equivalent to long4.zwww).
        /// </summary>
        public long4 baaa => new long4(z, w, w, w);
        
        /// <summary>
        /// Returns long4.wx swizzling.
        /// </summary>
        public long2 wx => new long2(w, x);
        
        /// <summary>
        /// Returns long4.ar swizzling (equivalent to long4.wx).
        /// </summary>
        public long2 ar => new long2(w, x);
        
        /// <summary>
        /// Returns long4.wxx swizzling.
        /// </summary>
        public long3 wxx => new long3(w, x, x);
        
        /// <summary>
        /// Returns long4.arr swizzling (equivalent to long4.wxx).
        /// </summary>
        public long3 arr => new long3(w, x, x);
        
        /// <summary>
        /// Returns long4.wxxx swizzling.
        /// </summary>
        public long4 wxxx => new long4(w, x, x, x);
        
        /// <summary>
        /// Returns long4.arrr swizzling (equivalent to long4.wxxx).
        /// </summary>
        public long4 arrr => new long4(w, x, x, x);
        
        /// <summary>
        /// Returns long4.wxxy swizzling.
        /// </summary>
        public long4 wxxy => new long4(w, x, x, y);
        
        /// <summary>
        /// Returns long4.arrg swizzling (equivalent to long4.wxxy).
        /// </summary>
        public long4 arrg => new long4(w, x, x, y);
        
        /// <summary>
        /// Returns long4.wxxz swizzling.
        /// </summary>
        public long4 wxxz => new long4(w, x, x, z);
        
        /// <summary>
        /// Returns long4.arrb swizzling (equivalent to long4.wxxz).
        /// </summary>
        public long4 arrb => new long4(w, x, x, z);
        
        /// <summary>
        /// Returns long4.wxxw swizzling.
        /// </summary>
        public long4 wxxw => new long4(w, x, x, w);
        
        /// <summary>
        /// Returns long4.arra swizzling (equivalent to long4.wxxw).
        /// </summary>
        public long4 arra => new long4(w, x, x, w);
        
        /// <summary>
        /// Returns long4.wxy swizzling.
        /// </summary>
        public long3 wxy => new long3(w, x, y);
        
        /// <summary>
        /// Returns long4.arg swizzling (equivalent to long4.wxy).
        /// </summary>
        public long3 arg => new long3(w, x, y);
        
        /// <summary>
        /// Returns long4.wxyx swizzling.
        /// </summary>
        public long4 wxyx => new long4(w, x, y, x);
        
        /// <summary>
        /// Returns long4.argr swizzling (equivalent to long4.wxyx).
        /// </summary>
        public long4 argr => new long4(w, x, y, x);
        
        /// <summary>
        /// Returns long4.wxyy swizzling.
        /// </summary>
        public long4 wxyy => new long4(w, x, y, y);
        
        /// <summary>
        /// Returns long4.argg swizzling (equivalent to long4.wxyy).
        /// </summary>
        public long4 argg => new long4(w, x, y, y);
        
        /// <summary>
        /// Returns long4.wxyz swizzling.
        /// </summary>
        public long4 wxyz => new long4(w, x, y, z);
        
        /// <summary>
        /// Returns long4.argb swizzling (equivalent to long4.wxyz).
        /// </summary>
        public long4 argb => new long4(w, x, y, z);
        
        /// <summary>
        /// Returns long4.wxyw swizzling.
        /// </summary>
        public long4 wxyw => new long4(w, x, y, w);
        
        /// <summary>
        /// Returns long4.arga swizzling (equivalent to long4.wxyw).
        /// </summary>
        public long4 arga => new long4(w, x, y, w);
        
        /// <summary>
        /// Returns long4.wxz swizzling.
        /// </summary>
        public long3 wxz => new long3(w, x, z);
        
        /// <summary>
        /// Returns long4.arb swizzling (equivalent to long4.wxz).
        /// </summary>
        public long3 arb => new long3(w, x, z);
        
        /// <summary>
        /// Returns long4.wxzx swizzling.
        /// </summary>
        public long4 wxzx => new long4(w, x, z, x);
        
        /// <summary>
        /// Returns long4.arbr swizzling (equivalent to long4.wxzx).
        /// </summary>
        public long4 arbr => new long4(w, x, z, x);
        
        /// <summary>
        /// Returns long4.wxzy swizzling.
        /// </summary>
        public long4 wxzy => new long4(w, x, z, y);
        
        /// <summary>
        /// Returns long4.arbg swizzling (equivalent to long4.wxzy).
        /// </summary>
        public long4 arbg => new long4(w, x, z, y);
        
        /// <summary>
        /// Returns long4.wxzz swizzling.
        /// </summary>
        public long4 wxzz => new long4(w, x, z, z);
        
        /// <summary>
        /// Returns long4.arbb swizzling (equivalent to long4.wxzz).
        /// </summary>
        public long4 arbb => new long4(w, x, z, z);
        
        /// <summary>
        /// Returns long4.wxzw swizzling.
        /// </summary>
        public long4 wxzw => new long4(w, x, z, w);
        
        /// <summary>
        /// Returns long4.arba swizzling (equivalent to long4.wxzw).
        /// </summary>
        public long4 arba => new long4(w, x, z, w);
        
        /// <summary>
        /// Returns long4.wxw swizzling.
        /// </summary>
        public long3 wxw => new long3(w, x, w);
        
        /// <summary>
        /// Returns long4.ara swizzling (equivalent to long4.wxw).
        /// </summary>
        public long3 ara => new long3(w, x, w);
        
        /// <summary>
        /// Returns long4.wxwx swizzling.
        /// </summary>
        public long4 wxwx => new long4(w, x, w, x);
        
        /// <summary>
        /// Returns long4.arar swizzling (equivalent to long4.wxwx).
        /// </summary>
        public long4 arar => new long4(w, x, w, x);
        
        /// <summary>
        /// Returns long4.wxwy swizzling.
        /// </summary>
        public long4 wxwy => new long4(w, x, w, y);
        
        /// <summary>
        /// Returns long4.arag swizzling (equivalent to long4.wxwy).
        /// </summary>
        public long4 arag => new long4(w, x, w, y);
        
        /// <summary>
        /// Returns long4.wxwz swizzling.
        /// </summary>
        public long4 wxwz => new long4(w, x, w, z);
        
        /// <summary>
        /// Returns long4.arab swizzling (equivalent to long4.wxwz).
        /// </summary>
        public long4 arab => new long4(w, x, w, z);
        
        /// <summary>
        /// Returns long4.wxww swizzling.
        /// </summary>
        public long4 wxww => new long4(w, x, w, w);
        
        /// <summary>
        /// Returns long4.araa swizzling (equivalent to long4.wxww).
        /// </summary>
        public long4 araa => new long4(w, x, w, w);
        
        /// <summary>
        /// Returns long4.wy swizzling.
        /// </summary>
        public long2 wy => new long2(w, y);
        
        /// <summary>
        /// Returns long4.ag swizzling (equivalent to long4.wy).
        /// </summary>
        public long2 ag => new long2(w, y);
        
        /// <summary>
        /// Returns long4.wyx swizzling.
        /// </summary>
        public long3 wyx => new long3(w, y, x);
        
        /// <summary>
        /// Returns long4.agr swizzling (equivalent to long4.wyx).
        /// </summary>
        public long3 agr => new long3(w, y, x);
        
        /// <summary>
        /// Returns long4.wyxx swizzling.
        /// </summary>
        public long4 wyxx => new long4(w, y, x, x);
        
        /// <summary>
        /// Returns long4.agrr swizzling (equivalent to long4.wyxx).
        /// </summary>
        public long4 agrr => new long4(w, y, x, x);
        
        /// <summary>
        /// Returns long4.wyxy swizzling.
        /// </summary>
        public long4 wyxy => new long4(w, y, x, y);
        
        /// <summary>
        /// Returns long4.agrg swizzling (equivalent to long4.wyxy).
        /// </summary>
        public long4 agrg => new long4(w, y, x, y);
        
        /// <summary>
        /// Returns long4.wyxz swizzling.
        /// </summary>
        public long4 wyxz => new long4(w, y, x, z);
        
        /// <summary>
        /// Returns long4.agrb swizzling (equivalent to long4.wyxz).
        /// </summary>
        public long4 agrb => new long4(w, y, x, z);
        
        /// <summary>
        /// Returns long4.wyxw swizzling.
        /// </summary>
        public long4 wyxw => new long4(w, y, x, w);
        
        /// <summary>
        /// Returns long4.agra swizzling (equivalent to long4.wyxw).
        /// </summary>
        public long4 agra => new long4(w, y, x, w);
        
        /// <summary>
        /// Returns long4.wyy swizzling.
        /// </summary>
        public long3 wyy => new long3(w, y, y);
        
        /// <summary>
        /// Returns long4.agg swizzling (equivalent to long4.wyy).
        /// </summary>
        public long3 agg => new long3(w, y, y);
        
        /// <summary>
        /// Returns long4.wyyx swizzling.
        /// </summary>
        public long4 wyyx => new long4(w, y, y, x);
        
        /// <summary>
        /// Returns long4.aggr swizzling (equivalent to long4.wyyx).
        /// </summary>
        public long4 aggr => new long4(w, y, y, x);
        
        /// <summary>
        /// Returns long4.wyyy swizzling.
        /// </summary>
        public long4 wyyy => new long4(w, y, y, y);
        
        /// <summary>
        /// Returns long4.aggg swizzling (equivalent to long4.wyyy).
        /// </summary>
        public long4 aggg => new long4(w, y, y, y);
        
        /// <summary>
        /// Returns long4.wyyz swizzling.
        /// </summary>
        public long4 wyyz => new long4(w, y, y, z);
        
        /// <summary>
        /// Returns long4.aggb swizzling (equivalent to long4.wyyz).
        /// </summary>
        public long4 aggb => new long4(w, y, y, z);
        
        /// <summary>
        /// Returns long4.wyyw swizzling.
        /// </summary>
        public long4 wyyw => new long4(w, y, y, w);
        
        /// <summary>
        /// Returns long4.agga swizzling (equivalent to long4.wyyw).
        /// </summary>
        public long4 agga => new long4(w, y, y, w);
        
        /// <summary>
        /// Returns long4.wyz swizzling.
        /// </summary>
        public long3 wyz => new long3(w, y, z);
        
        /// <summary>
        /// Returns long4.agb swizzling (equivalent to long4.wyz).
        /// </summary>
        public long3 agb => new long3(w, y, z);
        
        /// <summary>
        /// Returns long4.wyzx swizzling.
        /// </summary>
        public long4 wyzx => new long4(w, y, z, x);
        
        /// <summary>
        /// Returns long4.agbr swizzling (equivalent to long4.wyzx).
        /// </summary>
        public long4 agbr => new long4(w, y, z, x);
        
        /// <summary>
        /// Returns long4.wyzy swizzling.
        /// </summary>
        public long4 wyzy => new long4(w, y, z, y);
        
        /// <summary>
        /// Returns long4.agbg swizzling (equivalent to long4.wyzy).
        /// </summary>
        public long4 agbg => new long4(w, y, z, y);
        
        /// <summary>
        /// Returns long4.wyzz swizzling.
        /// </summary>
        public long4 wyzz => new long4(w, y, z, z);
        
        /// <summary>
        /// Returns long4.agbb swizzling (equivalent to long4.wyzz).
        /// </summary>
        public long4 agbb => new long4(w, y, z, z);
        
        /// <summary>
        /// Returns long4.wyzw swizzling.
        /// </summary>
        public long4 wyzw => new long4(w, y, z, w);
        
        /// <summary>
        /// Returns long4.agba swizzling (equivalent to long4.wyzw).
        /// </summary>
        public long4 agba => new long4(w, y, z, w);
        
        /// <summary>
        /// Returns long4.wyw swizzling.
        /// </summary>
        public long3 wyw => new long3(w, y, w);
        
        /// <summary>
        /// Returns long4.aga swizzling (equivalent to long4.wyw).
        /// </summary>
        public long3 aga => new long3(w, y, w);
        
        /// <summary>
        /// Returns long4.wywx swizzling.
        /// </summary>
        public long4 wywx => new long4(w, y, w, x);
        
        /// <summary>
        /// Returns long4.agar swizzling (equivalent to long4.wywx).
        /// </summary>
        public long4 agar => new long4(w, y, w, x);
        
        /// <summary>
        /// Returns long4.wywy swizzling.
        /// </summary>
        public long4 wywy => new long4(w, y, w, y);
        
        /// <summary>
        /// Returns long4.agag swizzling (equivalent to long4.wywy).
        /// </summary>
        public long4 agag => new long4(w, y, w, y);
        
        /// <summary>
        /// Returns long4.wywz swizzling.
        /// </summary>
        public long4 wywz => new long4(w, y, w, z);
        
        /// <summary>
        /// Returns long4.agab swizzling (equivalent to long4.wywz).
        /// </summary>
        public long4 agab => new long4(w, y, w, z);
        
        /// <summary>
        /// Returns long4.wyww swizzling.
        /// </summary>
        public long4 wyww => new long4(w, y, w, w);
        
        /// <summary>
        /// Returns long4.agaa swizzling (equivalent to long4.wyww).
        /// </summary>
        public long4 agaa => new long4(w, y, w, w);
        
        /// <summary>
        /// Returns long4.wz swizzling.
        /// </summary>
        public long2 wz => new long2(w, z);
        
        /// <summary>
        /// Returns long4.ab swizzling (equivalent to long4.wz).
        /// </summary>
        public long2 ab => new long2(w, z);
        
        /// <summary>
        /// Returns long4.wzx swizzling.
        /// </summary>
        public long3 wzx => new long3(w, z, x);
        
        /// <summary>
        /// Returns long4.abr swizzling (equivalent to long4.wzx).
        /// </summary>
        public long3 abr => new long3(w, z, x);
        
        /// <summary>
        /// Returns long4.wzxx swizzling.
        /// </summary>
        public long4 wzxx => new long4(w, z, x, x);
        
        /// <summary>
        /// Returns long4.abrr swizzling (equivalent to long4.wzxx).
        /// </summary>
        public long4 abrr => new long4(w, z, x, x);
        
        /// <summary>
        /// Returns long4.wzxy swizzling.
        /// </summary>
        public long4 wzxy => new long4(w, z, x, y);
        
        /// <summary>
        /// Returns long4.abrg swizzling (equivalent to long4.wzxy).
        /// </summary>
        public long4 abrg => new long4(w, z, x, y);
        
        /// <summary>
        /// Returns long4.wzxz swizzling.
        /// </summary>
        public long4 wzxz => new long4(w, z, x, z);
        
        /// <summary>
        /// Returns long4.abrb swizzling (equivalent to long4.wzxz).
        /// </summary>
        public long4 abrb => new long4(w, z, x, z);
        
        /// <summary>
        /// Returns long4.wzxw swizzling.
        /// </summary>
        public long4 wzxw => new long4(w, z, x, w);
        
        /// <summary>
        /// Returns long4.abra swizzling (equivalent to long4.wzxw).
        /// </summary>
        public long4 abra => new long4(w, z, x, w);
        
        /// <summary>
        /// Returns long4.wzy swizzling.
        /// </summary>
        public long3 wzy => new long3(w, z, y);
        
        /// <summary>
        /// Returns long4.abg swizzling (equivalent to long4.wzy).
        /// </summary>
        public long3 abg => new long3(w, z, y);
        
        /// <summary>
        /// Returns long4.wzyx swizzling.
        /// </summary>
        public long4 wzyx => new long4(w, z, y, x);
        
        /// <summary>
        /// Returns long4.abgr swizzling (equivalent to long4.wzyx).
        /// </summary>
        public long4 abgr => new long4(w, z, y, x);
        
        /// <summary>
        /// Returns long4.wzyy swizzling.
        /// </summary>
        public long4 wzyy => new long4(w, z, y, y);
        
        /// <summary>
        /// Returns long4.abgg swizzling (equivalent to long4.wzyy).
        /// </summary>
        public long4 abgg => new long4(w, z, y, y);
        
        /// <summary>
        /// Returns long4.wzyz swizzling.
        /// </summary>
        public long4 wzyz => new long4(w, z, y, z);
        
        /// <summary>
        /// Returns long4.abgb swizzling (equivalent to long4.wzyz).
        /// </summary>
        public long4 abgb => new long4(w, z, y, z);
        
        /// <summary>
        /// Returns long4.wzyw swizzling.
        /// </summary>
        public long4 wzyw => new long4(w, z, y, w);
        
        /// <summary>
        /// Returns long4.abga swizzling (equivalent to long4.wzyw).
        /// </summary>
        public long4 abga => new long4(w, z, y, w);
        
        /// <summary>
        /// Returns long4.wzz swizzling.
        /// </summary>
        public long3 wzz => new long3(w, z, z);
        
        /// <summary>
        /// Returns long4.abb swizzling (equivalent to long4.wzz).
        /// </summary>
        public long3 abb => new long3(w, z, z);
        
        /// <summary>
        /// Returns long4.wzzx swizzling.
        /// </summary>
        public long4 wzzx => new long4(w, z, z, x);
        
        /// <summary>
        /// Returns long4.abbr swizzling (equivalent to long4.wzzx).
        /// </summary>
        public long4 abbr => new long4(w, z, z, x);
        
        /// <summary>
        /// Returns long4.wzzy swizzling.
        /// </summary>
        public long4 wzzy => new long4(w, z, z, y);
        
        /// <summary>
        /// Returns long4.abbg swizzling (equivalent to long4.wzzy).
        /// </summary>
        public long4 abbg => new long4(w, z, z, y);
        
        /// <summary>
        /// Returns long4.wzzz swizzling.
        /// </summary>
        public long4 wzzz => new long4(w, z, z, z);
        
        /// <summary>
        /// Returns long4.abbb swizzling (equivalent to long4.wzzz).
        /// </summary>
        public long4 abbb => new long4(w, z, z, z);
        
        /// <summary>
        /// Returns long4.wzzw swizzling.
        /// </summary>
        public long4 wzzw => new long4(w, z, z, w);
        
        /// <summary>
        /// Returns long4.abba swizzling (equivalent to long4.wzzw).
        /// </summary>
        public long4 abba => new long4(w, z, z, w);
        
        /// <summary>
        /// Returns long4.wzw swizzling.
        /// </summary>
        public long3 wzw => new long3(w, z, w);
        
        /// <summary>
        /// Returns long4.aba swizzling (equivalent to long4.wzw).
        /// </summary>
        public long3 aba => new long3(w, z, w);
        
        /// <summary>
        /// Returns long4.wzwx swizzling.
        /// </summary>
        public long4 wzwx => new long4(w, z, w, x);
        
        /// <summary>
        /// Returns long4.abar swizzling (equivalent to long4.wzwx).
        /// </summary>
        public long4 abar => new long4(w, z, w, x);
        
        /// <summary>
        /// Returns long4.wzwy swizzling.
        /// </summary>
        public long4 wzwy => new long4(w, z, w, y);
        
        /// <summary>
        /// Returns long4.abag swizzling (equivalent to long4.wzwy).
        /// </summary>
        public long4 abag => new long4(w, z, w, y);
        
        /// <summary>
        /// Returns long4.wzwz swizzling.
        /// </summary>
        public long4 wzwz => new long4(w, z, w, z);
        
        /// <summary>
        /// Returns long4.abab swizzling (equivalent to long4.wzwz).
        /// </summary>
        public long4 abab => new long4(w, z, w, z);
        
        /// <summary>
        /// Returns long4.wzww swizzling.
        /// </summary>
        public long4 wzww => new long4(w, z, w, w);
        
        /// <summary>
        /// Returns long4.abaa swizzling (equivalent to long4.wzww).
        /// </summary>
        public long4 abaa => new long4(w, z, w, w);
        
        /// <summary>
        /// Returns long4.ww swizzling.
        /// </summary>
        public long2 ww => new long2(w, w);
        
        /// <summary>
        /// Returns long4.aa swizzling (equivalent to long4.ww).
        /// </summary>
        public long2 aa => new long2(w, w);
        
        /// <summary>
        /// Returns long4.wwx swizzling.
        /// </summary>
        public long3 wwx => new long3(w, w, x);
        
        /// <summary>
        /// Returns long4.aar swizzling (equivalent to long4.wwx).
        /// </summary>
        public long3 aar => new long3(w, w, x);
        
        /// <summary>
        /// Returns long4.wwxx swizzling.
        /// </summary>
        public long4 wwxx => new long4(w, w, x, x);
        
        /// <summary>
        /// Returns long4.aarr swizzling (equivalent to long4.wwxx).
        /// </summary>
        public long4 aarr => new long4(w, w, x, x);
        
        /// <summary>
        /// Returns long4.wwxy swizzling.
        /// </summary>
        public long4 wwxy => new long4(w, w, x, y);
        
        /// <summary>
        /// Returns long4.aarg swizzling (equivalent to long4.wwxy).
        /// </summary>
        public long4 aarg => new long4(w, w, x, y);
        
        /// <summary>
        /// Returns long4.wwxz swizzling.
        /// </summary>
        public long4 wwxz => new long4(w, w, x, z);
        
        /// <summary>
        /// Returns long4.aarb swizzling (equivalent to long4.wwxz).
        /// </summary>
        public long4 aarb => new long4(w, w, x, z);
        
        /// <summary>
        /// Returns long4.wwxw swizzling.
        /// </summary>
        public long4 wwxw => new long4(w, w, x, w);
        
        /// <summary>
        /// Returns long4.aara swizzling (equivalent to long4.wwxw).
        /// </summary>
        public long4 aara => new long4(w, w, x, w);
        
        /// <summary>
        /// Returns long4.wwy swizzling.
        /// </summary>
        public long3 wwy => new long3(w, w, y);
        
        /// <summary>
        /// Returns long4.aag swizzling (equivalent to long4.wwy).
        /// </summary>
        public long3 aag => new long3(w, w, y);
        
        /// <summary>
        /// Returns long4.wwyx swizzling.
        /// </summary>
        public long4 wwyx => new long4(w, w, y, x);
        
        /// <summary>
        /// Returns long4.aagr swizzling (equivalent to long4.wwyx).
        /// </summary>
        public long4 aagr => new long4(w, w, y, x);
        
        /// <summary>
        /// Returns long4.wwyy swizzling.
        /// </summary>
        public long4 wwyy => new long4(w, w, y, y);
        
        /// <summary>
        /// Returns long4.aagg swizzling (equivalent to long4.wwyy).
        /// </summary>
        public long4 aagg => new long4(w, w, y, y);
        
        /// <summary>
        /// Returns long4.wwyz swizzling.
        /// </summary>
        public long4 wwyz => new long4(w, w, y, z);
        
        /// <summary>
        /// Returns long4.aagb swizzling (equivalent to long4.wwyz).
        /// </summary>
        public long4 aagb => new long4(w, w, y, z);
        
        /// <summary>
        /// Returns long4.wwyw swizzling.
        /// </summary>
        public long4 wwyw => new long4(w, w, y, w);
        
        /// <summary>
        /// Returns long4.aaga swizzling (equivalent to long4.wwyw).
        /// </summary>
        public long4 aaga => new long4(w, w, y, w);
        
        /// <summary>
        /// Returns long4.wwz swizzling.
        /// </summary>
        public long3 wwz => new long3(w, w, z);
        
        /// <summary>
        /// Returns long4.aab swizzling (equivalent to long4.wwz).
        /// </summary>
        public long3 aab => new long3(w, w, z);
        
        /// <summary>
        /// Returns long4.wwzx swizzling.
        /// </summary>
        public long4 wwzx => new long4(w, w, z, x);
        
        /// <summary>
        /// Returns long4.aabr swizzling (equivalent to long4.wwzx).
        /// </summary>
        public long4 aabr => new long4(w, w, z, x);
        
        /// <summary>
        /// Returns long4.wwzy swizzling.
        /// </summary>
        public long4 wwzy => new long4(w, w, z, y);
        
        /// <summary>
        /// Returns long4.aabg swizzling (equivalent to long4.wwzy).
        /// </summary>
        public long4 aabg => new long4(w, w, z, y);
        
        /// <summary>
        /// Returns long4.wwzz swizzling.
        /// </summary>
        public long4 wwzz => new long4(w, w, z, z);
        
        /// <summary>
        /// Returns long4.aabb swizzling (equivalent to long4.wwzz).
        /// </summary>
        public long4 aabb => new long4(w, w, z, z);
        
        /// <summary>
        /// Returns long4.wwzw swizzling.
        /// </summary>
        public long4 wwzw => new long4(w, w, z, w);
        
        /// <summary>
        /// Returns long4.aaba swizzling (equivalent to long4.wwzw).
        /// </summary>
        public long4 aaba => new long4(w, w, z, w);
        
        /// <summary>
        /// Returns long4.www swizzling.
        /// </summary>
        public long3 www => new long3(w, w, w);
        
        /// <summary>
        /// Returns long4.aaa swizzling (equivalent to long4.www).
        /// </summary>
        public long3 aaa => new long3(w, w, w);
        
        /// <summary>
        /// Returns long4.wwwx swizzling.
        /// </summary>
        public long4 wwwx => new long4(w, w, w, x);
        
        /// <summary>
        /// Returns long4.aaar swizzling (equivalent to long4.wwwx).
        /// </summary>
        public long4 aaar => new long4(w, w, w, x);
        
        /// <summary>
        /// Returns long4.wwwy swizzling.
        /// </summary>
        public long4 wwwy => new long4(w, w, w, y);
        
        /// <summary>
        /// Returns long4.aaag swizzling (equivalent to long4.wwwy).
        /// </summary>
        public long4 aaag => new long4(w, w, w, y);
        
        /// <summary>
        /// Returns long4.wwwz swizzling.
        /// </summary>
        public long4 wwwz => new long4(w, w, w, z);
        
        /// <summary>
        /// Returns long4.aaab swizzling (equivalent to long4.wwwz).
        /// </summary>
        public long4 aaab => new long4(w, w, w, z);
        
        /// <summary>
        /// Returns long4.wwww swizzling.
        /// </summary>
        public long4 wwww => new long4(w, w, w, w);
        
        /// <summary>
        /// Returns long4.aaaa swizzling (equivalent to long4.wwww).
        /// </summary>
        public long4 aaaa => new long4(w, w, w, w);

        #endregion

    }
}
