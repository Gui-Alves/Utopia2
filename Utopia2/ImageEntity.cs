using Otter;

namespace Utopia2
{
    public class ImageEntity : Entity
    {
        public ImageEntity(float x, float y, string imagePath) : base(x, y)
        {
            // Create an Image using the path passed in with the constructor
            var image = new Image(imagePath);
            // Center the origin of the Image
            image.CenterOrigin();
            // Add the Image to the Entity's Graphic list.
            AddGraphic(image);
        }

        public void changePath(string imagePath)
        {
            var image = new Image(imagePath);
            image.CenterOrigin();
            AddGraphic(image);
        }
    }
}