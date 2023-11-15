using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RotationArm : MonoBehaviour
{
    public Transform orb;
    public float radius;

    private Transform pivot;

    public UnityEvent<float> rotationEvent;

    void Start()
    {
        radius = Vector2.Distance(transform.position, orb.position)/2;
        pivot = orb.transform;
        transform.parent = pivot;
        transform.position += Vector3.up * radius;
    }

    private void OnMouseDrag()
    {
        Vector3 orbVector = Camera.main.WorldToScreenPoint(orb.position);
        orbVector = Input.mousePosition - orbVector;
        float angle = Mathf.Atan2(orbVector.y, orbVector.x) * Mathf.Rad2Deg;

        pivot.position = orb.position;
        pivot.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        rotationEvent.Invoke(angle);
        
    }

}
//modulus 360