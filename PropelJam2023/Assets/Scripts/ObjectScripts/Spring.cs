using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : ActivatedObject
{
    public override void Activate()
    {
        Debug.Log("player jumps");
    }
}