using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedFalcon : MonoBehaviour
{
    public bool SpeedFalconOn = false;

    public Transform playerposition;
    float SpeedFalconSpeed = -5.0f;

    public Rigidbody2D SpeedFalconrb;
    public Transform SpeedFalconPosition;
    public GameObject Deatheffect;
    public GameObject SpeedPowerEgg;


    void Update()
    {
        if (playerposition.position.x >= SpeedFalconPosition.position.x - 40.0) { SpeedFalconOn = true; }
        if (SpeedFalconOn)
        {
            SpeedFalconrb.velocity = new Vector2(SpeedFalconSpeed, 0f);
           
        }
    }

    public void die()
    {
        Destroy(this.gameObject);
        Instantiate(Deatheffect, transform.position, Quaternion.identity);
        Instantiate(SpeedPowerEgg, transform.position, Quaternion.identity);
    }
}
