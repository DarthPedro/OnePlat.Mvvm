//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Core
// Author           : DarthPedro
// Created          : 7/15/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="IViewModel.cs" company="DarthPedro">
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
namespace OnePlat.Mvvm.Core
{
    /// <summary>
    /// Interface to encapsulate view models.
    /// </summary>
    public interface IViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the view model is busy
        /// </summary>
        bool IsBusy { get; set; }

        /// <summary>
        /// Gets or sets the title of the view model.
        /// </summary>
        string Title { get; set; }
    }
}
