using System.Data;
using System.Windows.Forms;
using Otter;
using Utopia2.Models;
using Utopia2.Services;
namespace Utopia2
{ 
    public static class GameManger
    {
        public static Game game;

        public static void AddGame(Game games)
        {
            game = games;
        }

        public static void AddToGameScene(Entity entity)
        {
            game.Scene.Add(entity);
        }
        
        public static void BuildACard()
        {
            //Get possible Questions from db
            
            
            //Choose wich Question to do the thing
            
            //Add Card to Scene
        }

        public static void Apocalypse(Apocalypse cause)
        {
            GameOverScreen a = new GameOverScreen("Oops", "Algo deu errado");
            if (cause == Utopia2.Apocalypse.macroPop)
            { 
                a = new GameOverScreen("Distopia de Superpopulação", "Seus habitantes conseguiram uma resistencia incrível ao longo dos anos" +
                                                                         "\n Tanto que sua população cresceu espontaneamente!" +
                                                                         "\n Claro que não há recursos para todos.. e Muitos morrerão de fome..." +
                                                                         "\n eventualmente lavando a anarquia... Mas pelo menos você foi eficiente!");
                
            }

            if (cause == Utopia2.Apocalypse.microPop)
            {
                a = new GameOverScreen("Distopia de Micropopulação",
                    "Espera... O quê? " +
                    "\n Como... Quando... Pra onde foi todo mundo?");
            }

            if (cause == Utopia2.Apocalypse.microEco)
            {
                a = new GameOverScreen("Distopia Ambiental",
                    "Ah, o clássico ''Eu não sabia que poluir os mares seria tão ruim!'' ou " +
                    "\n ''Eu não sabia que abelhas eram tão importantes!''... tsk tsk..." +
                    "\n Mas olhe pelo lado bom: por um breve momento \n na história aquela empresa multibilionária recebeu " +
                    "\n um crescimento de 0.001% em suas ações!!");
            }

            if (cause == Utopia2.Apocalypse.microMood)
            {
                a = new GameOverScreen("Distopia da infelicidade", 
                    "Quer dizer... Nenhuma distopia é muito feliz não é? " +
                    "\n devido às suas escolhas, o mundo se tornou rápido \n demais para se importar com o indivíduo" +
                    "\n Cidades inteiras sofreram com doenças mentais \n causadas pela falta de motivação" +
                    "\n Logo, ninguém mais sorria em sua nação");
            }

            if (cause == Utopia2.Apocalypse.microTech)
            {
                a = new GameOverScreen("Distopia da Derrota Técnológica", 
                    "Olha, eu te entendo: ciência é assustadora, certo? " +
                    "\n E se as máquinas se rebelarem?" +
                    "\n e se algum cientista louco inventar uma \n arma de destruição em massa? " +
                    "\n Não... Melhor ir devagar... Precaução nunca é demais certo?" +
                    "\n Sim, é sim. Boa sorte descobrindo a roda enquanto as outras espécies \n deste planeta visitam outras galáxias, primata");
            }
            
            game.SwitchScene(a);
        }
    }
}