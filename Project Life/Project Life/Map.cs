using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Project_Life
{
    [Serializable]
    public class Map
    {
        public int[,] map = new int[50, 33];

        //Инициализация существа
        public void NewCreature(Creature c)
        {
            map[c.x, c.y] = 1;
        }

        //Инициализация существа на основе листа
        public void NewCreature(List<Creature> l)
        {
            for (int i = 0; i < l.Count; ++i)
            {
                map[l[i].x - 1, l[i].y - 1] = 1;
            }
        }

        //Очистка карты
        public void Clear()
        {
            for (int i = 0; i < 49; ++i)
            {
                for (int j = 0; j < 32; ++j)
                {
                    map[i, j] = 0;
                }
            }
        }

        public void ClearChecked(List<Creature> checkedCreature)
        {
            for (int i = 0; i < checkedCreature.Count; ++i)
            {
                map[checkedCreature[i].x, checkedCreature[i].y] = 0;
            }
        }
    }
}