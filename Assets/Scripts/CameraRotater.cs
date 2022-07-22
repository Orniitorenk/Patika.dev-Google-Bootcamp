using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotater : MonoBehaviour
{
    [Header("Speed variables")]
    public float speed; // Camera rotate speed

    [Header("Booleans")]
    public bool isClicked = false;

    private void Update()
    {
        if (!isClicked)
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
        else
        {
            
        }
     
    }


}
