using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatedObject : MonoBehaviour
{
    public virtual void Activate()
    {
        Debug.Log(this.gameObject.name + "Acivated");
    }
}
