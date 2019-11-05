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
    /// Temporary vector of type long with 2 components, used for implementing swizzling for long2.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_long2
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_long2.
        /// </summary>
        internal swizzle_long2(long x, long y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns long2.xx swizzling.
        /// </summary>
        public long2 xx => new long2(x, x);
        
        /// <summary>
        /// Returns long2.rr swizzling (equivalent to long2.xx).
        /// </summary>
        public long2 rr => new long2(x, x);
        
        /// <summary>
        /// Returns long2.xxx swizzling.
        /// </summary>
        public long3 xxx => new long3(x, x, x);
        
        /// <summary>
        /// Returns long2.rrr swizzling (equivalent to long2.xxx).
        /// </summary>
        public long3 rrr => new long3(x, x, x);
        
        /// <summary>
        /// Returns long2.xxxx swizzling.
        /// </summary>
        public long4 xxxx => new long4(x, x, x, x);
        
        /// <summary>
        /// Returns long2.rrrr swizzling (equivalent to long2.xxxx).
        /// </summary>
        public long4 rrrr => new long4(x, x, x, x);
        
        /// <summary>
        /// Returns long2.xxxy swizzling.
        /// </summary>
        public long4 xxxy => new long4(x, x, x, y);
        
        /// <summary>
        /// Returns long2.rrrg swizzling (equivalent to long2.xxxy).
        /// </summary>
        public long4 rrrg => new long4(x, x, x, y);
        
        /// <summary>
        /// Returns long2.xxy swizzling.
        /// </summary>
        public long3 xxy => new long3(x, x, y);
        
        /// <summary>
        /// Returns long2.rrg swizzling (equivalent to long2.xxy).
        /// </summary>
        public long3 rrg => new long3(x, x, y);
        
        /// <summary>
        /// Returns long2.xxyx swizzling.
        /// </summary>
        public long4 xxyx => new long4(x, x, y, x);
        
        /// <summary>
        /// Returns long2.rrgr swizzling (equivalent to long2.xxyx).
        /// </summary>
        public long4 rrgr => new long4(x, x, y, x);
        
        /// <summary>
        /// Returns long2.xxyy swizzling.
        /// </summary>
        public long4 xxyy => new long4(x, x, y, y);
        
        /// <summary>
        /// Returns long2.rrgg swizzling (equivalent to long2.xxyy).
        /// </summary>
        public long4 rrgg => new long4(x, x, y, y);
        
        /// <summary>
        /// Returns long2.xy swizzling.
        /// </summary>
        public long2 xy => new long2(x, y);
        
        /// <summary>
        /// Returns long2.rg swizzling (equivalent to long2.xy).
        /// </summary>
        public long2 rg => new long2(x, y);
        
        /// <summary>
        /// Returns long2.xyx swizzling.
        /// </summary>
        public long3 xyx => new long3(x, y, x);
        
        /// <summary>
        /// Returns long2.rgr swizzling (equivalent to long2.xyx).
        /// </summary>
        public long3 rgr => new long3(x, y, x);
        
        /// <summary>
        /// Returns long2.xyxx swizzling.
        /// </summary>
        public long4 xyxx => new long4(x, y, x, x);
        
        /// <summary>
        /// Returns long2.rgrr swizzling (equivalent to long2.xyxx).
        /// </summary>
        public long4 rgrr => new long4(x, y, x, x);
        
        /// <summary>
        /// Returns long2.xyxy swizzling.
        /// </summary>
        public long4 xyxy => new long4(x, y, x, y);
        
        /// <summary>
        /// Returns long2.rgrg swizzling (equivalent to long2.xyxy).
        /// </summary>
        public long4 rgrg => new long4(x, y, x, y);
        
        /// <summary>
        /// Returns long2.xyy swizzling.
        /// </summary>
        public long3 xyy => new long3(x, y, y);
        
        /// <summary>
        /// Returns long2.rgg swizzling (equivalent to long2.xyy).
        /// </summary>
        public long3 rgg => new long3(x, y, y);
        
        /// <summary>
        /// Returns long2.xyyx swizzling.
        /// </summary>
        public long4 xyyx => new long4(x, y, y, x);
        
        /// <summary>
        /// Returns long2.rggr swizzling (equivalent to long2.xyyx).
        /// </summary>
        public long4 rggr => new long4(x, y, y, x);
        
        /// <summary>
        /// Returns long2.xyyy swizzling.
        /// </summary>
        public long4 xyyy => new long4(x, y, y, y);
        
        /// <summary>
        /// Returns long2.rggg swizzling (equivalent to long2.xyyy).
        /// </summary>
        public long4 rggg => new long4(x, y, y, y);
        
        /// <summary>
        /// Returns long2.yx swizzling.
        /// </summary>
        public long2 yx => new long2(y, x);
        
        /// <summary>
        /// Returns long2.gr swizzling (equivalent to long2.yx).
        /// </summary>
        public long2 gr => new long2(y, x);
        
        /// <summary>
        /// Returns long2.yxx swizzling.
        /// </summary>
        public long3 yxx => new long3(y, x, x);
        
        /// <summary>
        /// Returns long2.grr swizzling (equivalent to long2.yxx).
        /// </summary>
        public long3 grr => new long3(y, x, x);
        
        /// <summary>
        /// Returns long2.yxxx swizzling.
        /// </summary>
        public long4 yxxx => new long4(y, x, x, x);
        
        /// <summary>
        /// Returns long2.grrr swizzling (equivalent to long2.yxxx).
        /// </summary>
        public long4 grrr => new long4(y, x, x, x);
        
        /// <summary>
        /// Returns long2.yxxy swizzling.
        /// </summary>
        public long4 yxxy => new long4(y, x, x, y);
        
        /// <summary>
        /// Returns long2.grrg swizzling (equivalent to long2.yxxy).
        /// </summary>
        public long4 grrg => new long4(y, x, x, y);
        
        /// <summary>
        /// Returns long2.yxy swizzling.
        /// </summary>
        public long3 yxy => new long3(y, x, y);
        
        /// <summary>
        /// Returns long2.grg swizzling (equivalent to long2.yxy).
        /// </summary>
        public long3 grg => new long3(y, x, y);
        
        /// <summary>
        /// Returns long2.yxyx swizzling.
        /// </summary>
        public long4 yxyx => new long4(y, x, y, x);
        
        /// <summary>
        /// Returns long2.grgr swizzling (equivalent to long2.yxyx).
        /// </summary>
        public long4 grgr => new long4(y, x, y, x);
        
        /// <summary>
        /// Returns long2.yxyy swizzling.
        /// </summary>
        public long4 yxyy => new long4(y, x, y, y);
        
        /// <summary>
        /// Returns long2.grgg swizzling (equivalent to long2.yxyy).
        /// </summary>
        public long4 grgg => new long4(y, x, y, y);
        
        /// <summary>
        /// Returns long2.yy swizzling.
        /// </summary>
        public long2 yy => new long2(y, y);
        
        /// <summary>
        /// Returns long2.gg swizzling (equivalent to long2.yy).
        /// </summary>
        public long2 gg => new long2(y, y);
        
        /// <summary>
        /// Returns long2.yyx swizzling.
        /// </summary>
        public long3 yyx => new long3(y, y, x);
        
        /// <summary>
        /// Returns long2.ggr swizzling (equivalent to long2.yyx).
        /// </summary>
        public long3 ggr => new long3(y, y, x);
        
        /// <summary>
        /// Returns long2.yyxx swizzling.
        /// </summary>
        public long4 yyxx => new long4(y, y, x, x);
        
        /// <summary>
        /// Returns long2.ggrr swizzling (equivalent to long2.yyxx).
        /// </summary>
        public long4 ggrr => new long4(y, y, x, x);
        
        /// <summary>
        /// Returns long2.yyxy swizzling.
        /// </summary>
        public long4 yyxy => new long4(y, y, x, y);
        
        /// <summary>
        /// Returns long2.ggrg swizzling (equivalent to long2.yyxy).
        /// </summary>
        public long4 ggrg => new long4(y, y, x, y);
        
        /// <summary>
        /// Returns long2.yyy swizzling.
        /// </summary>
        public long3 yyy => new long3(y, y, y);
        
        /// <summary>
        /// Returns long2.ggg swizzling (equivalent to long2.yyy).
        /// </summary>
        public long3 ggg => new long3(y, y, y);
        
        /// <summary>
        /// Returns long2.yyyx swizzling.
        /// </summary>
        public long4 yyyx => new long4(y, y, y, x);
        
        /// <summary>
        /// Returns long2.gggr swizzling (equivalent to long2.yyyx).
        /// </summary>
        public long4 gggr => new long4(y, y, y, x);
        
        /// <summary>
        /// Returns long2.yyyy swizzling.
        /// </summary>
        public long4 yyyy => new long4(y, y, y, y);
        
        /// <summary>
        /// Returns long2.gggg swizzling (equivalent to long2.yyyy).
        /// </summary>
        public long4 gggg => new long4(y, y, y, y);

        #endregion

    }
}
