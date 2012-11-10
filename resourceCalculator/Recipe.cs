using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace resourceCalculator
{
    class Recipe
    {
        public String name;
        public Part[] parts;
        public byte resultedAmmount;

        public Recipe(String name, Part[] parts, byte resultedAmmount)
        {
            this.name = name;
            this.parts = parts;
            this.resultedAmmount = resultedAmmount;
        }

        public List<Part> getRequiredMaterials(double ammount, int depth)
        {
            List<Part> reqs = new List<Part>();

            foreach (Part part in parts)
            {
                Recipe recipe = Defaults.currentRecipeSet.Find(
                    delegate(Recipe rcp)
                    {
                        return rcp.name == part.name;
                    }
                );
                if (recipe == null || depth == 0)
                {
                    reqs.Add(new Part(part.name, part.ammount * ammount / this.resultedAmmount));
                }
                else
                {
                    reqs.AddRange(recipe.getRequiredMaterials((double)part.ammount * ammount, depth - 1));
                }
            }
            return reqs;
        }

        public List<Part> getConsolidatedRequiredMaterials(double ammount, int depth)
        {
            return this.getRequiredMaterials(ammount, depth).GroupBy(x => x.name).Select(y => { y.First().ammount = y.Sum(z => z.ammount); return y.First(); }).ToList<Part>();
        }
    }
}
