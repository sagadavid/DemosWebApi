namespace FirstWebApi;

public class TransientService : ITransientService
{
  private readonly Guid _transientGuid;
  private readonly DateTime _transientTime;

  public TransientService()
  {
    _transientGuid = Guid.NewGuid();
    _transientTime = DateTime.Now;
  }

  public string Navning => nameof(TransientService);
  public string HilsPublikum()
  {
    return $" hilsen ! mitt {Navning}-guid er {_transientGuid}, \n fremkomst-time er {_transientTime}";

  }

}
