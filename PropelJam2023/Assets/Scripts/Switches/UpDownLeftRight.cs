using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UpDownLeftRight : MonoBehaviour
{
    public UnityEvent<Vector3> DirectionPressed;
    public UnityEvent<Vector3> SendDirection;
    [SerializeField] private Direction direction;

    private Vector3[] _direction = new Vector3[5]
        {
            Vector3.up,
            Vector3.down,
            Vector3.left,
            Vector3.right,
            Vector3.zero
        };

    private void OnMouseDrag()
    {
        DirectionPressed.Invoke(_direction[((int)direction)]);
    }

    public void ButtonPressed(Vector3 value) //calls parent to send direction
    {
        SendDirection.Invoke(value);
    }

}
public enum Direction
{ 
    up,
    down,
    left,
    right,
    none
}

