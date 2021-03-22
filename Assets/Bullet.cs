using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public  float speed=50.0f;
        public Rigidbody2D bulletrb;
    // Start is called before the first frame update
    void Start()
    {
        bulletrb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        //Debug.Log(hitinfo.name);
        Enemy1 enemy1 = hitinfo.GetComponent<Enemy1>();

        Enemy4 enemy4 = hitinfo.GetComponent<Enemy4>();

        Enemy3 enemy3 = hitinfo.GetComponent<Enemy3>();

        if (enemy1 != null) { enemy1.die(); }
        if (enemy4 != null) { enemy4.die(); }
        if (enemy3 != null) { enemy3.die(); }

        if (hitinfo.name != "player") { Destroy(gameObject); }
    }
   
}
