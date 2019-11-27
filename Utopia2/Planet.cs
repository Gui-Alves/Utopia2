using System;
using System.Diagnostics;
using Otter;

namespace Utopia2
{
    public class Planet : Entity
    {
        public ImageEntity image;
        public Planet(int x, int y)
        {
            Position = new Vector2(x: x, y: y);
            image =  new ImageEntity(x, y, "Images/OTIMO.png");
        }

        public override void Update()
        {
            base.Update();
            int eco;
            eco = PlayerStats.stats.Eco;
            
            if(eco > 75)
                image.changePath("Images/OTIMO.png");
            if(eco <= 75 && eco > 50)
                image.changePath("Images/BOM.png");
            if(eco <= 50 && eco > 25)
                image.changePath("Images/RUIM.png");
            if(eco <= 25)
                image.changePath("Images/PESSIMO.png");
        }
    }
}