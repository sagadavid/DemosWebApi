namespace FirstWebApi;

public class SingletonService : ISingletonService
{
  private readonly Guid _singletonGuid;
  private readonly DateTime _singletonTime;

  public SingletonService()
  {
    _singletonGuid = Guid.NewGuid();
    _singletonTime = DateTime.Now;
  }

  public string Navning => nameof(SingletonService);
  public string HilsPublikum()
  {
    return $" hilsen ! mitt {Navning}-guid er {_singletonGuid}, \n fremkomst-time er {_singletonTime}";
  }
}
