
namespace Utopia2.Models
{
    class Solution
    {
        string descricao;

        Stats result;

        public string Descricao { get => descricao; set => descricao = value; }
        public Stats Result { get => result; set => result = value; }

        public Solution(string descricao, Stats result)
        {
            this.descricao = descricao;
            this.result = result;
        }
    }
}
