using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.ECS.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ECS.ECS.Systems
{
    class Renderer : System
    {
        public Renderer(Ecs ecs) : base(ecs)
        {
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Render(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (var component in Components)
            {
                RendererLogic(component, spriteBatch);
            }
        }

        private void RendererLogic(KeyValuePair<int, IComponent> component, SpriteBatch spriteBatch)
        {
            RenderComponent render = (RenderComponent) component.Value;
            TransformComponent transform = (TransformComponent) Ecs.GetSystem("Transform").GetComponent(component.Key);

            spriteBatch.Draw(render.Texture, transform.Position, render.Texture.Bounds, 
                Color.White, transform.Rotation, transform.Origin, 1.0f, SpriteEffects.None, 1);
        }
    }
}
