using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading.Tasks;
using Otter;
using Utopia2.Models;
using Utopia2.Services;

namespace Utopia2
{
    internal class StartGame
    {
        public static void Main(string[] args)
        {
            var f = new RealDatabaseService();

            var game = new Game("Utopia", 1280, 720, 60, true);
            GameManger.AddGame(game);

            var scene = new Scene();
            scene.Add(new ImageEntity(640, 360, "Images/rsz_bg.jpg"));
            
            PlayerStats.SetUp();
            
            var card = new Card();
            scene.Add(card);
            scene.Add(card.desc);
            scene.Add(card.fundo);
            scene.Add(card.firstOption);
            scene.Add(card.secondOption);
            
            var StWin = new StatusWindow(game.Width - 400, game.Height/2);
            scene.Add(StWin);
            
            var a = new Planet(250, game.Height/2);
            scene.Add(a);
            scene.Add(a.image);


            game.Start(scene);
            
            //GameManger.AddToGameScene(new Planet(40, game.Height / 2));
        }
    }
}