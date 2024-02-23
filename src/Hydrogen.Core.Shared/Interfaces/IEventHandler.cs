namespace Hydrogen.Core.Shared.Interfaces;

public interface IEventHandler<TEvent> : IHandler<TEvent> where TEvent : IEvent
{
}
