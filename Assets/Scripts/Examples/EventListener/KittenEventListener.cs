using UnityEngine.Events;
using System;

[Serializable]
public class KittenEventListener : UnityEventListener<Kitten, KittenEvent, KittenUnityEvent>
{

}

[Serializable]
public class KittenUnityEvent : UnityEvent<Kitten> { }
