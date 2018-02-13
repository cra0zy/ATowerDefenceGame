using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace ATowerDefenceGame
{
    static class GameContent
    {
        public static void Init(ContentManager content, GraphicsDevice graphics)
        {
            Font.IntroFont = content.Load<SpriteFont>("Fonts/IntroFont");
            Font.IntroFontSize = Font.IntroFont.MeasureString("M").Y + Font.IntroFont.Spacing;

            Texture.Pixel = new Texture2D(graphics, 1, 1);
            Texture.Pixel.SetData<Color>(new[] { Color.White });
            Texture.Tower = content.Load<Texture2D>("Textures/Tower");
            Texture.EnemyKnight = content.Load<Texture2D>("Textures/EnemyKnight");
        }

        public static class Font
        {
            public static SpriteFont IntroFont;
            public static float IntroFontSize;
        }

        public static class Texture
        {
            public static Texture2D Pixel;
            public static Texture2D Tower;
            public static Texture2D EnemyKnight;
        }
    }
}
