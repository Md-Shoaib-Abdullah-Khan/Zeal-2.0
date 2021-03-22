using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonDown : MonoBehaviour
{
     float speed = -10.0f;
    public Rigidbody2D poisondownrb;
    public GameObject Deatheffect;
    void Start()
    {
        poisondownrb.velocity = new Vector2( 0.0f,speed);
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {

        if (hitinfo.tag != "Enemy3" && hitinfo.tag != "Enemy2" && hitinfo.tag != "Enemy1" && hitinfo.tag != "Enemy4")
        {
            Debug.Log("Destroy");
            Destroy(this.gameObject);
            if (hitinfo.name == "player") Instantiate(Deatheffect, transform.position, Quaternion.identity);

        }
    }
}
