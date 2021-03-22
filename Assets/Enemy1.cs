using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
     bool enemy1on = false;

    public Transform playerposition;
     float enemy1speed = -8f;

    public Rigidbody2D enemy1rb;
    public Transform enemy1position;
   // public DeathEffect deatheffecton;
    public GameObject Deatheffect;


    // Update is called once per frame
    void Update()
    {
        if (playerposition.position.x >= enemy1position.position.x -30.0) { enemy1on = true ; }
        if (enemy1on)
        {
            enemy1rb.velocity = new Vector2(enemy1speed, 0f);
        }
    }
    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        //Debug.Log(collisioninfo.collider.name);
      
        if (collisioninfo.collider.name == "player")
        {

            die();
        }

    }

    public void die()
        {
        
        //Invoke("Deatheffect", 2.0f);
            Destroy(this.gameObject);
        //Debug.Log("Des");
        //Destroy(DeathEffect);
        Instantiate(Deatheffect, transform.position, Quaternion.identity);

        //deatheffecton.EnemyDeathEffect();
        
    }

    
}
