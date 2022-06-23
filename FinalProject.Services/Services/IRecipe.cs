using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface IRecipe
    {
        Task<bool> CreateRecipeAsync(RecipeDetail model);
        Task<IEnumerable<RecipeListItem>> ListAllRecipes();
        Task<RecipeEdit> UpdateRecipe(int RecipeID);
        Task<RecipeEdit> DeleteRecipe(int RecipeID);
    }