namespace FirstWebApi;

public class InjectionService : IInjectionService
{
  private readonly Guid injectGuid;
  private readonly DateTime injectTime;

  public InjectionService()
  {
    injectGuid = Guid.NewGuid();
    injectTime = DateTime.Now;
  }

  public string HilsPublikum()
  {
    return $"Hei, guidNo er {injectGuid}, \n og fremkomst-time er {injectTime:yyyy-MM-dd HH:mm:ss},\n guid (kan) fornyes an på lifecycle av injection type: scoped, singleton eller transient !";
  }

}
