using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace ECS.ECS.Components
{
    class RenderComponent : IComponent
    {
        public Texture2D Texture;

        public RenderComponent(Texture2D texture)
        {
            Texture = texture;
        }
    }
}
