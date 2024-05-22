using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers;

[Route("[controller]")]
[ApiController]
public class KeyedServicesController : ControllerBase
{
  [HttpGet("sql")]
  public ActionResult GetSqlData
  ([FromKeyedServices("sqlService")] IDataBaseService dataService) => Content(dataService.GetData());

  [HttpGet("cosmos")]
  public ActionResult GetCosmosData
  ([FromKeyedServices("cosmosService")] IDataBaseService dataService) => Content(dataService.GetData());



}
