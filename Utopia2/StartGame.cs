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
            Task<Stats> s = f.Get(); 
            
            f.Post(s);

            var game = new Game("Utopia", 1280, 720, 60, true);


            var card = new Card(game);

            var scene = new Scene();
            scene.Add(new ImageEntity(640, 360, "rsz_bg.jpg"));
            scene.Add(card);
            scene.Add(card.firstOption);
            scene.Add(card.secondOption);
            

            game.Start(scene);
        }
    }
}