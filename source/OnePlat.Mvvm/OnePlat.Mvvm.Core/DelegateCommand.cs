//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Core
// Author           : DarthPedro
// Created          : 7/14/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/14/2017
// ***********************************************************************
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
using System.Windows.Input;

namespace OnePlat.Mvvm.Core
{
    /// <summary>
    /// Command implementation class that delegates execution method to the
    /// specified action.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        #region Members

        /// <summary>
        /// The _execute
        /// </summary>
        private readonly Action execute;

        /// <summary>
        /// The _can execute
        /// </summary>
        private readonly Func<bool> canExecute;
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="execute">The execute.</param>
        /// <param name="canExecute">The can execute.</param>
        /// <exception cref="System.ArgumentNullException">execute</exception>
        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException("execute");

            if (canExecute != null)
            {
                this.canExecute = canExecute;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class that
        /// can always execute.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <exception cref="ArgumentNullException">If the execute argument is null.</exception>
        public DelegateCommand(Action execute)
            : this(execute, null)
        {
        }
        #endregion

        #region ICommand methods

        /// <summary>
        /// Occurs when changes occur that affect whether the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Raises the can execute changed.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>true if this command can be executed; otherwise, false.</returns>
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute.Invoke();
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public virtual void Execute(object parameter)
        {
            if (this.CanExecute(parameter))
            {
                this.execute.Invoke();
            }
        }
        #endregion
    }
}
