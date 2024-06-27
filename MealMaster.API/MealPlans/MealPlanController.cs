
using Microsoft.AspNetCore.Mvc;

namespace BasePlatform.API.MealPlans

{
    [Route("api/[controller]")]
    [ApiController]
    public class MealPlanController : ControllerBase
    {
        private readonly MealPlanService _mealPlanService;

        public MealPlanController(MealPlanService mealPlanService)
        {
            _mealPlanService = mealPlanService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MealPlan>> GetAll()
        {
            var mealPlans = _mealPlanService.GetAll();
            return Ok(mealPlans);
        }

        [HttpGet("{id}")]
        public ActionResult<MealPlan> GetById(int id)
        {
            var mealPlan = _mealPlanService.GetById(id);
            if (mealPlan == null)
            {
                return NotFound();
            }
            return Ok(mealPlan);
        }

        [HttpPost]
        public ActionResult Add(MealPlan mealPlan)
        {
            _mealPlanService.Add(mealPlan);
            return CreatedAtAction(nameof(GetById), new { id = mealPlan.Id }, mealPlan);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, MealPlan mealPlan)
        {
            if (id != mealPlan.Id)
            {
                return BadRequest();
            }

            _mealPlanService.Update(mealPlan);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _mealPlanService.Delete(id);
            return NoContent();
        }
    }
}
