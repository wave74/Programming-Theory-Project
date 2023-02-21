using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private float displayScore;
    [SerializeField] TextMeshProUGUI scoreText;

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void UpdateScore(int score)
    {
        displayScore += score;
        scoreText.text = "Score: " + displayScore;
    }
}
