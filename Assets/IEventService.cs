using System;

public interface IEventService
{
    void FireEvent<TEvent>(TEvent eventPublisher) where TEvent : IEvent;

    void Subscribe<TEvent>(Action<TEvent> action) where TEvent : IEvent;

    void Unsubscribe<TEvent>(Action<TEvent> action) where TEvent : IEvent;

}

