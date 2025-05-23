using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;

    // ��𼭵� ���� �����ϵ���
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
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
}
