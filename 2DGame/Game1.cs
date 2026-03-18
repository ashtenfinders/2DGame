using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReusableEngineComponents;

namespace _2DGame
{
    public class Game1 : Core
    {

        private Texture2D _logo;



        public Game1(): base("Snake Game", 1280, 720, false)
        {
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {

            // TODO: use this.Content to load your game content here
            _logo = Content.Load<Texture2D>("images/logo");
           
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SpriteBatch.Begin();
            SpriteBatch.Draw(_logo, new Vector2((Window.ClientBounds.Width * 0.5f) - (_logo.Width * 0.5f),
            (Window.ClientBounds.Height * 0.5f) - (_logo.Height * 0.5f)),  Color.White);

            SpriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
