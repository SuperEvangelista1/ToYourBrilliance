using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI statusText;
    public GameObject inventoryPanel;
    public GameObject mapPanel;
    public GameObject encyclopediaPanel;


    private int currentIndex = 0;
    private string[] modes = { "Inventory", "Map", "Encyclopedia" };
    private GameObject[] panels;

    void Start()
    {
        panels = new GameObject[] { inventoryPanel, mapPanel, encyclopediaPanel };

        foreach (GameObject panel in panels)
        {
            if (panel != null) panel.SetActive(false);
        }
        if (statusText != null) statusText.gameObject.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            FindObjectOfType<ShopManager>().ToggleShop();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleUI();
        }
        if (statusText.gameObject.activeSelf)
        {
            FindObjectOfType<Movement>().canMove = false;
            if (Input.GetKeyDown(KeyCode.A))
            {
                SwitchMode(-1);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                SwitchMode(1);
            }
        }
        else
        {
            FindObjectOfType<Movement>().canMove = true;
        }
        FindObjectOfType<PlayerInventory>().UpdateInventoryUI();
    }

    void ToggleUI()
    {
        bool isActive = statusText.gameObject.activeSelf;
        statusText.gameObject.SetActive(!isActive);
        panels[currentIndex].SetActive(!isActive);

        if (!isActive)
        {
            UpdateUI();
        }
    }

    void SwitchMode(int direction)
    {
        if (panels[currentIndex] != null)
        {
            panels[currentIndex].SetActive(false);
        }

        currentIndex = (currentIndex + direction + modes.Length) % modes.Length;

        if (statusText != null)
        {
            statusText.text = "Current Mode: " + modes[currentIndex];
        }

        if (panels[currentIndex] != null)
        {
            panels[currentIndex].SetActive(true);
        }
    }

    void UpdateUI()
    {
        if (statusText != null)
        {
            statusText.text = "Current Mode: " + modes[currentIndex];
        }
    }

   
}
