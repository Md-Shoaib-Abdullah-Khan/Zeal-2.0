using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldFalcon : MonoBehaviour
{
    public bool ShieldFalconOn = false;

    public Transform playerposition;
    float ShieldFalconSpeed = -5.0f;

    public Rigidbody2D ShieldFalconrb;
    public Transform ShieldFalconPosition;
    public GameObject Deatheffect;
    public GameObject ShieldPowerEgg;


    void Update()
    {
        if (playerposition.position.x >= ShieldFalconPosition.position.x - 40.0) { ShieldFalconOn = true; }
        if (ShieldFalconOn)
        {
            ShieldFalconrb.velocity = new Vector2(ShieldFalconSpeed, 0f);

        }
    }

    public void die()
    {
        Destroy(this.gameObject);
        Instantiate(Deatheffect, transform.position, Quaternion.identity);
        Instantiate(ShieldPowerEgg, transform.position, Quaternion.identity);
    }
}
