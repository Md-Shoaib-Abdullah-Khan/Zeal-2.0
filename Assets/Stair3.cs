using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair3 : MonoBehaviour
{
    public Rigidbody2D Stair3rb;
    public Transform Stair3pos;

     float Stair3speed = -20.0f;

     void Update()
    {
        if (transform.position.y > Stair3pos.position.y)
        {
            transform.position = Stair3pos.position;
            Stair3rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }

    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        //Debug.Log(collisioninfo.collider.name);

        if (collisioninfo.collider.name == "player")
        {

            Invoke("Down",1.0f);
        }

    }

    public void Down()
    {
        Stair3rb.velocity = new Vector2(0.0f,Stair3speed);
        Invoke("Up", 1.0f);
    }

    public void Up()
    {
        Stair3rb.velocity = new Vector2(0.0f, -Stair3speed);
    }
}
