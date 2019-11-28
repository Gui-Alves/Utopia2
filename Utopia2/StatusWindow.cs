using Otter;
using Utopia2.Models;

namespace Utopia2
{
    public class StatusWindow: Entity
    {
        private string losing;
        private string winning;
        private string shake;
        private Stats status;
        private RichText t;
        public StatusWindow(int PosX, int PosY)
        {
            losing = "{color:f00}";
            winning = "";
            shake = "{shake:1}";
            status = new Stats(0,0,0,0,0);
            t = new RichText(16);
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
            
            t.String = "\n      Ecologia:   "+losing + status.Eco + "{clear}\n      População:   " + status.Pop +
                       "{clear}\n      Tecnologia:   " + status.Tech + "{clear}\n      Felicidade:   " + status.Mood +
                       "{clear}\n\n           Ano:    " + status.Year;
            //t.String = "Hello, {color:f00}Ecologia:{clear} {shake:0}Shaking text!";

            if (status.Eco == 0)
            {
                GameManger.Apocalypse(Apocalypse.microEco);
                return;
            }
            if (status.Mood == 0)
            {
                GameManger.Apocalypse(Apocalypse.microMood);
                return;
            }
            if (status.Tech == 0)
            {
                GameManger.Apocalypse(Apocalypse.microTech);
                return;
            }
            if (status.Pop == 0)
            {
                GameManger.Apocalypse(Apocalypse.microPop);
                return;
            }
            if (status.Pop == 100)
                GameManger.Apocalypse(Apocalypse.macroPop);

            
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