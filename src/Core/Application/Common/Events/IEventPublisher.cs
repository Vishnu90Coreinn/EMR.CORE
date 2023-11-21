using EMR.CORE.Shared.Events;

namespace EMR.CORE.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}