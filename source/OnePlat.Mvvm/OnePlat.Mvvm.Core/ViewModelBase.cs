//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Core
// Author           : DarthPedro
// Created          : 7/15/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="ViewModelBase.cs" company="DarthPedro">
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
    /// Base class for all ViewModel classes.
    /// </summary>
    public abstract class ViewModelBase : ObservableObject, IViewModel
    {
        #region Members
        private bool isBusy = false;
        private string title = string.Empty;
        #endregion

        #region Properties

        /// <inheritdoc/>
        public bool IsBusy
        {
            get { return this.isBusy; }
            set { this.SetProperty(ref this.isBusy, value); }
        }

        /// <inheritdoc/>
        public string Title
        {
            get { return this.title; }
            set { this.SetProperty(ref this.title, value); }
        }
        #endregion
    }
}
