using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utopia2.Models;

namespace Utopia2
{
    class PlayerStats
    {
        string nome;
        Stats stats;

        public string Nome { get => nome; set => nome = value; }
        public Stats Stats { get => stats; set => stats = value; }
    }
}
