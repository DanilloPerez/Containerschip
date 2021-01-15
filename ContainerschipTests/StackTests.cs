using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containerschip;
using System;
using System.Collections.Generic;
using System.Text;

namespace Containerschip.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void TryPlaceContainerInColumnWeightAllowed()
        {
            //arrange
            Stack stack = new Stack();
            Container regularContainer = new Container(Container.ContainerType.Regular,5000);
            stack.placedContainers.Add(regularContainer);
            //act
            bool result = stack.TryPlaceContainerInColumn(regularContainer);
            //assert
            Assert.IsTrue(result);
            Assert.AreEqual(2, stack.placedContainers.Count);
        }
        [TestMethod()]
        public void TryPlaceContainerInColumnWeightNotAllowed()
        {
            //arrange
            Stack stack = new Stack();
            Container regularContainer = new Container(Container.ContainerType.Regular, 150000);
            stack.placedContainers.Add(regularContainer);
            //act
            bool result = stack.TryPlaceContainerInColumn(regularContainer);
            //assert
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void TryPlaceContainerInColumnStackOnValuableNotAllowed()
        {
            //arrange
            Stack stack = new Stack();
            Container ValueableContainer = new Container(Container.ContainerType.Valueable, 5000);
            stack.placedContainers.Add(ValueableContainer);
            //act
            bool result = stack.TryPlaceContainerInColumn(ValueableContainer);
            //assert
            Assert.IsFalse(result);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "container cannot be null")]
        public void TryPlaceContainerInColumnNulltest()
        {
            //arrange
            Stack stack = new Stack();
            Container ValueableContainer = null;
            stack.placedContainers.Add(ValueableContainer);
            //act
            bool result = stack.TryPlaceContainerInColumn(ValueableContainer);
          
        }

    }
}