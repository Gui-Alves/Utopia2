﻿using System;
using Otter;
using Utopia2.Models;

namespace Utopia2
{
    class Card : Entity
    {
        private Random r;
        public Question Question;
        public CardOption firstOption;
        public CardOption secondOption;
        public ImageEntity fundo;
        public desc desc;
        public Text t;

        
        public int cardSizex = 350;
        public int cardSizeY = 450;
        public Card(Question question)
        {
            Question = question;
            if (GameManger.game != null) Position = new Vector2(x: GameManger.game.Width / 2, y:50);
            //AddGraphic(Image.CreateRectangle(cardSizex, cardSizeY, Color.White));
            fundo = new ImageEntity(400, 314, "Images/IMG.png");
            fundo.Position = new Vector2(650, 200);
            //Position = new Vector2(x: Position.X - Graphic.Width / 2, y:Position.Y);
            desc = new desc(470, 360, "\n  "+ Question.Texto);

            firstOption = new CardOption(Position.X - 180, fundo.Position.Y + 320, question.Opcao1);
             secondOption = new CardOption(Position.X + 50, fundo.Position.Y + 320, question.Opcao2);
        }

        public Card()
        {
            r = new Random();
            if (GameManger.game != null) Position = new Vector2(x: GameManger.game.Width / 2, y:50);
            //AddGraphic(Image.CreateRectangle(cardSizex, cardSizeY, Color.White));
            fundo = new ImageEntity(400, 314, "Images/IMG.png");
            fundo.Position = new Vector2(650, 200);
            //Position = new Vector2(x: Position.X - Graphic.Width / 2, y:Position.Y);
            desc = new desc(470, 360, "\n  Rolar os dados? ");

            firstOption = new CardOption(Position.X - 180, fundo.Position.Y + 320);
            secondOption = new CardOption(Position.X + 50, fundo.Position.Y + 320);
        }


        public override void Update()
        {
            base.Update();
            
            if (Input.KeyPressed(Key.Left))
            {
                if(Question!=null)
                    PlayerStats.AddStats(Question.Opcao1.Result);
                else
                {
                    PlayerStats.AddStats(new Stats(r.Next(-20, 20),r.Next(-20, 20), r.Next(-20, 20), r.Next(-20, 20), r.Next(-20, 20)));
                }
                GameManger.BuildACard();
                RemoveAll();
                
            }
            
            if (Input.KeyPressed(Key.Right)){
                if(Question!=null)
                    PlayerStats.AddStats((Question.Opcao2.Result));
                else
                {
                    PlayerStats.AddStats(new Stats(r.Next(-20, 20),r.Next(-20, 20), r.Next(-20, 20), r.Next(-20, 20), r.Next(-20, 20)));
                }
                GameManger.BuildACard();
                RemoveAll();
            }

            if (Input.KeyPressed(Key.R))
            {
                PlayerStats.AddStats(new Stats(r.Next(-20, 20),r.Next(-20, 20), r.Next(-20, 20), r.Next(-20, 20), r.Next(-20, 20)));
                GameManger.BuildACard();
                RemoveAll();
            }
        }

        void RemoveAll()
        {
            firstOption.RemoveSelf();
            secondOption.RemoveSelf();
            desc.RemoveSelf();
            fundo.RemoveSelf();
            RemoveSelf();
        }
    }
}