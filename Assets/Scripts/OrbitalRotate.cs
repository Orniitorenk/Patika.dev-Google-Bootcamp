using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalRotate : MonoBehaviour
{
    [SerializeField] int rotateMultiplier;
    void Update()
    {
        transform.Rotate(Vector3.up * rotateMultiplier * Time.deltaTime, Space.World);
    }
}
