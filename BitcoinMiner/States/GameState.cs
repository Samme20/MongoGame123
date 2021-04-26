using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using BitcoinMiner.Controls;
using BitcoinMiner.States;


namespace BitcoinMiner.States
{
    public class GameState : State
    {
        public GameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            var Gamefont = _content.Load<SpriteFont>("Fonts/gameFont");
            //Sprites
            var myShip = _content.Load<Texture2D>("sprites/ship");
            var coin = _content.Load<Texture2D>("sprites/coin");
            var enemyShip = _content.Load<Texture2D>("sprites/tripod");
            var bullet = _content.Load<Texture2D>("sprites/bullet");

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
        }

        public override void PostUpdate(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
