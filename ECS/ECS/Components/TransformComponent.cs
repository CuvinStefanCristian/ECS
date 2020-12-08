using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace ECS.ECS.Components
{
    /// <summary>
    /// Componenta de Pozitie, Viteza si Rotatie
    /// </summary>
    class TransformComponent : IComponent
    {
        public Vector2 Position;
        public Vector2 Velocity;

        public float Rotation;
        public Vector2 Origin;

        public TransformComponent(Vector2 position, Vector2 velocity, float rotation, Vector2 origin)
        {
            Position = position;
            Velocity = velocity;

            Rotation = rotation;
            Origin = origin;
        }
    }
}
