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
    private PlayerController playerController;

    private int currentIndex = 0;
    private string[] modes = { "Inventory", "Map", "Encyclopedia" };
    private GameObject[] panels;

    void Start()
    {
        panels = new GameObject[] { inventoryPanel, mapPanel, encyclopediaPanel };
        playerController = FindObjectOfType<PlayerController>();

        foreach (GameObject panel in panels)
        {
            if (panel != null) panel.SetActive(false);
        }
        if (statusText != null) statusText.gameObject.SetActive(false);

        if (playerController != null)
        {
            playerController.canMove = true; // 确保游戏开始时可以移动
        }


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleUI();
        }
        if (statusText.gameObject.activeSelf) 
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SwitchMode(-1);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                SwitchMode(1);
            }
        }
    }

    void ToggleUI()
    {
        bool isActive = statusText.gameObject.activeSelf; // UI 当前状态
        statusText.gameObject.SetActive(!isActive);
        panels[currentIndex].SetActive(!isActive);

        if (playerController != null)
        {
            playerController.canMove = !isActive;
            Debug.Log("UI Toggled. Player canMove: " + playerController.canMove);
        }

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
