using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//conveyor belts dont work for some reason
public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _on;
    [SerializeField] private Grabber _grabber;

    public UnityEvent swap;
    // Start is called before the first frame update
    void Start()
    {
       _grabber = GetComponent<Grabber>();
      

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ChangeState()
    {
        _on = !_on;
    }

    public void ChangeDirection()
    {
        _speed *= -1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           swap.Invoke();
        }
    }

}
