using Otter;
using Utopia2.Models;

namespace Utopia2
{
    public class StatusWindow: Entity
    {
        private Stats status;
        private Text t;
        public StatusWindow(int PosX, int PosY)
        {
            status = new Stats(0,0,0,0,0);
            t = new Text(16);
            Position = new Vector2(PosX, PosY);
            AddGraphic(new Image("Images/TEXT.png"));
            AddGraphic(t);
        }

        public override void Update()
        {
            base.Update();
            status.Eco = FormatNumber(status.Eco, PlayerStats.stats.Eco);
            status.Mood = FormatNumber(status.Mood, PlayerStats.stats.Mood);
            status.Pop = FormatNumber(status.Pop, PlayerStats.stats.Pop);
            status.Tech = FormatNumber(status.Tech, PlayerStats.stats.Tech);
            status.Year = FormatNumber(status.Year, PlayerStats.stats.Year);

            t.String = "\n      Ecologia:   " + status.Eco + "\n      População:   " + status.Pop +
                       "\n      Tecnologia:   " + status.Tech + "\n      Felicidade:   " + status.Mood +
                       "\n\n           Ano:    " + status.Year;
            
        }

        private int FormatNumber(int i, int target)
        {
            if (i < target)
                i++;
            if (i > target)
                i--;
            return i;
        }
    }
}