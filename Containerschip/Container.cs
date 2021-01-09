using System;
using System.Collections.Generic;
using System.Text;

namespace Containerschip
{
    public class Container
    {
        public enum ContainerType
        {
            Cooled = 1,
            Regular = 2,
            Valueable =3
        }
        
        public ContainerType containertype { get; set; }
        public int containerweight { get; set; }

        public Container(ContainerType type, int weight)
        {
            this.containertype = type;
            this.containerweight = weight;
        }
        
    }
} 
