using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour

    
{
    float SpawnTimer = 5.0f;
    public GameObject Stair1Prefab;
    // Update is called once per frame
    void Update()
    {
        SpawnTimer -= Time.fixedDeltaTime;

        if (SpawnTimer <= 0.0) 
        {
            SpawnTimer = 5.0f;
            Instantiate(Stair1Prefab, transform.position, transform.rotation); }
    }
}
