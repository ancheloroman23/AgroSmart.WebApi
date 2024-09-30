using Microsoft.AspNetCore.Mvc;

namespace AgroSmart.WebApi.Controllers.V1
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
