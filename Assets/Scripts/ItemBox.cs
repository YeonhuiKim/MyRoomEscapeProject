using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;

    // 어디서든 실행 가능하도록
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // PickupObj가 클릭되면 아이템 슬롯으로
    public void SetItem(Item item)
    {
        foreach(Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
    }
}
