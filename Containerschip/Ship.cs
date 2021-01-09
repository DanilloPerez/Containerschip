using System;
using System.Collections.Generic;
using System.Text;

namespace Containerschip
{
   public class Ship
   {
        public int height;
        public int width;
        public int leftSideWeight;
        public int rightSideWeight;
       

        public List<Container> newCooledContainer = new List<Container>();
        public List<Container> newRegularContainer = new List<Container>();
        public List<Container> newValueableContainer = new List<Container>();

        
   }   

    private int AddWeight(int containerWeight)
    {
        
    }

    private bool CheckTotalShipWeight(int containerWeight)
    {

    }
    // to do : check for valueable entrance


}
