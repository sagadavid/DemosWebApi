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
    return $"Hei :) min guidNo er {injectGuid}, \n og min fremkomst time er {injectTime:yyyy-MM-dd HH:mm:ss} \n og dens lifecycle er singelton og-eller scoped !";
  }

}
