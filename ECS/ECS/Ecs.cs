using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.ECS.Components;
using ECS.ECS.Systems;
using ECS.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ECS.ECS
{
    public class Ecs
    {
        private Dictionary<string,Systems.System> _updateSystems = new Dictionary<string, Systems.System>();
        private Dictionary<string,Systems.System> _renderSystems = new Dictionary<string, Systems.System>();

        public Assets _assets;
        public EntityFactory _factory;

        public Ecs(Assets assets)
        {
            _assets = assets;

            _updateSystems.Add("Player", new Player(this));
            _updateSystems.Add("Transform", new Transform(this));
            _renderSystems.Add("Render", new Renderer(this));

            _factory = new EntityFactory(this, _assets);
        }

        public void Update(GameTime gameTime)
        {
            ManageSystems();

            foreach (var system in _updateSystems)
            {
                system.Value.Update(gameTime);
            }
        }

        public void Render(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (var system in _renderSystems)
            {
                system.Value.Render(spriteBatch, gameTime);
            }
        }

        public void RemoveEntity(int id)
        {
            foreach (var system in _updateSystems)
            {
                system.Value.RemoveComponentById(id);
            }

            foreach (var system in _renderSystems)
            {
                system.Value.RemoveComponentById(id);
            }
        }

        public void ManageSystems()
        {
            foreach (var system in _updateSystems)
            {
                system.Value.ManageComponents();
            }

            foreach (var system in _renderSystems)
            {
                system.Value.ManageComponents();
            }
        }

        /// <summary>
        /// Cauta un Sistem in cele 2 liste si returneaza Sistemul cerut
        /// </summary>
        /// <param name="system"></param>
        /// <returns></returns>
        public Systems.System GetSystem(string system)
        {
            foreach (var sys in _updateSystems)
            {
                if (sys.Key.Equals(system)) return sys.Value;
            }

            foreach (var sys in _renderSystems)
            {
                if (sys.Key.Equals(system)) return sys.Value;
            }

            return null;
        }

        /// <summary>
        /// Functiile sunt folosite pentru Form-ul de Demonstratie
        /// </summary>
        /// <returns></returns>
#if DEBUG 
        public Dictionary<string, Systems.System> GetUpdateSystems()
        {
            return _updateSystems;
        }

        public Dictionary<string, Systems.System> GetRenderSystems()
        {
            return _renderSystems;
        }
#endif
    }
}
