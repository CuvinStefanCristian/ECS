using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECS.ECS;
using ECS.ECS.Components;

namespace ECS
{
    public partial class Control : Form
    {
        public int Index = 0;

        private Game1 game;
        public Ecs _ecs;

        public Control()
        {
            InitializeComponent();

            game = new Game1(this);
            Thread gameThread = new Thread(game.Run);
            gameThread.Start();
        }

        private void btnAddDefault_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(mtbX.Text) && !String.IsNullOrWhiteSpace(mtbY.Text)) 
                _ecs._factory.AddDefaultEntity(int.Parse(mtbX.Text), int.Parse(mtbY.Text));
        }

        /// <summary>
        /// Legatura dintre Form si MonoGame
        /// </summary>
        public void UpdateControl()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateComponentList));
                return;
            }
        }

        /// <summary>
        /// Adauga listei din dreapta Componentele prezente in Entitatea Selectata
        /// </summary>
        public void UpdateComponentList()
        {
            lbEntityComp.Items.Clear();

            foreach (var system in _ecs.GetUpdateSystems())
            {
                if (system.Value.GetComponents().ContainsKey(Index)) lbEntityComp.Items.Add(system.Key);
            }

            foreach (var system in _ecs.GetRenderSystems())
            {
                if (system.Value.GetComponents().ContainsKey(Index)) lbEntityComp.Items.Add(system.Key);
            }

            LoadAvailableList();
        }

        /// <summary>
        /// Adauga listei din stanga Componentele Posibile de Adaugat Entitatii Selectate
        /// </summary>
        public void LoadAvailableList()
        {
            lbAllComp.Items.Clear();

            foreach (var system in _ecs.GetUpdateSystems())
            {
                lbAllComp.Items.Add(system.Key);
            }

            foreach (var system in _ecs.GetRenderSystems())
            {
                lbAllComp.Items.Add(system.Key);
            }
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            LoadAvailableList();
        }

        private void lbEntityComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbEntityComp.SelectedItem.Equals("Transform"))
            {
                _ecs.RemoveEntity(Index);
                lbEntityComp.Items.Clear();
                return;
            }

            if (lbEntityComp.SelectedItem.Equals("Player"))
            {
                _ecs.GetSystem("Player").RemoveComponentById(Index);
                lbEntityComp.Items.Remove(lbEntityComp.SelectedItem);
                return;
            }

            if (lbEntityComp.SelectedItem.Equals("Render"))
            {
                _ecs.GetSystem("Render").RemoveComponentById(Index);
                lbEntityComp.Items.Remove(lbEntityComp.SelectedItem);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbAllComp.SelectedItem.Equals("Player") && !_ecs.GetSystem("Player").GetComponents().ContainsKey(Index))
            {
                _ecs.GetSystem("Player").AddComponent(new PlayerComponent(), Index);
                lbEntityComp.Items.Add("Player");
            }

            if (lbAllComp.SelectedItem.Equals("Render") && !_ecs.GetSystem("Render").GetComponents().ContainsKey(Index))
            {
                _ecs.GetSystem("Render").AddComponent(new RenderComponent(_ecs._assets.dirt), Index);
                lbEntityComp.Items.Add("Render");
            }
        }

        private void btnChangeTexture_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("dirt"))
            {
                RenderComponent render = (RenderComponent) _ecs.GetSystem("Render").GetComponent(Index);
                render.Texture = _ecs._assets.dirt;
                _ecs.GetSystem("Render").GetComponents()[Index] = render;
            }

            if (comboBox1.SelectedItem.Equals("grass"))
            {
                RenderComponent render = (RenderComponent) _ecs.GetSystem("Render").GetComponent(Index);
                render.Texture = _ecs._assets.grass;
                _ecs.GetSystem("Render").GetComponents()[Index] = render;
            }
        }
    }
}
