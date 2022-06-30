using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
    public async Task<IEnumerable<RecipeListItem>> ListAllRecipesAsync()
    {
        var recipes = await _context.Recipes.Select(r => new RecipeListItem{
            RecipeID = r.RecipeID,
            Name=r.Name,
            Type=r.Type
        }).ToListAsync();

        return recipes;
    }
    public async Task<bool> UpdateRecipeAsync(RecipeEdit model, int RecipeID)
    {
        var recipe = await _context.Recipes.FindAsync(model.RecipeID);
        if (recipe is null)
            return false;

            recipe.Name = model.Name;
            recipe.Ingredients = model.Ingredients;
            recipe.IngredientAmounts = model.IngredientAmounts;
            recipe.Type = model.Type;
            recipe.Instructions = model.Instructions;

            await _context.SaveChangesAsync();
            return true;
    }
    
    public async Task<bool> DeleteRecipeAsync(int RecipeID)
    {
        var recipe = await _context.Recipes.FindAsync(RecipeID);

        if (recipe is null)
        {
            return false;
        }

        _context.Recipes.Remove(recipe);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<RecipeDetail> GetRecipeByCategoryAsync(RecipeType type)
    {
        var recipe = await _context.Recipes.Include(r=> r.Items).FirstOrDefaultAsync(Recipe => Recipe.Type == type);
        if (recipe is null)
        return null;

        return new RecipeDetail
        {
            RecipeID= recipe.RecipeID,
            Name= recipe.Name,
            Ingredients=recipe.Ingredients,
            Items=recipe.Items,
            IngredientAmounts=recipe.IngredientAmounts,
            Type=recipe.Type,
            Instructions=recipe.Instructions
        };
    }

    // public async Task<RecipeItems> GetItemsForRecipe(List<RecipeItems> items) //* get terrys help
    // {
    //* terrys help
    //* 2.0 version
    // }
}
