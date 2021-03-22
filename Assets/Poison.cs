using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{


     float speed = -10.0f;
    public Rigidbody2D poisonrb;
    public GameObject Deatheffect;
    void Start()
    {
        poisonrb.velocity = new Vector2(speed, 0f);
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        
        if (hitinfo.name != "Enemy3"&& hitinfo.name != "Enemy2"&& hitinfo.name != "Enemy1" && hitinfo.name != "Coin" && hitinfo.name != "Enemy4") 
        {
            Destroy(this.gameObject);
            if(hitinfo.name == "player") Instantiate(Deatheffect, transform.position, Quaternion.identity);
        }
    }
}
