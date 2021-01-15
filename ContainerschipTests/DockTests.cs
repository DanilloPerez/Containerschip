using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containerschip;
using System;
using System.Collections.Generic;
using System.Text;

namespace Containerschip.Tests
{
    [TestClass()]
    public class DockTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "containerlist cannot be empty")]
        public void PlaceContainerContainerlistNullTest()
        {
            //arrange
            Dock dock = new Dock();
            Ship ship = new Ship(10, 5);
            List<Container> containerlist = null;
            //act
            dock.PlaceContainer(containerlist, 10, 5);          
        }

        [TestMethod()]
       
        public void PlaceContainerShipWithoutLength()
        {
            //arrange
            Dock dock = new Dock();
            Ship ship = new Ship(0, 5);
            List<Container> containerlist = new List<Container>();
            //act
            dock.PlaceContainer(containerlist, 0, 5);
            //assert
            Assert.AreEqual(0, containerlist.Count);

        }

        [TestMethod()]
        public void PlaceContainerShipWithoutWidth()
        {
            //arrange
            Dock dock = new Dock();
            Ship ship = new Ship(5, 0);
            List<Container> containerlist = new List<Container>();
            //act
            dock.PlaceContainer(containerlist, 5, 0);
            //assert
            Assert.AreEqual(0, containerlist.Count);
        }

        [TestMethod()]
        public void PlaceContainerFilledList()
        {
            //arrange
            Container container = new Container(Container.ContainerType.Regular,  5000);
            Container container1 = new Container(Container.ContainerType.Regular, 5000);
            Container container2 = new Container(Container.ContainerType.Regular, 5000);
            Container container3 = new Container(Container.ContainerType.Regular, 5000);

            Dock dock = new Dock();
            Ship ship = new Ship(5, 10);           
            List<Container> containerlist = new List<Container>();
            containerlist.Add(container);
            containerlist.Add(container1);
            containerlist.Add(container2);
            containerlist.Add(container3);
            //act
            dock.PlaceContainer(containerlist, 5, 10);
            //assert
            Assert.AreEqual(4, containerlist.Count);
        }

    }
}