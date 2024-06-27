using BasePlatform.API.FoodRecipes.Domain.Model.Aggregates;
using BasePlatform.API.FoodRecipes.Domain.Model.Commands;

namespace BasePlatform.API.FoodRecipes.Domain.Services;

public interface IRecipeCommandService
{
    Task<Recipe?> Handle(CreateRecipeCommand command);
}