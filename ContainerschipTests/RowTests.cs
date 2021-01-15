using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containerschip;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Containerschip.Tests
{
    [TestClass()]
    public class RowTests
    {
        [TestMethod()]
        public void TryPlaceContainerInRowRightInputCooled()
        {
            //arrange
            Row row = new Row(12);
            Container cooledContainer = new Container(Container.ContainerType.Cooled, 5000);
            //act
            row.TryPlaceContainerInRow(cooledContainer);
            //assert
            int NonNullStacks = row.columnarray.Count(Stack => Stack != null);
            Assert.AreEqual(1, NonNullStacks);
        }

        [TestMethod()]
        public void TryPlaceContainerInRowRightInputRegular()
        {
            //arrange
            Row row = new Row(12);
            Container regularContainer = new Container(Container.ContainerType.Regular, 5000);
            //act
            row.TryPlaceContainerInRow(regularContainer);
            //assert
            int NonNullStacks = row.columnarray.Count(Stack => Stack != null);
            Assert.AreEqual(1, NonNullStacks);
        }

        [TestMethod()]
        public void TryPlaceContainerInRowRightInputValueable()
        {
            //arrange
            Row row = new Row(12);
            Container valueableContainer = new Container(Container.ContainerType.Valueable, 5000);
            //act
            row.TryPlaceContainerInRow(valueableContainer);
            //assert
            int NonNullStacks = row.columnarray.Count(Stack => Stack != null);
            Assert.AreEqual(1, NonNullStacks);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "invalid containertype")]
        public void TryPlaceContainerInRowNullTest()
        {
            //arrange
            Row row = new Row(12);
            Container Container = null;
            //act
            row.TryPlaceContainerInRow(Container);
        }

        [TestMethod()]
        public void TryPlaceContainerTryPlaceExistingStackTest()
        {
            //arrange
            Stack stack = new Stack();
            Row row = new Row(12);
            Container valueableContainer = new Container(Container.ContainerType.Valueable, 5000);
            row.columnarray[0] = stack;
            //act
            row.TryPlaceContainerInRow(valueableContainer);
            //assert
            int Stacks = row.columnarray.Count(Stack => Stack != null);
            Assert.AreEqual(1, Stacks);    
        }
    }
}