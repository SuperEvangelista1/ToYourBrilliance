using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Panel;

    private UnityEngine.UI.Text inventoryText;

    public void AddItemToInventory(string itemName)
    {
        inventoryText.text += "\n" + itemName;  // Adds the item name to the inventory text
    }


}
