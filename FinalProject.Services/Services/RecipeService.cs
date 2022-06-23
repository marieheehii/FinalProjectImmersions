using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class RecipeService : IRecipe
{
    private readonly ApplicationDbContext _context;
    public RecipeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateRecipeAsync(RecipeDetail model)
    {
        var recipe = new Recipe
        {

        }
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
    public async Task<RecipeEdit> GetRecipeByCategory(RecipeType type)
    {
        return await _context.Recipes.FirstOrDefaultAsync(Recipe => Recipe.RecipeType.ToLower() == recipeType.ToLower());
    }
    public async Task<RecipeItems> GetItemsForRecipe(List<RecipeItems> items) //* get terrys help
    {

    }
}
