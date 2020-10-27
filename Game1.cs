using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace MyProject
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D background;
        private Texture2D shuttle;
        private Texture2D earth;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            background = Content.Load<Texture2D>("stars"); // change these names to the names of your images
            shuttle = Content.Load<Texture2D>("shuttle");  // if you are using your own images.
            earth = Content.Load<Texture2D>("earth");

            // TODO: use this.Content to load your game content here
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
            GraphicsDevice.Clear(Color.BurlyWood);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(background, new Rectangle(0, 0, 800, 480), Color.White);
            _spriteBatch.Draw(earth, new Vector2(400, 240), Color.White);
            _spriteBatch.Draw(shuttle, new Vector2(450, 240), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
