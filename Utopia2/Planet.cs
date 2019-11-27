using Otter;

namespace Utopia2
{
    public class Planet : Entity
    {
        private ImageEntity image;
        public Planet(int x, int y)
        {
            Position = new Vector2(x: x, y: y); 
            image =  new ImageEntity(400, 400, "Images/OTIMO.png");
        }

        public override void Update()
        {
            base.Update();
            var eco = PlayerStats.stats.Eco;
            if(eco > 75)
                image =  new ImageEntity(400, 400, "Images/OTIMO.png");
            if(eco <= 75 && eco > 50)
                image =  new ImageEntity(400, 400, "Images/BOM.png");
            if(eco <= 50 && eco > 25)
                image =  new ImageEntity(400, 400, "Images/RUIM.png");
            if(eco <= 25)
                image =  new ImageEntity(400, 400, "Images/PESSIMO.png");
        }
    }
}