using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    private bool _on = false;
    protected bool on
    {
        get
        {
            return _on;
        }
        set
        {
            _on = value;
            
        }
    }

    public virtual void TurnOnOrOff(bool value)
    {
        on = value;
    }
    
        
}
