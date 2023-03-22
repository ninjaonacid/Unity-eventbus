using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubscription<TEvent>
{
    void Publish(TEvent eventItem);
    object SubscriptionToken { get; }
}
