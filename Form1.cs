using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GADE_POE
{

    public partial class frmRTS : Form
    {
        public frmRTS()
        {
            InitializeComponent();
            
        }

        private void btnGame_Load(object sender, EventArgs e)
        {
           
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        public void printUnit (Unit u)
        {
            string unitType = u.GetType().ToString();
            string[] arr = unitType.Split('.');
            unitType = arr[arr.Length - 1];

            if (unitType == "Melee")
            {
                MeleeUnit temp = (MeleeUnit)u;
                cmbStats.Text = "I am a Melee fighter, my team is " + temp.Team;
            }
            else
            {
                RangedUnit temp = (RangedUnit)u;
                cmbStats.Text = "I am a Range fighter, my team is " + temp.Team;
                
            }
        }

        public char redraw()
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
                    lblMap.Text = Convert.ToString(map[k, j]) + "\n";
                }
            }
            return map[height, width];
        }

       

        

       

        private void frmRTS_Load(object sender, EventArgs e)
        {

        }

        public void Save()
        {
            FileStream fs = new FileStream("saves/saves.game", FileMode.Open, FileAccess.Read);
            StreamWriter reader = new StreamWriter(fs);
            int count = File.ReadAllLines("saves/saves.game").Length;
            reader.WriteLine(this);

            reader.Close();
            fs.Close();
        }

        private void btnSaveandRead_Click(object sender, EventArgs e)
        {
            Save();  
            
        }
    }
}







