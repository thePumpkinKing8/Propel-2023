using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> _listeners = new List<GameEventListener>(); // How many listeners are there?

    public void Raise() // Increments listeners in the list
    {
        for (int i = _listeners.Count - 1; i >= 0; i--)
            _listeners[i].OnEventRaised();
    }

    public void RegisterListener(GameEventListener listener)
    {_listeners.Add(listener); }

    public void UnregisterListener(GameEventListener listener)
    {_listeners.Remove(listener); }
}

