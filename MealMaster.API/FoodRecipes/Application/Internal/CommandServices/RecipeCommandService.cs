using BasePlatform.API.FoodRecipes.Domain.Model.Aggregates;
using BasePlatform.API.FoodRecipes.Domain.Model.Commands;
using BasePlatform.API.FoodRecipes.Domain.Repositories;
using BasePlatform.API.FoodRecipes.Domain.Services;
using BasePlatform.API.Shared.Domain.Repositories;

namespace BasePlatform.API.FoodRecipes.Application.Internal.CommandServices;

public class RecipeCommandService(IRecipeRepository recipeRepository, IUnitOfWork unitOfWork) : IRecipeCommandService
{
    public async Task<Recipe?> Handle(CreateRecipeCommand command)
    {
        var recipe = new Recipe(command);
        try
        {
            await recipeRepository.AddAsync(recipe);
            await unitOfWork.CompleteAsync();
            return recipe;
        } catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the recipe: {e.Message}");
            return null;
        }
    }
}