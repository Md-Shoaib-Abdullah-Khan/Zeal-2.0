using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    bool enemy2on = false;

    public Transform playerposition;
    float enemy2speed = -8f;

    public Rigidbody2D enemy2rb;
    public Transform enemy2position;
    public GameObject Deatheffect;

    // Update is called once per frame
    void Update()
    {
        if (playerposition.position.x >= enemy2position.position.x - 30.0) { enemy2on = true; }
        if (enemy2on)
        {
            enemy2rb.velocity = new Vector2(enemy2speed, 0f);
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
