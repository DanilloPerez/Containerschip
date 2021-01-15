using System;
using System.Collections.Generic;
using System.Text;
using static Containerschip.Ship;

namespace Containerschip
{
    public class Ship
    {
        public int height;
        public int width;
        public int lenght;
        public int leftSideWeight = 0;
        public int rightSideWeight = 0;
        public int centerWeight= 0;
        public int placeContainerCount = 0;
        public Row[] rowArray;


        public Ship(int length, int width)
        {
            rowArray = new Row[width];

            this.lenght = length;
            this.width = width;
        }
            

        public enum Shipside
        {
            left,
            center,
            right,
        }


        private void AddWeight(Container container, Shipside shipside)
        {
            if (Shipside.left == shipside)
            {
                leftSideWeight += container.containerweight;
            }
            else if (Shipside.center == shipside)
            {
                centerWeight += container.containerweight;
            }
            else if (Shipside.right == shipside)
            {
                rightSideWeight += container.containerweight;
            }
            else
            {
                throw new Exception("you did an oopsie");
            }
        }

        private bool CheckTotalShipWeight()
        {
            int minimalShipWeight = lenght * width * height * 30000 / 2;

            if (leftSideWeight + centerWeight + rightSideWeight <= minimalShipWeight)
            {
                return false;
            }
            return true;
        }

        private bool CheckBalance()
        {
            int totalWeight = leftSideWeight + centerWeight + rightSideWeight;
            double leftsideWeightPercentage = leftSideWeight / totalWeight * 100;
            double rightsideWeightPercentage = leftSideWeight / totalWeight * 100;

            if (Math.Abs(leftsideWeightPercentage - rightsideWeightPercentage) < 20)
            {
                return false;
            }
            return true;
        }

        private Shipside DecideSide()
        {
            if (leftSideWeight < rightSideWeight)
            {
                return Shipside.left;
            }
            else
            {
                return Shipside.right;
            }

        }



        public Ship PlaceContainers(List<Container> sortedContainers)
        {
            foreach (Container container in sortedContainers)
            {
                Shipside side = DecideSide();
                if (TryPlaceSide(container, side))
                {
                    AddWeight(container,side);
                    placeContainerCount++;
                }
                else if (width%2!= 0 && TryPlaceCenter(container))
                {                    
                    AddWeight(container, Shipside.center);
                    placeContainerCount++;
                }
            }
            return this;

        }

        private bool TryPlaceCenter(Container container)
        {
            int centerIndex = (int)(width / 2);
            if(rowArray[centerIndex] == null)
            {
                rowArray[centerIndex] = new Row(lenght);
            }
            return (rowArray[centerIndex].TryPlaceContainerInRow(container));
           
           
            
        }

        private bool TryPlaceSide(Container container, Shipside side)
        {
            int lowerBoundary = 0;
            int upperboundary = 0;
            if (side == Shipside.left)
            {
                upperboundary = (int)width / 2 - 1;
                lowerBoundary = 0;

            }
            else if (side == Shipside.right)
            {
                upperboundary = width - 1;
                lowerBoundary = (int)Math.Ceiling((double)width / 2);
            }
            for (int i = lowerBoundary; i < upperboundary; i++)
            {
                if (rowArray[i] == null)
                {
                    rowArray[i] = new Row(lenght);
                }
                if (rowArray[i].TryPlaceContainerInRow(container))
                {
                    return true;
                }
            }
            return false;

        }


    }
}
