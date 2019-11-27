using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utopia2.Models;

namespace Utopia2
{
    public static class PlayerStats
    {
        public static string nome;
        public static Stats stats;
        

        public static void AddStats(Stats statsToAdd)
        {
            stats.Eco = NumberLimit(stats.Eco + statsToAdd.Eco);
            stats.Mood = NumberLimit(stats.Mood + statsToAdd.Mood);
            stats.Pop = NumberLimit(stats.Pop + statsToAdd.Pop);
            stats.Tech = NumberLimit(stats.Tech + statsToAdd.Tech);
            stats.Year += 10;

            if (stats.Eco == 0)
            {
                GameManger.Apocalypse(Apocalypse.microEco);
                return;
            }
            if (stats.Mood == 0)
            {
                GameManger.Apocalypse(Apocalypse.microMood);
                return;
            }
            if (stats.Tech == 0)
            {
                GameManger.Apocalypse(Apocalypse.microTech);
                return;
            }
            if (stats.Pop == 0)
            {
                GameManger.Apocalypse(Apocalypse.microPop);
                return;
            }
            if (stats.Pop == 100)
                GameManger.Apocalypse(Apocalypse.macroPop);
            
        }

        public static void SetUp()
        {
            Random r = new Random();
            Stats setUp = new Stats(r.Next(20, 60), r.Next(20, 60),r.Next(20, 80),r.Next(20, 60),r.Next(20, 60));
            stats = setUp;
        }

        static int NumberLimit(int n)
        {
            if (n > 100)
                return 100;
            if (n < 0)
                return 0;
            return n;
        }
    }
}
