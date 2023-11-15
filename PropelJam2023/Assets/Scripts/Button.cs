using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Button : MonoBehaviour
{
    public UnityEvent OnPressed;

    public void Clicked()
    {
        OnPressed.Invoke();
    }
    private void OnMouseDown()
    {
        Clicked();
    }
}
