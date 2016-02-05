namespace MvcEssentialsHw.Controllers
{
    using System.Web.Mvc;
    using MvcEssentialsHw.Models;

    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Calculator()
        {
            var model = new CalculatorFormViewModel
            {
                Quantity = 1,
                Type = "1",
                Kilo = "1000"
            };
            foreach (var unit in model.Units)
            {
                ((StorageUnit)unit).RelativeValue = 1 / ((StorageUnit)unit).IntrinsicValue;
            }

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Calculator(CalculatorFormViewModel model)
        {
            var chosenValue = decimal.Parse(model.Type);
            var kilo = decimal.Parse(model.Kilo);
            var quantity = model.Quantity;

            foreach (var unit in model.Units)
            {
                ((StorageUnit)unit).RelativeValue = (chosenValue / ((StorageUnit)unit).IntrinsicValue) * quantity;
                if (kilo == 1024)
                {
                    ((StorageUnit)unit).RelativeValue *= 1024.0m / 1000;
                }
            }

            if (this.Request.IsAjaxRequest())
            {
                return this.PartialView("_CalcResult", model);
            }

            return this.View(model);
        }

        [ChildActionOnly]
        public ActionResult CalcPartial(CalculatorFormViewModel model)
        {
            return this.PartialView("_CalcResult", model);
        }
    }
}