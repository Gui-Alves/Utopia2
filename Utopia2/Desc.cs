using Otter;

namespace Utopia2
{
    public class desc : Entity
    {
        private Text t;
        public desc(int PosX, int PosY, string desc)
        {
            Position = new Vector2(PosX, PosY);
            AddGraphic(new Image("Images/TEXT.png"));
            t = new Text(desc, 16);
            t.Color = Color.White;
            AddGraphics(t);
        }
    }
}