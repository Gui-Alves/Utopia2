﻿using Otter;
using Utopia2.Models;

namespace Utopia2
{
    public class StatusWindow: Entity
    {
        private string[] prefixes;
        
        private string losing;
        private string winning;
        private string shake;
        private Stats status;
        private RichText t;
        public StatusWindow(int PosX, int PosY)
        {
            losing = "{color:f00}";
            winning = "{color:0f0}";
            shake = "{shake:1}";
            prefixes = new string[5];
            status = new Stats(0,0,0,0,0);
            t = new RichText(16);
            Position = new Vector2(PosX, PosY);
            AddGraphic(new Image("Images/TEXT.png"));
            AddGraphic(t);
        }

        public override void Update()
        {
            base.Update();
            status.Eco = FormatNumber(status.Eco, PlayerStats.stats.Eco, 0);
            status.Mood = FormatNumber(status.Mood, PlayerStats.stats.Mood, 1);
            status.Pop = FormatNumber(status.Pop, PlayerStats.stats.Pop, 2);
            status.Tech = FormatNumber(status.Tech, PlayerStats.stats.Tech, 3);
            status.Year = FormatNumber(status.Year, PlayerStats.stats.Year, 4);
            
            t.String = "\n      Ecologia:   "+prefixes[0] + status.Eco + "{clear}\n      População:   " +prefixes[2] + status.Pop +
                       "{clear}\n      Tecnologia:   " + prefixes[3]+ status.Tech + "{clear}\n      Felicidade:   " +prefixes[1]+ status.Mood +
                       "{clear}\n\n           Ano:    " + status.Year;
            //t.String = "Hello, {color:f00}Ecologia:{clear} {shake:0}Shaking text!";
            if (status.Eco == PlayerStats.stats.Eco && status.Mood == PlayerStats.stats.Mood && 
                status.Year == PlayerStats.stats.Year && status.Pop == PlayerStats.stats.Pop && 
                status.Tech == PlayerStats.stats.Tech)
            {
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


        }

        private int FormatNumber(int i, int target, int n)
        {
            string a;
            if (i < target)
            {
                i++;
                a = winning;
            }
            else if (i > target)
            {
                i--;
                a = losing;
            }
            else
                a = "{color:fff}";

            prefixes[n] = a;
            return i;
        }
    }
}