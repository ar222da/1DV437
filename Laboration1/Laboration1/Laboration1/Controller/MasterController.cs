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
        int frameWidth = 100;
        

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
            ballStartPosition.X = 0.5F;
            ballStartPosition.Y = 0.5F;
            ballSpeed.X = 0.6F;
            ballSpeed.Y = 0.8F;
            camera = new Camera(screenWidth, screenHeight, frameWidth);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ballTexture = Content.Load<Texture2D>("ball");

            ballSimulation = new BallSimulation(ballStartPosition, ballSpeed, 0.05F);
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

            //Rectangle ballRectangle = new Rectangle(100,100,32,32); 
            ballView.Draw((float)gameTime.ElapsedGameTime.TotalSeconds);
            /*spriteBatch.Begin();
            spriteBatch.Draw(ballTexture, ballRectangle, Color.White);
            spriteBatch.End();*/
            base.Draw(gameTime);
        }
    }
}
