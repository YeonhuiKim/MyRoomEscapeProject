using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;

    private void Start()
    {
        // itemType�� ���� �������� ����
        item = ItemGenerator.instance.Spawn(itemType);

    }
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}
