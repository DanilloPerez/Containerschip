﻿using System;
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
                Container tempContainer = new Container(Container.containerType.Regular, 4000);
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

        private Ship SplitByContainerType(Container container)
        {
            Ship tempship = new Ship();
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

        private Ship PlaceCooledContainers(Container newCooledContainer, Ship ship)
        {
            List<Container> PlacedContainers = new List<Container>();
            // first row only

 
        }
        private Ship PlaceRegularContainers(Container newRegularContainer, Ship ship)
        {
            List<Container> PlacedContainers = new List<Container>();
            // all the places

        }
        private Ship PlaceValueableContainers(Container newValueableContainer, Ship ship)
        {
            List<Container> PlacedContainers = new List<Container>();
            // one of both sides must be reacheable
            // nothing on top
                      
        }
    }
}



















//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//#####@xxMxx###nnxMW@######xnnzn@#WxMWW@##@MxxxxxMMMxxxxx@###MxxxxxW#@xxMMxxxxxM@xxxxxxxMMM@####@xxxxxx@#####xx+:zMW##@###WxxxM@MMMMWWxnnnznM@W@xxxMM@#
//#####;``...@#@```.`;#####n`````n#WnxW@W+,```````.`+`````n###````.`;x:`````````:z```````````:n###``````+####n```...,#####W.````*MxxxMM``````M@WM``...*#
//####@``:;::##x`.,:,;####W``..,,*#MnM@#```..,,,,,,,*`.,,.x@+`...,.`.``..,...,,.*i`......,,,,.`x#;`.,,,,:###@.`.,,,,;#####;`..,:,xnnnx#`.,,,.#@@#`,;;,z#
//####x`..,.*##+`...`n####i````..;#xnWz```.``......*:````.Mi`...`.,.``....`....`x.```.........`i@.```..`*@##+````..`z##@@#````..`nnzz#;```...;MW;...,,M@
//####i``...+zz,````inznz*```````;@xMn.````````````n`````i:`````,Wi````````````;M``````````````*M```````*##+.``````,####*````````i+**i``````.:#+.``..###
//####;````;@#M`````x###W,```````;Wxx:`````,#n+.;MM#````.#`````;#x`````.+nx+.,x@z`````izz#i````:z```````z#@:```````.M@#@,````````n@WMn```````.#x```.`W@M
//###W.````;n#;`````####i````````,nM#`````.W###@@@@;````..````.@@,`````+xnz#ixxMi`````n@#@#````.*```````*@z`````````#@#+````````.W###+````````iz````,@Wn
//###n`````````````.n##x````.;````*W: ````########@.``````````##n``````````````:` ````::,,`````*:````````x:````````.:@M`````;````####;`````````;````.@#@
//###*`````````````.@#@, ```+#` ``:x` ````W@######n` ```````.zW#i``````````````;` ````` ``````.x` ```````:`````````,`x: ```*n ```,@#@.````,`````````:@##
//###,`````````````,##*`````+;`````:````,,@@@#####+``````.:,#WWW.````````````.`:,```````````..++`````````````````,.z;;`````x#`````W#W````.+```.````.*@@@
//##@,MW@WMMxxWWMW;in#.MWWW;.+xWMz``,M@@i*M@@@@##@,i@WWxMxM*#@@M`nMMxzzzzzznni,,z@WWWMMMxnz,.*W:*xMn`nMMi;MMx.nWM#,M#`nWWWzi,zWW@:zMz;WWW+#iWWx,M@@+M###
//##W*@@@+++`.+@WM:nz*+WWWWWMMn###.*;Mxx;x@#####@x`*WMn,xnzn:@@M:xzz+,::::,,:;i:nMxn;;,#Wn#`,Wz:###*`#Mx+#z#;,nnn;+#`;@@WMMMMxnnMinxz*MxMiziMxxxMW@#@@#@
//##*.ii+;@#M:,;i;,n,.;;;iii;;:,,:.:.,,;,#WWWWWMxn`,:;:+,:,;,#@n`,,:,`*n**:..`.`::;,zx;.:::..#n`,.,,.,::::::..,,:`i;`:;::::::,,:;:+W,,:;i*@;;;;:;i*z###@
//##:`...+##@.``..;n`````````````````````````````;````.x.```..MW`````````````+*````,@#z``````xz````:n``````.i```````````````````.`i@```..n#+`......x###@
//#@.``.`x##n`````;.````;@xiMM,`````````````````.,````i#i`````i#;` ``````````n* ```*##@.`````z*````+W` ````#+```` `````,@###z`````:x`````W#M`````.`W###@
//#x````.@###```````````M#####, ```z+` `````````;: ```z#M.  ``.@x. `````````.@; ```n###i` ```+* ```z@` ```:@, `````````i@###@.````,+````,##@:`````:@####
//#+````i###i``````````#######i ```*@;` ````````*,  ``W##+`  ` +##.`````````i#,  ``@###n` ```zi   `,#`  ``xM` ``:;````.,W####;` ``.*` ``*###+`````z#####
//z + *+++z###i****.`,+++z######ii*:*W#@n*iii*****x;i++####@++++++##M#*****+++M@+*++#####@#*++*nz*++#W#**++z#ni***n+***+i:+z#zz*;;.`i#i+++z+++++**,`++++
//#@#@#@@###@@W@#@W@##########@@############################@##################################################################@@W@@@###@###@@##WM#####@
//#########################@############################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################
//######################################################################################################################################################