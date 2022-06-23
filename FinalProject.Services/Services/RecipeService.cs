using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class RecipeService : IRecipe
{
    public async Task<bool> CreateRecipeAsync(RecipeDetail model)
    {

    }
    public async Task<IEnumerable<RecipeListItem>> ListAllRecipes()
    {

    }
    public async Task<RecipeEdit> UpdateRecipe(int RecipeID)
    {

    }
    public async Task<RecipeEdit> DeleteRecipe(int RecipeID)
    {
        
    }
}
