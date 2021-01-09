using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Containerschip
{
    public class Row
    {
        public Column[] columnarray;
        private int shiplength;

        public Row(int shiplenght)
        {
            this.shiplength = shiplength;
            columnarray = new Column[shiplenght];
        }



        public void TryPlaceContainerInRow(Container container)
        {

            if (container.containertype == Container.ContainerType.Cooled)
            {
                if (columnarray[0] == null)
                {
                    columnarray[0] = new Column();
                }
                columnarray[0].TryPlaceContainerInColumn(container);
            }
            else if (container.containertype == Container.ContainerType.Regular)
            {
                for (int i = 0; i < shiplength; i++)
                {
                    if (columnarray[i] == null)
                    {
                        columnarray[i] = new Column();
                    }
                    try { columnarray[i].TryPlaceContainerInColumn(container); }
                    catch (Exception ex) { continue; };
                }
            }
            else if (container.containertype == Container.ContainerType.Valueable)
            {

                for (int i = 0; i < shiplength; i++)
                {
                    if (columnarray[i] == null)
                    {
                        columnarray[i] = new Column();
                    }
                    try { columnarray[i].TryPlaceContainerInColumn(container); }
                    catch (Exception ex) { continue; };
                }

            }
            else
            {
                throw new Exception("too much cool bro");
            }
        }


    }
}
