using Microsoft.AspNetCore.Mvc;
namespace FineSpiritsStore.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}