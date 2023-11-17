using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] public float _speed;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rb;
    private Vector2 _velocity = Vector2.right;
    private bool isReversed = false;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level_02")
        {
            isReversed = true;
        }
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
        this.tag = "Player";
        _rb.velocity = _velocity * _speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(isReversed == true)
        {
            _rb.velocity = -(_velocity * _speed);
        }
        else
        {
            _rb.velocity = _velocity * _speed;
        }
        
    }
    private void FixedUpdate()
    {
        //_rb.transform.Translate(Vector2.right * Time.fixedDeltaTime * _speed);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)//turns around when hitting wall
    {
        if(collision.tag != "Switch")
        {
            _velocity *= new Vector2(-1, 0);
            this.gameObject.transform.localScale *= new Vector2(-1, 1);
        }
        
    }

    public void SwitchDirection(bool value)
    {
        isReversed = !value;
    }


}





