namespace FirstWebApi;

public class CosmosService : IDataBaseService
{
  public string GetData()
  {
    return "data from cosmos service";
  }
}
