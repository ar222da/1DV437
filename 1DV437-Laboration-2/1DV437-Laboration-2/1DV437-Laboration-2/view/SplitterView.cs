using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using _1DV437_Laboration_2.model;


namespace _1DV437_Laboration_2.view
{
    class SplitterView
    {
        private SplitterSystem splitterSystem;
        private SpriteBatch spriteBatch;
        private Texture2D particleTexture;
        private Camera camera;

        public SplitterView(SplitterSystem splitterSystem, ContentManager content, GraphicsDevice device)
        {
            this.splitterSystem = splitterSystem;
            this.spriteBatch = new SpriteBatch(device);
            this.camera = new Camera(device.Viewport);
            this.particleTexture = content.Load<Texture2D>("ball");
        }

        public void Draw (float elapsedTimeSeconds)
        {
            spriteBatch.Begin();
            
            for (int i = 0; i < 100; i++)
            {
                Vector2 screenPosition = camera.toView(splitterSystem.particles[i].centerPosition);
                spriteBatch.Draw(particleTexture, screenPosition, null, Color.White, 0f, Vector2.Zero, 0.2F, SpriteEffects.None, 0f);
            }

            spriteBatch.End();
        }

    }
}
