﻿using Otter;
using Utopia2.Models;

namespace Utopia2
{
    class CardOption : Entity
    {
        Text t;
        public CardOption(float x, float y)
        {
            Position = new Vector2(x, y);
            AddGraphic(Image.CreateRectangle(400, 100, Color.Random));
            t = new Text("Test Text", 16);

            t.Color = Color.White;
            AddGraphics(t);
        }
        public CardOption(float x, float y, Solution solution)
        {
            Position = new Vector2(x, y);
            AddGraphic(Image.CreateRectangle(400, 100, Color.Random));
            t = new Text(solution.Descricao, 16);

            t.Color = Color.White;
            AddGraphics(t);
        }
    }
}