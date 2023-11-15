using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rb;
    private Vector2 _velocity = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        this.tag = "Player";
        _rb.velocity = _velocity * _speed;
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = _velocity * _speed;
    }
    private void FixedUpdate()
    {
        //_rb.transform.Translate(Vector2.right * Time.fixedDeltaTime * _speed);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _velocity *= new Vector2(-1, 0);
    }


}
