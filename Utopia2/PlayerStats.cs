using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            stats.Eco = NumberLimit(stats.Mood + statsToAdd.Mood);
            stats.Eco = NumberLimit(stats.Pop + statsToAdd.Pop);
            stats.Eco = NumberLimit(stats.Tech + statsToAdd.Tech);
            stats.Year += 10;
        }

        public static void SetUp()
        {
            Stats setUp = new Stats();
            setUp.Eco = 70;
            setUp.Mood = 50;
            setUp.Pop = 30;
            setUp.Tech = 10;
            setUp.Year = 0;
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
