using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerScript : MonoBehaviour
{
    public Transform Pos;
    // Start is called before the first frame update
    void Update()
    {
        //Pos= GetComponent<player>();
        //transform.position = PlayerPos.position; ;
        //Invoke("PowerOff",.1f);
        //PowerOff();
    }
    public void PowerOff()
    {
        Destroy(this.gameObject);
    }
}
