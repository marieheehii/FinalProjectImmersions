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
            Name = model.Name,
            Ingredients = model.Ingredients,
            IngredientAmounts = model.IngredientAmounts,
            Type = model.Type,
            Instructions = model.Instructions
        };

        _context.Recipes.Add(recipe);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }
    public async Task<IEnumerable<RecipeListItem>> ListAllRecipes()
    {
        return _context.
    }
    public async Task<RecipeEdit> UpdateRecipe(int RecipeID)
    {
        var recipe = await _context.Recipes.FindAsync(RecipeID);
        if (recipe is null)
            return null;

        return new RecipeDetail
        {
            Name = model.Name,
            Ingredients = model.Ingredients,
            IngredientAmounts = model.IngredientAmounts,
            Type = model.Type,
            Instructions = model.Instructions
        };

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
