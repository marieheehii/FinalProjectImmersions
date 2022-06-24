using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class RecipeController
{
    public readonly IRecipe _recipeService;
    public RecipeController(IRecipe recipeService)
    {
        _recipeService = recipeService;
    }
}
