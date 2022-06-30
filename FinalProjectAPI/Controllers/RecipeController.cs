using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class RecipeController : ControllerBase
{
    public readonly IRecipe _recipeService;
    public RecipeController(IRecipe recipeService)
    {
        _recipeService = recipeService;
    }

    [HttpPost]
    public async Task<IActionResult> AddRecipe([FromForm] RecipeDetail model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var addedRecipe = await _recipeService.CreateRecipeAsync(model);
        if (addedRecipe)
            return Ok("Recipe was added!");

        return BadRequest("Recipe was NOT added!");
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRecipes()
    {
        var recipes = await _recipeService.ListAllRecipesAsync();
        return Ok(recipes);
    }

    // [HttpGet]
    // public async Task<IActionResult> GetRecipeByCategory()
    // {
    //     var recipe = await _recipeService.GetRecipeByCategoryAsync();
    //     return Ok(recipe);
    // }

    [HttpPut]
    [Route("{RecipeID}")]
    public async Task<IActionResult> UpdateRecipe([FromForm] RecipeEdit model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        
        
        
    }

    [HttpPut]
    public async Task<IActionResult> DeleteRecipe()
    {

    }
}