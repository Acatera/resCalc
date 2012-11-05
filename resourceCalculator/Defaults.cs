using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace resourceCalculator
{
    class Defaults
    {
        public static List<Recipe> recipes = new List<Recipe>();

        public Defaults()
        {
            //Vanilla
            recipes.Add(new Recipe("Plank", new Part[] { new Part("Log", 1) }, 4));
            recipes.Add(new Recipe("Stick", new Part[] { new Part("Plank", 2) }, 4));
            recipes.Add(new Recipe("Lever", new Part[] { new Part("Stick", 1), new Part("Cobblestone", 1) }, 1));
            recipes.Add(new Recipe("Furnace", new Part[] { new Part("Cobblestone", 8) }, 1));
            recipes.Add(new Recipe("Chest", new Part[] { new Part("Plank", 8) }, 1));
            recipes.Add(new Recipe("Lapis Lazuli Block", new Part[] { new Part("Lapis Lazuli", 9) }, 1));
            recipes.Add(new Recipe("Iron Chestplace", new Part[] { new Part("Iron", 8) }, 1));
            recipes.Add(new Recipe("Leather Tunic", new Part[] { new Part("Leather", 8) }, 1));
            recipes.Add(new Recipe("Wool", new Part[] { new Part("String", 4) }, 1));

            //Cables
            recipes.Add(new Recipe("Tin Cable", new Part[] { new Part("Tin", 3) }, 9));
            recipes.Add(new Recipe("Copper Cable", new Part[] { new Part("Copper", 3), new Part("Rubber", 6) }, 6));
            recipes.Add(new Recipe("Gold Cable", new Part[] { new Part("Gold Ingot", 3) }, 12));
            recipes.Add(new Recipe("2xIns. Gold Cable", new Part[] { new Part("Gold Cable", 1), new Part("Rubber", 2) }, 1));
            recipes.Add(new Recipe("HV Cable", new Part[] { new Part("Refined Iron", 3) }, 12));
            recipes.Add(new Recipe("4xIns. HV Cable", new Part[] { new Part("HV Cable", 1), new Part("Rubber", 3) }, 1));
            recipes.Add(new Recipe("Glass Fiber Cable", new Part[] { new Part("Glass", 6), new Part("Redstone Dust", 2), new Part("Diamond", 1) }, 4));
            recipes.Add(new Recipe("Detector Cable", new Part[] { new Part("4xIns. HV Cable", 1), new Part("Redstone Dust", 3), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Splitter Cable", new Part[] { new Part("4xIns. HV Cable", 2), new Part("Redstone Dust", 2), new Part("Lever", 1) }, 1));

            //EU Storage
            recipes.Add(new Recipe("BatBox", new Part[] { new Part("Plank", 5), new Part("Copper Cable", 1), new Part("RE Battery", 3) }, 1));
            recipes.Add(new Recipe("MFE Unit", new Part[] { new Part("Energy Crystal", 4), new Part("2xIns. Gold Cable", 4), new Part("Machine", 1) }, 1));
            recipes.Add(new Recipe("MFS Unit", new Part[] { new Part("Lapotron Crystal", 6), new Part("Advanced Circuit", 1), new Part("MFE Unit", 1), new Part("Advanced Machine", 1) }, 1));

            //Items
            recipes.Add(new Recipe("RE Battery", new Part[] { new Part("Copper Cable", 1), new Part("Tin", 4), new Part("Redstone Dust", 2) }, 1));
            recipes.Add(new Recipe("Energy Crystal", new Part[] { new Part("Redstone Dust", 8), new Part("Diamond", 1) }, 1));
            recipes.Add(new Recipe("Lapotron Crystal", new Part[] { new Part("Lapis Lazuli", 6), new Part("Electronic Circuit", 2), new Part("Energy Crystal", 1) }, 1));

            //Transformers
            recipes.Add(new Recipe("LV Transformer", new Part[] { new Part("Plank", 4), new Part("Copper", 3), new Part("Copper Cable", 2) }, 1));
            recipes.Add(new Recipe("MV Transformer", new Part[] { new Part("Machine", 1), new Part("2xIns. Gold Cable", 2) }, 1));
            recipes.Add(new Recipe("HV Transformer", new Part[] { new Part("Electronic Circuit", 1), new Part("MV Transformer", 1), new Part("4xIns. HV Cable", 2), new Part("Energy Crystal", 1) }, 1));

            //Machine Components
            recipes.Add(new Recipe("Machine", new Part[] { new Part("Refined Iron", 8) }, 1));
            recipes.Add(new Recipe("Advanced Machine", new Part[] { new Part("Advanced Alloy", 2), new Part("Carbon Plate", 2), new Part("Machine", 1) }, 1));
            recipes.Add(new Recipe("Electronic Circuit", new Part[] { new Part("Copper Cable", 6), new Part("Refined Iron", 1), new Part("Redstone Dust", 2) }, 1));
            recipes.Add(new Recipe("Advanced Circuit", new Part[] { new Part("Electronic Circuit", 1), new Part("Redstone Dust", 4), new Part("Glowstone Dust", 2), new Part("Lapis Lazuli", 2) }, 1));

            //Generators
            recipes.Add(new Recipe("Generator", new Part[] { new Part("Furnace", 1), new Part("Machine", 1), new Part("RE Battery", 1) }, 1));
            recipes.Add(new Recipe("Geothermal Generator", new Part[] { new Part("Glass", 4), new Part("Empty Cell", 2), new Part("Refined Iron", 2), new Part("Generator", 1) }, 1));
            recipes.Add(new Recipe("Solar Panel", new Part[] { new Part("Generator", 1), new Part("Electronic Circuit", 2), new Part("Glass", 3), new Part("Coal Dust", 3) }, 1));
            recipes.Add(new Recipe("Water Mill", new Part[] { new Part("Plank", 4), new Part("Stick", 4), new Part("Generator", 1) }, 1));
            recipes.Add(new Recipe("Wind Mill", new Part[] { new Part("Iron", 4), new Part("Generator", 1) }, 1));
            
            //Nuclear Reactor

            //Processors
            recipes.Add(new Recipe("Iron Furnace", new Part[] { new Part("Furnace", 1), new Part("Iron", 5) }, 1));
            recipes.Add(new Recipe("Electric Furnace", new Part[] { new Part("Iron Furnace", 1), new Part("Redstone Dust", 2), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Macerator", new Part[] { new Part("Flint", 3), new Part("Cobblestone", 2), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Extractor", new Part[] { new Part("Treetap", 4), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Compressor", new Part[] { new Part("Stone", 6), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Recycler", new Part[] { new Part("Glowstone Dust", 2), new Part("Dirt", 2), new Part("Refined Iron", 2), new Part("Compressor", 1) }, 1));
            recipes.Add(new Recipe("Canning Machine", new Part[] { new Part("Tin", 7), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Induction Furnace", new Part[] { new Part("Copper", 7), new Part("Electric Furnace", 1), new Part("Advanced Machine", 1) }, 1));
            recipes.Add(new Recipe("Mass Fabricator", new Part[] { new Part("Advanced Machine", 2), new Part("Glowstone Dust", 4), new Part("Advanced Circuit", 2), new Part("Lapotron Crystal", 1) }, 1));

            //Utility
            recipes.Add(new Recipe("Luminator", new Part[] { new Part("Glass", 5), new Part("Tin Cable", 1), new Part("Refined Iron", 2), new Part("Copper Cable", 1) }, 8));
            recipes.Add(new Recipe("Personal Safe", new Part[] { new Part("Electronic Circuit", 1), new Part("Machine", 1), new Part("Chest", 1) }, 1));
            recipes.Add(new Recipe("Trade-O-Mat", new Part[] { new Part("Redstone Dust", 3), new Part("Chest", 2), new Part("Machine", 1) }, 1));
            recipes.Add(new Recipe("Magnetizer", new Part[] { new Part("Redstone Dust", 6), new Part("Iron Fence", 2), new Part("Machine", 1) }, 1));
            recipes.Add(new Recipe("Electrolyzer", new Part[] { new Part("Copper Cable", 4), new Part("Empty Cell", 2), new Part("Machine", 1), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Tesla Coil", new Part[] { new Part("Redstone Dust", 5), new Part("Refined Iron", 2), new Part("MV Transformer", 1), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Teleporter", new Part[] { new Part("Advanced Circuit", 4), new Part("Advanced Machine", 1), new Part("Glass Fiber Cable", 2), new Part("Diamond", 1), new Part("FreqTrans", 1) }, 1));
            recipes.Add(new Recipe("Industrial TNT", new Part[] { new Part("Flint", 6), new Part("TNT", 3) }, 4));
            recipes.Add(new Recipe("Dynamite", new Part[] { new Part("TNT", 1), new Part("String", 1) }, 8));
            recipes.Add(new Recipe("Stiky Dynamite", new Part[] { new Part("Dynamite", 8), new Part("Sticky Resin", 1) }, 8));
            recipes.Add(new Recipe("Rubber Trampoline", new Part[] { new Part("Rubber", 6) }, 3));
            recipes.Add(new Recipe("Iron Fence", new Part[] { new Part("Refined Iron", 6) }, 12));

            //Miner
            recipes.Add(new Recipe("Miner", new Part[] { new Part("Electronic Circuit", 2), new Part("Mining Pipe", 2), new Part("Machine", 1) }, 1));
            recipes.Add(new Recipe("Pump", new Part[] { new Part("Empty Cell", 4), new Part("Mining Pipe", 2), new Part("Machine", 1), new Part("Treetap", 1), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Mining Pipe", new Part[] { new Part("Refined Iron", 6), new Part("Treetap", 1) }, 8));

            //Terraformer
            recipes.Add(new Recipe("Terraformer", new Part[] { new Part("Empty Blueprint", 1), new Part("Advanced Machine", 1), new Part("Glowstone Dust", 4), new Part("Dirt", 3) }, 1));
            recipes.Add(new Recipe("Empty Blueprint", new Part[] { new Part("Electronic Circuit", 1), new Part("Advanced Circuit", 1), new Part("Redstone Dust", 2) }, 1));
            recipes.Add(new Recipe("Chilling Blueprint", new Part[] { new Part("Snowball", 4), new Part("Empty Blueprint", 1) }, 1));
            recipes.Add(new Recipe("Compression Blueprint", new Part[] { new Part("Cobblestone", 4), new Part("Stone", 1), new Part("Empty Blueprint", 1) }, 1));
            recipes.Add(new Recipe("Cultivation Blueprint", new Part[] { new Part("Seeds", 4), new Part("Empty Blueprint", 1) }, 1));
            recipes.Add(new Recipe("Desertification Blueprint", new Part[] { new Part("Sand", 4), new Part("Empty Blueprint", 1) }, 1));
            recipes.Add(new Recipe("Flatificator Blueprint", new Part[] { new Part("Dirt", 4), new Part("Empty Blueprint", 1) }, 1));
            recipes.Add(new Recipe("Irrigation Blueprint", new Part[] { new Part("Bucket of Water", 4), new Part("Empty Blueprint", 1) }, 1));

            //Upgrades
            recipes.Add(new Recipe("Overclocker Upgrade", new Part[] { new Part("Cooling cell", 3), new Part("Copper Cable", 2), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Transformer Upgrade", new Part[] { new Part("Glass", 5), new Part("2xIns. Gold Cable", 2), new Part("MV Transformer", 1), new Part("Electronic Circuit", 1) }, 1));
            recipes.Add(new Recipe("Energy Storage Upgrade", new Part[] { new Part("Plank", 5), new Part("Copper Cable", 2), new Part("RE Battery", 1), new Part("Electronic Circuit", 1) }, 1));

            //Energy Armor
            recipes.Add(new Recipe("Nano Helmet", new Part[] { new Part("Carbon Plate", 4), new Part("Energy Crystal", 1), new Part("Glass", 1) }, 1));
            recipes.Add(new Recipe("Nano Body Armor", new Part[] { new Part("Carbon Plate", 7), new Part("Energy Crystal", 1) }, 1));
            recipes.Add(new Recipe("Nano Leggings", new Part[] { new Part("Carbon Plate", 6), new Part("Energy Crystal", 1) }, 1));
            recipes.Add(new Recipe("Nano Boots", new Part[] { new Part("Carbon Plate", 4), new Part("Energy Crystal", 1) }, 1));

            recipes.Add(new Recipe("Iridium Plate", new Part[] { new Part("Advanced Alloy", 4), new Part("Iridium Ore", 4), new Part("Diamond", 1) }, 1));

            recipes.Add(new Recipe("Quantum Helmet", new Part[] { new Part("Nano Helmet", 1), new Part("Iridium Plate", 2), new Part("Lapotron Crystal", 1), new Part("Advanced Circuit", 2), new Part("Reinforced Glass", 1) }, 1));
            recipes.Add(new Recipe("Quantum Body Armor", new Part[] { new Part("Nano Body Armor", 1), new Part("Iridium Plate", 4), new Part("Lapotron Crystal", 1), new Part("Advanced Alloy", 3) }, 1));
            recipes.Add(new Recipe("Quantum Leggings", new Part[] { new Part("Nano Leggings", 1), new Part("Iridium Plate", 2), new Part("Lapotron Crystal", 1), new Part("Machine", 2), new Part("Glowstoen Dust", 2) }, 1));
            recipes.Add(new Recipe("Quantum Boots", new Part[] { new Part("Nano Boots", 1), new Part("Iridium Plate", 2), new Part("Lapotron Crystal", 1), new Part("Rubber Boots", 1) }, 1));

            //Utility
            recipes.Add(new Recipe("BatPack", new Part[] { new Part("RE Battery", 6), new Part("Electronic Circuit", 1), new Part("Tin", 1) }, 1));
            recipes.Add(new Recipe("LapPack", new Part[] { new Part("Advanced Circuit", 1), new Part("Lapis Lazuli Block", 6), new Part("BatPack", 1) }, 1));
            recipes.Add(new Recipe("Composite Armor", new Part[] { new Part("Advanced Alloy", 6), new Part("Iron Chestplate", 1), new Part("Leather Tunic", 1) }, 1));
            recipes.Add(new Recipe("Electric Jetpack", new Part[] { new Part("Refined Iron", 4), new Part("Glowstone Dust", 2), new Part("Advanced Circuit", 1), new Part("BatBox", 1) }, 1));
            recipes.Add(new Recipe("Jetpack", new Part[] { new Part("Refined Iron", 4), new Part("Redstone Dust", 2), new Part("Electronic Circuit", 1), new Part("Fuel Can", 1) }, 1));
            recipes.Add(new Recipe("CF Pack", new Part[] { new Part("CF Sprayer", 2), new Part("Electronic Circuit", 1), new Part("Tin", 1), new Part("Fuel Can", 4) }, 1));
            recipes.Add(new Recipe("Rubber Boots", new Part[] { new Part("Rubber", 6), new Part("Wool", 1) }, 1));
            recipes.Add(new Recipe("Static Boots", new Part[] { new Part("Iron", 4), new Part("Copper Cable", 3), new Part("Wool", 1) }, 1));
            recipes.Add(new Recipe("Solar Helmet", new Part[] { new Part("Iron", 5), new Part("Copper Cable", 3), new Part("Solar Panel", 1) }, 1));





            // recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            
            
            //Tools
           /* recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));

            //Electric 
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            recipes.Add(new Recipe("", new Part[] { new Part("", 2), new Part("", 2), new Part("", 1) }, 1));
            */

            //Compact Solar
            recipes.Add(new Recipe("LV Solar Array", new Part[] { new Part("Solar Panel", 8), new Part("LV Transformer", 1) }, 1));
            recipes.Add(new Recipe("MV Solar Array", new Part[] { new Part("LV Solar Array", 8), new Part("MV Transformer", 1) }, 1));
            recipes.Add(new Recipe("HV Solar Array", new Part[] { new Part("MV Solar Array", 8), new Part("HV Transformer", 1) }, 1));
        }
    }
}
