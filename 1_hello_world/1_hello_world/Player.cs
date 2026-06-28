using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_hello_world
{
    internal class Player
    {
        public string name = "harry";
        private int health = 67;

        public int getHealth()
        {
            return health;
        }
        public void setHealth(int h)
        {
            health = h;
        }
    }
}
