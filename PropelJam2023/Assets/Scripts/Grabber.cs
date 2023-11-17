using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    public Player Object
    {
        get { return _object; }
    }

    private Player _object = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)//checks if nearby object is grabable and if it is remembers that object
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("grab");
            _object = collision.gameObject.GetComponent<Player>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)//forgets a saved object that leaves its trigger zone
    {
        if(collision.gameObject == _object)
        {
            _object = null;
        }
    }
}
