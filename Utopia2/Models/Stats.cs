using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopia2.Models
{
    public class Stats
    {
        public Stats()
        {

        }
        public Stats(int tech, int eco, int pop, int mood, int year)
        {
            Tech = tech;
            Eco = eco;
            Pop = pop;
            Mood = mood;
            Year = year;
        }

        public int Tech{ get; set; }
        public int Eco { get; set; }
        public int Pop { get; set; }
        public int Mood { get; set; }
        public int Year { get; set; }
    }
}
