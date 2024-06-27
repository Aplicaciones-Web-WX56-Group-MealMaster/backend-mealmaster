using BasePlatform.API.FoodRecipes.Domain.Model.Commands;
using BasePlatform.API.FoodRecipes.Domain.Model.ValueObjects;

namespace BasePlatform.API.FoodRecipes.Domain.Model.Aggregates;

public partial class Recipe
{
    public Recipe()
    {
        
    }
    
    public Recipe(string name,List<string> ingredients, string directions, string imageUrl, int calories, int proteins, int fats, int carbohydrates, EDifficultyTag difficulty, EMealtTimeTag mealTime, EPrincingTag princing, ETypeCuisine typeCuisine)
    {
        this.name = name;
        this.Ingredients = ingredients;
        this.directions = directions;
        this.imageUrl = imageUrl;
        this.calories = calories;
        this.proteins = proteins;
        this.fats = fats;
        this.carbohydrates = carbohydrates;
        Difficulty = difficulty;
        MealTime = mealTime;
        Princing = princing;
        TypeCuisine = typeCuisine;
    }

    public Recipe(CreateRecipeCommand command)
    {
        this.name = command.name;
        this.Ingredients = command.ingredients;
        this.directions = command.directions;
        this.imageUrl = command.imageUrl;
        this.calories = command.calories;
        this.proteins = command.proteins;
        this.fats = command.fats;
        this.carbohydrates = command.carbohydrates;
        Difficulty = command.difficulty;
        MealTime = command.mealTime;
        Princing = command.princing;
        TypeCuisine = command.typeCuisine;
    }
    
    public int Id { get; }
    
    public string name { get; private set; }
    
    public string directions { get; private set; }
    
    public string imageUrl { get; private set; }
    
    public int calories { get; private set; }
    
    public int proteins { get; private set; }
    
    public int fats { get; private set; }
    
    public int carbohydrates { get; private set; }
    
    // cambiar string por la clase Ingredient
    public List<string> Ingredients { get; private set; }
    
    public EDifficultyTag Difficulty { get; private set; }
    
    public EMealtTimeTag MealTime { get; private set; }
    
    public EPrincingTag Princing { get; private set; }
    
    public ETypeCuisine TypeCuisine { get; private set; }
    
}