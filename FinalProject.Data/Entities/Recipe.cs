using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public List<KitchenInventory> Items { get; set; }
        public int IngredientAmounts { get; set; }
        public RecipeType Type { get; set; }
        public string Instructions { get; set; }

    }
