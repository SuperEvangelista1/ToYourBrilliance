using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ShopManager : MonoBehaviour
{
    public GameObject shopPanel;
    public TextMeshProUGUI playerGoldText;
    public GameObject itemButtonPrefab;
    public Transform itemListContent;

    public List<ShopItem> shopItems = new List<ShopItem>();
    public PlayerInventory playerInventory;

    private int playerGold = 100;

    void Start()
    {
        shopPanel.SetActive(false);
        UpdateGoldUI();
        GenerateShopItems();
    }

    public void ToggleShop()
    {
        shopPanel.SetActive(!shopPanel.activeSelf);
        FindObjectOfType<Movement>().canMove = !shopPanel.activeSelf;
    }

    void UpdateGoldUI()
    {
        playerGoldText.text = "Gold: " + playerGold;
    }

    void GenerateShopItems()
    {
        foreach (ShopItem item in shopItems)
        {
            GameObject buttonObj = Instantiate(itemButtonPrefab, itemListContent);
            buttonObj.GetComponentInChildren<TextMeshProUGUI>().text = $"{item.itemName} - {item.price}G";
            buttonObj.GetComponent<Button>().onClick.AddListener(() => BuyItem(item));
        }
    }

    public void BuyItem(ShopItem item)
    {
        if (playerGold >= item.price)
        {
            playerGold -= item.price;
            playerInventory.AddObject(item.itemName);
            UpdateGoldUI();
        }
        else
        {
            Debug.Log("Not enough gold!");
        }
    }
}
