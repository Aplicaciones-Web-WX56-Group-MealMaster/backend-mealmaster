using System.Net.Mime;
using BasePlatform.API.FoodRecipes.Domain.Services;
using BasePlatform.API.FoodRecipes.Interfaces.REST.Resources;
using BasePlatform.API.FoodRecipes.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace BasePlatform.API.FoodRecipes.Interfaces.REST;


[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class RecipesController(IRecipeCommandService recipeCommandService, IRecipeQueryService recipeQueryService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateRecipe(CreateRecipeResource resource)
    {
        var createRecipeCommand = CreateRecipeCommandFromResource.ToCommandFromResource(resource);
        var recipe = await recipeCommandService.Handle(createRecipeCommand);
        if (recipe is null) return BadRequest();
        
    }
    
    
    
}