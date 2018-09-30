using UnityEngine;
using System;

namespace Maikel.EventSystem
{
    public class GameEvent<ArgType> : ScriptableObject
    where ArgType : EventArgs
    {
        public event EventHandler<ArgType> EventFired;

        public void Invoke(ArgType args)
        {
            if (EventFired != null)
            {
                EventFired.Invoke(this, args);
            }
        }

        public void RegisterListener(EventHandler<ArgType> listener)
        {
            EventFired += listener;

        }

        public void UnregisterListener(EventHandler<ArgType> listener)
        {

            EventFired -= listener;
        }

        public void ClearListeners()
        {
            EventFired = null;
        }

        private void OnDestroy()
        {
            ClearListeners();
        }

    }
}

