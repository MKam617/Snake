using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrigger : MonoBehaviour
{
    [SerializeField] private GameObject newFood;
    private Vector3 randomPos;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            randomPos = new Vector3(Random.Range(-18f,18f),0.7f,Random.Range(-18f,18f));
            Instantiate(newFood, randomPos, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
