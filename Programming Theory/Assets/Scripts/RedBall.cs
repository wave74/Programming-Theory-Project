using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{
    void Start()
    {
        SetSize(1.5f);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            DestroyBall();
        }
    }
}
