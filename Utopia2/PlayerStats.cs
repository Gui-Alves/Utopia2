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
            stats.Eco += statsToAdd.Eco;
            stats.Mood += statsToAdd.Mood;
            stats.Pop += statsToAdd.Pop;
            stats.Tech += statsToAdd.Tech;
            stats.Year += 10;
        }
    }
}
