
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 10;
    public bool death = false;

    public Enemy1 enemy1;
    public Enemy2 enemy2;
    public Enemy3 enemy3;
    public Poison poison;
    bool ShieldOn;

    //Health bar initiation:
    
    public Transform HealthBarPoint;

    public GameObject HealthBarPrefab0;
    public GameObject HealthBarPrefab1;
    public GameObject HealthBarPrefab2;
    public GameObject HealthBarPrefab3;
    public GameObject HealthBarPrefab4;
    public GameObject HealthBarPrefab5;
    public GameObject HealthBarPrefab6;
    public GameObject HealthBarPrefab7;
    public GameObject HealthBarPrefab8;
    public GameObject HealthBarPrefab9;
    public GameObject HealthBarPrefab10;

    public void Shield(bool Shield)
    {
        ShieldOn = Shield;
    }

    void Update()
    {
        if (health == 0) { Instantiate(HealthBarPrefab0, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 1) { Instantiate(HealthBarPrefab1, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 2) { Instantiate(HealthBarPrefab2, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 3) { Instantiate(HealthBarPrefab3, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 4) { Instantiate(HealthBarPrefab4, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 5) { Instantiate(HealthBarPrefab5, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 6) { Instantiate(HealthBarPrefab6, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 7) { Instantiate(HealthBarPrefab7, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 8) { Instantiate(HealthBarPrefab8, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 9) { Instantiate(HealthBarPrefab9, HealthBarPoint.position, HealthBarPoint.rotation); }
        if (health == 10) { Instantiate(HealthBarPrefab10, HealthBarPoint.position, HealthBarPoint.rotation); }
    }

    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        
       if(collisioninfo.collider.tag=="Enemy1")
        {
            if(ShieldOn==false)health--;
            
        }
        if (collisioninfo.collider.tag == "Enemy2")
        {
            if (ShieldOn == false) health--;
            
        }

        if (collisioninfo.collider.tag == "Enemy3")
        {
            if (ShieldOn == false) health--;
             
        }
        if (collisioninfo.collider.tag == "Poison")
        {
            if (ShieldOn == false) health--;
        }
        if (collisioninfo.collider.tag == "PoisonDown")
        {
            if (ShieldOn == false) health--;
        }

        Debug.Log(health);

        if (health == 0) { death = true; }


        //Health bar update:

        
    }


}
