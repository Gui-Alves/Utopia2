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
