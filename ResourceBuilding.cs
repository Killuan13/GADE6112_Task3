using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    public class ResourceBuilding : Building
    {
        //fields
        protected string[] resourceType;
        protected int resourceGen;
        protected int resourceGenPerRound;
        protected int resourcePool;

        //Accessors
        public string[] ResourceType { get => resourceType; }
        public int ResourceGen { get => resourceGen; set => resourceGen = value; }
        public int ResourceGenPerRound { get => resourceGenPerRound; }
        public int ResourcePool { get => resourcePool; }

        protected int PositionX { get => positionX; set => positionX = value; }
        protected int PositionY { get => positionY; set => positionY = value; }
        protected int Hp { get => hp; set => hp = value; }
        protected int MaxHP { get => maxHP; }
        protected string[] Faction { get => faction; }
        protected char[,] Structure { get => structure; }

        //Constructers

        public ResourceBuilding(int positionX, int positionY, int hp, string[] faction, char[,] structure) : base(positionX, positionY, hp, faction, structure)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.hp = hp;
            this.faction = faction;
            this.structure = structure;
        }

        

        public override bool death()
        {
            bool isDead;
            if (resourcePool >= 0)
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
            string combatStats = "Max HP: " + maxHP + "Current HP: " + hp +  "\n" + "Faction: " + faction + "\n" + "Resource Type: " + resourceType + "Resource Generated: " + resourceGen + "\n" + "Resources Generated Per Round: " + resourceGenPerRound + "\n" + "Resource Pool Remaining: " + resourcePool;
            return combatStats;
        }

        public void GenerateResources()
        {   
                resourceGen += resourceGenPerRound;
                resourcePool -= resourceGen;        
        }
    }
}
