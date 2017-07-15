//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Core
// Author           : DarthPedro
// Created          : 7/14/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="DelegateCommand.cs" company="DarthPedro">
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
using System;

namespace OnePlat.Mvvm.Core
{
    /// <summary>
    /// Command implementation class that delegates execution method to the
    /// specified action.
    /// This implementation is just an instance of the templated DelegateCommand
    /// with object as its type, so it will work with untyped delegates.
    /// </summary>
    public class DelegateCommand : DelegateCommand<object>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="execute">The execute.</param>
        /// <param name="canExecute">The can execute.</param>
        /// <exception cref="System.ArgumentNullException">execute</exception>
        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
            : base(execute, canExecute)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class that
        /// can always execute.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <exception cref="ArgumentNullException">If the execute argument is null.</exception>
        public DelegateCommand(Action<object> execute)
            : base(execute)
        {
        }
    }
}
