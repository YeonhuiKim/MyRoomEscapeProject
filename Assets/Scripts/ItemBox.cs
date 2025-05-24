using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    Slot selectedSlot = null;

    // 어디서든 실행 가능하도록
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<Slot>();
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

    public void OnSelectSlot(int position)
    {
        foreach(Slot slot in slots)
        {
            slot.HideBGPanel();
        }

        if (slots[position].OnSelect())
        {
            selectedSlot = slots[position];
        }
        else
        {
            selectedSlot = null;
        }
        
    }
}
