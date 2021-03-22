using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair1 : MonoBehaviour
{
     float speed = 5.0f;
    public Rigidbody2D stair1rb;

    public Transform stair1transform;

   

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        stair1rb.velocity = new Vector2(0.0f, speed);
        if (stair1transform.position.y >= 35.0f) { Destroy(this.gameObject); }
    }

    
}
