using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rb;
    private Vector2 _velocity = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
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

    private void OnTriggerEnter2D(Collider2D collision)//turns around when hitting wall
    {
        _velocity *= new Vector2(-1, 0);
        this.gameObject.transform.localScale *= new Vector2(-1,1);
    }


}





