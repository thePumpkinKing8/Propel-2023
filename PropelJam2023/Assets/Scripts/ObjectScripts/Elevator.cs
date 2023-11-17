using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private bool _active;
    private bool _moving; 
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Transform _target;
    private Vector3 _position;

    private void Start()
    {
        _position = transform.position;
    }
    void FixedUpdate()
    {
        if(_active == true)
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
        }
        else if(_active == false && _moving == false)
        {
            transform.position = Vector3.Lerp(transform.position, _position, _speed * Time.deltaTime);
        }
    }

    public void Activate(bool value = true)
    {
        if(value == true)
        {
            _active = true;
        }
        else
        {
            _active = false;
        }
        
    }

    public void MoveByRotation(float amount)
    {
        float _distance = Vector3.Distance(transform.position, _target.position);
        Vector3 temp = transform.position;
        _moving = true;
        transform.Translate((transform.position - _target.position) * (amount * Time.deltaTime));
        if(Vector3.Distance(transform.position, _target.position) > _distance)
        {
            transform.position = temp;
        }

    }

    public void MoveDirection(Vector3 direction)
    {
        _moving = true;
        if(direction == Vector3.up)
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, _position, _speed * Time.deltaTime);
        }
        
    }

}
