/*
 * Jacob Buri
 * PlayerControllerX.cs
 * Assignment 4
 * Gets spacebar to spawn a dog
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float nextFire = 0.0f;
    public float fireRate = 3.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press and after cd, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation) as GameObject;
        }
    }
}
