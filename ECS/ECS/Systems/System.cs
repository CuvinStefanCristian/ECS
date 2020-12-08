using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.ECS.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ECS.ECS.Systems
{
    /// <summary>
    /// Clasa Baza a Sustemelor
    /// 
    /// Contine toata logica necesara managerierii Componentelor
    /// </summary>
    //TODO: O parte din logica Sistemelor trebuie mutata intr-o Clasa de Management (ex: Updatarea listelor de componente)
    public abstract class System
    {
        protected Dictionary<int, IComponent> Components = new Dictionary<int, IComponent>();

        protected Dictionary<int, IComponent> MarkedForAddition = new Dictionary<int, IComponent>();
        protected List<int> MarkedForRemoval = new List<int>();

        protected Ecs Ecs;

        protected System(Ecs ecs)
        {
            Ecs = ecs;
        }

        /// <summary>
        /// Folosita de Toate Sistemele pentru a procesa datele din Componente
        /// </summary>
        /// <param name="gameTime"></param>
        public abstract void Update(GameTime gameTime);

        /// <summary>
        /// Folosita pentru Sistemele ce trebuie sa Randeze Componente pe ecran. (Functie Optionala)
        /// </summary>
        /// <param name="spriteBatch"></param>
        /// <param name="gameTime"></param>
        public virtual void Render(SpriteBatch spriteBatch, GameTime gameTime)
        {
            
        }

        public IComponent GetComponent(int id)
        {
            return Components[id];
        }

        public void AddComponent(IComponent component, int id)
        {
            MarkedForAddition[id] = component;
            Console.WriteLine("component added");
        }

        public void RemoveComponent(IComponent component)
        {
            for (int i = 0; i < Components.Count; i++)
            {
                if (Components[i] == component) MarkedForRemoval.Add(i);
            }
        }

        public void RemoveComponentById(int id)
        {
            MarkedForRemoval.Add(id);
        }

        public void RemoveAllComponents()
        {
            foreach (var component in Components)
            {
                MarkedForRemoval.Add(component.Key);
            }
        }

        /// <summary>
        /// Updateaza continutul listelor de componente folosind listele de adaugare sau de stergere
        /// </summary>
        public void ManageComponents()
        {
            foreach (var component in MarkedForAddition)
            {
                Components[component.Key] = component.Value;
                Console.WriteLine(component.Key);
            }

            foreach (var id in MarkedForRemoval)
            {
                Components.Remove(id);
            }

            MarkedForAddition.Clear();
            MarkedForRemoval.Clear();
        }

        public bool HasComponents()
        {
            return Components.Count > 0;
        }

#if DEBUG
        public Dictionary<int, IComponent> GetComponents()
        {
            return Components;
        }
#endif   
    }
}
