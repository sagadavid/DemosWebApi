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
    return $"Guid (kan) fornyes an på injection type: scoped, singleton eller transient! \n GuidNo er {injectGuid}, \n og fremkomst-time er {injectTime:yyyy-MM-dd HH:mm:ss} ";
  }

}
