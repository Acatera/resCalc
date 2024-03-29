﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace resourceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Defaults(); 
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Defaults.currentRecipeSet = Defaults.recipesIndustrialCraft;
            foreach (Recipe recipe in Defaults.recipesIndustrialCraft)
            {
                items.Items.Add(recipe.name);
            }
            items.SelectedIndex = 0;
        }

        private void doCalculateReqs()
        {
            title.Text = items.Text;
            Recipe recipe = Defaults.currentRecipeSet.Find(
                delegate(Recipe rcp)
                {
                    return rcp.name == items.Text;
                }
            );
            if (recipe != null)
            {
                required.Items.Clear();
                foreach (Part part in recipe.getConsolidatedRequiredMaterials((double)ammount.Value, trackBar1.Value))
                {
                    required.Items.Add(String.Format("{0} {1} ({2} stacks)", part.name, part.ammount, Math.Ceiling(part.ammount / 64 * 1000)/1000));
                }
            }
        }

        private void ammount_ValueChanged(object sender, EventArgs e)
        {
            doCalculateReqs();
        }

        private void items_SelectedIndexChanged(object sender, EventArgs e)
        {
            doCalculateReqs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] copy = required.Items.OfType<String>().Select(x => "[ ] " + x.ToString()).ToArray();
            Clipboard.SetText(String.Join(Environment.NewLine, copy));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            doCalculateReqs();
        }

        private void btnIndustrialCraft_Click(object sender, EventArgs e)
        {
            Defaults.currentRecipeSet = Defaults.recipesIndustrialCraft;
            items.Items.Clear();
            foreach (Recipe recipe in Defaults.recipesIndustrialCraft)
            {
                items.Items.Add(recipe.name);
            }
            items.SelectedIndex = 0;
        }

        private void btnRailCraft_Click(object sender, EventArgs e)
        {
            Defaults.currentRecipeSet = Defaults.recipesRailCraft;
            items.Items.Clear();
            foreach (Recipe recipe in Defaults.recipesRailCraft)
            {
                items.Items.Add(recipe.name);
            }
            items.SelectedIndex = 0;
        }
    }
}
