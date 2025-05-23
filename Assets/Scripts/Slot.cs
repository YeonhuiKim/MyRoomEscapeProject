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
        // 아이템을 얻으면 슬롯에 이미지 표시
        image.sprite = item.sprite;
    }
}
