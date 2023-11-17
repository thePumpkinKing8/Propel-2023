using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    private SurfaceEffector2D _surfaceEffector;
    [SerializeField] private float _speed;
    [SerializeField] private bool _directionRight = true;
    [SerializeField] private bool _on;
    // Start is called before the first frame update
    void Start()
    {
        _surfaceEffector = GetComponentInChildren<SurfaceEffector2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_directionRight == true && _on)
        {
            _surfaceEffector.speed = Mathf.Abs(_speed);
        }
        else if(_directionRight == false && _on)
        {
            _surfaceEffector.speed  = -1f * _speed;
        }
    }

    public void ChangeState()
    {
        _on = !_on;
    }

    public void ChangeDirection()
    {
        _directionRight = !_directionRight;
    }

}
