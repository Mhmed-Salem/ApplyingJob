using Microsoft.AspNetCore.Mvc;

namespace JobApplying.Controllers
{
    public class ApplierController:Controller
    {
        public IActionResult AddApplier()
        {
            return View();
        }
    }
}