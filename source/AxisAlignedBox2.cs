#region LGPL License

/*
Axiom Graphics Engine Library
Copyright © 2003-2011 Axiom Project Team

The overall design, and a majority of the core engine and rendering code
contained within this library is a derivative of the open source Object Oriented
Graphics Engine OGRE, which can be found at http://ogre.sourceforge.net.
Many thanks to the OGRE team for maintaining such a high quality project.

The math library included in this project, in addition to being a derivative of
the works of Ogre, also include derivative work of the free portion of the
Wild Magic mathematics source code that is distributed with the excellent
book Game Engine Design.
http://www.wild-magic.com/

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
*/

#endregion LGPL License

#region SVN Version Information

// <file>
//     <license see="http://axiom3d.net/wiki/index.php/license.txt"/>
//     <id value="$Id: AxisAlignedBox.cs 2353 2010-12-30 03:50:52Z borrillis $"/>
// </file>

#endregion SVN Version Information

#region Namespace Declarations

using System;
using System.Diagnostics;

#endregion Namespace Declarations

namespace Atma.Math
{
    /// <summary>
    ///		A 3D box aligned with the x/y/z axes.
    /// </summary>
    /// <remarks>
    ///		This class represents a simple box which is aligned with the
    ///	    axes. It stores 2 points as the extremeties of
    ///	    the box, one which is the minima of all 3 axes, and the other
    ///	    which is the maxima of all 3 axes. This class is typically used
    ///	    for an axis-aligned bounding box (AABB) for collision and
    ///	    visibility determination.
    /// </remarks>
    public struct AxisAlignedBox2 : ICloneable
    {
        #region Fields

        public float2 Max;
        public float2 Min;
        //private float2[] corners;
        //private bool isInfinite => float2.IsInfinity(m_minVector) || float2.IsInfinity(m_maxVector);
        //private bool isNull;

        #endregion Fields

        #region Constructors

        public AxisAlignedBox2(float x0, float y0, float x1, float y1)
        {
            //corners = new float2[4];
            Min.x = x0;
            Min.y = y0;
            Max.x = x1;
            Max.y = y1;
            //isNull = false;
            //isInfinite = false;
            //UpdateCorners();
        }

        public AxisAlignedBox2(float2 min, float2 max)
        {
            //corners = new float2[4];
            Min = min;
            Max = max;
            //isNull = false;
            //isInfinite = false;
            //UpdateCorners();
        }

        public AxisAlignedBox2(AxisAlignedBox2 box)
        {
            //corners = new float2[4];
            Min = box.Min;
            Max = box.Max;
            //isNull = box.IsNull;
            //isInfinite = box.IsInfinite;
            //UpdateCorners();
        }

        #endregion Constructors

        #region Public methods

        public float Height
        {
            get { return Max.y - Min.y; }
        }

        public float Width
        {
            get { return Max.x - Min.x; }
        }

        public float x0 { get { return Min.x; } }

        public float x1 { get { return Max.x; } }

        public float y0 { get { return Min.y; } }

        public float y1 { get { return Max.y; } }

        /// <summary>
        ///     Return new bounding box from the supplied dimensions.
        /// </summary>
        /// <param name="center">Center of the new box</param>
        /// <param name="size">Entire size of the new box</param>
        /// <returns>New bounding box</returns>
        public static AxisAlignedBox2 FromDimensions(float2 center, float2 size)
        {
            float2 halfSize = .5f * size;

            return new AxisAlignedBox2(center - halfSize, center + halfSize);
        }

        // public static AxisAlignedBox2 FromRect(Rectangle rect)
        // {
        //     var min = new float2(rect.x, rect.y);
        //     var max = new float2(rect.Width, rect.Height) + min;
        //     return new AxisAlignedBox2(min, max);
        // }

        public static AxisAlignedBox2 FromRect(float x, float y, float w, float h)
        {
            var min = new float2(x, y);
            var max = new float2(w, h) + min;
            return new AxisAlignedBox2(min, max);
        }

        public static AxisAlignedBox2 FromRect(float2 min, float w, float h)
        {
            var max = new float2(w, h) + min;
            return new AxisAlignedBox2(min, max);
        }

        public static AxisAlignedBox2 FromRect(float2 min, float2 size)
        {
            return new AxisAlignedBox2(min, min + size);
        }

        public void Inflate(float x, float y)
        {
            var hx = x / 2f;
            var hy = y / 2f;
            Min.x -= hx;
            Min.y -= hy;
            Max.x += hx;
            Max.y += hy;
            //UpdateCorners();
        }

        public void Inflate(float2 size)
        {
            Inflate(size.x, size.y);
        }

        /// <summary>
        ///		Allows for merging two boxes together (combining).
        /// </summary>
        /// <param name="box">Source box.</param>
        public void Merge(AxisAlignedBox2 box)
        {
            // if (box.IsNull)
            // {
            //     // nothing to merge with in this case, just return
            //     return;
            // }
            // else if (box.IsInfinite)
            // {
            //     this.IsInfinite = true;
            // }
            // else if (this.IsNull)
            // {
            //     SetExtents(box.Minimum, box.Maximum);
            // }
            // else if (!this.IsInfinite)
            // {
            if (box.Min.x < Min.x)
                Min.x = box.Min.x;
            if (box.Max.x > Max.x)
                Max.x = box.Max.x;

            if (box.Min.y < Min.y)
                Min.y = box.Min.y;
            if (box.Max.y > Max.y)
                Max.y = box.Max.y;

            //UpdateCorners();
            //}
        }

        /// <summary>
        ///		Extends the box to encompass the specified point (if needed).
        /// </summary>
        /// <param name="point"></param>
        public void Merge(float2 point)
        {
            // if (isNull || isInfinite)
            // {
            //     // if null, use this point
            //     SetExtents(point, point);
            // }
            // else
            // {
            if (point.x > Max.x)
                Max.x = point.x;
            else if (point.x < Min.x)
                Min.x = point.x;

            if (point.y > Max.y)
                Max.y = point.y;
            else if (point.y < Min.y)
                Min.y = point.y;

            //UpdateCorners();
            //}
        }

        /// <summary>
        ///    Scales the size of the box by the supplied factor.
        /// </summary>
        /// <param name="factor">Factor of scaling to apply to the box.</param>
        public void Scale(float2 factor)
        {
            SetExtents(Min * factor, Max * factor);
        }

        /// <summary>
        ///		Sets both Minimum and Maximum at once, so that UpdateCorners only
        ///		needs to be called once as well.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void SetExtents(float2 min, float2 max)
        {
            // isNull = false;
            // isInfinite = false;

            Min = min;
            Max = max;

            //UpdateCorners();
        }

        public void UpdateCorners(float2 minVector, float2 maxVector)
        {
            Min = minVector;
            Max = maxVector;
            //UpdateCorners();
        }

        // /// <summary>
        // ///
        // /// </summary>
        // internal void UpdateCorners()
        // {
        //     // The order of these items is, using right-handed co-ordinates:
        //     // Minimum Z face, starting with Min(all), then anticlockwise
        //     //   around face (looking onto the face)
        //     // Maximum Z face, starting with Max(all), then anticlockwise
        //     //   around face (looking onto the face)
        //     corners[0] = m_minVector;
        //     corners[1].x = m_minVector.x;
        //     corners[1].y = m_maxVector.y;
        //     corners[2].x = m_maxVector.x;
        //     corners[2].y = m_maxVector.y;
        //     corners[3].x = m_maxVector.x;
        //     corners[3].y = m_minVector.y;

        //     //corners[4] = m_maxVector;
        //     //corners[5].x= m_minVector.x;
        //     //corners[5].y= m_maxVector.y;
        //     //corners[6].x= m_minVector.x;
        //     //corners[6].y= m_minVector.y;
        //     //corners[7].x= m_maxVector.x;
        //     //corners[7].y= m_minVector.y;
        // }

        #endregion Public methods

        #region Contain methods

        /// <summary>
        /// Tests whether the given point contained by this box.
        /// </summary>
        /// <param name="v"></param>
        /// <returns>True if the vector is contained inside the box.</returns>
        public bool Contains(float2 v)
        {
            // if (IsNull)
            //     return false;
            // if (IsInfinite)
            //     return true;

            return Minimum.x <= v.x && v.x <= Maximum.x &&
                      Minimum.y <= v.y && v.y <= Maximum.y;
        }

        public bool Contains(AxisAlignedBox2 box)
        {
            return Contains(box.Min) && Contains(box.Max);
        }

        #endregion Contain methods

        #region Intersection Methods

        public MinimumTranslationVector collide(AxisAlignedBox2 box2)
        {
            if (Intersection(box2, out var overlap))
            {
                var axis = new Axis();
                var minOverlap = 0.0;
                var adjust = overlap.Size;

                if (adjust.x < adjust.y)
                {
                    minOverlap = adjust.x;
                    if (overlap.Center.x < box2.Center.x)
                        axis.edge = new float2(overlap.x0, overlap.y0) - new float2(overlap.x0, overlap.y1);
                    else
                        axis.edge = new float2(overlap.x1, overlap.y1) - new float2(overlap.x1, overlap.y0);
                }
                else
                {
                    minOverlap = adjust.y;
                    if (overlap.Center.y > box2.Center.y)
                        axis.edge = new float2(overlap.x0, overlap.y0) - new float2(overlap.x1, overlap.y0);
                    else
                        axis.edge = new float2(overlap.x1, overlap.y1) - new float2(overlap.x0, overlap.y1);
                }

                axis.unit = axis.edge.Perpendicular;
                //axis.unit = axis.edge.PerpendicularRight;
                axis.normal = axis.unit.Normalized;
                return new MinimumTranslationVector(axis, minOverlap);
            }
            return MinimumTranslationVector.Zero;
        }

        public MinimumTranslationVector collideX(AxisAlignedBox2 box2)
        {
            //var overlap = Intersection(box2);
            if (Intersection(box2, out var overlap))
            {
                var axis = new Axis();
                var minOverlap = 0.0;
                var adjust = overlap.Size;

                minOverlap = adjust.x;
                if (overlap.Center.x < box2.Center.x)
                    axis.edge = new float2(overlap.x0, overlap.y0) - new float2(overlap.x0, overlap.y1);
                else
                    axis.edge = new float2(overlap.x1, overlap.y1) - new float2(overlap.x1, overlap.y0);

                //axis.unit = axis.edge.PerpendicularRight;
                axis.unit = axis.edge.Perpendicular;
                axis.normal = axis.unit.Normalized;
                return new MinimumTranslationVector(axis, minOverlap);
            }
            return MinimumTranslationVector.Zero;
        }

        public MinimumTranslationVector collideY(AxisAlignedBox2 box2)
        {
            //var overlap = Intersection(box2);
            if (Intersection(box2, out var overlap))
            {
                var axis = new Axis();
                var minOverlap = 0.0;
                var adjust = overlap.Size;

                minOverlap = adjust.y;
                if (overlap.Center.y > box2.Center.y)
                    axis.edge = new float2(overlap.x0, overlap.y0) - new float2(overlap.x1, overlap.y0);
                else
                    axis.edge = new float2(overlap.x1, overlap.y1) - new float2(overlap.x0, overlap.y1);

                //axis.unit = axis.edge.PerpendicularRight;
                axis.unit = axis.edge.Perpendicular;
                axis.normal = axis.unit.Normalized;
                return new MinimumTranslationVector(axis, minOverlap);
            }
            return MinimumTranslationVector.Zero;
        }

        /// <summary>
        ///		Calculate the area of intersection of this box and another
        /// </summary>
        public bool Intersection(AxisAlignedBox2 b2, out AxisAlignedBox2 intersection)
        {
            if (!Intersects(b2))
            {
                intersection = new AxisAlignedBox2(float2.Zero, float2.Zero);
                return false;
            }

            float2 intMin = float2.Zero;
            float2 intMax = float2.Zero;

            float2 b2max = b2.Max;
            float2 b2min = b2.Min;

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

            intersection = new AxisAlignedBox2(intMin, intMax);
            return true;
        }

        /// <summary>
        ///		Returns whether or not this box intersects another.
        /// </summary>
        /// <param name="box2"></param>
        /// <returns>True if the 2 boxes intersect, false otherwise.</returns>
        public bool Intersects(AxisAlignedBox2 box2)
        {
            // // Early-fail for nulls
            // if (this.IsNull || box2.IsNull)
            //     return false;

            // if (this.IsInfinite || box2.IsInfinite)
            //     return true;

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
        public bool Intersects(float2 vector)
        {
            return (vector.x >= Min.x && vector.x <= Max.x &&
                vector.y >= Min.y && vector.y <= Max.y);
        }

        #endregion Intersection Methods

        #region Properties

        public float2 maxVector
        {
            get { return Max; }
            set
            {
                Max = value;
                //UpdateCorners();
            }
        }

        public float2 minVector
        {
            get { return Min; }
            set
            {
                Min = value;
                //UpdateCorners();
            }
        }

        // /// <summary>
        // ///		Returns a null box
        // /// </summary>
        // public static AxisAlignedBox2 Null
        // {
        //     get
        //     {
        //         AxisAlignedBox2 nullBox = new AxisAlignedBox2(new float2(-0.5f, -0.5f), new float2(0.5f, 0.5f));
        //         // nullBox.IsNull = true;
        //         // nullBox.isInfinite = false;
        //         return nullBox;
        //     }
        // }

        /// <summary>
        ///    Get/set the center point of this bounding box.
        /// </summary>
        public float2 Center
        {
            get
            {
                return (Min + Max) * 0.5f;
            }
            set
            {
                float2 halfSize = .5f * Size;
                Min = value - halfSize;
                Max = value + halfSize;
                //UpdateCorners();
            }
        }

        // /// <summary>
        // ///		Returns an array of 8 corner points, useful for
        // ///		collision vs. non-aligned objects.
        // /// </summary>
        // /// <remarks>
        // ///		If the order of these corners is important, they are as
        // ///		follows: The 4 points of the minimum Z face (note that
        // ///		because we use right-handed coordinates, the minimum Z is
        // ///		at the 'back' of the box) starting with the minimum point of
        // ///		all, then anticlockwise around this face (if you are looking
        // ///		onto the face from outside the box). Then the 4 points of the
        // ///		maximum Z face, starting with maximum point of all, then
        // ///		anticlockwise around this face (looking onto the face from
        // ///		outside the box). Like this:
        // ///		<pre>
        // ///		      -z
        // ///		   1-----2
        // ///		  /|+y  /|
        // ///		 / |   / | +x
        // ///		5-----4  |
        // ///	 -x	|  0--|--3
        // ///		| /   | /
        // ///		|/ -y |/
        // ///		6-----7
        // ///		   +z
        // ///		</pre>
        // /// </remarks>
        // public float2[] Corners
        // {
        //     get
        //     {
        //         Debug.Assert(!isNull && !isInfinite, "Cannot get the corners of a null or infinite box.");

        //         return corners;
        //     }
        // }

        public float2 HalfSize
        {
            get
            {
                // if (isNull)
                //     return float2.Zero;

                // if (isInfinite)
                //     return new float2(float.PositiveInfinity, float.PositiveInfinity);

                return (Maximum - Minimum) * 0.5f;
            }
        }

        // /// <summary>
        // /// Returns true if the box is infinite.
        // /// </summary>
        // public bool IsInfinite
        // {
        //     get
        //     {
        //         return isInfinite;
        //     }
        //     set
        //     {
        //         isInfinite = value;
        //         if (value)
        //             isNull = false;
        //     }
        // }

        // /// <summary>
        // ///		Get/set the value of whether this box is null (i.e. not dimensions, etc).
        // /// </summary>
        // public bool IsNull
        // {
        //     get
        //     {
        //         return isNull;
        //     }
        //     set
        //     {
        //         isNull = value;
        //         if (value)
        //             isInfinite = false;
        //     }
        // }

        /// <summary>
        ///		Get/set the maximum corner of the box.
        /// </summary>
        public float2 Maximum
        {
            get
            {
                return Max;
            }
            set
            {
                //isNull = false;
                Max = value;
                //UpdateCorners();
            }
        }

        /// <summary>
        ///		Get/set the minimum corner of the box.
        /// </summary>
        public float2 Minimum
        {
            get
            {
                return Min;
            }
            set
            {
                //isNull = false;
                Min = value;
                //UpdateCorners();
            }
        }

        /// <summary>
        ///     Get/set the size of this bounding box.
        /// </summary>
        public float2 Size
        {
            get
            {
                return Max - Min;
            }
            set
            {
                float2 center = Center;
                float2 halfSize = .5f * value;
                Min = center - halfSize;
                Max = center + halfSize;
                //UpdateCorners();
            }
        }

        /// <summary>
        ///     Calculate the volume of this box
        /// </summary>
        public float Volume
        {
            get
            {
                // if (isNull)
                //     return 0.0f;

                // if (isInfinite)
                //     return float.PositiveInfinity;

                float2 diff = Maximum - Minimum;
                return diff.x * diff.y;
            }
        }

        #endregion Properties

        #region Operator Overloads

        public static bool operator !=(AxisAlignedBox2 left, AxisAlignedBox2 right)
        {
            //if ((object.ReferenceEquals(left, null) || left.isNull) &&
            //    (object.ReferenceEquals(right, null) || right.isNull))
            //    return false;

            //else if ((object.ReferenceEquals(left, null) || left.isNull) ||
            //         (object.ReferenceEquals(right, null) || right.isNull))
            //    return true;

            return left.Min != right.Min || left.Max != right.Max;
            //return
            //    (left.corners[0] != right.corners[0] || left.corners[1] != right.corners[1] || left.corners[2] != right.corners[2] ||
            //    left.corners[3] != right.corners[3] || left.corners[4] != right.corners[4] || left.corners[5] != right.corners[5] ||
            //    left.corners[6] != right.corners[6] || left.corners[7] != right.corners[7]);
        }

        public static bool operator ==(AxisAlignedBox2 left, AxisAlignedBox2 right)
        {
            //if ((object.ReferenceEquals(left, null) || left.isNull) &&
            //    (object.ReferenceEquals(right, null) || right.isNull))
            //    return true;

            //else if ((object.ReferenceEquals(left, null) || left.isNull) ||
            //         (object.ReferenceEquals(right, null) || right.isNull))
            //    return false;

            return left.Min == right.Min && left.Max == right.Max;
            //(left.corners[0] == right.corners[0] && left.corners[1] == right.corners[1] && left.corners[2] == right.corners[2] &&
            //left.corners[3] == right.corners[3] && left.corners[4] == right.corners[4] && left.corners[5] == right.corners[5] &&
            //left.corners[6] == right.corners[6] && left.corners[7] == right.corners[7]);
        }

        public override bool Equals(object obj)
        {
            return obj is AxisAlignedBox2 && this == (AxisAlignedBox2)obj;
        }

        public unsafe override int GetHashCode()
        {
            // if (isNull)
            //     return 0;

            return (Min.GetHashCode() * 7) ^ Max.GetHashCode();
            //return corners[0].GetHashCode() ^ corners[1].GetHashCode() ^ corners[2].GetHashCode() ^ corners[3].GetHashCode();// ^
            //corners[4].GetHashCode() ^ corners[5].GetHashCode() ^ corners[6].GetHashCode() ^ corners[7].GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}", this.Min, this.Max);
        }

        #endregion Operator Overloads

        #region ICloneable Members

        public object Clone()
        {
            return new AxisAlignedBox2(this);
        }

        #endregion ICloneable Members

        // public AxisAlignedBox2[] fromRectOffset(RectOffset offset)
        // {
        //     var inner = new AxisAlignedBox2(m_minVector + offset.min, m_maxVector - offset.max);

        //     var rects = new AxisAlignedBox2[9];

        //     rects[0] = new AxisAlignedBox2(corners[0], inner.corners[0]);
        //     rects[2] = new AxisAlignedBox2(Utility.Min(corners[1], inner.corners[1]), Utility.Max(corners[1], inner.corners[1]));
        //     rects[6] = new AxisAlignedBox2(Utility.Min(corners[3], inner.corners[3]), Utility.Max(corners[3], inner.corners[3]));
        //     rects[8] = new AxisAlignedBox2(inner.corners[2], corners[2]);

        //     rects[1] = new AxisAlignedBox2(rects[0].corners[1], inner.corners[1]);
        //     rects[3] = new AxisAlignedBox2(rects[0].corners[3], inner.corners[3]);
        //     rects[4] = inner;
        //     rects[5] = new AxisAlignedBox2(rects[2].corners[3], rects[8].corners[1]);
        //     rects[7] = new AxisAlignedBox2(rects[6].corners[1], rects[8].corners[3]);
        //     return rects;
        // }



        //public void RotateAndContain(float2 pivot, float r)
        //{
        //    if (!isNull && !isInfinite && r != 0)
        //    {
        //        var rotatedCorners = this.ToOBB(pivot, r);
        //        var center = (rotatedCorners[0] + rotatedCorners[1] + rotatedCorners[2] + rotatedCorners[3]) / 4f;
        //        this.m_minVector = center;
        //        this.m_maxVector = center;
        ////        UpdateCorners();

        //        this.Merge(rotatedCorners[0]);
        //        this.Merge(rotatedCorners[1]);
        //        this.Merge(rotatedCorners[2]);
        //        this.Merge(rotatedCorners[3]);
        //    }
        //}

        // public Rectangle ToRect()
        // {
        //     return new Rectangle((int)minVector.x, (int)minVector.y, (int)Width, (int)Height);
        // }

        //public float2[] ToOBB(float2 pivot, float r)
        //{
        //    if (!isNull && !isInfinite && r != 0)
        //    {
        //        var rotatedCorners = new float2[4];
        //        for (var i = 0; i < corners.Length; i++)
        //        {
        //            rotatedCorners[i] = corners[i].Rotate(pivot, r);
        //        }
        //        return rotatedCorners;
        //    }
        //    return corners;
        //}

        //public Rectangle ToRect()
        //{
        //    if (IsNull)
        //        throw new NullReferenceException();

        //    return new Rectangle((int)m_minVector.x, (int)m_minVector.y, (int)(m_maxVector.x- m_minVector.x), (int)(m_maxVector.y- m_minVector.y));
        //}
    }
}