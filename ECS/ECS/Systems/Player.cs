using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.ECS.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ECS.ECS.Systems
{
    class Player : System
    {
        public Player(Ecs ecs) : base(ecs)
        {
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in Components)
            {
                PlayerComponent player = (PlayerComponent) component.Value;
                TransformComponent transform = (TransformComponent) Ecs.GetSystem("Transform").GetComponent(component.Key);

                if (Keyboard.GetState().IsKeyDown(Keys.Up)) transform.Velocity.Y = -player.Velocity;
                if (Keyboard.GetState().IsKeyDown(Keys.Down)) transform.Velocity.Y = player.Velocity;
                if (Keyboard.GetState().IsKeyDown(Keys.Left)) transform.Velocity.X = -player.Velocity;
                if (Keyboard.GetState().IsKeyDown(Keys.Right)) transform.Velocity.X = player.Velocity;
            }
        }
    }
}
