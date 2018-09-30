using System;
using UnityEngine;
using UnityEngine.Events;

namespace Maikel.EventSystem
{
    public abstract class GameEventListener<ArgType, EventType> : MonoBehaviour
    where ArgType : EventArgs
    where EventType : GameEvent<ArgType>
    {
        public EventType Event;

        private void OnEnable()
        {
            Event.RegisterListener(OnEventRaised);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(OnEventRaised);
        }

        public abstract void OnEventRaised(object sender, ArgType args);
    }
}


