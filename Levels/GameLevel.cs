using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace ATowerDefenceGame
{
    class GameLevel : ILevel
    {

        public GameLevel()
        {
            BackgroundColor = Color.LightBlue;

            int x = GameSettings.BaseWidth / 2 - 64 / 2;
            int y = GameSettings.FloorLevel - 64 * 5;

            Objects.Add(new Tower(0) { Position = new Rectangle(x, y, 64, 64) });
            y += 64;

            for (; y < GameSettings.FloorLevel; y += 64)
                Objects.Add(new Tower() { Position = new Rectangle(x, y, 64, 64) });
        }

        public override void Update(GameTime gameTime)
        {
            if (InputManager.KeyPressed(Keys.Space))
                AddObject(new EnemyKnight());

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            /*var rectangle = new Rectangle(0, 0, 1, GameSettings.BaseHeight);
            var thic = false;

            for (rectangle.X = 16; rectangle.X < GameSettings.BaseWidth; rectangle.X += 16)
            {
                rectangle.Width = thic ? 2 : 1;
                spriteBatch.DrawRectangle(rectangle, Color.Gray);
                thic = !thic;
            }

            rectangle = new Rectangle(0, 0, GameSettings.BaseWidth, 1);
            thic = false;
            for (rectangle.Y = 16; rectangle.Y < GameSettings.BaseHeight; rectangle.Y += 16)
            {
                rectangle.Height = thic ? 2 : 1;
                spriteBatch.DrawRectangle(rectangle, Color.Gray);
                thic = !thic;
            }*/

            base.Draw(gameTime, spriteBatch);

            spriteBatch.DrawRectangle(new Rectangle(0, GameSettings.FloorLevel, GameSettings.BaseWidth, GameSettings.BaseHeight - GameSettings.FloorLevel), Color.SandyBrown);
        }
    }
}