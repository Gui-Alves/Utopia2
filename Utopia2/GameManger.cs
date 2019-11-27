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
    }
}