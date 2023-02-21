using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public void BallCatched(int scoreToAdd)
    {
        GameManager.Instance.UpdateScore(scoreToAdd);
        Destroy(gameObject);
    }

    public void SetInitialSpeed(float initialForce)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * initialForce, ForceMode.Impulse);
    }
}
