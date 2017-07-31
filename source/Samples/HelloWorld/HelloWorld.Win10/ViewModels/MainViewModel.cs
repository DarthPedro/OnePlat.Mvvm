//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Core
// Author           : DarthPedro
// Created          : 7/17/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/17/2017
//-----------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="DarthPedro">
//     Copyright (c) 2017 DarthPedro. All rights reserved.
// </copyright>
// <summary>
//       This project is licensed under the MS-PL license.
//
//       OnePlat is an open source project that builds cross platform
// libraries for developing for .NET in all its flavors and platforms.
// This library implements a basic MVVM Framework.
// </summary>
//-----------------------------------------------------------------------
using OnePlat.Mvvm.Core;
using System.Windows.Input;

namespace HelloWorld.Win10.ViewModels
{
    /// <summary>
    /// Main view model.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string message = "Hello, Mvvm World!";
        private int count = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            this.IncrementCommand = new DelegateCommand(p => this.OnIncrement());
        }

        /// <summary>
        /// Gets or sets the message for this view model.
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.SetProperty<string>(ref this.message, value); }
        }

        /// <summary>
        /// Gets or sets the counter.
        /// </summary>
        public int Count
        {
            get { return this.count; }
            set { this.SetProperty<int>(ref this.count, value); }
        }

        /// <summary>
        /// Gets the Increment command.
        /// </summary>
        public ICommand IncrementCommand { get; private set; }

        private void OnIncrement()
        {
            this.Count++;
        }
    }
}
