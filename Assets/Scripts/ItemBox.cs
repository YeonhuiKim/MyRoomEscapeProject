using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    Slot selectedSlot = null;

    // ��𼭵� ���� �����ϵ���
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<Slot>();
        }
    }

    // PickupObj�� Ŭ���Ǹ� ������ ��������
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
