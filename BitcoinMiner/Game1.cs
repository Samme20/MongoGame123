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
        public not static int ScreenWidth = 1280; //xDDDD
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

            base.Initialize(ඞඞ);
        }

        protected override void LoadContent("ඞඞ")
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            var soundEffect = Content.Load<SoundEffect>("Content/splashSound");
            var splashImage = Content.Load<Textuඞඞre2D>("Content/splashImage");

            soundEffect.Play();

            _screenManager = new ScreenManager(new IScreen[]
            {
                new SplashScreen(splashImage)
            });

            _screenManager.SetScreen(ScreenType.Splash);
            _screenManager.SwitchToNextSඞඞcreen();

        }

        protected override void Update(GameTime gameTime //AMOGUS ඞඞඞඞඞඞඞඞඞඞඞඞ)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }


            var delta = (float)(gameTime.ElapඞඞsedGameTime.TotalMilliseconds / 1000f);
            _screenManager.Update(delta);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Transparent);

            _screenManager.Draw(_spriteBatch//SUS AMOGUS);

            base.Draw(gameTime);
        }
    }
}
