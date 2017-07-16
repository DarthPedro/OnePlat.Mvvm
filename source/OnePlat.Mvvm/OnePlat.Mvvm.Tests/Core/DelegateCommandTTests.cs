//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Tests
// Author           : DarthPedro
// Created          : 7/15/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="DelegateCommandTTests.cs" company="DarthPedro">
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnePlat.Mvvm.Core;
using System;
using System.Windows.Input;

namespace OnePlat.Mvvm.Tests.Core
{
    /// <summary>
    /// Templated DelegateCommand tests.
    /// </summary>
    [TestClass]
    public class DelegateCommandTTests
    {
        // --- DelegateCommand<T>.Constructor tests

        /// <summary>
        /// DelegateCommandT constructor test - with both parameters.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_ConstructorTest()
        {
            // set up
            bool actionCalled = false;
            bool canExecute = true;

            // run test
            ICommand command = new DelegateCommand<string>(p => actionCalled = true, p => { return canExecute; });

            // validate result
            Assert.IsNotNull(command);
            Assert.IsInstanceOfType(command, typeof(DelegateCommand<string>));
            Assert.IsFalse(actionCalled);
        }

        /// <summary>
        /// DelegateCommandT constructor test - execute parameter only.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_ConstructorSingleParamTest()
        {
            // set up
            bool actionCalled = false;

            // run test
            ICommand command = new DelegateCommand<string>(p => actionCalled = true);

            // validate result
            Assert.IsNotNull(command);
            Assert.IsInstanceOfType(command, typeof(DelegateCommand<string>));
            Assert.IsFalse(actionCalled);
        }

        /// <summary>
        /// DelegateCommandT constructor test - null execute parameter.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_ConstructorNullExecuteTest()
        {
            // set up
            ICommand command = null;

            // run test
            Assert.ThrowsException<ArgumentNullException>(() => command = new DelegateCommand<string>(null));

            // validate result
            Assert.IsNull(command);
        }

        // --- DelegateCommand.CanExecute tests

            /// <summary>
        /// CanExecute with no delegate.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_CanExecuteNoDelegateTest()
        {
            // set up
            ICommand command = new DelegateCommand<string>(p => this.NullAction());

            // run test
            bool result = command.CanExecute(null);

            // validate result
            Assert.IsTrue(result);
        }

        /// <summary>
        /// CanExecute with false result.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_CanExecuteFalseTest()
        {
            // set up
            bool canExecute = false;
            ICommand command = new DelegateCommand<string>(p => this.NullAction(), p => { return canExecute; });

            // run test
            bool result = command.CanExecute(null);

            // validate result
            Assert.IsFalse(result);
        }

        /// <summary>
        /// CanExecute with true.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_CanExecuteTrueTest()
        {
            // set up
            bool canExecute = true;
            ICommand command = new DelegateCommand<string>(p => this.NullAction(), p => { return canExecute; });

            // run test
            bool result = command.CanExecute(null);

            // validate result
            Assert.IsTrue(result);
        }

        /// <summary>
        /// CanExecute with parameter.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_CanExecuteWithParameterTest()
        {
            // set up
            ICommand command = new DelegateCommand<int>(p => this.NullAction(), p => this.CanExecuteEval(p));

            // run test
            bool result = command.CanExecute(42);

            // validate result
            Assert.IsTrue(result);
        }

        // --- DelegateCommand.Execute tests

        /// <summary>
        /// Execute test with simple action.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_ExecuteSimpleTest()
        {
            // set up
            bool actionCalled = false;
            ICommand command = new DelegateCommand<string>(p => actionCalled = true);

            // run test
            command.Execute(null);

            // validate result
            Assert.IsTrue(command.CanExecute(null));
            Assert.IsTrue(actionCalled);
        }

        /// <summary>
        /// Execute test with false CanExecute.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_ExecuteFalseCanTest()
        {
            // set up
            bool actionCalled = false;
            ICommand command = new DelegateCommand<string>(p => actionCalled = true, p => { return false; });

            // run test
            command.Execute(null);

            // validate result
            Assert.IsFalse(command.CanExecute(null));
            Assert.IsFalse(actionCalled);
        }

        /// <summary>
        /// Execute test with parameter.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_ExecuteWithParameterTest()
        {
            // set up
            string param = "ParameterCalled";
            ICommand command = new DelegateCommand<string>(p => this.ExecuteAction(p));

            // run test
            command.Execute(param);

            // validate result
            Assert.IsTrue(command.CanExecute(param));
        }

        // --- DelegateCommand.RaiseCanExecuteChanged tests

        /// <summary>
        /// RaiseCanExecuteChanged test with no event handler.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_RaiseCanExecuteChangedTest()
        {
            // set up
            bool actionCalled = false;
            bool canExecuteChanged = false;
            DelegateCommand<string> command = new DelegateCommand<string>(p => actionCalled = true);

            // run test
            command.RaiseCanExecuteChanged();

            // validate result
            Assert.IsTrue(command.CanExecute(null));
            Assert.IsFalse(actionCalled);
            Assert.IsFalse(canExecuteChanged);
        }

        /// <summary>
        /// RaiseCanExecuteChanged test with event handler.
        /// </summary>
        [TestMethod]
        public void DelegateCommandT_RaiseCanExecuteChangedWithEventTest()
        {
            // set up
            bool actionCalled = false;
            bool canExecute = false;
            bool canExecuteChanged = false;
            DelegateCommand<string> command = new DelegateCommand<string>(p => actionCalled = true, p => { return canExecute; });

            // run test
            command.CanExecuteChanged += new EventHandler((s, e) => canExecuteChanged = true);
            canExecute = true;
            command.RaiseCanExecuteChanged();

            // validate result
            Assert.IsTrue(command.CanExecute(null));
            Assert.IsFalse(actionCalled);
            Assert.IsTrue(canExecuteChanged);
        }

        // --- Helper handlers
        private void NullAction()
        {
        }

        private void ExecuteAction(string param)
        {
            Assert.AreEqual("ParameterCalled", param);
        }

        private bool CanExecuteEval(int param)
        {
            return (int)param == 42;
        }
    }
}
