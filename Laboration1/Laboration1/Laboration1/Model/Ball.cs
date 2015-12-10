using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Laboration1.Model
{
    class Ball
    {
        public Vector2 centerPosition;
        public Vector2 speed;
        public float radius;

        public Ball(Vector2 centerPosition, Vector2 speed, float radius)
        {
            this.centerPosition.X = centerPosition.X;
            this.centerPosition.Y = centerPosition.Y;
            this.speed.X = speed.X;
            this.speed.Y = speed.Y;
            this.radius = radius;
        }

    }
}
