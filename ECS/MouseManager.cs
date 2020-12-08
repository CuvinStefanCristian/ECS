using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using ECS.ECS;
using ECS.ECS.Components;
using Microsoft.Xna.Framework.Input;

namespace ECS
{
    class MouseManager
    {
        private Dictionary<int, IComponent> _components = new Dictionary<int, IComponent>();

        private Ecs _ecs;
        private Control _control;

        public MouseManager(Ecs ecs, Control control)
        {
            _ecs = ecs;
            _control = control;
        }

        public void Update(MouseState state)
        {
            _components = _ecs.GetSystem("Transform").GetComponents();

            foreach (var component in _components)
            {
                TransformComponent transform = (TransformComponent) component.Value;
                if (Hover(state, (int) transform.Position.X, (int) transform.Position.Y, 64, 64))
                {
                    _control.Index = component.Key;
                    _control.UpdateControl();
                }
            }
        }

        private bool Hover(MouseState state, int x, int y, int width, int height)
        {
            if (state.LeftButton == ButtonState.Pressed)
            {
                if (state.X > x && state.X < x + width)
                {
                    return state.Y > y && state.Y < y + height;
                }
            }
            return false;
        }
    }
}
