using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LifeTimeController : ControllerBase
    {
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;
        private readonly ISingletonService _singletonService;

        public LifeTimeController(IScopedService scopedService, ITransientService transientService,
            ISingletonService singletonService)
        {
            _scopedService = scopedService;
            _transientService = transientService;
            _singletonService = singletonService;
        }

        [HttpGet]
        public ActionResult Get([FromServices] ITransientService transientService)
        {
            var scopedServiceMessage = _scopedService.HilsPublikum();
            var transientServiceMessage = transientService.HilsPublikum();
            var singletonServiceMessage = _singletonService.HilsPublikum();
            return Content(
                $"{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}{singletonServiceMessage}");
        }
    }
}
