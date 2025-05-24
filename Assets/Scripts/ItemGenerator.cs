using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] ItemListEntity itemListEntity;

    public static ItemGenerator instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public Item Spawn(Item.Type type)
    {
        // itemList중 type과 일치하는 아이템을 생성하여 반환
        foreach(Item item in itemListEntity.itemList)
        {
            if (item.type == type)
            {
                return new Item(item.type, item.sprite) ;
            }
        }
        return null;
    }
}
