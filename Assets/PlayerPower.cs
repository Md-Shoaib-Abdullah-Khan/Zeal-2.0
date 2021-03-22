using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{
    public Transform Powerpoint;
    bool SpeedPowerOn = false;
    public GameObject SpeedPowerPrefab1;
    public GameObject SpeedPowerPrefab2;
    public GameObject SpeedPowerPrefab3;
    public GameObject SpeedPowerPrefab4;
   

    public PlayerMovement PlayerSpeed;
    int i = 1,j=1;

    //Shield Power Initiation:
    public Health HealthCall;
      bool ShieldPowerOn = false;
    
    public GameObject ShieldPowerPrefab;

     bool JumpPowerOn = false;
    public GameObject JumpPowerPrefab1;
    public GameObject JumpPowerPrefab2;
    public GameObject JumpPowerPrefab3;
    public GameObject JumpPowerPrefab4;
    public GameObject JumpPowerPrefab5;
    public GameObject JumpPowerPrefab6;
    public GameObject JumpPowerPrefab7;
    public GameObject JumpPowerPrefab8;
    public GameObject JumpPowerPrefab9;
    public GameObject JumpPowerPrefab10;
    public GameObject JumpPowerPrefab11;
    public GameObject JumpPowerPrefab12;
    public GameObject JumpPowerPrefab13;
    public GameObject JumpPowerPrefab14;
    public GameObject JumpPowerPrefab15;
    public GameObject JumpPowerPrefab16;
    public GameObject JumpPowerPrefab17;
    public GameObject JumpPowerPrefab18;
    public GameObject JumpPowerPrefab19;
    public GameObject JumpPowerPrefab20;
    public GameObject JumpPowerPrefab21;
    public GameObject JumpPowerPrefab22;
    public GameObject JumpPowerPrefab23;
    public GameObject JumpPowerPrefab24;
    public GameObject JumpPowerPrefab25;
    public GameObject JumpPowerPrefab26;
    public GameObject JumpPowerPrefab27;
    public GameObject JumpPowerPrefab28;
    public GameObject JumpPowerPrefab29;
    public GameObject JumpPowerPrefab30;
    public GameObject JumpPowerPrefab31;
    public GameObject JumpPowerPrefab32;
    public GameObject JumpPowerPrefab33;
    public GameObject JumpPowerPrefab34;
    public GameObject JumpPowerPrefab35;
    public GameObject JumpPowerPrefab36;
    public GameObject JumpPowerPrefab37;
    public GameObject JumpPowerPrefab38;
    public GameObject JumpPowerPrefab39;
    public GameObject JumpPowerPrefab40;
    public GameObject JumpPowerPrefab41;
    public GameObject JumpPowerPrefab42;
    public GameObject JumpPowerPrefab43;
    public GameObject JumpPowerPrefab44;
    public GameObject JumpPowerPrefab45;
    public GameObject JumpPowerPrefab46;
    public GameObject JumpPowerPrefab47;
    public GameObject JumpPowerPrefab48;

    public CharacterController2D PlayerJump; 
    


    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        if (SpeedPowerOn)
        {
            if (i == 1) Instantiate(SpeedPowerPrefab1, Powerpoint.position, Powerpoint.rotation);
            if (i == 2) Instantiate(SpeedPowerPrefab1, Powerpoint.position, Powerpoint.rotation);
            if (i == 3) Instantiate(SpeedPowerPrefab2, Powerpoint.position, Powerpoint.rotation);
            if (i == 4) Instantiate(SpeedPowerPrefab2, Powerpoint.position, Powerpoint.rotation);
            if (i == 5) Instantiate(SpeedPowerPrefab3, Powerpoint.position, Powerpoint.rotation);
            if (i == 6) Instantiate(SpeedPowerPrefab3, Powerpoint.position, Powerpoint.rotation);
            if (i == 7) Instantiate(SpeedPowerPrefab4, Powerpoint.position, Powerpoint.rotation);
            if (i == 8) Instantiate(SpeedPowerPrefab4, Powerpoint.position, Powerpoint.rotation);
            i++;
            if (i == 8) { i = 1; }
            Invoke("SpeedFix", 10.0f);
            PlayerSpeed.SpeedIncrease();
        }
        if (ShieldPowerOn)
        {
            
            Instantiate(ShieldPowerPrefab, Powerpoint.position, Powerpoint.rotation);
            Invoke("ShieldFix", 20.0f);
            
            
        }
        HealthCall.Shield(ShieldPowerOn);
        if (JumpPowerOn)
        {
            if(j==1)Instantiate(JumpPowerPrefab1, Powerpoint.position, Powerpoint.rotation);
            if (j == 2) Instantiate(JumpPowerPrefab1, Powerpoint.position, Powerpoint.rotation);
            if (j == 3) Instantiate(JumpPowerPrefab2, Powerpoint.position, Powerpoint.rotation);
            if (j == 4) Instantiate(JumpPowerPrefab2, Powerpoint.position, Powerpoint.rotation);
            if (j == 5) Instantiate(JumpPowerPrefab3, Powerpoint.position, Powerpoint.rotation);
            if (j == 6) Instantiate(JumpPowerPrefab3, Powerpoint.position, Powerpoint.rotation);
            if (j == 7) Instantiate(JumpPowerPrefab4, Powerpoint.position, Powerpoint.rotation);
            if (j == 8) Instantiate(JumpPowerPrefab4, Powerpoint.position, Powerpoint.rotation);
            if (j == 9) Instantiate(JumpPowerPrefab5, Powerpoint.position, Powerpoint.rotation);
            if (j == 10) Instantiate(JumpPowerPrefab5, Powerpoint.position, Powerpoint.rotation);
            if (j == 11) Instantiate(JumpPowerPrefab6, Powerpoint.position, Powerpoint.rotation);
            if (j == 12) Instantiate(JumpPowerPrefab6, Powerpoint.position, Powerpoint.rotation);
            if (j == 13) Instantiate(JumpPowerPrefab7, Powerpoint.position, Powerpoint.rotation);
            if (j == 14) Instantiate(JumpPowerPrefab7, Powerpoint.position, Powerpoint.rotation);
            if (j == 15) Instantiate(JumpPowerPrefab8, Powerpoint.position, Powerpoint.rotation);
            if (j == 16) Instantiate(JumpPowerPrefab8, Powerpoint.position, Powerpoint.rotation);
            if (j == 17) Instantiate(JumpPowerPrefab9, Powerpoint.position, Powerpoint.rotation);
            if (j == 18) Instantiate(JumpPowerPrefab9, Powerpoint.position, Powerpoint.rotation);
            if (j == 19) Instantiate(JumpPowerPrefab10, Powerpoint.position, Powerpoint.rotation);
            if (j == 20) Instantiate(JumpPowerPrefab10, Powerpoint.position, Powerpoint.rotation);
            if (j == 21) Instantiate(JumpPowerPrefab11, Powerpoint.position, Powerpoint.rotation);
            if (j == 22) Instantiate(JumpPowerPrefab11, Powerpoint.position, Powerpoint.rotation);
            if (j == 23) Instantiate(JumpPowerPrefab12, Powerpoint.position, Powerpoint.rotation);
            if (j == 24) Instantiate(JumpPowerPrefab12, Powerpoint.position, Powerpoint.rotation);
            if (j == 25) Instantiate(JumpPowerPrefab13, Powerpoint.position, Powerpoint.rotation);
            if (j == 26) Instantiate(JumpPowerPrefab13, Powerpoint.position, Powerpoint.rotation);
            if (j == 27) Instantiate(JumpPowerPrefab14, Powerpoint.position, Powerpoint.rotation);
            if (j == 28) Instantiate(JumpPowerPrefab14, Powerpoint.position, Powerpoint.rotation);
            if (j == 29) Instantiate(JumpPowerPrefab15, Powerpoint.position, Powerpoint.rotation);
            if (j == 30) Instantiate(JumpPowerPrefab15, Powerpoint.position, Powerpoint.rotation);
            if (j == 31) Instantiate(JumpPowerPrefab16, Powerpoint.position, Powerpoint.rotation);
            if (j == 32) Instantiate(JumpPowerPrefab16, Powerpoint.position, Powerpoint.rotation);
            if (j == 33) Instantiate(JumpPowerPrefab17, Powerpoint.position, Powerpoint.rotation);
            if (j == 34) Instantiate(JumpPowerPrefab17, Powerpoint.position, Powerpoint.rotation);
            if (j == 35) Instantiate(JumpPowerPrefab18, Powerpoint.position, Powerpoint.rotation);
            if (j == 36) Instantiate(JumpPowerPrefab18, Powerpoint.position, Powerpoint.rotation);
            if (j == 37) Instantiate(JumpPowerPrefab19, Powerpoint.position, Powerpoint.rotation);
            if (j == 38) Instantiate(JumpPowerPrefab19, Powerpoint.position, Powerpoint.rotation);
            if (j == 39) Instantiate(JumpPowerPrefab20, Powerpoint.position, Powerpoint.rotation);
            if (j == 40) Instantiate(JumpPowerPrefab20, Powerpoint.position, Powerpoint.rotation);
            if (j == 41) Instantiate(JumpPowerPrefab21, Powerpoint.position, Powerpoint.rotation);
            if (j == 42) Instantiate(JumpPowerPrefab21, Powerpoint.position, Powerpoint.rotation);
            if (j == 43) Instantiate(JumpPowerPrefab22, Powerpoint.position, Powerpoint.rotation);
            if (j == 44) Instantiate(JumpPowerPrefab22, Powerpoint.position, Powerpoint.rotation);
            if (j == 45) Instantiate(JumpPowerPrefab23, Powerpoint.position, Powerpoint.rotation);
            if (j == 46) Instantiate(JumpPowerPrefab23, Powerpoint.position, Powerpoint.rotation);
            if (j == 47) Instantiate(JumpPowerPrefab24, Powerpoint.position, Powerpoint.rotation);
            if (j == 48) Instantiate(JumpPowerPrefab24, Powerpoint.position, Powerpoint.rotation);
            Invoke("JumpFix", 20.0f);
            j++;
            if (j == 48) j = 1;
            PlayerJump.JumpIncrease();



        }
    }

    void SpeedFix()
    {
        PlayerSpeed.SpeedPower();
        SpeedPowerOn = false;
    }
    
    void ShieldFix()
    {
        ShieldPowerOn = false;

    }
    void JumpFix()
    {
        JumpPowerOn = false;
        PlayerJump.JumpDecrease();

    }
    public void SpeedPower()
    {

        SpeedPowerOn = true; ;
    }
    public void ShieldPower()
    {

        ShieldPowerOn = true; ;
    }

    public void JumpPower()
    {

        JumpPowerOn = true; ;
    }


}

    
