using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration1.View
{
    class Camera
    {
        private int windowWidth;
        private int windowHeight;
        private int width;
        private int height;

        private int frame;

        public Camera(int width, int height, int frame)
        {
            this.width = width;
            this.height = height;
            this.frame = frame;
        }

        public int Width
        {
            get 
            {
                return width;
            }

            set
            {
                width = value;
            }

        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }

        }

        public int WindowWidth
        {
            get
            {
                return windowWidth;
            }

            set
            {
                windowWidth = value;
            }

        }

        public int WindowHeight
        {
            get
            {
                return windowHeight;
            }

            set
            {
                windowHeight = value;
            }

        }
        public int Frame
        {
            get
            {
                return frame;
            }
            set
            {
                frame = value;
            }
        }


        public float toViewX(float x)
        {
            return ((width - (2.0F * frame)) * x) + frame;
        }

        public float toViewY(float y)
        {
            return ((height - (2.0F * frame)) * y) + frame;
        }
        
    }
}
