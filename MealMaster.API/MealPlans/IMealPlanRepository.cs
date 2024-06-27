
namespace BasePlatform.API.MealPlans
{
    public interface IMealPlanRepository
    {
        IEnumerable<MealPlan> GetAll();
        MealPlan GetById(int id);
        void Add(MealPlan mealPlan);
        void Update(MealPlan mealPlan);
        void Delete(int id);
    }
}
