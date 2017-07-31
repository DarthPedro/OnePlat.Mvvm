//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Tests
// Author           : DarthPedro
// Created          : 7/15/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="MockViewModel.cs" company="DarthPedro">
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
    /// Mock view model.
    /// </summary>
    public class MockViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MockViewModel"/> class.
        /// </summary>
        public MockViewModel()
        {
            this.Title = "Test View Model";
        }
    }
}
