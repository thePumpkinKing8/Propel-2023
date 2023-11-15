using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] private bool _isOn;
    [SerializeField] private bool _moveRight;
    [SerializeField] private int _speed = 5;
    private SurfaceEffector2D _effector;

    // Start is called before the first frame update
    void Start()
    {
        _effector = GetComponent<SurfaceEffector2D>();
        if(_moveRight == false)
        {
            _effector.speed = _speed * -1;
        }
        else
        {

            _effector.speed = _speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
