using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Laboration1.Model
{
    class BallSimulation
    {
        private Ball ball;
               
        public BallSimulation(Vector2 startPosition, Vector2 speed, float radius)
        {
            ball = new Ball(startPosition, speed, radius);
        }
        
        public void Update(float elapsedTimeSeconds)
        {
            ball.centerPosition.X += ball.speed.X * elapsedTimeSeconds;
            ball.centerPosition.Y += ball.speed.Y * elapsedTimeSeconds;
            
            if (ball.centerPosition.X + ball.radius > 1.0)
            {
                ball.speed.X = ball.speed.X * -1;
                ball.centerPosition.X = 1 - ball.radius;
            }

            if (ball.centerPosition.X - ball.radius < 0)
            {
                ball.speed.X = ball.speed.X * -1;
                ball.centerPosition.X = ball.radius;
            }

            if (ball.centerPosition.Y + ball.radius > 1.0)
            {
                ball.speed.Y = ball.speed.Y * -1;
            }

            if (ball.centerPosition.Y - ball.radius < 0)
            {
                ball.speed.Y = ball.speed.Y * -1;
            }

            
        }

        public Ball Ball
        {
            get
            {
                return ball;
            }
        }

    }
}
