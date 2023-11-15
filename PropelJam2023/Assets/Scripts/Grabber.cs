using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    public GameObject Object
    {
        get { return _object; }
    }

    private GameObject _object = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)//checks if nearby object is grabable and if it is remembers that object
    {
        if(collision.tag == "Player")
        {
            Debug.Log("grab");
            _object = collision.gameObject;
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
