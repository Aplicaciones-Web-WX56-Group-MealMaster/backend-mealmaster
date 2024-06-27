using BasePlatform.API.FoodRecipes.Domain.Model.Aggregates;
using BasePlatform.API.FoodRecipes.Domain.Model.ValueObjects;
using BasePlatform.API.FoodRecipes.Domain.Repositories;
using BasePlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using BasePlatform.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BasePlatform.API.FoodRecipes.Infrastructure.Persistence.EFC.Repositories;

public class RecipeRepository(AppDbContext context) : BaseRepository<Recipe>(context), IRecipeRepository
{
    public async Task<IEnumerable<Recipe>?> FindRecipesByTagAsync(object tag)
    {
        if (tag is EPrincingTag pricingTag)
        {
            return await Context.Set<Recipe>().Where(r => r.Princing == pricingTag).ToListAsync();
        }
        else if (tag is EMealtTimeTag mealtTimeTag)
        {
            return await Context.Set<Recipe>().Where(r => r.MealTime == mealtTimeTag).ToListAsync();
        }
        else if (tag is EDifficultyTag difficultyTag)
        {
            return await Context.Set<Recipe>().Where(r => r.Difficulty == difficultyTag).ToListAsync();
        }
        else if (tag is ETypeCuisine typeCuisine)
        {
            return await Context.Set<Recipe>().Where(r => r.TypeCuisine == typeCuisine).ToListAsync();
        }

        throw new ArgumentException("Tag type not supported");
    }
}
