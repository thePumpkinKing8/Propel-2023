using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    private bool _on = false;

    public void TurnOnOrOff(bool value)
    {
        _on = value;
    }
        
}
