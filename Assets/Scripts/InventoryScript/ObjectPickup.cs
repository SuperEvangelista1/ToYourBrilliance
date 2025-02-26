using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour
{
    // Reference to the player's inventory (assume PlayerInventory is attached to the player)
    public PlayerInventory playerInventory;

    // The name of the object to be added to the inventory
    public string objectName;

    // On trigger, when player collides with the object
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if the collider belongs to the player
        {
            // Add the object to the player's inventory
            playerInventory.AddObject(objectName);

            // Destroy the object after it has been picked up
            Destroy(gameObject);
        }
    }
}
