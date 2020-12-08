using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace ECS.ECS.Components
{
    class PlayerComponent : IComponent
    {
        public float Velocity = 200;

        public PlayerComponent()
        {
        }
    }
}
