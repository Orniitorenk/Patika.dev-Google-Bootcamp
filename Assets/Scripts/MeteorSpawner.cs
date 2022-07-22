using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteor;
    public float nextSpawn = 4f;
    public Transform[] spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnMeteor());
    }


    IEnumerator SpawnMeteor()
    {
        while (true)
        {
            Instantiate(meteor, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            yield return new WaitForSeconds(nextSpawn);
        }
    }
}
