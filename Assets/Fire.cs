using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    float firetime = 0.0f;
    public GameObject Poison;
   // public Enemy3 enemy3on;

    

    public void PoisonFire()
    {
        firetime -= Time.fixedDeltaTime;
        if (firetime <= 0.0 )
        {
            firetime = 4.0f;
            Instantiate(Poison, transform.position, Quaternion.identity);
        }
    }
}
