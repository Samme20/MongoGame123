using Microsoft.Xna.Framework.Graphics;

namespace BitcoinMiner.Screens
{
    public interface IScreen
    {
        ScreenType ScreenType { get; }
        void Update(float delta);

        void Draw(SpriteBatch spriteBatch);


    }
}
