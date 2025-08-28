using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private ItemSlot slotPrefab;  // ������ ����
    [SerializeField] private Transform slotPanel;  // ���� �θ� Transform
    private List<ItemSlot> slotList = new List<ItemSlot>();

    public GameObject inventory;

    void Start()
    {
        InitInventoryUI();
    }
    public void InitInventoryUI()
    {
        List<ItemData> playerItems = GamaManager.Instance.Player.GetInventory();
        // ���� ���� ����
        foreach (var slot in slotList)
        {
            Destroy(slot.gameObject);
        }
        slotList.Clear();

        // �÷��̾� �κ��丮 ��������
        List<ItemData> items = GamaManager.Instance.Player.GetInventory();

        // ���� ���� �� ������ ��ġ
        for (int i = 0; i < items.Count; i++)
        {
            ItemSlot newSlot = Instantiate(slotPrefab, slotPanel);
            newSlot.SetItem(items[i]);
            newSlot.index = i;
            newSlot.Inventory = this;

            slotList.Add(newSlot);
        }
    }
}
