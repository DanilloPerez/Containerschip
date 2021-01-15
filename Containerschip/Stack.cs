using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Containerschip
{
   public class Stack
   {
        
        public List<Container> placedContainers = new List<Container>();
        

        public bool TryPlaceContainerInColumn(Container container)
        {
            if (container == null)
            {
                throw new ArgumentException("container cannot be null");
            }
            if(placedContainers.Count() > 0 && placedContainers.Last().containertype == Container.ContainerType.Valueable)
            {
                return false;
            }
            if (placedContainers.Sum(item => item.containerweight) + container.containerweight <= 120000)
            {
                placedContainers.Add(container);
                return true;
            }
            else
            {
                return false;
            }            
        }
   }
}
