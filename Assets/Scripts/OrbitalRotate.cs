using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalRotate : MonoBehaviour
{
    [Header("Planet Variables")]
    [SerializeField] int rotateMultiplier;
    [SerializeField] int yearCounter;
    bool yearTrigger = true;
    [SerializeField] string planetName;

    void Update()
    {
        TurnAroundItself();
    }

    //If planet complete its full circle(year)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DayTrigger") && yearTrigger)
        {
            yearCounter++;
            yearTrigger = false;
            Debug.Log("I'm " + planetName +" and I complete " + yearCounter + " year.");
        }        
    }

    //Planet starts a new year.
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("DayTrigger"))
        {
            yearTrigger = true;
        }
    }

    //Rotate around itself
    private void TurnAroundItself()
    {
        transform.Rotate(Vector3.up * rotateMultiplier * Time.deltaTime, Space.World);
    }
}
