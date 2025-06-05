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
        // itemList�� type�� ��ġ�ϴ� �������� �����Ͽ� ��ȯ
        foreach(Item item in itemListEntity.itemList)
        {
            if (item.type == type)
            {
                return new Item(item.type, item.sprite, item.zoomObj) ;
            }
        }
        return null;
    }

    public GameObject GetZoomItem(Item.Type type)
    {
        foreach(Item item in itemListEntity.itemList)
        {
            if (item.type == type)
            {
                return item.zoomObj;
            }
        }
        return null;
    }
}
