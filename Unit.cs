using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    abstract class Unit
    {
        //Protected definitions
        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected int maxHealth;
        protected int speed;
        protected int attack;
        protected int atkRange;
        protected char[,] team;
        protected bool ifAtk;
        protected string[] unit;

        //Constructers
        public Unit(int xPosition, int yPosition, int health, int speed, int attack, int atkRange, char[,] team, bool ifAtk, string[] unit)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.atkRange = atkRange;
            this.team = team;
            this.ifAtk = ifAtk;
            this.unit = unit;
        }

        //Abstract Methods
        public abstract int movePosition();
        public abstract int combat();
        public abstract bool attackRange();
        public abstract int unitDistance();
        public abstract bool death();
        public abstract override string ToString();

    }
}
