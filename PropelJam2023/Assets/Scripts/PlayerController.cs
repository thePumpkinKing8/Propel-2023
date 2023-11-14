using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _flyForce = 2.0f;
    [SerializeField] private float _maxSpeed = 5.0f;
    [SerializeField] private Transform _container;
    private GameObject _heldObject;
    private Grabber _grabber;
    private Rigidbody2D _rb;
    private Vector2 _move;
    private bool _isFlying = false;
    private bool _hasObject;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _grabber = GetComponentInChildren<Grabber>();
    }

    private void Update()
    {
        _move = new Vector2(Input.GetAxisRaw("Horizontal"), 0); //gets axis player will move on
        
        if(Input.GetButton("Jump"))//checks if player is jumping
        {
     
            _isFlying = true;
        }
        else
        {
            _isFlying = false;
        }

        if(Input.GetKeyDown(KeyCode.E))//checks if player is trying to pick up/put own a gameobject
        {
            GameObject grabberObject = _grabber.Object;
            if(_hasObject == true)
            {
                PutDown(_heldObject);
                _hasObject = false;
            }
            else if(grabberObject != null)
            {
                PickUp(grabberObject);
                _hasObject = true;
            }
        }

        
    }
    void FixedUpdate()
    {
        _rb.transform.Translate(_move * Time.fixedDeltaTime * _speed);//moves the player


        if(_isFlying == true)//adds upward force to the player while they are holding jump
        {
            _rb.AddForce(new Vector2(0, _flyForce));
        }

        if(_rb.velocity.magnitude > _maxSpeed)//limits the players velocity
        {
            _rb.velocity = _rb.velocity.normalized * _maxSpeed;
        }

        if(_move.x != 0)//switches the direction the player is facing
        {
            this.transform.localScale = new Vector3(_move.x, transform.localScale.y, transform.localScale.z); ;
        }
       
    }

    private void PickUp(GameObject _object) //has the plyer pick up a game object
    {
        _object.transform.SetParent(_container);
        _object.transform.position = _container.transform.position;
        _heldObject = _object;
    }

    private void PutDown(GameObject _object) // has player put down a held game object
    {
        _object.transform.SetParent(null);
        _object.transform.position = _grabber.GetComponent<BoxCollider2D>().ClosestPoint(transform.position);
    }



}
