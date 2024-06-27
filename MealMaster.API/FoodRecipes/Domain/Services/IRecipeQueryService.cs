using BasePlatform.API.FoodRecipes.Domain.Model.Aggregates;
using BasePlatform.API.FoodRecipes.Domain.Model.Queries;

namespace BasePlatform.API.FoodRecipes.Domain.Services;

public interface IRecipeQueryService
{
    Task<IEnumerable<Recipe>> Handle(GetAllRecipesQuery query);
    Task<Recipe?> Handle(GetRecipeByIdQuery query);
    Task<IEnumerable<Recipe>?>Handle(GetRecipesByTagQuery query);
}