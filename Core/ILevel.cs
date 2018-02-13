using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATowerDefenceGame
{
    class ILevel
    {
        public Color BackgroundColor;
        public List<IObject> Objects;
        private List<IObject> _newobjects;

        public ILevel()
        {
            Objects = new List<IObject>();
            _newobjects = new List<IObject>();
        }

        public void AddObject(IObject obj)
        {
            _newobjects.Add(obj);
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach(var obj in Objects)
                obj.Update(gameTime);

            while(_newobjects.Count > 0)
            {
                Objects.Add(_newobjects[0]);
                _newobjects.RemoveAt(0);
            }
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach(var obj in Objects)
                obj.Draw(gameTime, spriteBatch);
        }
    }
}