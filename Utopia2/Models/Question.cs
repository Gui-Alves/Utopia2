using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utopia2.Models;

namespace Utopia2.Models
{
    class Question
    {
        string texto;
        Stats preRequisitos;
        Solution opcao1;
        Solution opcao2;


        public string Texto { get => texto; set => texto = value; }
        public Stats PreRequisitos { get => preRequisitos; set => preRequisitos = value; }
        public Solution Opcao1 { get => opcao1; set => opcao1 = value; }
        public Solution Opcao2 { get => opcao2; set => opcao2 = value; }
    }
}
