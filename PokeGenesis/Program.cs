using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GenesisEngine;

namespace PokeGenesis
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLtoList list = new XMLtoList();
            Random rnd = new Random();
        Start:
            List<Identifier> pokeList = list.createList("Pokemon");
            int pokeRange = pokeList.Count;
            int pokeN = rnd.Next(0, pokeRange);
            Console.WriteLine("A wild {0} appeared!", pokeList[pokeN].id);
            int isUnique = rnd.Next(0, 10);
            if (isUnique == 9)
            {
                List<Identifier> itemList = list.createList("Item");
                List<Identifier> designList = list.createList("Design");
                List<Identifier> shadeList = list.createList("Shade");
                List<Identifier> colorList = list.createList("Color");
                int itemRange = itemList.Count;
                int designRange = designList.Count;
                int shadeRange = shadeList.Count;
                int colorRange = colorList.Count;
                int itemN = rnd.Next(0, itemRange);
                int designN = rnd.Next(0, designRange);
                int shadeN1 = rnd.Next(0, shadeRange);
                int shadeN2 = rnd.Next(0, shadeRange);
                int colorN1 = rnd.Next(0, colorRange);
                int colorN2 = rnd.Next(0, colorRange);
                if (colorN1 == 0 || colorN1 == 1) { shadeN1 = 0; }
                if (colorN2 == 0 || colorN2 == 1) { shadeN2 = 0; }
                string shade1 = shadeList[shadeN1].id;
                string color1 = colorList[colorN1].id;
                string item = itemList[itemN].id;
                string shade2 = shadeList[shadeN2].id;
                string color2 = colorList[colorN2].id;
                string design = designList[designN].id;
                Console.WriteLine("It is wearing a{0}{1}{2}, with{3}{4}{5}... That is unique!", shade1, color1, item, shade2, color2, design);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.ReadKey();
            goto Start;
        }
    }
}

