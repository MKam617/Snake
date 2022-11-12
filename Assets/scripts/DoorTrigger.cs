using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private GameObject Door;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Door.GetComponent<Animator>().SetBool("open", true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Door.GetComponent<Animator>().SetBool("open", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Door.GetComponent<Animator>().SetBool("open", false);
        }
=======
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

>>>>>>> cfdd48e7aaec03b062a3092cee82d9f6e9f9065d
    }
}
