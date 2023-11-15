using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent<bool> LeverPull;
    private bool _on = false;

    public void Clicked()
    {
        Debug.Log("huh");
        _on = !_on;
        LeverPull.Invoke(_on);
    }

    public void Test(bool value)
    {
        Debug.Log(value);
    }

    private void OnMouseDown()
    {
        Clicked();
    }


}
