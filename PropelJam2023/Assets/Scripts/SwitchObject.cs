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
    [SerializeField] private bool _isLocal; // will allow multiple switches to effect this object naturally

    public virtual void TurnOnOrOff(bool value)
    {
        if (_isLocal)
        {
            on = value;
        }
        else
        {
            on = !on;
        }
    }
    
        
}
