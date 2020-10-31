using System;
using System.Collections.Generic;
using System.Text;

namespace Containerschip
{
   public class schip
    {
        public int height;
        public int width;
        public int weightperhalf;
        public int length;

        public List<Container> newCooledContainer = new List<Container>();
        public List<Container> newRegularContainer = new List<Container>();
        public List<Container> newValueableContainer = new List<Container>();
    }   
}
