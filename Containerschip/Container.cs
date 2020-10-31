using System;
using System.Collections.Generic;
using System.Text;

namespace Containerschip
{
    public class Container
    {
        public enum containerType
        {
            Cooled,
            Regular,
            Valueable
        }
        public enum ContainerWeight
        {
            full = 30000,
            empty = 4000
        }
        public containerType containertype { get; set; }
        public int containerweight { get; set; }

        public Container(containerType type, int weight)
        {
            this.containertype = type;
            this.containerweight = weight;
        }
    }
}
