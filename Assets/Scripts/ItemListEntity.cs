using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class ItemListEntity : ScriptableObject
{
    public List<Item> itemList = new List<Item>();
}
