using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ECS.Graphics
{
    class Graphics
    {
        public static Texture2D LoadTexture2D(String s, GraphicsDevice g)
        {
            FileStream fileStream = new FileStream(s + ".png", FileMode.Open);
            Texture2D spriteAtlas = Texture2D.FromStream(g, fileStream);
            fileStream.Dispose();

            return spriteAtlas;
        }

        public static Texture2D TileSplicer2D(int x, int y, int width, int height, Texture2D texture, GraphicsDevice g)
        {
            Rectangle rec = new Rectangle(x, y, width, height);
            Texture2D tmp = new Texture2D(g, rec.Width, rec.Height);
            int count = rec.Width * rec.Height;
            Color[] color = new Color[count];
            texture.GetData(0, rec, color, 0, count);
            tmp.SetData(color);

            return tmp;
        }

        public static Texture2D[] AnimTile2D(int x, int y, int width, int height, int sliceWidth, Texture2D spriteSheet, GraphicsDevice g)
        {
            int slices = (int)(width / sliceWidth);
            Texture2D[] slicedTexture2D = new Texture2D[slices];
            Console.WriteLine(slicedTexture2D.Length);
            for (int i = 0; i < slices; i++)
            {
                slicedTexture2D[i] = TileSplicer2D(x + sliceWidth * i, y, sliceWidth, height, spriteSheet, g);
            }

            return slicedTexture2D;
        } 
    }
}
