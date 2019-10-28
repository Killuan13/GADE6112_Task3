using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    abstract class Building
    {
        //protected fields
        protected int positionX;
        protected int positionY;
        protected int hp;
        protected int maxHP;
        protected string[] faction;
        protected char[,] structure;

        

        public abstract bool death();
        public abstract override string ToString();

        public Building(int positionX, int positionY, int hp, string[] faction, char[,] structure)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.hp = hp;
            this.faction = faction;
            this.structure = structure;
        }
    }

}
