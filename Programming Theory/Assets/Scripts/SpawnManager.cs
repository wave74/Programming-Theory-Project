using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPrefabs;
    [SerializeField] private float spawnInterval;
    private float xSpawnRange = 7.0f;
    private float ySpawnPos = 10.0f;
    private float zSpawnPos = 0.0f;

    void Start()
    {
        StartCoroutine(SpawnCycle());
    }

    void SpawnBall()
    {
        Instantiate(GetRandomBall(), GetRandomPosition(), Quaternion.identity);
    }
    IEnumerator SpawnCycle()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnBall();
        }
    }

    GameObject GetRandomBall()
    {
        int randomBallIndex = Random.Range(0, ballPrefabs.Length);
        return ballPrefabs[randomBallIndex];
    }

    Vector3 GetRandomPosition()
    {
        float xRandomPos = Random.Range(-xSpawnRange, xSpawnRange);
        return new Vector3(xRandomPos, ySpawnPos, zSpawnPos);

    }
}
