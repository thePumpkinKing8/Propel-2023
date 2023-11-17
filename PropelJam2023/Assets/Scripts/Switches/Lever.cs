using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent<bool> LeverPull;
    [SerializeField] private SpriteRenderer right;
    [SerializeField] private SpriteRenderer left;
    private bool _on = false;


    private void Start()
    {
        left.enabled = false;
    }
    public void Clicked()
    {
        _on = !_on;
        left.enabled = _on;
        right.enabled = !_on;
        LeverPull.Invoke(_on);
    }

    public void Test(bool value)
    {
        Debug.Log(value);
    }

    private void OnMouseDown()
    {
        Clicked();
    }


}
