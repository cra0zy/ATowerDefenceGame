using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATowerDefenceGame
{
    class Ground : IObject
    {
        public Rectangle Position;
        private Rectangle _sourceRectangle;

        public Ground(bool top, Rectangle position)
        {
            Position = position;
            _sourceRectangle = new Rectangle(
                (int)(RngGenerator.GetUInt32() % (GameContent.Texture.Ground.Width / 16)) * 16,
                top ? 0 : 16,
                16, 16
            );
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                GameContent.Texture.Ground,
                Position,
                _sourceRectangle,
                Color.White
            );
        }
    }
}