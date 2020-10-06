﻿using System;
using CircutApp;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class ElementTests
    {
        private ElementHeir _element;

        public void Initialize()
        {
            _element = new ElementHeir();
        }

        [Test(Description = "Test Value property with negative value")]
        public void ElementValueTest_NegativeValue()
        {
            Initialize();
            Assert.Throws<ArgumentOutOfRangeException>(() => { _element.Value = -1; },
                "Element value was set negative");
        }

        [Test(Description = "Test value set with positive value")]
        public void ElementValueTest_PositiveValue()
        {
            Initialize();
            double expected = 30.133;
            _element.Value = 30.133;
            Assert.AreEqual(expected, _element.Value, "Wrong set/get");
        }

        [Test(Description = "Test PropertyChanged event firing")]
        public void ElementPropertyChangedEventTest_Firing()
        {
            Initialize();
            var wasCalled = false;
            _element.PropertyChanged += (o, e) => wasCalled = true;
            _element.Value = 30.0;
            Assert.IsTrue(wasCalled,"Event wasn't called");
        }

        [Test(Description = "Test SubSegments property get")]
        public void ElementSubSegments_getTest()
        {
            Initialize();
            Assert.AreEqual(null,_element.SubSegments,"Element SubSegments wasn't null");
        }

        [Test(Description = "Test element Name property get")]
        public void ElementName_GetPositiveTest()
        {
            Initialize();
            string expected = "Test";
            _element.Name = "Test";
            Assert.AreEqual(expected,_element.Name,"Returned wrong value");
        }
    }
}