using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public List<ObjectValue> inventory = new List<ObjectValue>();
    public TextMeshProUGUI inventoryText;
    public GameObject inventoryPanel;

    // Ìí¼ÓÎïÆ·
    public void AddObject(string objectName)
    {
        ObjectValue existingObject = inventory.Find(item => item.objectName == objectName);

        if (existingObject != null)
        {
            existingObject.value++;
        }
        else
        {
            inventory.Add(new ObjectValue(objectName));
        }

        UpdateInventoryUI();
    }

    public void UpdateInventoryUI()
    {
        if (!inventoryPanel.activeSelf) return;

        inventoryText.text = "";
        foreach (ObjectValue obj in inventory)
        {
            inventoryText.text += obj.objectName + " x" + obj.value + "\n";
        }
    }
}