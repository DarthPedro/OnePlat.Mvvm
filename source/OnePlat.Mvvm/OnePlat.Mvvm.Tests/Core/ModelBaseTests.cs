//-----------------------------------------------------------------------
// Assembly         : OnePlat.Mvvm.Tests
// Author           : DarthPedro
// Created          : 7/15/2017
//
// Last Modified By : DarthPedro
// Last Modified On : 7/15/2017
//-----------------------------------------------------------------------
// <copyright file="ModelBaseTests.cs" company="DarthPedro">
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
    /// ModelBase tests.
    /// </summary>
    [TestClass]
    public class ModelBaseTests
    {
        /// <summary>
        /// Tests the default constructor.
        /// </summary>
        [TestMethod]
        public void ModelBase_ConstructorTest()
        {
            // set up

            // run test
            MockModel m = new MockModel();

            // validate result
            Assert.IsNotNull(m);
            Assert.IsInstanceOfType(m, typeof(MockModel));
            Assert.IsInstanceOfType(m, typeof(ModelBase));
            Assert.AreEqual("Uninitialized", m.Test);
        }

        /// <summary>
        /// Tests the default constructor.
        /// </summary>
        [TestMethod]
        public void ModelBase_PropertyTest()
        {
            // set up
            MockModel m = new MockModel();

            // run test
            m.Test = "MockModel.Test1";

            // validate result
            Assert.AreEqual("MockModel.Test1", m.Test);
        }
    }
}
