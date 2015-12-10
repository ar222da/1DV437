using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Laboration1.Model;
using Laboration1.View;

namespace Laboration1
{
    
    public class MasterController : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D ballTexture;
        Texture2D frameTexture;
        BallSimulation ballSimulation;
        BallView ballView;
        Camera camera;

        int screenWidth = 400;
        int screenHeight = 400;
        int frameWidth = 10;
        

        Vector2 ballStartPosition;
        Vector2 ballSpeed;
       

        public MasterController()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            graphics.PreferredBackBufferHeight = screenWidth;
            graphics.PreferredBackBufferWidth = screenHeight;
            graphics.ApplyChanges();
            ballStartPosition.X = 0.1F;
            ballStartPosition.Y = 0.9F;
            ballSpeed.X = 0.5F;
            ballSpeed.Y = 1.0F;
            camera = new Camera(screenWidth, screenHeight, frameWidth);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ballTexture = Content.Load<Texture2D>("ball");

            ballSimulation = new BallSimulation(ballStartPosition, ballSpeed, 0.06F);
            ballView = new BallView(ballSimulation, spriteBatch, ballTexture, frameTexture, camera);  
            base.Initialize();
        }

        protected override void LoadContent()
        {
            ballTexture = Content.Load<Texture2D>("ball");

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            ballSimulation.Update((float)gameTime.ElapsedGameTime.TotalSeconds);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            ballView.Draw((float)gameTime.ElapsedGameTime.TotalSeconds);            
            base.Draw(gameTime);
        }
    }
}
