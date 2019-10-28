using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    class MeleeUnit : Unit
    {
        //Constructers
        public MeleeUnit(int xPosition, int yPosition, int health, int speed, int attack, int atkRange, char[,] team, bool ifAtk, string[] unit) : base(xPosition, yPosition, health, speed, attack, atkRange, team, ifAtk, unit)
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

        //Accessors
        public int XPosition { get => base.xPosition; set => base.xPosition = value; }
        public int YPosition { get => base.yPosition; set => base.yPosition = value; }
        public int Health { get => base.health; set => base.health = value; }
        public int Speed { get => base.speed; }
        public int Attack { get => base.attack; set => base.attack = value; }
        public int AtkRange { get => base.atkRange; set => base.atkRange = value; }
        public char[,] Team { get => base.team; }
        public int MaxHealth { get => base.maxHealth; }
        public string[] Unit { get => base.unit; }

        //Methods
        public override int movePosition()
        {
            int direction = 0;
            switch (direction)
            {
                case 1:
                    {
                        yPosition -= 1;
                        break;
                    }
                case 2:
                    {
                        yPosition += 1;
                        break;
                    }
                case 3:
                    {
                        xPosition -= 1;
                        break;
                    }
                case 4:
                    {
                        xPosition += 1;
                        break;
                    }
            }
            return direction;
        }
        public override int combat()
        {
            int returnVal;
            health -= attack;
            returnVal = health;
            return returnVal;
        }
        public override bool attackRange()
        {
            int distance = 0;
            if (distance <= 1)
            {
                ifAtk = true;
            }
            else
            {
                ifAtk = false;
            }
            return ifAtk;
        }
        public override int unitDistance()
        {

        }
        public override bool death()
        {
            bool isDead;
            if (health >= 0)
            {
                isDead = true;
            }
            else
            {
                isDead = false;
            }
            return isDead;
        }

        public override string ToString()
        {
            string combatStats = "Max HP: " + maxHealth + "Current HP: " + health + "\n" + "Unit: " + unit + "\n" + "Team: " + team + "\n" + "Attack: " + attack + "Attack range: " + atkRange + "\n" + "Speed: " + speed;
            return combatStats;
        }
    }
}
