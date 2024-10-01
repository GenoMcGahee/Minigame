using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnDemon", startDelay, spawnInterval);
    }

    // Update is called once per frame

    public GameObject[] demonPrefab;
    private float spawnRangeY = 8;
    private float spawnPosX = 15;

    void Update()
    {
        

    }
    void SpawnDemon()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(2, spawnRangeY));
        int demonIndex = Random.Range(0, demonPrefab.Length);
        Instantiate(demonPrefab[demonIndex], new Vector3(15, Random.Range(2, spawnRangeY), -3), demonPrefab[demonIndex].transform.rotation);
    }

}

