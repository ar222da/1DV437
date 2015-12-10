using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _1DV437_Laboration_2.view
{
    class Camera
    {
        public int scaleX;
        public int scaleY;

        public Camera(Viewport viewport)
        {
            scaleX = viewport.Width;
            scaleY = viewport.Height;
        }

        public Vector2 toView(Vector2 modelPosition)
        {
            Vector2 viewPosition;
            viewPosition.X = modelPosition.X * scaleX;
            viewPosition.Y = modelPosition.Y * scaleY;
            return viewPosition;
        }

    }
}
