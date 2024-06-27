
namespace BasePlatform.API.MealPlans

{
    public class MealPlanService
    {
        private readonly IMealPlanRepository _mealPlanRepository;

        public MealPlanService(IMealPlanRepository mealPlanRepository)
        {
            _mealPlanRepository = mealPlanRepository;
        }

        public IEnumerable<MealPlan> GetAll()
        {
            return _mealPlanRepository.GetAll();
        }

        public MealPlan GetById(int id)
        {
            return _mealPlanRepository.GetById(id);
        }

        public void Add(MealPlan mealPlan)
        {
            // Business logic for adding a meal plan
            _mealPlanRepository.Add(mealPlan);
        }

        public void Update(MealPlan mealPlan)
        {
            // Business logic for updating a meal plan
            _mealPlanRepository.Update(mealPlan);
        }

        public void Delete(int id)
        {
            // Business logic for deleting a meal plan
            _mealPlanRepository.Delete(id);
        }
    }
}
