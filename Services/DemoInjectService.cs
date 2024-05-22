namespace FirstWebApi;

public class DemoInjectService : IDemoInjectService
{
  private readonly Guid injectGuid;
  private readonly DateTime injectTime;

  public DemoInjectService()
  {
    injectGuid = Guid.NewGuid();
    injectTime = DateTime.Now;
  }

  public string HilsPublikum()
  {
    return $"Hei :) min guidNo er {injectGuid}, \n og min fremkomst time er {injectTime:yyyy-MM-dd HH:mm:ss} !";
  }

}
