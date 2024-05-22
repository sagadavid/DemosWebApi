using FirstWebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InjectionController : ControllerBase
    {
        private readonly IInjectionService _injectionService;
        public InjectionController(IInjectionService injectionService) //pre .net8 constructor injection
        {
            _injectionService = injectionService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Content(_injectionService.HilsPublikum());
        }



    }
}
