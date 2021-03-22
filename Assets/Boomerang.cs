using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    float speed = 10.0f;
    public Rigidbody2D boomerangrb;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(transform.right.x);
        if (transform.right.x==1)boomerangrb.velocity = new Vector2(speed,speed);
        if (transform.right.x ==-1) boomerangrb.velocity = new Vector2(-speed, speed);
        

    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        //Debug.Log(hitinfo.name);
        Enemy1 enemy1 = hitinfo.GetComponent<Enemy1>();

        Enemy2 enemy2 = hitinfo.GetComponent<Enemy2>();

        Enemy3 enemy3 = hitinfo.GetComponent<Enemy3>();
        
        Enemy4 enemy4 = hitinfo.GetComponent<Enemy4>();

        SpeedFalcon SpeedFalcon = hitinfo.GetComponent<SpeedFalcon>();
        ShieldFalcon ShieldFalcon = hitinfo.GetComponent<ShieldFalcon>();
        JumpFalcon JumpFalcon = hitinfo.GetComponent<JumpFalcon>();
        if (enemy1 != null) { enemy1.die(); }
        if (enemy2 != null) { enemy2.die(); }
        if (enemy3 != null) { enemy3.die(); }
        if (enemy4 != null) { enemy4.die(); }
        if (SpeedFalcon != null) { SpeedFalcon.die(); }
        if (ShieldFalcon != null) { ShieldFalcon.die(); }
        if (JumpFalcon != null) { JumpFalcon.die(); }

        if (hitinfo.name != "player") { Destroy(this.gameObject); }
    }
}
