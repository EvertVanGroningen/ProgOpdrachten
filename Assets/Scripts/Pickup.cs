using Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pickup : MonoBehaviour
{

    public static event Action GetPickup;
    void OnCollisionEnter(Collision bump)
    {
        if (bump.gameObject.name == "Player")
        {
            Debug.Log("aanraaking");
            GetPickup?.Invoke();
            Destroy(gameObject);
        }
    }
    
}
