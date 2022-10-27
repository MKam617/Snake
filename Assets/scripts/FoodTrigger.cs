using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrigger : MonoBehaviour
{
    [SerializeField] private GameObject newFood;
    private Vector3 randomFoodPos;

    [SerializeField] private GameObject AddNew_ScpitObj;
    private AddNew addNew;

    private void Awake()
    {
        addNew = AddNew_ScpitObj.GetComponent<AddNew>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            addNew.NewBall = true;
            randomFoodPos = new Vector3(Random.Range(-18f,18f),0.7f,Random.Range(-18f,18f)); // We have field 20x20
            Instantiate(newFood, randomFoodPos, Quaternion.identity);
            
            Destroy(this.gameObject);
        }
    }
}
