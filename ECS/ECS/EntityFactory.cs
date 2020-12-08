using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using ECS.ECS.Components;
using ECS.Graphics;
using Microsoft.Xna.Framework;

namespace ECS.ECS
{
    public class EntityFactory
    {
        private int Id = 0;

        private Ecs _ecs;
        private Assets _assets;

        public EntityFactory(Ecs ecs, Assets assets)
        {
            _ecs = ecs;
            _assets = assets;

            Init();
        }

        public void Init()
        {
            _ecs.GetSystem("Player").AddComponent(new PlayerComponent(), Id);

            _ecs.GetSystem("Transform").AddComponent(new TransformComponent(
                new Vector2(100, 100),
                new Vector2(0, 0),
                0.0f,
                new Vector2(0, 0)
            ), Id);

            _ecs.GetSystem("Render").AddComponent(new RenderComponent(_assets.grass), Id);

            Id++;
        }

        public void AddDefaultEntity(int x, int y)
        {
            _ecs.GetSystem("Transform").AddComponent(new TransformComponent(
                new Vector2(x, y),
                new Vector2(0, 0),
                0.0f,
                new Vector2(0, 0)
            ), Id);

            _ecs.GetSystem("Render").AddComponent(new RenderComponent(_assets.grass), Id);

            Id++;
        }

        public int GetNextId()
        {
            return Id++;
        }
    }
}
