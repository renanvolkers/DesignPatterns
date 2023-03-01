using Microsoft.Extensions.Options;

namespace Singleton.Domain
{
    public class SingletonService : ISingletonService
    {
        private readonly IOptionsMonitor<UnitOptions> _unitOptions;

        public SingletonService(IOptionsMonitor<UnitOptions> unitOptions)
        {
            _unitOptions = unitOptions;
        }
        public UnitOptions GetUnits()
        {
            return _unitOptions.CurrentValue;
        }
    }
}
