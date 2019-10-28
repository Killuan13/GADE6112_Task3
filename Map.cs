using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    class Map
    {
        public Map(int createUnit)
        {

        }

        Random rng = new Random();
        char[,] map;
        char[,] unit;
        int xPosition;
        int yPosition;

        public void newUnits()
        {
            int maxX = 20;
            int maxY = 20;
            char[] fighter = { 'a', 'b', 'c', 'A', 'B', 'C' };
            fighter = new char[6];
            xPosition = rng.Next(0, maxX + 1);
            yPosition = rng.Next(0, maxY + 1);
            unit = new char[yPosition, xPosition];
            unit[yPosition, xPosition] = Convert.ToChar(rng.Next(0, fighter.Length));
        }

        public void battlefieldWithUnits()
        {
            char[,] map;
            int height = 20;
            int width = 20;
            map = new char[height, width];
            for (int k = 0; k < height; k++)
            {
                for (int j = 0; j < width; j++)
                {
                    map[k, j] = ',';
                    char[] fighter = { 'a', 'b', 'c', 'A', 'B', 'C' };
                    char[] teamMelee = new char[3];
                    teamMelee[0] = fighter[0];
                    teamMelee[1] = fighter[1];
                    teamMelee[2] = fighter[2];
                    char[] teamRange = new char[3];
                    teamRange[0] = fighter[3];
                    teamRange[1] = fighter[4];
                    teamRange[2] = fighter[5];
                    xPosition = rng.Next(0, j + 1);
                    yPosition = rng.Next(0, k + 1);
                    unit = new char[yPosition, xPosition];
                    unit[yPosition, xPosition] = Convert.ToChar(rng.Next(0, fighter.Length + 1));
                }
            }

        }
    }
}
