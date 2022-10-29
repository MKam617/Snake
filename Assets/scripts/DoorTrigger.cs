using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private Rigidbody doorRB;
    [SerializeField] private float OpenForce = 1;
    [SerializeField] private GameObject Door;


    private void Awake()
    {
        doorRB = Door.GetComponent<Rigidbody>();
    }
    private void OnTrggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            doorRB.AddTorque(Vector3.right * OpenForce);
        }
    }
    private void OnTriggerExit(Collider other)
    {

    }
}
