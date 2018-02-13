using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ATowerDefenceGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = GameSettings.BaseWidth;
            graphics.PreferredBackBufferHeight = GameSettings.BaseHeight;
            graphics.IsFullScreen = true;
            graphics.HardwareModeSwitch = false;

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Window.Title = "A Tower Defence Game";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            GameSettings.GDManager = graphics;

            GameContent.Init(Content, GraphicsDevice);
            LevelManager.Init(graphics);
            LevelManager.LoadLevel(new BootLevel(GraphicsDevice), false);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            InputManager.Update();
            LevelManager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(LevelManager.BackgroundColor);
            LevelManager.Draw(gameTime, spriteBatch);

            spriteBatch.Begin();
            spriteBatch.Draw(LevelManager.ScreenSpace, new Rectangle(0, 0, Window.ClientBounds.Width, Window.ClientBounds.Height), null, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
