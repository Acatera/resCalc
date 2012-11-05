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

        public List<Part> getRequiredMaterials(double ammount)
        {
            List<Part> reqs = new List<Part>();

            foreach (Part part in parts)
            {
                Recipe recipe = Defaults.recipes.Find(
                    delegate(Recipe rcp)
                    {
                        return rcp.name == part.name;
                    }
                );
                if (recipe == null)
                {
                    reqs.Add(new Part(part.name, part.ammount * ammount));
                }
                else
                {
                    reqs.AddRange(recipe.getRequiredMaterials((double)part.ammount * ammount / (double)recipe.resultedAmmount));
                }
            }
            return reqs;
        }

        public List<Part> getConsolidatedRequiredMaterials(double ammount)
        {
            return this.getRequiredMaterials(ammount).GroupBy(x => x.name).Select(y => { y.First().ammount = y.Sum(z => z.ammount); return y.First(); }).ToList<Part>();
        }
    }
}
