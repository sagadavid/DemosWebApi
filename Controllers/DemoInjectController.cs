using FirstWebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoInjectController : ControllerBase
    {
        private readonly IDemoInjectService _demoInjectService;
        public DemoInjectController(IDemoInjectService demoInjectService) //pre .net8 constructor injection
        {
            _demoInjectService = demoInjectService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Content(_demoInjectService.HilsPublikum());
        }



    }
}
