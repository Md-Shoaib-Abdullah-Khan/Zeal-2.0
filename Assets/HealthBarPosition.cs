using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarPosition : MonoBehaviour
{
    public Transform CameraPosition;
    public Transform BarPosition;

    void Update()
    {
        BarPosition.position = CameraPosition.position;
    }
}
