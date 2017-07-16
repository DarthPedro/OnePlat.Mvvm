//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Tests
// Author           : DarthPedro
// Created          : 7/14/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/14/2017
//-----------------------------------------------------------------------
// <copyright file="ObservableObjectTests.cs" company="DarthPedro">
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
using OnePlat.Mvvm.Tests.Mocks;
using System.ComponentModel;

namespace OnePlat.Mvvm.Tests.Core
{
    /// <summary>
    /// ObservableObject tests
    /// </summary>
    [TestClass]
    public class ObservableObjectTests
    {
        /// <summary>
        /// SetProperty simple test
        /// </summary>
        [TestMethod]
        public void ObservableObject_SetPropertySimpleTest()
        {
            // set up
            MockObservable m = new MockObservable();
            Assert.AreEqual("Uninitialized", m.DisplayText);

            // run test
            m.DisplayText = "Test1";

            // validate result
            Assert.AreEqual("Test1", m.DisplayText);
        }

        /// <summary>
        /// SetProperty with PropertyChanged event handler test
        /// </summary>
        [TestMethod]
        public void ObservableObject_SetPropertyChangedEventTest()
        {
            // set up
            MockObservable m = new MockObservable();
            Assert.AreEqual("Uninitialized", m.DisplayText);
            m.PropertyChanged += new PropertyChangedEventHandler((s, e) => Assert.AreEqual("DisplayText", e.PropertyName));

            // run test
            m.DisplayText = "Test2";

            // validate result
            Assert.AreEqual("Test2", m.DisplayText);
        }

        /// <summary>
        /// SetProperty with property changed handler test
        /// </summary>
        [TestMethod]
        public void ObservableObject_SetPropertyChangedTest()
        {
            // set up
            MockObservable m = new MockObservable();
            Assert.AreEqual(0, m.Value);
            Assert.IsFalse(m.HasValueChanged);

            // run test
            m.Value = 42;

            // validate result
            Assert.AreEqual(42, m.Value);
            Assert.IsTrue(m.HasValueChanged);
        }

        /// <summary>
        /// SetProperty with property changed handler test
        /// </summary>
        [TestMethod]
        public void ObservableObject_SetPropertySetToSameValueTest()
        {
            // set up
            MockObservable m = new MockObservable();
            m.Value = 512;
            m.HasValueChanged = false;

            // run test
            m.Value = 512;

            // validate result
            Assert.AreEqual(512, m.Value);
            Assert.IsFalse(m.HasValueChanged);
        }

        /// <summary>
        /// SetProperty with PropertyChanged event handler test
        /// </summary>
        [TestMethod]
        public void ObservableObject_SetPropertyDifferentPropertyNameTest()
        {
            // set up
            MockObservable m = new MockObservable();
            Assert.AreEqual("foo", m.Name);
            m.PropertyChanged += new PropertyChangedEventHandler((s, e) => Assert.AreEqual("FullName", e.PropertyName));

            // run test
            m.Name = "DarthPedro";

            // validate result
            Assert.AreEqual("DarthPedro", m.Name);
        }
    }
}
