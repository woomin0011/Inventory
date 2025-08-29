using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ItemData Itemdata;
    [SerializeField] private string playerName;
    [SerializeField] private int playerLevel;
    [SerializeField] private int playerHealth;
    [SerializeField] private int playerExperience;
    [SerializeField] private int playerAttack;
    [SerializeField] private int playerDefense;
    [SerializeField] private int playerCritical;
    [SerializeField] private int playerGold;

    public string PlayerName => playerName;
    public int PlayerLevel => playerLevel;
    public int PlayerHealth => playerHealth;
    public int PlayerExperience => playerExperience;
    public int PlayerAttack => playerAttack;
    public int PlayerDefense => playerDefense;
    public int PlayerCritical => playerCritical;

    public int PlayerGold => playerGold;

    private List<ItemData> inventory;
    private ItemData equippedItem;

    private void Awake()
    {
        inventory = new List<ItemData>();
    }

    public void AddItem(ItemData item)
    {
        inventory.Add(item);
    }
    public void EquipItem(ItemData item)
    {
        if (inventory.Contains(item))
        {
            // 장착 로직 구현
            Debug.Log($"Equipped item: {item.Name}");
        }
    }

    public void UnEquipItem(ItemData item)
    {
        if (inventory.Contains(item))
        {
            // 장착 해제 로직 구현
            Debug.Log($"Unequipped item: {item.Name}");
        }
    }

    public void Initialize(string playerName , int playerLevel , int playerHealth, int playerExperience, int playerGold , int attack , int defense,int critical)
    {
        this.playerName = playerName;
        this.playerLevel = playerLevel;
        this.playerHealth = playerHealth;
        this.playerExperience = playerExperience;
        this.playerGold = playerGold;
        this.playerAttack = attack;
        this.playerDefense = defense;
        this.playerCritical = critical;
    }

    public List<ItemData> GetInventory()
    {
        return inventory;
    }

    public ItemData GetEquippedItem()
    {
        return equippedItem;
    }
}
