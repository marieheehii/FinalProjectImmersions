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
        Task<RecipeEdit> GetRecipeByCategory(RecipeType type);
        Task<RecipeItems> GetItemsForRecipe(List<RecipeItems> items); //* get terrys help
    }