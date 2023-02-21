using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public void DestroyBall()
    {
        Destroy(gameObject);
    }

    public virtual void SetSize(float size)
    {
        transform.localScale *= size;
    }

}
