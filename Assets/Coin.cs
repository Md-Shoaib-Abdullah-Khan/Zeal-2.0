using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int Point=0;
    void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        if(collisioninfo.collider.name == "player") 
        { Point++ ;
            Destroy(this.gameObject);
        }

        Debug.Log(Point);   
    }
}
