using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedEgg : MonoBehaviour
{
    

   
    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        

        if (collisioninfo.collider.name == "player")
        {
            Destroy(this.gameObject);
          
        }
       
    }
}
