using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace BitcoinMiner.Screens
{
    class SplashScreen : IScreen
    {
        private readonly Texture2D _splashImage;

        public SplashScreen(Texture2D splashImage)
        {
            _splashImage = splashImage;
        }

        public ScreenType ScreenType => ScreenType.Splash;

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            var origin = new Vector2(_splashImage.Width / 2f, _splashImage.Height / 2f);


            spriteBatch.Draw(
                _splashImage,
                new Vector2(Game1.ScreenWidth / 2f, Game1.ScreenHeight / 2f),
                null,
                Color.White,
                (float)Math.PI / 4f,
                origin,
                1f,
                SpriteEffects.None,
                0f
            );

            spriteBatch.End();
        }

        public void Update(float delta)
        {
            
        }
    }
}
