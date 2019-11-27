using Otter;
using Utopia2.Models;

namespace Utopia2
{
    class Card : Entity
    {
        public CardOption firstOption;
        public CardOption secondOption;
        public Text t;

        public int cardSizex = 350;
        public int cardSizeY = 450;
        public Card(Game game,Question question)
        {
            Position = new Vector2(game.Width / 2, 50);
            AddGraphic(Image.CreateRectangle(cardSizex, cardSizeY, Color.White));
            Position = new Vector2(Position.X - Graphic.Width / 2, Position.Y);

            firstOption = new CardOption(Position.X, Graphic.Height - 100, question.Opcao1);
            secondOption = new CardOption(Position.X, Graphic.Height, question.Opcao2);
        }

        public Card(Game game)
        {
            Position = new Vector2(game.Width / 2, 50);
            AddGraphic(Image.CreateRectangle(cardSizex, cardSizeY, Color.White));
            Position = new Vector2(Position.X - Graphic.Width / 2, Position.Y);

            firstOption = new CardOption(Position.X, Graphic.Height - 100);
            secondOption = new CardOption(Position.X, Graphic.Height);
        }


        public override void Update()
        {
            base.Update();

            if (Input.KeyPressed(Key.Any)){
               
            }
        }
    }
}