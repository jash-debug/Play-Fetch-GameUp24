using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float lastSpawn = 0f;
    public float spawnDelay = 1.5f;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog after 3 seconds pass
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastSpawn + spawnDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawn = Time.time;
        }
    }
}
