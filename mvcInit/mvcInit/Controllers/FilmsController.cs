using Microsoft.AspNetCore.Mvc;

namespace mvcInit.Controllers
{
    public class FilmsController : Controller
    {
        public string Index() => "Action padrão!";

        public string Welcome() => "Bem vindo!";
    }
}
