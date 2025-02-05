using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public string itemName = "Placeholder Item";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PanelScript inventory = FindObjectOfType<PanelScript>();
            inventory.AddItemToInventory(itemName);

            Destroy(gameObject);
        }
    }
}
