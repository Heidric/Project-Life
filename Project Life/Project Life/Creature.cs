using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project_Life
{
    [Serializable]
    public class Creature
    {
        public int x;
        public int y;
        public bool dead = false;
    }
}
