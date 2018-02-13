using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATowerDefenceGame
{
    class Fireball : Projectile
    {
        public override Rectangle BoundingBox { get; }

        public Fireball(Vector2 position, Vector2 speed)
            : base(position, GameContent.Texture.Fireball)
        {
            Speed = speed;
        }

        public override void Update(GameTime gameTime)
        {
            var dt = (float) gameTime.ElapsedGameTime.TotalSeconds;
            Position += dt * Speed;
        }
    }
}