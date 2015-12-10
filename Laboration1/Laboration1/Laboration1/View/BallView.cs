using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Laboration1.Model;

namespace Laboration1.View
{
    class BallView
    {
        private BallSimulation ballSimulation;
        private SpriteBatch spriteBatch;
        private Texture2D ballTexture;
        private Texture2D frameTexture;
        private Camera camera;

        

        public BallView(Model.BallSimulation ballSimulation, SpriteBatch spriteBatch, Texture2D ballTexture, Texture2D frameTexture, Camera camera)
        {
            this.ballSimulation = ballSimulation;
            this.spriteBatch = spriteBatch;
            this.ballTexture = ballTexture;
            this.frameTexture = frameTexture;
            this.camera = camera;
        }

        public void Draw(float elapsedTimeSeconds)
        {
            Rectangle topLine = new Rectangle(camera.Frame, camera.Frame, camera.Width - (2 * camera.Frame), 1);
            Rectangle leftLine = new Rectangle(camera.Frame, camera.Frame, 1 , camera.Height - (2 * camera.Frame));
            Rectangle rightLine = new Rectangle(camera.Width - camera.Frame, camera.Frame, 1, camera.Height - (2 * camera.Frame));
            Rectangle bottomLine = new Rectangle(camera.Frame, camera.Height - camera.Frame, camera.Width - (2 * camera.Frame), 1);

            int ballRectanglePointX = (int)(camera.toViewX(ballSimulation.Ball.centerPosition.X - ballSimulation.Ball.radius));
            int ballRectanglePointY = (int)(camera.toViewY(ballSimulation.Ball.centerPosition.Y - ballSimulation.Ball.radius));
            float ballDiameter = ballSimulation.Ball.radius * 2;
            int ballRectangleSideLengthX = (int)((camera.Width - 2 * camera.Frame) * ballDiameter);
            int ballRectangleSideLengthY = (int)((camera.Height -  2 * camera.Frame) * ballDiameter);

            Texture2D pixel = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);
            pixel.SetData<Color>(new Color[] { Color.White });
            
            Rectangle ballRectangle = new Rectangle(ballRectanglePointX, ballRectanglePointY, ballRectangleSideLengthX, ballRectangleSideLengthY);

            spriteBatch.Begin();
            spriteBatch.Draw(ballTexture, ballRectangle, Color.White);
            spriteBatch.Draw(pixel, topLine, Color.White);
            spriteBatch.Draw(pixel, leftLine, Color.White);
            spriteBatch.Draw(pixel, rightLine, Color.White);
            spriteBatch.Draw(pixel, bottomLine, Color.White);

            spriteBatch.End();
        }

    }
}
