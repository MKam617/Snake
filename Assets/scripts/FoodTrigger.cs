using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrigger : MonoBehaviour
{
    [SerializeField] private GameObject newFood;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            Destroy(this.gameObject);
            Instantiate(newFood, new Vector3(Random.Range(-18f,18f),0.7f,0), Quaternion.identity);
        }
    }
}
