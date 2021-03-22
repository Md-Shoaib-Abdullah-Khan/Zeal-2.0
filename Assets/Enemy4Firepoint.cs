using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Firepoint : MonoBehaviour
{
    float firetime = 0.0f;
    public GameObject Poison;
    public Enemy4 Enemy4;

    void Update()
    {
        if (Enemy4.enemy4on)
        {
            firetime -= Time.fixedDeltaTime;
            if (firetime <= 0.0)
            {
                firetime = 3.0f;
                Instantiate(Poison, transform.position, Quaternion.identity);
               // Debug.Log("Poison");
            }
        }
    }
}

   
