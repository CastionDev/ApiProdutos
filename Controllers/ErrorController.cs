using Microsoft.AspNetCore.Mvc;

namespace CrudFronteiraTec.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet("/error")]
        public IActionResult HandleError()
        {
            return Problem(
                title: "Erro interno no servidor",
                statusCode: 500
            );
        }
    }
}