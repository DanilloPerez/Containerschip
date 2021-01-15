using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containerschip;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Containerschip.Tests
{
    [TestClass()]
    public class ShipTests
    {
        [TestMethod()]
        public void PlaceContainersEmptySortedContainerList()
        {
            //arrange
            Ship ship = new Ship(5,10);
            List<Container> emptyList = new List<Container>();   
            //act
            ship.PlaceContainers(emptyList);
            //assert
            int NonNullRows = ship.rowArray.Count(Row => Row != null);
            Assert.AreEqual(0, NonNullRows);
        }

        [TestMethod()]
        public void PlaceContainersFilledList()
        {
            //arrange
            Ship ship = new Ship(5, 10);
            List<Container> sortedContainers = new List<Container>();
            Container container = new Container(Container.ContainerType.Regular, 5000);
            Container container1 = new Container(Container.ContainerType.Regular, 5000);
            Container container2 = new Container(Container.ContainerType.Regular, 5000);
            Container container3 = new Container(Container.ContainerType.Regular, 5000);
            sortedContainers.Add(container);
            sortedContainers.Add(container1);
            sortedContainers.Add(container2);
            sortedContainers.Add(container3);

            //act
            ship.PlaceContainers(sortedContainers);
            //assert
            
            Assert.AreEqual(4, sortedContainers.Count);
        }
        
    }

       
    
}