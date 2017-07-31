//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Core
// Author           : DarthPedro
// Created          : 7/15/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="ModelBase.cs" company="DarthPedro">
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
    /// Base class for all Model classes that implements INotifyPropertyChanged.
    /// </summary>
    public abstract class ModelBase : ObservableObject
    {
    }
}
