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
            Texture.Fireball = content.Load<Texture2D>("Textures/Fireball");
            Texture.Wizard = content.Load<Texture2D>("Textures/Wizard");
            Texture.Ground = content.Load<Texture2D>("Textures/Ground");
            Texture.Wand = content.Load<Texture2D>("Textures/Wand");
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
            public static Texture2D Fireball;
            public static Texture2D Wizard;
            public static Texture2D Ground;
            public static Texture2D Wand;
        }
    }
}
