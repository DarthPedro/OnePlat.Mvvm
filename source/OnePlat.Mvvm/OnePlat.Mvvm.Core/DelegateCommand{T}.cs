//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Core
// Author           : DarthPedro
// Created          : 7/14/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/14/2017
//-----------------------------------------------------------------------
// <copyright file="DelegateCommand{T}.cs" company="DarthPedro">
//      Copyright (c) 2017 DarthPedro. All rights reserved.
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
using System.Windows.Input;

namespace OnePlat.Mvvm.Core
{
    /// <summary>
    /// Command implementation class that delegates execution method to the
    /// specified action.
    /// </summary>
    /// <typeparam name="T">Command parameter type</typeparam>
    public class DelegateCommand<T> : ICommand
    {
        #region Members

        /// <summary>
        /// The execute
        /// </summary>
        private readonly Action<T> execute;

        /// <summary>
        /// The can execute
        /// </summary>
        private readonly Predicate<T> canExecute;
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand{T}" /> class.
        /// </summary>
        /// <param name="execute">The execute action.</param>
        /// <exception cref="System.ArgumentNullException">execute</exception>
        public DelegateCommand(Action<T> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand{T}" /> class.
        /// </summary>
        /// <param name="execute">The execute.</param>
        /// <param name="canExecute">The can execute predicate.</param>
        /// <exception cref="System.ArgumentNullException">execute</exception>
        public DelegateCommand(Action<T> execute, Predicate<T> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException("execute");

            if (canExecute != null)
            {
                this.canExecute = canExecute;
            }
        }
        #endregion

        #region ICommand methods

        /// <summary>
        /// Occurs when changes occur that affect whether the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Raise <see cref="DelegateCommand{T}.CanExecuteChanged" /> event.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Determines whether this instance can execute the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns><c>true</c> if this instance can execute the specified parameter; otherwise, <c>false</c>.</returns>
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute.Invoke((T)parameter);
        }

        /// <summary>
        /// Executes the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        public virtual void Execute(object parameter)
        {
            if (this.CanExecute(parameter))
            {
                this.execute((T)parameter);
            }
        }
        #endregion
    }
}
