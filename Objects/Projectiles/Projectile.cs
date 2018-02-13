using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATowerDefenceGame
{
    abstract class Projectile : IObject
    {
        public float Damage;
        public Vector2 Speed;
        public Vector2 Position;
        public abstract Rectangle BoundingBox { get; }
        public Texture2D Texture { get; }
        private Vector2 _texCenter;

        public Projectile(Vector2 position, Texture2D texture)
        {
            Position = position;
            Texture = texture;
            _texCenter = new Vector2(Texture.Width / 2, Texture.Height / 2);
        }

        public void Hit(Enemy enemy)
        {
            enemy.Health -= Damage;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var rot = Speed.GetAngle();
            spriteBatch.Draw(Texture, Position, null, Color.White, rot, _texCenter, Vector2.One, SpriteEffects.None, 0f);
        }
    }
}