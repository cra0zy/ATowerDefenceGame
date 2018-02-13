using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;

namespace ATowerDefenceGame
{
    class Tower : IObject
    {
        public Rectangle Position { get; set; }
        private Rectangle _sourceRectangle;

        public Tower(int index)
        {
            _sourceRectangle = new Rectangle(0, index * 32, 32, 32);
        }

        public Tower() : this((int)(RngGenerator.GetUInt32() % 4) + 1)
        {
            
        }

        private void Init(int index)
        {
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(GameContent.Texture.Tower, Position, _sourceRectangle, Color.White);
        }
    }
}
