/*
 * Jacob Buri
 * SpawnManagerX.cs
 * Assignment 4
 * Spawns balls at the top of the screen in three colors
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    
    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    //Create ball color index
    private int[] colors = new int[3] { 0, 1, 2};
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(3.0f, 5.0f));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        int ballColor = colors[Random.Range(0, 2)];

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballColor], spawnPos, ballPrefabs[ballColor].transform.rotation);
    }

}
