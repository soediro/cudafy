﻿/*
CUDAfy.NET - LGPL 2.1 License
Please consider purchasing a commerical license - it helps development, frees you from LGPL restrictions
and provides you with support.  Thank you!
Copyright (C) 2011 Hybrid DSP Systems
http://www.hybriddsp.com

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cudafy
{
    /// <summary>
    /// Cudafy equivalent of Cuda dim3.
    /// </summary>
    public class dim3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="dim3"/> class. Y and z will be 1.
        /// </summary>
        /// <param name="x">The x value.</param>
        public dim3(int x)
        {
            this.x = x;
            this.y = 1;
            this.z = 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="dim3"/> class. Z will be 1.
        /// </summary>
        /// <param name="x">The x value.</param>
        /// <param name="y">The y value.</param>
        public dim3(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.z = 1;
        }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="dim3"/> class.
        ///// </summary>
        ///// <param name="x">The x value.</param>
        ///// <param name="y">The y value.</param>
        ///// <param name="z">The z value.</param>
        //public dim3(int x, int y, int z)
        //{
        //    this.x = x;
        //    this.y = y;
        //    this.z = z;
        //}

        /// <summary>
        /// Gets the x.
        /// </summary>
        public int x { get; private set; }
        /// <summary>
        /// Gets the y.
        /// </summary>
        public int y { get; private set; }
        /// <summary>
        /// Gets the z.
        /// </summary>
        public int z { get; private set; }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Int32"/> to <see cref="Cudafy.dim3"/>.
        /// </summary>
        /// <param name="dimX">The dim X.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator dim3(int dimX) { return new dim3(dimX); }
    }
}
