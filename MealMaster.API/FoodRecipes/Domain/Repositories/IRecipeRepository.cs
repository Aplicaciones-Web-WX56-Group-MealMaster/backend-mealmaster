using BasePlatform.API.FoodRecipes.Domain.Model.Aggregates;
using BasePlatform.API.Shared.Domain.Repositories;

namespace BasePlatform.API.FoodRecipes.Domain.Repositories;

public interface IRecipeRepository : IBaseRepository<Recipe>
{
    Task<IEnumerable<Recipe>?> FindRecipesByTagAsync(object tag);
}