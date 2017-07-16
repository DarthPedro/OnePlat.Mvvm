//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Tests
// Author           : DarthPedro
// Created          : 7/14/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/14/2017
//-----------------------------------------------------------------------
// <copyright file="MockObservable.cs" company="DarthPedro">
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
    /// Mock class to test ObservableObject functionality.
    /// </summary>
    internal class MockObservable : ObservableObject
    {
        private string displayText = "Uninitialized";
        private int val = 0;
        private string name = "foo";

        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        public string DisplayText
        {
            get { return this.displayText; }
            set { this.SetProperty<string>(ref this.displayText, value); }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public int Value
        {
            get { return this.val; }
            set { this.SetProperty<int>(ref this.val, value, onChanged: this.OnValueChanged); }
        }

        /// <summary>
        /// Gets or sets the name property.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.SetProperty<string>(ref this.name, value, "FullName"); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Value property has changed.
        /// </summary>
        public bool HasValueChanged { get; set; } = false;

        private void OnValueChanged()
        {
            this.HasValueChanged = true;
        }
    }
}
