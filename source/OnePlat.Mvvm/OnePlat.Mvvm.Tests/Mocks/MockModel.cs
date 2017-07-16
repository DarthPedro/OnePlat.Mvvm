//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Tests
// Author           : DarthPedro
// Created          : 7/15/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="MockModel.cs" company="DarthPedro">
//      Copyright (c) 2017 DarthPedro. All rights reserved.
// </copyright>
// <summary>
//      This project is licensed under the MS-PL license.
//
//      OnePlat is an open source project that builds cross platform
// libraries for developing for .NET in all its flavors and platforms.
// This library implements a basic MVVM Framework.
// </summary>
//-----------------------------------------------------------------------
using OnePlat.Mvvm.Core;

namespace OnePlat.Mvvm.Tests.Mocks
{
    /// <summary>
    /// Mock model class.
    /// </summary>
    public class MockModel : ModelBase
    {
        private string test = "Uninitialized";

        /// <summary>
        /// Gets or sets the test string.
        /// </summary>
        public string Test
        {
            get { return this.test; }
            set { this.SetProperty<string>(ref this.test, value); }
        }
    }
}
