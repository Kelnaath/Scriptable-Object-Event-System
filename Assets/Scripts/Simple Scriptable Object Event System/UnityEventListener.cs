using System;
using UnityEngine.Events;

public class UnityEventListener<ArgType, EventType, UnityEventType> : GameEventListener<ArgType, EventType>
    where ArgType : EventArgs
    where EventType : GameEvent<ArgType>
    where UnityEventType : UnityEvent<ArgType>
{
    public UnityEventType Response;

    public override void OnEventRaised(object sender, ArgType args)
    {
        Response.Invoke(args);
    }
}
