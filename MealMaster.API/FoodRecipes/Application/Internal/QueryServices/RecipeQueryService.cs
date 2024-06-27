using BasePlatform.API.FoodRecipes.Domain.Model.Aggregates;
using BasePlatform.API.FoodRecipes.Domain.Model.Queries;
using BasePlatform.API.FoodRecipes.Domain.Model.ValueObjects;
using BasePlatform.API.FoodRecipes.Domain.Repositories;
using BasePlatform.API.FoodRecipes.Domain.Services;

namespace BasePlatform.API.FoodRecipes.Application.Internal.QueryServices;

public class RecipeQueryService(IRecipeRepository recipeRepository) : IRecipeQueryService
{
    public async Task<IEnumerable<Recipe>> Handle(GetAllRecipesQuery query)
    {
        return await recipeRepository.ListAsync();
    }
    
    public async Task<Recipe?> Handle(GetRecipeByIdQuery query)
    {
        return await recipeRepository.FindByIdAsync(query.RecipeId);
    }
    
    public async Task<IEnumerable<Recipe>?> Handle(GetRecipesByTagQuery query)
    {
        if (query.Tag is EPrincingTag pricingTag)
        {
            return await recipeRepository.FindRecipesByTagAsync(pricingTag);
        }
        else if (query.Tag is EMealtTimeTag mealtTime)
        {
            return await recipeRepository.FindRecipesByTagAsync(mealtTime);
        }
        else if (query.Tag is EDifficultyTag difficulty)
        {
            return await recipeRepository.FindRecipesByTagAsync(difficulty);
        }
        else if (query.Tag is ETypeCuisine typeCuisine)
        {
            return await recipeRepository.FindRecipesByTagAsync(typeCuisine);
        }
        throw new ArgumentException("Tag type not supported");
    }
}