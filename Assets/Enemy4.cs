using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4 : MonoBehaviour
{
    public bool enemy4on = false;

    public Transform playerposition;
    float enemy4speed = -7.0f;

    public Rigidbody2D enemy4rb;
    public Transform enemy4position;
    public GameObject Deatheffect;

    public Enemy4Firepoint PoisonFire;// Update is called once per frame
    void Update()
    {
        if (playerposition.position.x >= enemy4position.position.x - 30.0) { enemy4on = true; }
        if (enemy4on)
        {
            enemy4rb.velocity = new Vector2(enemy4speed, 0f);
            
        }
    }

    public void die()
    {
        Destroy(this.gameObject);
        Instantiate(Deatheffect, transform.position, Quaternion.identity);
    }
}