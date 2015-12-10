using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace _1DV437_Laboration_2.model
{
    class SplitterParticle
    {
        public Vector2 centerPosition;
        public Vector2 velocity;
        public float gravity = 1.82F;
        
        public SplitterParticle(Vector2 startPosition, Vector2 velocity)
        {
            centerPosition = startPosition;
            this.velocity = velocity;
        }

        public void Update(float elapsedTimeSeconds)
        {
            velocity.Y += gravity * elapsedTimeSeconds;
            centerPosition += velocity * elapsedTimeSeconds;
        }
        


    }
}
