using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Containerschip
{
   public class Column
   {
        
        List<Container> placedContainers = new List<Container>();
        

        public void TryPlaceContainerInColumn(Container container)
        {
            if (placedContainers.Sum(item => item.containerweight) + container.containerweight <= 150000)
            {
                placedContainers.Add(container);
            }
            else
            {
                throw new Exception("to chonky");
            }            
        }
   }
}
