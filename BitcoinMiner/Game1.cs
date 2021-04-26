using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using BitcoinMiner.Screens;
using BitcoinMiner.Managers;

namespace BitcoinMiner
{
    public class Game1 : Game
    {
        public static int ScreenWidth = 1280;
        public static int ScreenHeight = 720;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private ScreenManager _screenManager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = ScreenWidth;
            _graphics.PreferredBackBufferHeight = ScreenHeight;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            var soundEffect = Content.Load<SoundEffect>("Content/splashSound");
            var splashImage = Content.Load<Texture2D>("Content/splashImage");

            soundEffect.Play();

            _screenManager = new ScreenManager(new IScreen[]
            {
                new SplashScreen(splashImage)
            });

            _screenManager.SetScreen(ScreenType.Splash);
            _screenManager.SwitchToNextScreen();

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }


            var delta = (float)(gameTime.ElapsedGameTime.TotalMilliseconds / 1000f);
            _screenManager.Update(delta);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Transparent);

            _screenManager.Draw(_spriteBatch);

            base.Draw(gameTime);
        }
    }
}
