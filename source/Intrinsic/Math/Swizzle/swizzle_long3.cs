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
    /// Temporary vector of type long with 3 components, used for implementing swizzling for long3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_long3
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_long3.
        /// </summary>
        internal swizzle_long3(long x, long y, long z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns long3.xx swizzling.
        /// </summary>
        public long2 xx => new long2(x, x);
        
        /// <summary>
        /// Returns long3.rr swizzling (equivalent to long3.xx).
        /// </summary>
        public long2 rr => new long2(x, x);
        
        /// <summary>
        /// Returns long3.xxx swizzling.
        /// </summary>
        public long3 xxx => new long3(x, x, x);
        
        /// <summary>
        /// Returns long3.rrr swizzling (equivalent to long3.xxx).
        /// </summary>
        public long3 rrr => new long3(x, x, x);
        
        /// <summary>
        /// Returns long3.xxxx swizzling.
        /// </summary>
        public long4 xxxx => new long4(x, x, x, x);
        
        /// <summary>
        /// Returns long3.rrrr swizzling (equivalent to long3.xxxx).
        /// </summary>
        public long4 rrrr => new long4(x, x, x, x);
        
        /// <summary>
        /// Returns long3.xxxy swizzling.
        /// </summary>
        public long4 xxxy => new long4(x, x, x, y);
        
        /// <summary>
        /// Returns long3.rrrg swizzling (equivalent to long3.xxxy).
        /// </summary>
        public long4 rrrg => new long4(x, x, x, y);
        
        /// <summary>
        /// Returns long3.xxxz swizzling.
        /// </summary>
        public long4 xxxz => new long4(x, x, x, z);
        
        /// <summary>
        /// Returns long3.rrrb swizzling (equivalent to long3.xxxz).
        /// </summary>
        public long4 rrrb => new long4(x, x, x, z);
        
        /// <summary>
        /// Returns long3.xxy swizzling.
        /// </summary>
        public long3 xxy => new long3(x, x, y);
        
        /// <summary>
        /// Returns long3.rrg swizzling (equivalent to long3.xxy).
        /// </summary>
        public long3 rrg => new long3(x, x, y);
        
        /// <summary>
        /// Returns long3.xxyx swizzling.
        /// </summary>
        public long4 xxyx => new long4(x, x, y, x);
        
        /// <summary>
        /// Returns long3.rrgr swizzling (equivalent to long3.xxyx).
        /// </summary>
        public long4 rrgr => new long4(x, x, y, x);
        
        /// <summary>
        /// Returns long3.xxyy swizzling.
        /// </summary>
        public long4 xxyy => new long4(x, x, y, y);
        
        /// <summary>
        /// Returns long3.rrgg swizzling (equivalent to long3.xxyy).
        /// </summary>
        public long4 rrgg => new long4(x, x, y, y);
        
        /// <summary>
        /// Returns long3.xxyz swizzling.
        /// </summary>
        public long4 xxyz => new long4(x, x, y, z);
        
        /// <summary>
        /// Returns long3.rrgb swizzling (equivalent to long3.xxyz).
        /// </summary>
        public long4 rrgb => new long4(x, x, y, z);
        
        /// <summary>
        /// Returns long3.xxz swizzling.
        /// </summary>
        public long3 xxz => new long3(x, x, z);
        
        /// <summary>
        /// Returns long3.rrb swizzling (equivalent to long3.xxz).
        /// </summary>
        public long3 rrb => new long3(x, x, z);
        
        /// <summary>
        /// Returns long3.xxzx swizzling.
        /// </summary>
        public long4 xxzx => new long4(x, x, z, x);
        
        /// <summary>
        /// Returns long3.rrbr swizzling (equivalent to long3.xxzx).
        /// </summary>
        public long4 rrbr => new long4(x, x, z, x);
        
        /// <summary>
        /// Returns long3.xxzy swizzling.
        /// </summary>
        public long4 xxzy => new long4(x, x, z, y);
        
        /// <summary>
        /// Returns long3.rrbg swizzling (equivalent to long3.xxzy).
        /// </summary>
        public long4 rrbg => new long4(x, x, z, y);
        
        /// <summary>
        /// Returns long3.xxzz swizzling.
        /// </summary>
        public long4 xxzz => new long4(x, x, z, z);
        
        /// <summary>
        /// Returns long3.rrbb swizzling (equivalent to long3.xxzz).
        /// </summary>
        public long4 rrbb => new long4(x, x, z, z);
        
        /// <summary>
        /// Returns long3.xy swizzling.
        /// </summary>
        public long2 xy => new long2(x, y);
        
        /// <summary>
        /// Returns long3.rg swizzling (equivalent to long3.xy).
        /// </summary>
        public long2 rg => new long2(x, y);
        
        /// <summary>
        /// Returns long3.xyx swizzling.
        /// </summary>
        public long3 xyx => new long3(x, y, x);
        
        /// <summary>
        /// Returns long3.rgr swizzling (equivalent to long3.xyx).
        /// </summary>
        public long3 rgr => new long3(x, y, x);
        
        /// <summary>
        /// Returns long3.xyxx swizzling.
        /// </summary>
        public long4 xyxx => new long4(x, y, x, x);
        
        /// <summary>
        /// Returns long3.rgrr swizzling (equivalent to long3.xyxx).
        /// </summary>
        public long4 rgrr => new long4(x, y, x, x);
        
        /// <summary>
        /// Returns long3.xyxy swizzling.
        /// </summary>
        public long4 xyxy => new long4(x, y, x, y);
        
        /// <summary>
        /// Returns long3.rgrg swizzling (equivalent to long3.xyxy).
        /// </summary>
        public long4 rgrg => new long4(x, y, x, y);
        
        /// <summary>
        /// Returns long3.xyxz swizzling.
        /// </summary>
        public long4 xyxz => new long4(x, y, x, z);
        
        /// <summary>
        /// Returns long3.rgrb swizzling (equivalent to long3.xyxz).
        /// </summary>
        public long4 rgrb => new long4(x, y, x, z);
        
        /// <summary>
        /// Returns long3.xyy swizzling.
        /// </summary>
        public long3 xyy => new long3(x, y, y);
        
        /// <summary>
        /// Returns long3.rgg swizzling (equivalent to long3.xyy).
        /// </summary>
        public long3 rgg => new long3(x, y, y);
        
        /// <summary>
        /// Returns long3.xyyx swizzling.
        /// </summary>
        public long4 xyyx => new long4(x, y, y, x);
        
        /// <summary>
        /// Returns long3.rggr swizzling (equivalent to long3.xyyx).
        /// </summary>
        public long4 rggr => new long4(x, y, y, x);
        
        /// <summary>
        /// Returns long3.xyyy swizzling.
        /// </summary>
        public long4 xyyy => new long4(x, y, y, y);
        
        /// <summary>
        /// Returns long3.rggg swizzling (equivalent to long3.xyyy).
        /// </summary>
        public long4 rggg => new long4(x, y, y, y);
        
        /// <summary>
        /// Returns long3.xyyz swizzling.
        /// </summary>
        public long4 xyyz => new long4(x, y, y, z);
        
        /// <summary>
        /// Returns long3.rggb swizzling (equivalent to long3.xyyz).
        /// </summary>
        public long4 rggb => new long4(x, y, y, z);
        
        /// <summary>
        /// Returns long3.xyz swizzling.
        /// </summary>
        public long3 xyz => new long3(x, y, z);
        
        /// <summary>
        /// Returns long3.rgb swizzling (equivalent to long3.xyz).
        /// </summary>
        public long3 rgb => new long3(x, y, z);
        
        /// <summary>
        /// Returns long3.xyzx swizzling.
        /// </summary>
        public long4 xyzx => new long4(x, y, z, x);
        
        /// <summary>
        /// Returns long3.rgbr swizzling (equivalent to long3.xyzx).
        /// </summary>
        public long4 rgbr => new long4(x, y, z, x);
        
        /// <summary>
        /// Returns long3.xyzy swizzling.
        /// </summary>
        public long4 xyzy => new long4(x, y, z, y);
        
        /// <summary>
        /// Returns long3.rgbg swizzling (equivalent to long3.xyzy).
        /// </summary>
        public long4 rgbg => new long4(x, y, z, y);
        
        /// <summary>
        /// Returns long3.xyzz swizzling.
        /// </summary>
        public long4 xyzz => new long4(x, y, z, z);
        
        /// <summary>
        /// Returns long3.rgbb swizzling (equivalent to long3.xyzz).
        /// </summary>
        public long4 rgbb => new long4(x, y, z, z);
        
        /// <summary>
        /// Returns long3.xz swizzling.
        /// </summary>
        public long2 xz => new long2(x, z);
        
        /// <summary>
        /// Returns long3.rb swizzling (equivalent to long3.xz).
        /// </summary>
        public long2 rb => new long2(x, z);
        
        /// <summary>
        /// Returns long3.xzx swizzling.
        /// </summary>
        public long3 xzx => new long3(x, z, x);
        
        /// <summary>
        /// Returns long3.rbr swizzling (equivalent to long3.xzx).
        /// </summary>
        public long3 rbr => new long3(x, z, x);
        
        /// <summary>
        /// Returns long3.xzxx swizzling.
        /// </summary>
        public long4 xzxx => new long4(x, z, x, x);
        
        /// <summary>
        /// Returns long3.rbrr swizzling (equivalent to long3.xzxx).
        /// </summary>
        public long4 rbrr => new long4(x, z, x, x);
        
        /// <summary>
        /// Returns long3.xzxy swizzling.
        /// </summary>
        public long4 xzxy => new long4(x, z, x, y);
        
        /// <summary>
        /// Returns long3.rbrg swizzling (equivalent to long3.xzxy).
        /// </summary>
        public long4 rbrg => new long4(x, z, x, y);
        
        /// <summary>
        /// Returns long3.xzxz swizzling.
        /// </summary>
        public long4 xzxz => new long4(x, z, x, z);
        
        /// <summary>
        /// Returns long3.rbrb swizzling (equivalent to long3.xzxz).
        /// </summary>
        public long4 rbrb => new long4(x, z, x, z);
        
        /// <summary>
        /// Returns long3.xzy swizzling.
        /// </summary>
        public long3 xzy => new long3(x, z, y);
        
        /// <summary>
        /// Returns long3.rbg swizzling (equivalent to long3.xzy).
        /// </summary>
        public long3 rbg => new long3(x, z, y);
        
        /// <summary>
        /// Returns long3.xzyx swizzling.
        /// </summary>
        public long4 xzyx => new long4(x, z, y, x);
        
        /// <summary>
        /// Returns long3.rbgr swizzling (equivalent to long3.xzyx).
        /// </summary>
        public long4 rbgr => new long4(x, z, y, x);
        
        /// <summary>
        /// Returns long3.xzyy swizzling.
        /// </summary>
        public long4 xzyy => new long4(x, z, y, y);
        
        /// <summary>
        /// Returns long3.rbgg swizzling (equivalent to long3.xzyy).
        /// </summary>
        public long4 rbgg => new long4(x, z, y, y);
        
        /// <summary>
        /// Returns long3.xzyz swizzling.
        /// </summary>
        public long4 xzyz => new long4(x, z, y, z);
        
        /// <summary>
        /// Returns long3.rbgb swizzling (equivalent to long3.xzyz).
        /// </summary>
        public long4 rbgb => new long4(x, z, y, z);
        
        /// <summary>
        /// Returns long3.xzz swizzling.
        /// </summary>
        public long3 xzz => new long3(x, z, z);
        
        /// <summary>
        /// Returns long3.rbb swizzling (equivalent to long3.xzz).
        /// </summary>
        public long3 rbb => new long3(x, z, z);
        
        /// <summary>
        /// Returns long3.xzzx swizzling.
        /// </summary>
        public long4 xzzx => new long4(x, z, z, x);
        
        /// <summary>
        /// Returns long3.rbbr swizzling (equivalent to long3.xzzx).
        /// </summary>
        public long4 rbbr => new long4(x, z, z, x);
        
        /// <summary>
        /// Returns long3.xzzy swizzling.
        /// </summary>
        public long4 xzzy => new long4(x, z, z, y);
        
        /// <summary>
        /// Returns long3.rbbg swizzling (equivalent to long3.xzzy).
        /// </summary>
        public long4 rbbg => new long4(x, z, z, y);
        
        /// <summary>
        /// Returns long3.xzzz swizzling.
        /// </summary>
        public long4 xzzz => new long4(x, z, z, z);
        
        /// <summary>
        /// Returns long3.rbbb swizzling (equivalent to long3.xzzz).
        /// </summary>
        public long4 rbbb => new long4(x, z, z, z);
        
        /// <summary>
        /// Returns long3.yx swizzling.
        /// </summary>
        public long2 yx => new long2(y, x);
        
        /// <summary>
        /// Returns long3.gr swizzling (equivalent to long3.yx).
        /// </summary>
        public long2 gr => new long2(y, x);
        
        /// <summary>
        /// Returns long3.yxx swizzling.
        /// </summary>
        public long3 yxx => new long3(y, x, x);
        
        /// <summary>
        /// Returns long3.grr swizzling (equivalent to long3.yxx).
        /// </summary>
        public long3 grr => new long3(y, x, x);
        
        /// <summary>
        /// Returns long3.yxxx swizzling.
        /// </summary>
        public long4 yxxx => new long4(y, x, x, x);
        
        /// <summary>
        /// Returns long3.grrr swizzling (equivalent to long3.yxxx).
        /// </summary>
        public long4 grrr => new long4(y, x, x, x);
        
        /// <summary>
        /// Returns long3.yxxy swizzling.
        /// </summary>
        public long4 yxxy => new long4(y, x, x, y);
        
        /// <summary>
        /// Returns long3.grrg swizzling (equivalent to long3.yxxy).
        /// </summary>
        public long4 grrg => new long4(y, x, x, y);
        
        /// <summary>
        /// Returns long3.yxxz swizzling.
        /// </summary>
        public long4 yxxz => new long4(y, x, x, z);
        
        /// <summary>
        /// Returns long3.grrb swizzling (equivalent to long3.yxxz).
        /// </summary>
        public long4 grrb => new long4(y, x, x, z);
        
        /// <summary>
        /// Returns long3.yxy swizzling.
        /// </summary>
        public long3 yxy => new long3(y, x, y);
        
        /// <summary>
        /// Returns long3.grg swizzling (equivalent to long3.yxy).
        /// </summary>
        public long3 grg => new long3(y, x, y);
        
        /// <summary>
        /// Returns long3.yxyx swizzling.
        /// </summary>
        public long4 yxyx => new long4(y, x, y, x);
        
        /// <summary>
        /// Returns long3.grgr swizzling (equivalent to long3.yxyx).
        /// </summary>
        public long4 grgr => new long4(y, x, y, x);
        
        /// <summary>
        /// Returns long3.yxyy swizzling.
        /// </summary>
        public long4 yxyy => new long4(y, x, y, y);
        
        /// <summary>
        /// Returns long3.grgg swizzling (equivalent to long3.yxyy).
        /// </summary>
        public long4 grgg => new long4(y, x, y, y);
        
        /// <summary>
        /// Returns long3.yxyz swizzling.
        /// </summary>
        public long4 yxyz => new long4(y, x, y, z);
        
        /// <summary>
        /// Returns long3.grgb swizzling (equivalent to long3.yxyz).
        /// </summary>
        public long4 grgb => new long4(y, x, y, z);
        
        /// <summary>
        /// Returns long3.yxz swizzling.
        /// </summary>
        public long3 yxz => new long3(y, x, z);
        
        /// <summary>
        /// Returns long3.grb swizzling (equivalent to long3.yxz).
        /// </summary>
        public long3 grb => new long3(y, x, z);
        
        /// <summary>
        /// Returns long3.yxzx swizzling.
        /// </summary>
        public long4 yxzx => new long4(y, x, z, x);
        
        /// <summary>
        /// Returns long3.grbr swizzling (equivalent to long3.yxzx).
        /// </summary>
        public long4 grbr => new long4(y, x, z, x);
        
        /// <summary>
        /// Returns long3.yxzy swizzling.
        /// </summary>
        public long4 yxzy => new long4(y, x, z, y);
        
        /// <summary>
        /// Returns long3.grbg swizzling (equivalent to long3.yxzy).
        /// </summary>
        public long4 grbg => new long4(y, x, z, y);
        
        /// <summary>
        /// Returns long3.yxzz swizzling.
        /// </summary>
        public long4 yxzz => new long4(y, x, z, z);
        
        /// <summary>
        /// Returns long3.grbb swizzling (equivalent to long3.yxzz).
        /// </summary>
        public long4 grbb => new long4(y, x, z, z);
        
        /// <summary>
        /// Returns long3.yy swizzling.
        /// </summary>
        public long2 yy => new long2(y, y);
        
        /// <summary>
        /// Returns long3.gg swizzling (equivalent to long3.yy).
        /// </summary>
        public long2 gg => new long2(y, y);
        
        /// <summary>
        /// Returns long3.yyx swizzling.
        /// </summary>
        public long3 yyx => new long3(y, y, x);
        
        /// <summary>
        /// Returns long3.ggr swizzling (equivalent to long3.yyx).
        /// </summary>
        public long3 ggr => new long3(y, y, x);
        
        /// <summary>
        /// Returns long3.yyxx swizzling.
        /// </summary>
        public long4 yyxx => new long4(y, y, x, x);
        
        /// <summary>
        /// Returns long3.ggrr swizzling (equivalent to long3.yyxx).
        /// </summary>
        public long4 ggrr => new long4(y, y, x, x);
        
        /// <summary>
        /// Returns long3.yyxy swizzling.
        /// </summary>
        public long4 yyxy => new long4(y, y, x, y);
        
        /// <summary>
        /// Returns long3.ggrg swizzling (equivalent to long3.yyxy).
        /// </summary>
        public long4 ggrg => new long4(y, y, x, y);
        
        /// <summary>
        /// Returns long3.yyxz swizzling.
        /// </summary>
        public long4 yyxz => new long4(y, y, x, z);
        
        /// <summary>
        /// Returns long3.ggrb swizzling (equivalent to long3.yyxz).
        /// </summary>
        public long4 ggrb => new long4(y, y, x, z);
        
        /// <summary>
        /// Returns long3.yyy swizzling.
        /// </summary>
        public long3 yyy => new long3(y, y, y);
        
        /// <summary>
        /// Returns long3.ggg swizzling (equivalent to long3.yyy).
        /// </summary>
        public long3 ggg => new long3(y, y, y);
        
        /// <summary>
        /// Returns long3.yyyx swizzling.
        /// </summary>
        public long4 yyyx => new long4(y, y, y, x);
        
        /// <summary>
        /// Returns long3.gggr swizzling (equivalent to long3.yyyx).
        /// </summary>
        public long4 gggr => new long4(y, y, y, x);
        
        /// <summary>
        /// Returns long3.yyyy swizzling.
        /// </summary>
        public long4 yyyy => new long4(y, y, y, y);
        
        /// <summary>
        /// Returns long3.gggg swizzling (equivalent to long3.yyyy).
        /// </summary>
        public long4 gggg => new long4(y, y, y, y);
        
        /// <summary>
        /// Returns long3.yyyz swizzling.
        /// </summary>
        public long4 yyyz => new long4(y, y, y, z);
        
        /// <summary>
        /// Returns long3.gggb swizzling (equivalent to long3.yyyz).
        /// </summary>
        public long4 gggb => new long4(y, y, y, z);
        
        /// <summary>
        /// Returns long3.yyz swizzling.
        /// </summary>
        public long3 yyz => new long3(y, y, z);
        
        /// <summary>
        /// Returns long3.ggb swizzling (equivalent to long3.yyz).
        /// </summary>
        public long3 ggb => new long3(y, y, z);
        
        /// <summary>
        /// Returns long3.yyzx swizzling.
        /// </summary>
        public long4 yyzx => new long4(y, y, z, x);
        
        /// <summary>
        /// Returns long3.ggbr swizzling (equivalent to long3.yyzx).
        /// </summary>
        public long4 ggbr => new long4(y, y, z, x);
        
        /// <summary>
        /// Returns long3.yyzy swizzling.
        /// </summary>
        public long4 yyzy => new long4(y, y, z, y);
        
        /// <summary>
        /// Returns long3.ggbg swizzling (equivalent to long3.yyzy).
        /// </summary>
        public long4 ggbg => new long4(y, y, z, y);
        
        /// <summary>
        /// Returns long3.yyzz swizzling.
        /// </summary>
        public long4 yyzz => new long4(y, y, z, z);
        
        /// <summary>
        /// Returns long3.ggbb swizzling (equivalent to long3.yyzz).
        /// </summary>
        public long4 ggbb => new long4(y, y, z, z);
        
        /// <summary>
        /// Returns long3.yz swizzling.
        /// </summary>
        public long2 yz => new long2(y, z);
        
        /// <summary>
        /// Returns long3.gb swizzling (equivalent to long3.yz).
        /// </summary>
        public long2 gb => new long2(y, z);
        
        /// <summary>
        /// Returns long3.yzx swizzling.
        /// </summary>
        public long3 yzx => new long3(y, z, x);
        
        /// <summary>
        /// Returns long3.gbr swizzling (equivalent to long3.yzx).
        /// </summary>
        public long3 gbr => new long3(y, z, x);
        
        /// <summary>
        /// Returns long3.yzxx swizzling.
        /// </summary>
        public long4 yzxx => new long4(y, z, x, x);
        
        /// <summary>
        /// Returns long3.gbrr swizzling (equivalent to long3.yzxx).
        /// </summary>
        public long4 gbrr => new long4(y, z, x, x);
        
        /// <summary>
        /// Returns long3.yzxy swizzling.
        /// </summary>
        public long4 yzxy => new long4(y, z, x, y);
        
        /// <summary>
        /// Returns long3.gbrg swizzling (equivalent to long3.yzxy).
        /// </summary>
        public long4 gbrg => new long4(y, z, x, y);
        
        /// <summary>
        /// Returns long3.yzxz swizzling.
        /// </summary>
        public long4 yzxz => new long4(y, z, x, z);
        
        /// <summary>
        /// Returns long3.gbrb swizzling (equivalent to long3.yzxz).
        /// </summary>
        public long4 gbrb => new long4(y, z, x, z);
        
        /// <summary>
        /// Returns long3.yzy swizzling.
        /// </summary>
        public long3 yzy => new long3(y, z, y);
        
        /// <summary>
        /// Returns long3.gbg swizzling (equivalent to long3.yzy).
        /// </summary>
        public long3 gbg => new long3(y, z, y);
        
        /// <summary>
        /// Returns long3.yzyx swizzling.
        /// </summary>
        public long4 yzyx => new long4(y, z, y, x);
        
        /// <summary>
        /// Returns long3.gbgr swizzling (equivalent to long3.yzyx).
        /// </summary>
        public long4 gbgr => new long4(y, z, y, x);
        
        /// <summary>
        /// Returns long3.yzyy swizzling.
        /// </summary>
        public long4 yzyy => new long4(y, z, y, y);
        
        /// <summary>
        /// Returns long3.gbgg swizzling (equivalent to long3.yzyy).
        /// </summary>
        public long4 gbgg => new long4(y, z, y, y);
        
        /// <summary>
        /// Returns long3.yzyz swizzling.
        /// </summary>
        public long4 yzyz => new long4(y, z, y, z);
        
        /// <summary>
        /// Returns long3.gbgb swizzling (equivalent to long3.yzyz).
        /// </summary>
        public long4 gbgb => new long4(y, z, y, z);
        
        /// <summary>
        /// Returns long3.yzz swizzling.
        /// </summary>
        public long3 yzz => new long3(y, z, z);
        
        /// <summary>
        /// Returns long3.gbb swizzling (equivalent to long3.yzz).
        /// </summary>
        public long3 gbb => new long3(y, z, z);
        
        /// <summary>
        /// Returns long3.yzzx swizzling.
        /// </summary>
        public long4 yzzx => new long4(y, z, z, x);
        
        /// <summary>
        /// Returns long3.gbbr swizzling (equivalent to long3.yzzx).
        /// </summary>
        public long4 gbbr => new long4(y, z, z, x);
        
        /// <summary>
        /// Returns long3.yzzy swizzling.
        /// </summary>
        public long4 yzzy => new long4(y, z, z, y);
        
        /// <summary>
        /// Returns long3.gbbg swizzling (equivalent to long3.yzzy).
        /// </summary>
        public long4 gbbg => new long4(y, z, z, y);
        
        /// <summary>
        /// Returns long3.yzzz swizzling.
        /// </summary>
        public long4 yzzz => new long4(y, z, z, z);
        
        /// <summary>
        /// Returns long3.gbbb swizzling (equivalent to long3.yzzz).
        /// </summary>
        public long4 gbbb => new long4(y, z, z, z);
        
        /// <summary>
        /// Returns long3.zx swizzling.
        /// </summary>
        public long2 zx => new long2(z, x);
        
        /// <summary>
        /// Returns long3.br swizzling (equivalent to long3.zx).
        /// </summary>
        public long2 br => new long2(z, x);
        
        /// <summary>
        /// Returns long3.zxx swizzling.
        /// </summary>
        public long3 zxx => new long3(z, x, x);
        
        /// <summary>
        /// Returns long3.brr swizzling (equivalent to long3.zxx).
        /// </summary>
        public long3 brr => new long3(z, x, x);
        
        /// <summary>
        /// Returns long3.zxxx swizzling.
        /// </summary>
        public long4 zxxx => new long4(z, x, x, x);
        
        /// <summary>
        /// Returns long3.brrr swizzling (equivalent to long3.zxxx).
        /// </summary>
        public long4 brrr => new long4(z, x, x, x);
        
        /// <summary>
        /// Returns long3.zxxy swizzling.
        /// </summary>
        public long4 zxxy => new long4(z, x, x, y);
        
        /// <summary>
        /// Returns long3.brrg swizzling (equivalent to long3.zxxy).
        /// </summary>
        public long4 brrg => new long4(z, x, x, y);
        
        /// <summary>
        /// Returns long3.zxxz swizzling.
        /// </summary>
        public long4 zxxz => new long4(z, x, x, z);
        
        /// <summary>
        /// Returns long3.brrb swizzling (equivalent to long3.zxxz).
        /// </summary>
        public long4 brrb => new long4(z, x, x, z);
        
        /// <summary>
        /// Returns long3.zxy swizzling.
        /// </summary>
        public long3 zxy => new long3(z, x, y);
        
        /// <summary>
        /// Returns long3.brg swizzling (equivalent to long3.zxy).
        /// </summary>
        public long3 brg => new long3(z, x, y);
        
        /// <summary>
        /// Returns long3.zxyx swizzling.
        /// </summary>
        public long4 zxyx => new long4(z, x, y, x);
        
        /// <summary>
        /// Returns long3.brgr swizzling (equivalent to long3.zxyx).
        /// </summary>
        public long4 brgr => new long4(z, x, y, x);
        
        /// <summary>
        /// Returns long3.zxyy swizzling.
        /// </summary>
        public long4 zxyy => new long4(z, x, y, y);
        
        /// <summary>
        /// Returns long3.brgg swizzling (equivalent to long3.zxyy).
        /// </summary>
        public long4 brgg => new long4(z, x, y, y);
        
        /// <summary>
        /// Returns long3.zxyz swizzling.
        /// </summary>
        public long4 zxyz => new long4(z, x, y, z);
        
        /// <summary>
        /// Returns long3.brgb swizzling (equivalent to long3.zxyz).
        /// </summary>
        public long4 brgb => new long4(z, x, y, z);
        
        /// <summary>
        /// Returns long3.zxz swizzling.
        /// </summary>
        public long3 zxz => new long3(z, x, z);
        
        /// <summary>
        /// Returns long3.brb swizzling (equivalent to long3.zxz).
        /// </summary>
        public long3 brb => new long3(z, x, z);
        
        /// <summary>
        /// Returns long3.zxzx swizzling.
        /// </summary>
        public long4 zxzx => new long4(z, x, z, x);
        
        /// <summary>
        /// Returns long3.brbr swizzling (equivalent to long3.zxzx).
        /// </summary>
        public long4 brbr => new long4(z, x, z, x);
        
        /// <summary>
        /// Returns long3.zxzy swizzling.
        /// </summary>
        public long4 zxzy => new long4(z, x, z, y);
        
        /// <summary>
        /// Returns long3.brbg swizzling (equivalent to long3.zxzy).
        /// </summary>
        public long4 brbg => new long4(z, x, z, y);
        
        /// <summary>
        /// Returns long3.zxzz swizzling.
        /// </summary>
        public long4 zxzz => new long4(z, x, z, z);
        
        /// <summary>
        /// Returns long3.brbb swizzling (equivalent to long3.zxzz).
        /// </summary>
        public long4 brbb => new long4(z, x, z, z);
        
        /// <summary>
        /// Returns long3.zy swizzling.
        /// </summary>
        public long2 zy => new long2(z, y);
        
        /// <summary>
        /// Returns long3.bg swizzling (equivalent to long3.zy).
        /// </summary>
        public long2 bg => new long2(z, y);
        
        /// <summary>
        /// Returns long3.zyx swizzling.
        /// </summary>
        public long3 zyx => new long3(z, y, x);
        
        /// <summary>
        /// Returns long3.bgr swizzling (equivalent to long3.zyx).
        /// </summary>
        public long3 bgr => new long3(z, y, x);
        
        /// <summary>
        /// Returns long3.zyxx swizzling.
        /// </summary>
        public long4 zyxx => new long4(z, y, x, x);
        
        /// <summary>
        /// Returns long3.bgrr swizzling (equivalent to long3.zyxx).
        /// </summary>
        public long4 bgrr => new long4(z, y, x, x);
        
        /// <summary>
        /// Returns long3.zyxy swizzling.
        /// </summary>
        public long4 zyxy => new long4(z, y, x, y);
        
        /// <summary>
        /// Returns long3.bgrg swizzling (equivalent to long3.zyxy).
        /// </summary>
        public long4 bgrg => new long4(z, y, x, y);
        
        /// <summary>
        /// Returns long3.zyxz swizzling.
        /// </summary>
        public long4 zyxz => new long4(z, y, x, z);
        
        /// <summary>
        /// Returns long3.bgrb swizzling (equivalent to long3.zyxz).
        /// </summary>
        public long4 bgrb => new long4(z, y, x, z);
        
        /// <summary>
        /// Returns long3.zyy swizzling.
        /// </summary>
        public long3 zyy => new long3(z, y, y);
        
        /// <summary>
        /// Returns long3.bgg swizzling (equivalent to long3.zyy).
        /// </summary>
        public long3 bgg => new long3(z, y, y);
        
        /// <summary>
        /// Returns long3.zyyx swizzling.
        /// </summary>
        public long4 zyyx => new long4(z, y, y, x);
        
        /// <summary>
        /// Returns long3.bggr swizzling (equivalent to long3.zyyx).
        /// </summary>
        public long4 bggr => new long4(z, y, y, x);
        
        /// <summary>
        /// Returns long3.zyyy swizzling.
        /// </summary>
        public long4 zyyy => new long4(z, y, y, y);
        
        /// <summary>
        /// Returns long3.bggg swizzling (equivalent to long3.zyyy).
        /// </summary>
        public long4 bggg => new long4(z, y, y, y);
        
        /// <summary>
        /// Returns long3.zyyz swizzling.
        /// </summary>
        public long4 zyyz => new long4(z, y, y, z);
        
        /// <summary>
        /// Returns long3.bggb swizzling (equivalent to long3.zyyz).
        /// </summary>
        public long4 bggb => new long4(z, y, y, z);
        
        /// <summary>
        /// Returns long3.zyz swizzling.
        /// </summary>
        public long3 zyz => new long3(z, y, z);
        
        /// <summary>
        /// Returns long3.bgb swizzling (equivalent to long3.zyz).
        /// </summary>
        public long3 bgb => new long3(z, y, z);
        
        /// <summary>
        /// Returns long3.zyzx swizzling.
        /// </summary>
        public long4 zyzx => new long4(z, y, z, x);
        
        /// <summary>
        /// Returns long3.bgbr swizzling (equivalent to long3.zyzx).
        /// </summary>
        public long4 bgbr => new long4(z, y, z, x);
        
        /// <summary>
        /// Returns long3.zyzy swizzling.
        /// </summary>
        public long4 zyzy => new long4(z, y, z, y);
        
        /// <summary>
        /// Returns long3.bgbg swizzling (equivalent to long3.zyzy).
        /// </summary>
        public long4 bgbg => new long4(z, y, z, y);
        
        /// <summary>
        /// Returns long3.zyzz swizzling.
        /// </summary>
        public long4 zyzz => new long4(z, y, z, z);
        
        /// <summary>
        /// Returns long3.bgbb swizzling (equivalent to long3.zyzz).
        /// </summary>
        public long4 bgbb => new long4(z, y, z, z);
        
        /// <summary>
        /// Returns long3.zz swizzling.
        /// </summary>
        public long2 zz => new long2(z, z);
        
        /// <summary>
        /// Returns long3.bb swizzling (equivalent to long3.zz).
        /// </summary>
        public long2 bb => new long2(z, z);
        
        /// <summary>
        /// Returns long3.zzx swizzling.
        /// </summary>
        public long3 zzx => new long3(z, z, x);
        
        /// <summary>
        /// Returns long3.bbr swizzling (equivalent to long3.zzx).
        /// </summary>
        public long3 bbr => new long3(z, z, x);
        
        /// <summary>
        /// Returns long3.zzxx swizzling.
        /// </summary>
        public long4 zzxx => new long4(z, z, x, x);
        
        /// <summary>
        /// Returns long3.bbrr swizzling (equivalent to long3.zzxx).
        /// </summary>
        public long4 bbrr => new long4(z, z, x, x);
        
        /// <summary>
        /// Returns long3.zzxy swizzling.
        /// </summary>
        public long4 zzxy => new long4(z, z, x, y);
        
        /// <summary>
        /// Returns long3.bbrg swizzling (equivalent to long3.zzxy).
        /// </summary>
        public long4 bbrg => new long4(z, z, x, y);
        
        /// <summary>
        /// Returns long3.zzxz swizzling.
        /// </summary>
        public long4 zzxz => new long4(z, z, x, z);
        
        /// <summary>
        /// Returns long3.bbrb swizzling (equivalent to long3.zzxz).
        /// </summary>
        public long4 bbrb => new long4(z, z, x, z);
        
        /// <summary>
        /// Returns long3.zzy swizzling.
        /// </summary>
        public long3 zzy => new long3(z, z, y);
        
        /// <summary>
        /// Returns long3.bbg swizzling (equivalent to long3.zzy).
        /// </summary>
        public long3 bbg => new long3(z, z, y);
        
        /// <summary>
        /// Returns long3.zzyx swizzling.
        /// </summary>
        public long4 zzyx => new long4(z, z, y, x);
        
        /// <summary>
        /// Returns long3.bbgr swizzling (equivalent to long3.zzyx).
        /// </summary>
        public long4 bbgr => new long4(z, z, y, x);
        
        /// <summary>
        /// Returns long3.zzyy swizzling.
        /// </summary>
        public long4 zzyy => new long4(z, z, y, y);
        
        /// <summary>
        /// Returns long3.bbgg swizzling (equivalent to long3.zzyy).
        /// </summary>
        public long4 bbgg => new long4(z, z, y, y);
        
        /// <summary>
        /// Returns long3.zzyz swizzling.
        /// </summary>
        public long4 zzyz => new long4(z, z, y, z);
        
        /// <summary>
        /// Returns long3.bbgb swizzling (equivalent to long3.zzyz).
        /// </summary>
        public long4 bbgb => new long4(z, z, y, z);
        
        /// <summary>
        /// Returns long3.zzz swizzling.
        /// </summary>
        public long3 zzz => new long3(z, z, z);
        
        /// <summary>
        /// Returns long3.bbb swizzling (equivalent to long3.zzz).
        /// </summary>
        public long3 bbb => new long3(z, z, z);
        
        /// <summary>
        /// Returns long3.zzzx swizzling.
        /// </summary>
        public long4 zzzx => new long4(z, z, z, x);
        
        /// <summary>
        /// Returns long3.bbbr swizzling (equivalent to long3.zzzx).
        /// </summary>
        public long4 bbbr => new long4(z, z, z, x);
        
        /// <summary>
        /// Returns long3.zzzy swizzling.
        /// </summary>
        public long4 zzzy => new long4(z, z, z, y);
        
        /// <summary>
        /// Returns long3.bbbg swizzling (equivalent to long3.zzzy).
        /// </summary>
        public long4 bbbg => new long4(z, z, z, y);
        
        /// <summary>
        /// Returns long3.zzzz swizzling.
        /// </summary>
        public long4 zzzz => new long4(z, z, z, z);
        
        /// <summary>
        /// Returns long3.bbbb swizzling (equivalent to long3.zzzz).
        /// </summary>
        public long4 bbbb => new long4(z, z, z, z);

        #endregion

    }
}
