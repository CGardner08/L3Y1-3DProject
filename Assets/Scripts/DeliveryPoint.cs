using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DeliveryPoint : MonoBehaviour
{
    public int foodDelivered; 

    void Start()
    {
        foodDelivered = GameManager.foodDelivered;
    }

private void OnTriggerEnter(Collider other) {

    if (gameObject.tag=="DeliveryPoint")
    {
        if (GameObject.Find("Car").GetComponent<CarController>().hasFood == true)
        {
            Debug.Log("Delivered");
            GameManager.foodDelivered++;

            GameObject.Find("Car").GetComponent<CarController>().hasFood = false;

            Destroy(gameObject);
        }
    }

    if (gameObject.tag=="Pickup")
    {
        if (GameObject.Find("Car").GetComponent<CarController>().hasFood == false)
        {
            GameObject.Find("Car").GetComponent<CarController>().hasFood = true;

            Destroy(gameObject);

        }
    }

        
}
}
