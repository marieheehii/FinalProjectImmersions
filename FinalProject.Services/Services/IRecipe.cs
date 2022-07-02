using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface IRecipe
{
    Task<bool> CreateRecipeAsync(RecipeDetail model);
    Task<IEnumerable<RecipeListItem>> ListAllRecipesAsync();
    Task<bool> UpdateRecipeAsync(RecipeEdit model, int RecipeID);
    Task<bool> DeleteRecipeAsync(int RecipeID);
    Task<RecipeDetail> GetRecipeByCategoryAsync(RecipeType type);

    // Task<RecipeItems> GetItemsForRecipeAsync(List<RecipeItems> items); //* get terrys help
}