//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Tests
// Author           : DarthPedro
// Created          : 7/15/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="ViewModelBaseTests.cs" company="DarthPedro">
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
using OnePlat.Mvvm.Tests.Mocks;

namespace OnePlat.Mvvm.Tests.Core
{
    /// <summary>
    /// ViewModelBase tests.
    /// </summary>
    [TestClass]
    public class ViewModelBaseTests
    {
        /// <summary>
        /// Constructor test
        /// </summary>
        [TestMethod]
        public void ViewModelBase_ConstructorTest()
        {
            // set up

            // run test
            IViewModel vm = new MockViewModel();

            // validate result
            Assert.IsNotNull(vm);
            Assert.IsInstanceOfType(vm, typeof(MockViewModel));
            Assert.IsInstanceOfType(vm, typeof(ViewModelBase));
            Assert.IsInstanceOfType(vm, typeof(IViewModel));
            Assert.AreEqual("Test View Model", vm.Title);
            Assert.IsFalse(vm.IsBusy);
        }

        /// <summary>
        /// Title property test
        /// </summary>
        [TestMethod]
        public void ViewModelBase_TitleTest()
        {
            // set up
            IViewModel vm = new MockViewModel();

            // run test
            vm.Title = "TestSetter";

            // validate result
            Assert.AreEqual("TestSetter", vm.Title);
            Assert.IsFalse(vm.IsBusy);
        }

        /// <summary>
        /// IsBusy property test
        /// </summary>
        [TestMethod]
        public void ViewModelBase_IsBusyTest()
        {
            // set up
            IViewModel vm = new MockViewModel();
            Assert.IsFalse(vm.IsBusy);

            // run test
            vm.IsBusy = true;

            // validate result
            Assert.AreEqual("Test View Model", vm.Title);
            Assert.IsTrue(vm.IsBusy);

            // test another change
            vm.IsBusy = false;
            Assert.IsFalse(vm.IsBusy);
        }
    }
}
