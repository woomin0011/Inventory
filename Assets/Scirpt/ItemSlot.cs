using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public ItemData item;
    public UIInventory Inventory;
    public int index;
    public bool equpipped;

    [SerializeField] private Image icon;
    void Start()
    {
        ClearSlot();
    }
    public void SetItem(ItemData newItem)
    {
        item = newItem;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (item != null)
        {
            icon.sprite = item.icon;
            icon.enabled = true;
        }
        else
        {
            icon.sprite = null;
            icon.enabled = false;
        }
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
