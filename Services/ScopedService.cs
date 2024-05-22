namespace FirstWebApi;

public class ScopedService : IScopedService
{
  private readonly Guid _scopedGuid;
  private readonly DateTime _scopedTime;
  private readonly ITransientService _transientService;
  private readonly ISingletonService _singeltonService;

  public ScopedService(ITransientService transientService, ISingletonService singeltonService)
  {
    _scopedGuid = Guid.NewGuid();
    _scopedTime = DateTime.Now;
    _transientService = transientService;
    _singeltonService = singeltonService;
  }

  public string Navning => nameof(ScopedService);
  public string HilsPublikum()
  {
    var scopedServiceMessage = $"hilsen ! mitt {Navning}-guid er {_scopedGuid},\n fremkomst-time er {_scopedTime}";
    var singletonServiceMessage = $"{_singeltonService.HilsPublikum()}. jeg fremkommer under {Navning} lifetime";
    var transientServiceMessage = $"{_transientService.HilsPublikum()}. jeg fremkommer under {Navning} lifetime";

    return $"{scopedServiceMessage}{Environment.NewLine}{singletonServiceMessage}{Environment.NewLine}{transientServiceMessage}";
  }
}
