using System;
using Otter;
using Utopia2.Models;

namespace Utopia2
{
    class Card : Entity
    {
        public Question Question;
        public CardOption firstOption;
        public CardOption secondOption;
        public Text t;

        
        public int cardSizex = 350;
        public int cardSizeY = 450;
        public Card(Question question)
        {
            Question = question;
            if (GameManger.game != null) Position = new Vector2(x: GameManger.game.Width / 2, 50);
            AddGraphic(Image.CreateRectangle(cardSizex, cardSizeY, Color.White));
            Position = new Vector2(Position.X - Graphic.Width / 2, Position.Y);

            firstOption = new CardOption(Position.X, Graphic.Height - 100, question.Opcao1);
            secondOption = new CardOption(Position.X, Graphic.Height, question.Opcao2);
        }

        public Card()
        {
            if (GameManger.game != null) Position = new Vector2(x: GameManger.game.Width / 2, 50);
            AddGraphic(Image.CreateRectangle(cardSizex, cardSizeY, Color.White));
            Position = new Vector2(x: Position.X - Graphic.Width / 2, Position.Y);

            firstOption = new CardOption(Position.X, Graphic.Height - 100);
            secondOption = new CardOption(Position.X, Graphic.Height);
        }


        public override void Update()
        {
            base.Update();

            if (Input.KeyPressed(Key.Left))
            {
                if(Question!=null)
                    PlayerStats.AddStats(Question.Opcao1.Result);
                //RemoveAll();
                Position = new Vector2(Position.X - 10, Position.Y);

            }
            
            if (Input.KeyPressed(Key.Right)){
                if(Question!=null)
                    PlayerStats.AddStats((Question.Opcao2.Result));
                RemoveAll();
            }
        }

        void RemoveAll()
        {
            firstOption.RemoveSelf();
            secondOption.RemoveSelf();
            RemoveSelf();
        }
    }
}