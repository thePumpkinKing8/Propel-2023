using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent Event; // The event raised
    public UnityEvent Response; // Response to the event

    private void OnEnable()
    { Event.RegisterListener(this); } // Subscribes to the event

    private void OnDisable()
    { Event.UnregisterListener(this); } // Unsubscribes from the event

    public void OnEventRaised()
    { Response.Invoke(); } // Invokes the Unity event
}
