using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public bool enemy3on = false;

    public Transform playerposition;
    float enemy3speed = -8f;

    public Rigidbody2D enemy3rb;
    public Transform enemy3position;
    public GameObject Deatheffect;

    public Fire PoisonFire;
    // Update is called once per frame
    void Update()
    {
        if (playerposition.position.x >= enemy3position.position.x - 30.0) { enemy3on = true; }
        if (enemy3on)
        {
            enemy3rb.velocity = new Vector2(enemy3speed, 0f);
            PoisonFire.PoisonFire();
        }
    }

    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        Debug.Log(collisioninfo.collider.name);

        if (collisioninfo.collider.name == "player")
        {

            die();
        }

    }

    public void die()
    {
        Destroy(this.gameObject);
        Instantiate(Deatheffect, transform.position, Quaternion.identity);
    }
}