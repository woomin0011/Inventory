using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private ItemSlot slotPrefab;  // 프리팹 연결
    [SerializeField] private Transform slotPanel;  // 슬롯 부모 Transform
    private List<ItemSlot> slotList = new List<ItemSlot>();

    public GameObject inventory;

    void Start()
    {
        InitInventoryUI();
    }
    public void InitInventoryUI()
    {
        List<ItemData> playerItems = GamaManager.Instance.Player.GetInventory();
        // 기존 슬롯 삭제
        foreach (var slot in slotList)
        {
            Destroy(slot.gameObject);
        }
        slotList.Clear();

        // 플레이어 인벤토리 가져오기
        List<ItemData> items = GamaManager.Instance.Player.GetInventory();

        // 슬롯 생성 및 아이템 배치
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
