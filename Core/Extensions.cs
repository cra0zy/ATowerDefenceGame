using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATowerDefenceGame
{
    public static class Extensions
    {
        public static void DrawRectangle(this SpriteBatch spriteBatch, Rectangle rec, Color color)
        {
            spriteBatch.Draw(GameContent.Texture.Pixel, rec, color);
        }
    }
}