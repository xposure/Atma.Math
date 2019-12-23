namespace Atma.Math
{
    using System;
    using System.Diagnostics;

    /// <summary>
    ///		A 2D box aligned with the x/y axes.
    /// </summary>
    /// <remarks>
    ///		This class represents a simple box which is aligned with the
    ///	    axes. This class is typically used
    ///	    for an axis-aligned bounding box (AABB) for collision and
    ///	    visibility determination.
    /// </remarks>
    public struct AxisAlignedBox2i
    {
        #region Fields

        public int2 Max;
        public int2 Min;

        #endregion Fields

        #region Constructors

        public AxisAlignedBox2i(int x0, int y0, int x1, int y1)
        {
            Min.x = x0;
            Min.y = y0;
            Max.x = x1;
            Max.y = y1;
        }

        public AxisAlignedBox2i(int2 min, int2 max)
        {
            Min = min;
            Max = max;
        }

        public AxisAlignedBox2i(AxisAlignedBox2i box)
        {
            Min = box.Min;
            Max = box.Max;
        }

        #endregion Constructors

        #region Public methods

        public int Height
        {
            get { return Max.y - Min.y; }
        }

        public int Width
        {
            get { return Max.x - Min.x; }
        }

        public int x0 { get { return Min.x; } }

        public int x1 { get { return Max.x; } }

        public int y0 { get { return Min.y; } }

        public int y1 { get { return Max.y; } }

        // /// <summary>
        // ///     Return new bounding box from the supplied dimensions.
        // /// </summary>
        // /// <param name="center">Center of the new box</param>
        // /// <param name="size">Entire size of the new box</param>
        // /// <returns>New bounding box</returns>
        // public static AxisAlignedBox2 FromDimensions(int2 center, int2 size)
        // {
        //     float2 halfSize = .5f * size;

        //     return new AxisAlignedBox2(center - halfSize, center + halfSize);
        // }

        // public static AxisAlignedBox2 FromRect(Rectangle rect)
        // {
        //     var min = new float2(rect.x, rect.y);
        //     var max = new float2(rect.Width, rect.Height) + min;
        //     return new AxisAlignedBox2(min, max);
        // }

        public static AxisAlignedBox2 FromRect(int x, int y, int w, int h)
        {
            var min = new int2(x, y);
            var max = new int2(w, h) + min;
            return new AxisAlignedBox2(min, max);
        }

        public static AxisAlignedBox2 FromRect(int2 min, int w, int h)
        {
            var max = new int2(w, h) + min;
            return new AxisAlignedBox2(min, max);
        }

        public static AxisAlignedBox2 FromRect(int2 min, int2 size)
        {
            return new AxisAlignedBox2(min, min + size);
        }

        public void Inflate(int x, int y)
        {
            var hx = x >> 1;
            var hy = y >> 1;
            Min.x -= hx;
            Min.y -= hy;
            Max.x += hx;
            Max.y += hy;

            if ((x & 1) == 1) Max.x++;
            if ((y & 1) == 1) Max.y++;
        }

        public void Inflate(int2 size)
        {
            Inflate(size.x, size.y);
        }

        /// <summary>
        ///		Allows for merging two boxes together (combining).
        /// </summary>
        /// <param name="box">Source box.</param>
        public void Merge(AxisAlignedBox2i box)
        {
            if (box.Min.x < Min.x)
                Min.x = box.Min.x;
            if (box.Max.x > Max.x)
                Max.x = box.Max.x;

            if (box.Min.y < Min.y)
                Min.y = box.Min.y;
            if (box.Max.y > Max.y)
                Max.y = box.Max.y;

        }

        /// <summary>
        ///		Extends the box to encompass the specified point (if needed).
        /// </summary>
        /// <param name="point"></param>
        public void Merge(int2 point)
        {
            if (point.x > Max.x)
                Max.x = point.x;
            else if (point.x < Min.x)
                Min.x = point.x;

            if (point.y > Max.y)
                Max.y = point.y;
            else if (point.y < Min.y)
                Min.y = point.y;

        }

        /// <summary>
        ///    Scales the size of the box by the supplied factor.
        /// </summary>
        /// <param name="factor">Factor of scaling to apply to the box.</param>
        public void Scale(int2 factor)
        {
            SetExtents(Min * factor, Max * factor);
        }

        /// <summary>
        ///		Sets both Minimum and Maximum at once, so that UpdateCorners only
        ///		needs to be called once as well.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void SetExtents(int2 min, int2 max)
        {
            Min = min;
            Max = max;

        }

        public void Offset(int2 offset)
        {
            Min += offset;
            Max += offset;
        }

        #endregion Public methods

        #region Contain methods

        /// <summary>
        /// Tests whether the given point contained by this box.
        /// </summary>
        /// <param name="v"></param>
        /// <returns>True if the vector is contained inside the box.</returns>
        public bool Contains(int2 v)
        {
            return Min.x <= v.x && v.x <= Max.x &&
                      Min.y <= v.y && v.y <= Max.y;
        }

        public bool Contains(AxisAlignedBox2i box)
        {
            return Contains(box.Min) && Contains(box.Max);
        }

        #endregion Contain methods

        #region Intersection Methods


        /// <summary>
        ///		Calculate the area of intersection of this box and another
        /// </summary>
        public bool Intersection(AxisAlignedBox2i b2, out AxisAlignedBox2i intersection)
        {
            if (!Intersects(b2))
            {
                intersection = new AxisAlignedBox2i(int2.Zero, int2.Zero);
                return false;
            }

            int2 intMin = int2.Zero;
            int2 intMax = int2.Zero;

            int2 b2max = b2.Max;
            int2 b2min = b2.Min;

            if (b2max.x > Max.x && Max.x > b2min.x)
                intMax.x = Max.x;
            else
                intMax.x = b2max.x;
            if (b2max.y > Max.y && Max.y > b2min.y)
                intMax.y = Max.y;
            else
                intMax.y = b2max.y;

            if (b2min.x < Min.x && Min.x < b2max.x)
                intMin.x = Min.x;
            else
                intMin.x = b2min.x;
            if (b2min.y < Min.y && Min.y < b2max.y)
                intMin.y = Min.y;
            else
                intMin.y = b2min.y;

            intersection = new AxisAlignedBox2i(intMin, intMax);
            return true;
        }

        /// <summary>
        ///		Returns whether or not this box intersects another.
        /// </summary>
        /// <param name="box2"></param>
        /// <returns>True if the 2 boxes intersect, false otherwise.</returns>
        public bool Intersects(AxisAlignedBox2i box2)
        {
            // Use up to 6 separating planes
            if (this.Max.x <= box2.Min.x)
                return false;
            if (this.Max.y <= box2.Min.y)
                return false;

            if (this.Min.x >= box2.Max.x)
                return false;
            if (this.Min.y >= box2.Max.y)
                return false;

            // otherwise, must be intersecting
            return true;
        }

        /// <summary>
        ///		Returns whether or not this box intersects another.
        /// </summary>
        /// <param name="box2"></param>
        /// <returns>True if the 2 boxes intersect, false otherwise.</returns>
        public bool Intersects(ReadOnlySpan<AxisAlignedBox2i> boxes, out int index)
        {
            index = -1;
            for (var i = 0; i < boxes.Length; i++)
            {
                ref readonly var box2 = ref boxes[i];
                // Use up to 6 separating planes
                if (this.Max.x <= box2.Min.x)
                    return false;
                if (this.Max.y <= box2.Min.y)
                    return false;

                if (this.Min.x >= box2.Max.x)
                    return false;
                if (this.Min.y >= box2.Max.y)
                    return false;

                // otherwise, must be intersecting
                index = i;
                return true;
            }
            return false;
        }

        // public bool Intersects(Circle circle)
        // {
        //     return Intersects(circle.Center) ||
        //         circle.Intersects(corners[0]) ||
        //         circle.Intersects(corners[1]) ||
        //         circle.Intersects(corners[2]) ||
        //         circle.Intersects(corners[3]);
        // }

        /// <summary>
        ///		Tests whether this box intersects a sphere.
        /// </summary>
        /// <param name="sphere"></param>
        /// <returns>True if the sphere intersects, false otherwise.</returns>
        //public bool Intersects(Sphere sphere)
        //{
        //    return Utility.Intersects(sphere, this);
        //}

        /// <summary>
        ///
        /// </summary>
        /// <param name="plane"></param>
        /// <returns>True if the plane intersects, false otherwise.</returns>
        //public bool Intersects(Plane plane)
        //{
        //    return Utility.Intersects(plane, this);
        //}

        /// <summary>
        ///		Tests whether the vector point is within this box.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns>True if the vector is within this box, false otherwise.</returns>
        public bool Intersects(int2 vector)
        {
            return (vector.x >= Min.x && vector.x <= Max.x &&
                vector.y >= Min.y && vector.y <= Max.y);
        }

        #endregion Intersection Methods

        #region Properties

        /// <summary>
        ///    Get/set the center point of this bounding box.
        /// </summary>
        // public int2 Center
        // {
        //     get
        //     {
        //         return (Min + Max) * 0.5f;
        //     }
        //     set
        //     {
        //         int2 halfSize = .5f * Size;
        //         Min = value - halfSize;
        //         Max = value + halfSize;
        //     }
        // }

        // public int2 HalfSize
        // {
        //     get
        //     {
        //         return (Max - Min) * 0.5f;
        //     }
        // }

        /// <summary>
        ///     Get/set the size of this bounding box.
        /// </summary>
        public int2 Size
        {
            get
            {
                return Max - Min;
            }
            // set
            // {
            //     float2 center = Center;
            //     float2 halfSize = .5f * value;
            //     Min = center - halfSize;
            //     Max = center + halfSize;
            // }
        }

        /// <summary>
        ///     Calculate the volume of this box
        /// </summary>
        public float Volume
        {
            get
            {
                float2 diff = Max - Min;
                return diff.x * diff.y;
            }
        }

        #endregion Properties

        #region Operator Overloads

        public static bool operator !=(AxisAlignedBox2i left, AxisAlignedBox2i right)
        {
            return left.Min != right.Min || left.Max != right.Max;
        }

        public static bool operator ==(AxisAlignedBox2i left, AxisAlignedBox2i right)
        {
            return left.Min == right.Min && left.Max == right.Max;
        }

        public override bool Equals(object obj)
        {
            return obj is AxisAlignedBox2i && this == (AxisAlignedBox2i)obj;
        }

        public unsafe override int GetHashCode()
        {
            return (Min.GetHashCode() * 397) + Max.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}", this.Min, this.Max);
        }

        #endregion Operator Overloads
    }
}