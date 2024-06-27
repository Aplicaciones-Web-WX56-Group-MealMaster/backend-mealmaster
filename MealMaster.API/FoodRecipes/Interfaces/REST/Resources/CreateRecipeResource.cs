using BasePlatform.API.FoodRecipes.Domain.Model.ValueObjects;

namespace BasePlatform.API.FoodRecipes.Interfaces.REST.Resources;

public record CreateRecipeResource(string name, List<string> ingredients /*Cambiar string por clase Ingredients*/ , string directions, string imageUrl, int calories, int proteins, int fats, int carbohydrates, EDifficultyTag difficulty, EMealtTimeTag mealTime, EPrincingTag princing, ETypeCuisine typeCuisine);