using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : SwitchObject
{
    [SerializeField] private Transform _rightPivot;
    [SerializeField] private Transform _leftPivot;
    [SerializeField] private float _speed = .05f;
   // [SerializeField] private bool _useLocalState; //choose whether to keep track of this objects state based on the Switches value(false) or the value of
    public override void TurnOnOrOff(bool value)
    {
        base.TurnOnOrOff(value);
    }


    private void FixedUpdate()
    {
        if (on == true)
        {
            _rightPivot.rotation = Quaternion.Lerp(_rightPivot.rotation, Quaternion.Euler(0, 0, 90), Time.deltaTime * _speed);
            _leftPivot.rotation = Quaternion.Lerp(_leftPivot.rotation, Quaternion.Euler(0, 0, -90), Time.deltaTime * _speed);
        }
        else
        {
            _rightPivot.rotation = Quaternion.Lerp(_rightPivot.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * _speed);
            _leftPivot.rotation = Quaternion.Lerp(_leftPivot.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * _speed);
        }
    }
}
