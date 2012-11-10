using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace resourceCalculator
{
    class Defaults
    {
        public static List<Recipe> currentRecipeSet = null;
        public static List<Recipe> recipesIndustrialCraft = new List<Recipe>();
        public static List<Recipe> recipesRailCraft = new List<Recipe>();

        public Defaults()
        {
            addIndustrialCraftRecipes();
            addRailCraftRecipes();
            

            // recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
        }

        private void addRailCraftRecipes()
        {
            //recipesRailCraft.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipesRailCraft.Add(new Recipe("Iron Plate", new Part[] { new Part("Iron", 9)}, 8));
            recipesRailCraft.Add(new Recipe("Iron Tank Wall", new Part[] { new Part("Iron Plate", 4) }, 4));
        }

        private void addIndustrialCraftRecipes()
        {
            //Vanilla
            recipesIndustrialCraft.Add(new Recipe("Plank", new Part[] { new Part("Log", 1) }, 4));
            recipesIndustrialCraft.Add(new Recipe("Stick", new Part[] { new Part("Plank", 2) }, 4));
            recipesIndustrialCraft.Add(new Recipe("Lever", new Part[] { new Part("Stick", 1), new Part("Cobblestone", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Furnace", new Part[] { new Part("Cobblestone", 8) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Chest", new Part[] { new Part("Plank", 8) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Lapis Lazuli Block", new Part[] { new Part("Lapis Lazuli", 9) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Iron Chestplate", new Part[] { new Part("Iron", 8) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Leather Tunic", new Part[] { new Part("Leather", 8) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Iron Bars", new Part[] { new Part("Iron", 6) }, 16));

            //Cables
            recipesIndustrialCraft.Add(new Recipe("Tin Cable", new Part[] { new Part("Tin", 3) }, 9));
            recipesIndustrialCraft.Add(new Recipe("Copper Cable", new Part[] { new Part("Copper", 3), new Part("Rubber", 6) }, 6));
            recipesIndustrialCraft.Add(new Recipe("Gold Cable", new Part[] { new Part("Gold", 3) }, 12));
            recipesIndustrialCraft.Add(new Recipe("2xIns. Gold Cable", new Part[] { new Part("Gold Cable", 1), new Part("Rubber", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("HV Cable", new Part[] { new Part("Refined Iron", 3) }, 12));
            recipesIndustrialCraft.Add(new Recipe("4xIns. HV Cable", new Part[] { new Part("HV Cable", 1), new Part("Rubber", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Glass Fiber Cable", new Part[] { new Part("Glass", 6), new Part("Redstone", 2), new Part("Diamond", 1) }, 4));
            recipesIndustrialCraft.Add(new Recipe("Detector Cable", new Part[] { new Part("4xIns. HV Cable", 1), new Part("Redstone", 3), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Splitter Cable", new Part[] { new Part("4xIns. HV Cable", 2), new Part("Redstone", 2), new Part("Lever", 1) }, 1));

            //EU Storage
            recipesIndustrialCraft.Add(new Recipe("BatBox", new Part[] { new Part("Plank", 5), new Part("Copper Cable", 1), new Part("RE Battery", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("MFE Unit", new Part[] { new Part("Energy Crystal", 4), new Part("2xIns. Gold Cable", 4), new Part("Machine", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("MFS Unit", new Part[] { new Part("Lapotron Crystal", 6), new Part("Advanced Circuit", 1), new Part("MFE Unit", 1), new Part("Advanced Machine", 1) }, 1));

            //Items
            recipesIndustrialCraft.Add(new Recipe("RE Battery", new Part[] { new Part("Copper Cable", 1), new Part("Tin", 4), new Part("Redstone", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Energy Crystal", new Part[] { new Part("Redstone", 8), new Part("Diamond", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Lapotron Crystal", new Part[] { new Part("Lapis Lazuli", 6), new Part("Electronic Circuit", 2), new Part("Energy Crystal", 1) }, 1));

            //Transformers
            recipesIndustrialCraft.Add(new Recipe("LV Transformer", new Part[] { new Part("Plank", 4), new Part("Copper", 3), new Part("Copper Cable", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("MV Transformer", new Part[] { new Part("Machine", 1), new Part("2xIns. Gold Cable", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("HV Transformer", new Part[] { new Part("Electronic Circuit", 1), new Part("MV Transformer", 1), new Part("4xIns. HV Cable", 2), new Part("Energy Crystal", 1) }, 1));

            //Machine Components
            recipesIndustrialCraft.Add(new Recipe("Machine", new Part[] { new Part("Refined Iron", 8) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Advanced Machine", new Part[] { new Part("Advanced Alloy", 2), new Part("Carbon Plate", 2), new Part("Machine", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Electronic Circuit", new Part[] { new Part("Copper Cable", 6), new Part("Refined Iron", 1), new Part("Redstone", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Advanced Circuit", new Part[] { new Part("Electronic Circuit", 1), new Part("Redstone", 4), new Part("Glowstone Dust", 2), new Part("Lapis Lazuli", 2) }, 1));

            //Generators
            recipesIndustrialCraft.Add(new Recipe("Generator", new Part[] { new Part("Furnace", 1), new Part("Machine", 1), new Part("RE Battery", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Geothermal Generator", new Part[] { new Part("Glass", 4), new Part("Empty Cell", 2), new Part("Refined Iron", 2), new Part("Generator", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Solar Panel", new Part[] { new Part("Generator", 1), new Part("Electronic Circuit", 2), new Part("Glass", 3), new Part("Coal Dust", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Water Mill", new Part[] { new Part("Plank", 4), new Part("Stick", 4), new Part("Generator", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Wind Mill", new Part[] { new Part("Iron", 4), new Part("Generator", 1) }, 1));

            //Nuclear Reactor
            recipesIndustrialCraft.Add(new Recipe("Nuclear Reactor", new Part[] { new Part("Reactor Chamber", 3), new Part("Generator", 1), new Part("Advanced Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Reactor Chamber", new Part[] { new Part("Dense Copper Plate", 4), new Part("Machine", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Refined Uranium", new Part[] { new Part("Uranium", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Uranium Block", new Part[] { new Part("Refined Uranium", 9) }, 1));

            recipesIndustrialCraft.Add(new Recipe("LZH Condensator", new Part[] { new Part("Redstone", 4), new Part("RSH Condensator", 2), new Part("Reactor Heat Vent", 1), new Part("Reactor Heat Exchanger", 1), new Part("Lapis Lazuli Block", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("RSH Condensator", new Part[] { new Part("Redstone", 7), new Part("Heat Vent", 1), new Part("Heat Exchanger", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Thick Neutron Reflector", new Part[] { new Part("Neutron Reflector", 4), new Part("Dense Copper Plate", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Neutron Reflector", new Part[] { new Part("Tin Dust", 4), new Part("Coal Dust", 4), new Part("Dense Copper Place", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Heating Cell", new Part[] { new Part("Electronic Circuit", 1), new Part("Lava Cell", 1), new Part("Dense Copper Plate", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Advanced Heat Vent", new Part[] { new Part("Iron Bars", 6), new Part("Heat Vent", 2), new Part("Diamond", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Component Heat Vent", new Part[] { new Part("Iron Bars", 4), new Part("Tin", 4), new Part("Heat Vent", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Overclocked Heat Vent", new Part[] { new Part("Gold", 2), new Part("Reactor Heat Vent", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Reactor Heat Vent", new Part[] { new Part("Dense Copper Plate", 2), new Part("Heat Vent", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Heat Vent", new Part[] { new Part("Refined Iron", 4), new Part("Iron Bars", 4) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Advanced Heat Exchanger", new Part[] { new Part("Glass Fiber Cable", 4), new Part("Electronic Circuit", 2), new Part("Heat Exchanger", 2), new Part("Dense Copper Plate", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Component Heat Exchanger", new Part[] { new Part("Gold", 4), new Part("Heat Exchanger", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Reactor Heat Exchanger", new Part[] { new Part("Dense Copper Plate", 2), new Part("Heat Exchanger", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Heat Exchanger", new Part[] { new Part("Tin", 3), new Part("Electronic Circuit", 1), new Part("Dense Copper Plate", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Containment Reactor Plating", new Part[] { new Part("Advanced Alloy", 2), new Part("Reactor Plating", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Heat Capacity Reactor Plating", new Part[] { new Part("Dense Copper Plate", 2), new Part("Reactor Plating", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Reactor Plating", new Part[] { new Part("Dense Copper Plate", 1), new Part("Advanced Alloy", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("60k Coolant Cell", new Part[] { new Part("Tin", 6), new Part("30k Coolant Cell", 2), new Part("Dense Copper Plate", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("30k Coolant Cell", new Part[] { new Part("Tin", 6), new Part("10k Coolant Cell", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("10k Coolant Cell", new Part[] { new Part("Tin", 4), new Part("Water Cell", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Quad Uranium Cell", new Part[] { new Part("Dual Uranium Cell", 2), new Part("Dense Copper Plate", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Dual Uranium Cell", new Part[] { new Part("Uranium Cell", 2), new Part("Dense Copper Plate", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Uranium Cell", new Part[] { new Part("Empty Cell", 1), new Part("Refined Uranium", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Dense Copper Plate", new Part[] { new Part("Copper", 8) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Reinforced Glass", new Part[] { new Part("Glass", 7), new Part("Advanced Alloy", 2) }, 7));
            recipesIndustrialCraft.Add(new Recipe("Reinforced Stone", new Part[] { new Part("Stone", 8), new Part("Advanced Alloy", 1) }, 8));
            recipesIndustrialCraft.Add(new Recipe("Reinforced Door", new Part[] { new Part("Reinforced Stone", 16) }, 1));

            //Processors
            recipesIndustrialCraft.Add(new Recipe("Iron Furnace", new Part[] { new Part("Furnace", 1), new Part("Iron", 5) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Electric Furnace", new Part[] { new Part("Iron Furnace", 1), new Part("Redstone", 2), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Macerator", new Part[] { new Part("Flint", 3), new Part("Cobblestone", 2), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Extractor", new Part[] { new Part("Treetap", 4), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Compressor", new Part[] { new Part("Stone", 6), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Recycler", new Part[] { new Part("Glowstone Dust", 2), new Part("Dirt", 2), new Part("Refined Iron", 2), new Part("Compressor", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Canning Machine", new Part[] { new Part("Tin", 7), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Induction Furnace", new Part[] { new Part("Copper", 7), new Part("Electric Furnace", 1), new Part("Advanced Machine", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Mass Fabricator", new Part[] { new Part("Advanced Machine", 2), new Part("Glowstone Dust", 4), new Part("Advanced Circuit", 2), new Part("Lapotron Crystal", 1) }, 1));

            //Utility
            recipesIndustrialCraft.Add(new Recipe("Luminator", new Part[] { new Part("Glass", 5), new Part("Tin Cable", 1), new Part("Refined Iron", 2), new Part("Copper Cable", 1) }, 8));
            recipesIndustrialCraft.Add(new Recipe("Personal Safe", new Part[] { new Part("Electronic Circuit", 1), new Part("Machine", 1), new Part("Chest", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Trade-O-Mat", new Part[] { new Part("Redstone", 3), new Part("Chest", 2), new Part("Machine", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Magnetizer", new Part[] { new Part("Redstone", 6), new Part("Iron Fence", 2), new Part("Machine", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Electrolyzer", new Part[] { new Part("Copper Cable", 4), new Part("Empty Cell", 2), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Tesla Coil", new Part[] { new Part("Redstone", 5), new Part("Refined Iron", 2), new Part("MV Transformer", 1), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Teleporter", new Part[] { new Part("Advanced Circuit", 4), new Part("Advanced Machine", 1), new Part("Glass Fiber Cable", 2), new Part("Diamond", 1), new Part("FreqTrans", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Industrial TNT", new Part[] { new Part("Flint", 6), new Part("TNT", 3) }, 4));
            recipesIndustrialCraft.Add(new Recipe("Dynamite", new Part[] { new Part("TNT", 1), new Part("String", 1) }, 8));
            recipesIndustrialCraft.Add(new Recipe("Stiky Dynamite", new Part[] { new Part("Dynamite", 8), new Part("Sticky Resin", 1) }, 8));
            recipesIndustrialCraft.Add(new Recipe("Rubber Trampoline", new Part[] { new Part("Rubber", 6) }, 3));
            recipesIndustrialCraft.Add(new Recipe("Iron Fence", new Part[] { new Part("Refined Iron", 6) }, 12));

            //Miner
            recipesIndustrialCraft.Add(new Recipe("Miner", new Part[] { new Part("Electronic Circuit", 2), new Part("Mining Pipe", 2), new Part("Machine", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Pump", new Part[] { new Part("Empty Cell", 4), new Part("Mining Pipe", 2), new Part("Machine", 1), new Part("Treetap", 1), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Mining Pipe", new Part[] { new Part("Refined Iron", 6), new Part("Treetap", 1) }, 8));
            recipesIndustrialCraft.Add(new Recipe("OV Scanner", new Part[] { new Part("Glowstone Dust", 3), new Part("2xIns. Gold Cable", 2), new Part("Advanced Circuit", 1), new Part("RE Battery", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("OD Scanner", new Part[] { new Part("Copper Cable", 3), new Part("Electronic Circuit", 2), new Part("RE Battery", 1), new Part("Glowstone Dust", 1) }, 1));

            //Terraformer
            recipesIndustrialCraft.Add(new Recipe("Terraformer", new Part[] { new Part("Empty Blueprint", 1), new Part("Advanced Machine", 1), new Part("Glowstone Dust", 4), new Part("Dirt", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Empty Blueprint", new Part[] { new Part("Electronic Circuit", 1), new Part("Advanced Circuit", 1), new Part("Redstone", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Chilling Blueprint", new Part[] { new Part("Snowball", 4), new Part("Empty Blueprint", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Compression Blueprint", new Part[] { new Part("Cobblestone", 4), new Part("Stone", 1), new Part("Empty Blueprint", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Cultivation Blueprint", new Part[] { new Part("Seeds", 4), new Part("Empty Blueprint", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Desertification Blueprint", new Part[] { new Part("Sand", 4), new Part("Empty Blueprint", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Flatificator Blueprint", new Part[] { new Part("Dirt", 4), new Part("Empty Blueprint", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Irrigation Blueprint", new Part[] { new Part("Bucket of Water", 4), new Part("Empty Blueprint", 1) }, 1));

            //Upgrades
            recipesIndustrialCraft.Add(new Recipe("Overclocker Upgrade", new Part[] { new Part("10k Coolant cell", 3), new Part("Copper Cable", 2), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Transformer Upgrade", new Part[] { new Part("Glass", 5), new Part("2xIns. Gold Cable", 2), new Part("MV Transformer", 1), new Part("Electronic Circuit", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Energy Storage Upgrade", new Part[] { new Part("Plank", 5), new Part("Copper Cable", 2), new Part("RE Battery", 1), new Part("Electronic Circuit", 1) }, 1));

            //Energy Armor
            recipesIndustrialCraft.Add(new Recipe("Nano Helmet", new Part[] { new Part("Carbon Plate", 4), new Part("Energy Crystal", 1), new Part("Glass", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Nano Body Armor", new Part[] { new Part("Carbon Plate", 7), new Part("Energy Crystal", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Nano Leggings", new Part[] { new Part("Carbon Plate", 6), new Part("Energy Crystal", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Nano Boots", new Part[] { new Part("Carbon Plate", 4), new Part("Energy Crystal", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Iridium Plate", new Part[] { new Part("Advanced Alloy", 4), new Part("Iridium Ore", 4), new Part("Diamond", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Quantum Helmet", new Part[] { new Part("Nano Helmet", 1), new Part("Iridium Plate", 2), new Part("Lapotron Crystal", 1), new Part("Advanced Circuit", 2), new Part("Reinforced Glass", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Quantum Body Armor", new Part[] { new Part("Nano Body Armor", 1), new Part("Iridium Plate", 4), new Part("Lapotron Crystal", 1), new Part("Advanced Alloy", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Quantum Leggings", new Part[] { new Part("Nano Leggings", 1), new Part("Iridium Plate", 2), new Part("Lapotron Crystal", 1), new Part("Machine", 2), new Part("Glowstoen Dust", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Quantum Boots", new Part[] { new Part("Nano Boots", 1), new Part("Iridium Plate", 2), new Part("Lapotron Crystal", 1), new Part("Rubber Boots", 1) }, 1));

            //Utility
            recipesIndustrialCraft.Add(new Recipe("BatPack", new Part[] { new Part("RE Battery", 6), new Part("Electronic Circuit", 1), new Part("Tin", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("LapPack", new Part[] { new Part("Advanced Circuit", 1), new Part("Lapis Lazuli Block", 6), new Part("BatPack", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Composite Armor", new Part[] { new Part("Advanced Alloy", 6), new Part("Iron Chestplate", 1), new Part("Leather Tunic", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Electric Jetpack", new Part[] { new Part("Refined Iron", 4), new Part("Glowstone Dust", 2), new Part("Advanced Circuit", 1), new Part("BatBox", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Jetpack", new Part[] { new Part("Refined Iron", 4), new Part("Redstone", 2), new Part("Electronic Circuit", 1), new Part("Fuel Can", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("CF Pack", new Part[] { new Part("CF Sprayer", 2), new Part("Electronic Circuit", 1), new Part("Tin", 1), new Part("Fuel Can", 4) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Rubber Boots", new Part[] { new Part("Rubber", 6), new Part("Wool", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Static Boots", new Part[] { new Part("Iron", 4), new Part("Copper Cable", 3), new Part("Wool", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Solar Helmet", new Part[] { new Part("Iron", 5), new Part("Copper Cable", 3), new Part("Solar Panel", 1) }, 1));

            //Crops
            recipesIndustrialCraft.Add(new Recipe("Crop", new Part[] { new Part("Stick", 4) }, 2));
            recipesIndustrialCraft.Add(new Recipe("Crop-Matron", new Part[] { new Part("Crop", 5), new Part("Electronic Circuit", 2), new Part("Chest", 1), new Part("Machine", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Weed-Ex", new Part[] { new Part("Redstone", 1), new Part("Grin Powder", 1), new Part("Empty Cell", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Empty Booze Barrel", new Part[] { new Part("Plank", 2), new Part("Rubber Wood", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Cold Coffee", new Part[] { new Part("Stone Mug", 1), new Part("Coffee Powder", 1), new Part("Water Cell", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Dark Coffee", new Part[] { new Part("Cold Coffee", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Coffee", new Part[] { new Part("Dark Coffee", 1), new Part("Sugar", 1), new Part("Milk", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Stone Mug", new Part[] { new Part("Stone", 7) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Coffee Powder", new Part[] { new Part("Coffee Beans", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Fertilizer", new Part[] { new Part("Scrap", 1), new Part("Bonemeal", 1) }, 2));
            recipesIndustrialCraft.Add(new Recipe("Hydration Cell", new Part[] { new Part("Water Cell", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Cropnalizer", new Part[] { new Part("Redstone", 4), new Part("Copper Cable", 2), new Part("Electronic Circuit", 1), new Part("Glass", 1) }, 1));

            //Tools
            recipesIndustrialCraft.Add(new Recipe("Treetap", new Part[] { new Part("Plank", 5) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Wrench", new Part[] { new Part("Bronze", 6) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Cutter", new Part[] { new Part("Refined Iron", 3), new Part("Iron", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Painter", new Part[] { new Part("Wool", 3), new Part("Iron", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("EU Reader", new Part[] { new Part("Copper Cable", 4), new Part("Electronic Circuit", 1), new Part("Glowstone Dust", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Scaffold", new Part[] { new Part("Plank", 3), new Part("Stick", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Iron Scaffold", new Part[] { new Part("Iron Fence", 3), new Part("Refined Iron", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("CF Sprayer", new Part[] { new Part("Cobblestone", 4), new Part("Stick", 1) }, 1));

            //Electric 
            recipesIndustrialCraft.Add(new Recipe("Mining Drill", new Part[] { new Part("Refined Iron", 5), new Part("Electronic Circuit", 1), new Part("RE Battery", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Diamond Drill", new Part[] { new Part("Mining Drill", 1), new Part("Diamond", 3) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Chainsaw", new Part[] { new Part("Refined Iron", 5), new Part("Electronic Circuit", 1), new Part("RE Battery", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Electric Wrench", new Part[] { new Part("Wrench", 1), new Part("Electronic Circuit", 1), new Part("RE Battery", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Nano Saber", new Part[] { new Part("Glowstone Dust", 2), new Part("Carbon Plate", 2), new Part("Advanced Alloy", 2), new Part("Energy Crystal", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Electric Treetap", new Part[] { new Part("Treetap", 1), new Part("Electronic Circuit", 1), new Part("RE Battery", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Mining Laser", new Part[] { new Part("Advanced Alloy", 4), new Part("Energy Crystal", 2), new Part("Electronic Circuit", 1), new Part("Redstone", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Electric Hoe", new Part[] { new Part("Refined Iron", 2), new Part("Electronic Circuit", 1), new Part("RE Battery", 1) }, 1));

            //Compact Solar
            recipesIndustrialCraft.Add(new Recipe("LV Solar Array", new Part[] { new Part("Solar Panel", 8), new Part("LV Transformer", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("MV Solar Array", new Part[] { new Part("LV Solar Array", 8), new Part("MV Transformer", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("HV Solar Array", new Part[] { new Part("MV Solar Array", 8), new Part("HV Transformer", 1) }, 1));

            //IC2 Misc
            recipesIndustrialCraft.Add(new Recipe("Advanced Alloy", new Part[] { new Part("Metal Block", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Metal Block", new Part[] { new Part("Bronze", 3), new Part("Refined Iron", 3), new Part("Tin", 3) }, 2));
            recipesIndustrialCraft.Add(new Recipe("Carbon Plate", new Part[] { new Part("Raw Carbon Mesh", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Raw Carbon Mesh", new Part[] { new Part("Raw Carbon Fibre", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Raw Carbon Fibre", new Part[] { new Part("Coal Dust", 4) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Bronze Dust", new Part[] { new Part("Copper Dust", 3), new Part("Tin Dust", 1) }, 2));
            recipesIndustrialCraft.Add(new Recipe("Bronze", new Part[] { new Part("Bronze Dust", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Iridium Ore", new Part[] { new Part("UU Matter", 7) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Empty Cell", new Part[] { new Part("Tin", 4) }, 16));
            recipesIndustrialCraft.Add(new Recipe("Water Cell", new Part[] { new Part("Empty Cell", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Compressed Air Cell", new Part[] { new Part("Empty Cell", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Lava Cell", new Part[] { new Part("Empty Cell", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Clay Dust", new Part[] { new Part("Clay Block", 1) }, 2));
            recipesIndustrialCraft.Add(new Recipe("Construction Foam", new Part[] { new Part("Redstone", 1), new Part("Coal Dust", 1), new Part("Water Cell", 1), new Part("Clay Dust", 1) }, 3));
            recipesIndustrialCraft.Add(new Recipe("CF Pellet", new Part[] { new Part("Construction Foam", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Fuel Can", new Part[] { new Part("Tin", 7) }, 1));
            recipesIndustrialCraft.Add(new Recipe("FreqTrans", new Part[] { new Part("Electronic Circuit", 1), new Part("Copper Cable", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Grin Powder", new Part[] { new Part("Spider Eye", 1) }, 2));

            recipesIndustrialCraft.Add(new Recipe("Hazmat Suit Leggings", new Part[] { new Part("Rubber", 6), new Part("Orange Dye", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Hazmat Suit", new Part[] { new Part("Rubber", 6), new Part("Orange Dye", 2) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Scuba Helmet", new Part[] { new Part("Rubber", 4), new Part("Orange Dye", 2), new Part("Glass", 1), new Part("Iron Bars", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Tool Box", new Part[] { new Part("Refined Iron", 5), new Part("Chest", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Coal Ball", new Part[] { new Part("Coal Dust", 8), new Part("Flint", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Compressed Coal Ball", new Part[] { new Part("Coal Ball", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Coal Chunk", new Part[] { new Part("Compressed Coal Ball", 8), new Part("Obsidian", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Scrap Box", new Part[] { new Part("Scrap", 9) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Tin Can", new Part[] { new Part("Tin", 5) }, 4));
            recipesIndustrialCraft.Add(new Recipe("Plantball", new Part[] { new Part("Plants", 8) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Compressed Plants", new Part[] { new Part("Plantball", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Bio Cell", new Part[] { new Part("Compressed Plants", 1), new Part("Empty Cell", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Biofuel Cell", new Part[] { new Part("Bio Cell", 1) }, 1));

            recipesIndustrialCraft.Add(new Recipe("Hydrated Coal Dust", new Part[] { new Part("Coal Dust", 8), new Part("Water Cell", 1) }, 8));
            recipesIndustrialCraft.Add(new Recipe("H. Coal", new Part[] { new Part("Hydrated Coal Dust", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("H. Coal Cell", new Part[] { new Part("H. Coal", 1), new Part("Empty Cell", 1) }, 1));
            recipesIndustrialCraft.Add(new Recipe("Coalfuel Cell", new Part[] { new Part("H. Coal Cell", 1) }, 1));
        }
    }
}