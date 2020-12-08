using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace ECS.Graphics
{
    public class Assets
    {
        private const int WIDTH = 64, HEIGHT = 64;

        public Texture2D grass, dirt;

        public Assets(GraphicsDevice g)
        {
            Texture2D spriteSheet = Graphics.LoadTexture2D("test", g);

            grass = Graphics.TileSplicer2D(WIDTH * 2, 0, WIDTH, HEIGHT, spriteSheet, g);
            dirt = Graphics.TileSplicer2D(WIDTH, 0, WIDTH, HEIGHT, spriteSheet, g);
        }
    }
}
