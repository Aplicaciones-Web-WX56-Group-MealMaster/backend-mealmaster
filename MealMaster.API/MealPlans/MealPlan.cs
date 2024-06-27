
namespace BasePlatform.API.MealPlans
{
    public class MealPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int UserId { get; set; }

        public MealPlan()
        {
            Name = string.Empty; // Initialize Name
            StartDate = DateTime.Now;
            EndDate = StartDate.AddDays(30);
        }

        // If you need to change the dates after the object is created, you can add methods to do so
        public void SetStartDate(DateTime startDate)
        {
            StartDate = startDate;
            EndDate = StartDate.AddDays(30);
        }

        public void ExtendEndDate(int additionalDays)
        {
            EndDate = EndDate.AddDays(additionalDays);
        }
    }
}