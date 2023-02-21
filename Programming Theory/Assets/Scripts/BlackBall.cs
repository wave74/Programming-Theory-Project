using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBall : Ball
{
    [SerializeField] private float initialForce;
    [SerializeField] private int score;

    void Start()
    {
        SetInitialSpeed(initialForce);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            BallCatched(score);
        }

        if(other.gameObject.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }
}
