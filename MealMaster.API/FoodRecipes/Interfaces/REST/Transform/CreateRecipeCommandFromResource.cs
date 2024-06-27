using BasePlatform.API.FoodRecipes.Domain.Model.Commands;
using BasePlatform.API.FoodRecipes.Interfaces.REST.Resources;

namespace BasePlatform.API.FoodRecipes.Interfaces.REST.Transform;

public class CreateRecipeCommandFromResource
{
    public static CreateRecipeCommand ToCommandFromResource(CreateRecipeResource resource)
    {
        return new CreateRecipeCommand(resource.name, resource.ingredients, resource.directions, resource.imageUrl, resource.calories, resource.proteins, resource.fats, resource.carbohydrates, resource.difficulty, resource.mealTime, resource.princing, resource.typeCuisine);
    }
}