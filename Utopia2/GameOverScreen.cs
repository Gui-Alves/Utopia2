using Otter;

namespace Utopia2
{
    public class GameOverScreen : Scene
    {
        public RichText titulo;
        public RichText desc;
        public GameOverScreen(string titulo, string descricao) : base()
        {
            ImageEntity a = new ImageEntity(640, 360, "Images/rsz_bg.jpg");
            a.Graphic.Alpha = 0.3f;
            Add(a);
            
            
            this.titulo = new RichText(titulo, 50);
            this.titulo.TextAlign = TextAlign.Center;
            this.titulo.SetPosition(10,-300);
            this.titulo.CenterOrigin();
            this.titulo.Color = Color.White;
            this.titulo.DefaultOutlineColor = Color.Black;
            this.titulo.DefaultOutlineThickness = 30;
            a.AddGraphic(this.titulo);
            
            desc = new RichText(descricao, 30);
            desc.TextAlign = TextAlign.Center;
            desc.SetPosition(10, 0);
            desc.CenterOrigin();
            desc.Color = Color.White;
            desc.DefaultOutlineColor = Color.Black;
            desc.DefaultOutlineThickness = 2;
            a.AddGraphic(desc);
            
            
        }
    }
}