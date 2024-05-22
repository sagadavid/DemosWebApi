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
        public ActionResult Get()
        {
            var scopedServiceMessage = _scopedService.HilsPublikum();
            var transientServiceMessage = _transientService.HilsPublikum();
            var singletonServiceMessage = _singletonService.HilsPublikum();
            return Content(
                $"{scopedServiceMessage}{Environment.NewLine}\n{transientServiceMessage}{Environment.NewLine}\n{singletonServiceMessage}");
        }
    }
}
