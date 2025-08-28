using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Weapon,
    Armor,
    Consumable,
}
public enum ConsumableType
{
    Health
}

[Serializable]
public class ItemDataConsumale
{
    public ConsumableType type;
    public float value;
}
[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string Name;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;


    [Header("Consumable")]
    public ItemDataConsumale[] consumables;
}
