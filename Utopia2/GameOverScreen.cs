using Otter;
using Utopia2.Services;

namespace Utopia2
{
    public class GameOverScreen : Scene
    {
        public RichText titulo;
        public RichText desc;
        public RichText stats;
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
            desc.SetPosition(10, -100);
            desc.CenterOrigin();
            desc.Color = Color.White;
            desc.DefaultOutlineColor = Color.Black;
            desc.DefaultOutlineThickness = 2;
            a.AddGraphic(desc);
            
            stats = new RichText("Seus Status: " +
                                 "\n Ecologia : "+ PlayerStats.stats.Eco + 
                                 "\n População: "+ PlayerStats.stats.Pop +
                                 "\n Tecnologia: "+ PlayerStats.stats.Tech + 
                                 "\n Felicidade: "+ PlayerStats.stats.Mood +
                                 "\n ANO: "+PlayerStats.stats.Year, 30);
            stats.TextAlign = TextAlign.Center;
            stats.SetPosition(10,200);
            stats.CenterOrigin();
            stats.Color = Color.White;
            stats.DefaultOutlineColor = Color.Black;
            stats.DefaultOutlineThickness = 30;
            a.AddGraphic(stats);
            
            var f = new RealDatabaseService();
            f.Post(PlayerStats.stats);
        }

        public override void Update()
        {
            base.Update();
            
            if(Input.KeyPressed(Key.Any))
                GameManger.game.Close();
        }
    }
}