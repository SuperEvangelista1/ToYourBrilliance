using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using TMPro; // Import for TextMeshPro support

public class PlayerInventory : MonoBehaviour
{
    public List<ObjectValue> inventory = new List<ObjectValue>();
    public TextMeshProUGUI inventoryText; // Reference to the UI text

    // Method to handle when the player picks up an object
    public void AddObject(string objectName)
    {
        // Check if the object is already in the inventory
        ObjectValue existingObject = inventory.Find(item => item.objectName == objectName);

        if (existingObject != null)
        {
            // If the object exists, increase its value (number of times it's picked up)
            existingObject.value++;
        }
        else
        {
            // If the object doesn't exist, create a new ObjectValue and add it to the list
            ObjectValue newObject = new ObjectValue(objectName);
            inventory.Add(newObject);
        }

        // Update the inventory UI
        UpdateInventoryUI();
    }

    // Method to update the UI text
    void UpdateInventoryUI()
    {
        inventoryText.text = "Inventory:\n";

        foreach (ObjectValue obj in inventory)
        {
            inventoryText.text += obj.objectName + " x" + obj.value + "\n";
        }
    }
}
