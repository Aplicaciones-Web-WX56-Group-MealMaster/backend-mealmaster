
using BasePlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace BasePlatform.API.MealPlans

{
    public class MealPlanRepository : IMealPlanRepository
    {
        private readonly MealPlanDbContext _context;

        public MealPlanRepository(MealPlanDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MealPlan> GetAll()
        {
            return _context.MealPlans.ToList();
        }

        public MealPlan GetById(int id)
        {
            var mealPlan = _context.MealPlans.Find(id);
            if (mealPlan == null)
            {
                throw new Exception($"No MealPlan found with id {id}");
            }
            return mealPlan;
        }

        public void Add(MealPlan mealPlan)
        {
            _context.MealPlans.Add(mealPlan);
            _context.SaveChanges();
        }

        public void Update(MealPlan mealPlan)
        {
            _context.MealPlans.Update(mealPlan);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var mealPlan = GetById(id);
            _context.MealPlans.Remove(mealPlan);
            _context.SaveChanges();
        }
    }
}
