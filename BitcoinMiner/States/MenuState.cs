using BitcoinMiner.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinMiner.States
{
    public class MenuState : State
    {
        private List<Component> _components;

        public MenuState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button1");
            var buttonFont = _content.Load<SpriteFont>("Fonts/gameFont");

            var newGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(580, 400),
                Text = "Play",
            };

            newGameButton.Click += NewGameButton_Click;


            var quitGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(580, 520),
                Text = "Quit",
            };

            quitGameButton.Click += QuitGameButton_Click;


            _components = new List<Component>()
            {
                newGameButton,
                quitGameButton,
            };

        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            _game.Exit();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new GameState(_game, _graphicsDevice, _content));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {
            //REMOVE SPRITES HEHEHEHE
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);
        }
    }
}
