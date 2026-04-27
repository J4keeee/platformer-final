using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class LootItem
{
    public GameObject itemPrefab;
    [Range(0, 100)] public float dropChance;
}
