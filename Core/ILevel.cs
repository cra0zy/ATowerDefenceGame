using System.Collections.Generic;
using ATowerDefenceGame.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATowerDefenceGame
{
    class ILevel
    {
        public Color BackgroundColor;

        public SafeList<IObject> Objects;

        public ILevel()
        {
            Objects = new SafeList<IObject>();
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach (var obj in Objects)
                obj.Update(gameTime);
           
            Objects.Commit();
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (var obj in Objects)
                obj.Draw(gameTime, spriteBatch);
        }
    }
}