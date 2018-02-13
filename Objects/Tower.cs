using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;

namespace ATowerDefenceGame
{
    class Tower : IObject
    {
        public static List<Tower> Towers = new List<Tower>();

        public static Tower GetBottomTower()
        {
            Tower tower = null;
            var max = 0;

            foreach (var _tower in Towers)
            {
                if (_tower.Position.Y > max)
                {
                    tower = _tower;
                    max = _tower.Position.Y;
                }
            }

            return tower;
        }

        public float Health { get; set;  }
        public Rectangle Position { get; set; }
        private Rectangle _sourceRectangle;

        private Texture2D _damageTexture;
        private List<Vector2> _damagePixels;
        private int _damagePixelsMax;

        public Tower(int index)
        {
            _sourceRectangle = new Rectangle(0, index * 32, 32, 32);
            _damageTexture = new Texture2D(GameSettings.GDManager.GraphicsDevice, 32, 32);

            _damagePixels = new List<Vector2>();
            var colors = new Color[GameContent.Texture.Tower.Width * GameContent.Texture.Tower.Height];
            GameContent.Texture.Tower.GetData<Color>(colors);
            for (int y = 0; y < 32; y++)
            {
                for (int x = 0; x < GameContent.Texture.Tower.Width; x++)
                {
                    var color = colors[(y + index * 32) * GameContent.Texture.Tower.Width + x];
                    if (color != Color.Transparent && color != Color.Black)
                        _damagePixels.Add(new Vector2(x, y));
                }
            }
            _damagePixelsMax = _damagePixels.Count;

            Towers.Add(this);
        }

        public Tower() : this((int)(RngGenerator.GetUInt32() % 4) + 1)
        {
            Health = 100f;
        }

        public void DealDamage(float damage)
        {
            Health -= damage;
            var pixelcount = Health * _damagePixelsMax / 100f;

            // make next pixel black
            while (pixelcount < _damagePixels.Count && pixelcount >= 0)
            {
                var colors = new Color[_damageTexture.Width * _damageTexture.Height];
                _damageTexture.GetData<Color>(colors);

                var pixeltoremove = RngGenerator.GetUInt32() % _damagePixels.Count;
                var pixel = _damagePixels[(int)pixeltoremove];
                colors[(int)(_damageTexture.Width * pixel.Y + pixel.X)] = Color.Black;
                _damagePixels.RemoveAt((int)pixeltoremove);

                _damageTexture.SetData<Color>(colors);
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(GameContent.Texture.Tower, Position, _sourceRectangle, Color.White);
            spriteBatch.Draw(_damageTexture, Position, Color.White);
        }
    }
}
