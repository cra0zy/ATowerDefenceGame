using Microsoft.Xna.Framework;

namespace ATowerDefenceGame
{
    public struct Circle
    {
        public readonly Vector2 Position;
        public readonly float Radius;

        public Circle(Vector2 position, float radius)
        {
            Position = position;
            Radius = radius;
        }

        public Circle Offset(Vector2 dp)
        {
            return new Circle(Position + dp, Radius);
        }
    }
}