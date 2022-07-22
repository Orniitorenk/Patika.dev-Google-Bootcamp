using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    [SerializeField] private Transform[] planets;
    [SerializeField] private float speedModifier;
    [SerializeField] private GameObject impactEffect;



    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Venus").transform.position , speedModifier * Time.deltaTime);        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            ContactPoint contact = collision.GetContact(0);
            Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, contact.normal);
            Vector3 position = contact.point;
            Instantiate(impactEffect, position, rotation);
            Destroy(this.gameObject);
        }
    }

}
