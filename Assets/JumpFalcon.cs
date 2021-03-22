using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFalcon : MonoBehaviour
{
    public bool JumpFalconOn = false;

    public Transform playerposition;
    float JumpFalconSpeed = -5.0f;

    public Rigidbody2D JumpFalconrb;
    public Transform JumpFalconPosition;
    public GameObject Deatheffect;
    public GameObject JumpPowerEgg;


    void Update()
    {
        if (playerposition.position.x >= JumpFalconPosition.position.x - 40.0) { JumpFalconOn = true; }
        if (JumpFalconOn)
        {
            JumpFalconrb.velocity = new Vector2(JumpFalconSpeed, 0f);

        }
    }

    public void die()
    {
        Destroy(this.gameObject);
        Instantiate(Deatheffect, transform.position, Quaternion.identity);
        Instantiate(JumpPowerEgg, transform.position, Quaternion.identity);
    }
}
