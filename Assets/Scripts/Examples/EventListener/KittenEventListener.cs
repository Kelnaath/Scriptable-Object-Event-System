using UnityEngine.Events;
using System;
using Maikel.EventSystem;

[Serializable]
public class KittenEventListener : UnityEventListener<Kitten, KittenEvent, KittenUnityEvent>
{

}

[Serializable]
public class KittenUnityEvent : UnityEvent<Kitten> { }
