namespace FirstWebApi;

public class SqlService : IDataBaseService
{
  public string GetData()
  {
    return "data from sql service";
  }
}
