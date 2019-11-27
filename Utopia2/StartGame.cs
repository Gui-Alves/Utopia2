using System.Data.SqlTypes;
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
            var card = new Card();

            var scene = new Scene();
            scene.Add(new ImageEntity(640, 360, "Images/rsz_bg.jpg"));
       
            
            scene.Add(card);
            scene.Add(card.firstOption);
            scene.Add(card.secondOption);

            game.Start(scene);
        }
    }
}