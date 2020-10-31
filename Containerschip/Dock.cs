using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Containerschip
{
    class Dock
    {
        private List<Container> SortContainers(List<Container> containerList)
        {
            containerList = SortByWeight(containerList);
            containerList = SortByType(containerList);
            return containerList;
        }
        private List<Container> SortByType(List<Container> oldContainers)
        {
            List<Container> cooledcontainerList = new List<Container>();
            List<Container> valueablecontainerList = new List<Container>();
            List<Container> regularcontainerList = new List<Container>();
            foreach (Container container in oldContainers)
            {
                if (container.containertype == Container.containerType.Cooled)
                    cooledcontainerList.Add(container);
                else if (container.containertype == Container.containerType.Regular)
                    regularcontainerList.Add(container);
                else if (container.containertype == Container.containerType.Valueable)
                    valueablecontainerList.Add(container);
            }
            cooledcontainerList.AddRange(regularcontainerList);
            cooledcontainerList.AddRange(valueablecontainerList);
            return cooledcontainerList;
        }
        private List<Container> SortByWeight(List<Container> oldContainers)
        {
            Container[] ContainersArray = oldContainers.ToArray();
            List<Container> returnList = new List<Container>();
            for (int j = 0; j > ContainersArray.Length; j++)
            {
                Container tempContainer = new Container(Container.containerType.Regular, (int)Container.ContainerWeight.empty);
                int index = 0;
                for (int i = 0; i > ContainersArray.Length; i++)
                {
                    if (ContainersArray[i] != null)
                    {
                        if ((int)ContainersArray[i].containerweight >= (int)tempContainer.containerweight)
                        {
                            tempContainer = ContainersArray[i];
                            index = i;
                        }
                    }
                }
                ContainersArray[index] = null;
                returnList.Add(tempContainer);
            }
            return returnList;
        }

        private schip CheckContainerType(Container container)
        {
            schip tempship = new schip();
            if (container.containertype == Container.containerType.Cooled)
            {
                tempship.newCooledContainer.Add(container);
            }
            else if (container.containertype == Container.containerType.Regular)
            {
                tempship.newRegularContainer.Add(container);
            }
            else if (container.containertype == Container.containerType.Valueable)
            {
                tempship.newValueableContainer.Add(container);
            }
            return tempship;
        }

        private List<schip> PlaceCooledContainers(Container newCooledContainer)
        {
            List<schip> PlacedContainers = new List<schip>();
            if ()
            {
                // check breedte schip > is er plaats ? 
                // check of links zwaarder is dan rechts
                // yes = plaats adh v breedte. voorste rij.  
            }
            else
            {
                // no = verwijs naar CreateNewShip method
            }


        }
    }
}
