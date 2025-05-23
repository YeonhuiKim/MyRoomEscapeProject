using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{

    Item item;
    Image image;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }

    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    void UpdateImage(Item item)
    {
        // �������� ������ ���Կ� �̹��� ǥ��
        image.sprite = item.sprite;
    }
}
