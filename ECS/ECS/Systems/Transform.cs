using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.ECS.Components;
using Microsoft.Xna.Framework;

namespace ECS.ECS.Systems
{
    class Transform : System
    {
        private float _delta;

        public Transform(Ecs ecs) : base(ecs)
        {
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in Components)
            {
                TransformLogic((TransformComponent) component.Value, gameTime);
            }
        }

        private void TransformLogic(TransformComponent component, GameTime gameTime)
        {
            _delta = (float) gameTime.ElapsedGameTime.TotalSeconds;

            component.Position.X += component.Velocity.X * _delta;
            component.Position.Y += component.Velocity.Y * _delta;

            component.Velocity = Vector2.Zero;
        }
    }
}
