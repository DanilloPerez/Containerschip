using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Containerschip
{
    public class Row
    {
        public Stack[] columnarray;
        private int shiplength;

        public Row(int shiplength)
        {
            this.shiplength = shiplength;
            columnarray = new Stack[shiplength];
        }



        public bool TryPlaceContainerInRow(Container container)
        {
            if (container == null)
            {
                throw new ArgumentException("invalid containertype");
            }

            if (container.containertype == Container.ContainerType.Cooled)
            {
                if (columnarray[0] == null)
                {
                    columnarray[0] = new Stack();
                }
                return columnarray[0].TryPlaceContainerInColumn(container);
                               
            }
            else if (container.containertype == Container.ContainerType.Regular)
            {
                for (int i = 0; i < shiplength; i++)
                {
                    if (columnarray[i] == null)
                    {
                        columnarray[i] = new Stack();
                    }
                    if(columnarray[i].TryPlaceContainerInColumn(container))
                    {
                        return true;

                    }                                     
                }
                return false;
            }
            else if (container.containertype == Container.ContainerType.Valueable)
            {
                for (int i = 0; i < shiplength; i++)
                {
                    if (columnarray[i] == null)
                    {
                        columnarray[i] = new Stack();
                    }
                    if (columnarray[i].TryPlaceContainerInColumn(container))
                    {
                        return true;
                    }                                                 
                }
                return false;
            }
            else
            {
                throw new ArgumentException("invalid containertype");
            }
        }


      
    }
}
