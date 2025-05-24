using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{

    Item item;
    [SerializeField] Image image;
    [SerializeField] GameObject backgroundPanel;
    private void Start()
    {
        backgroundPanel.SetActive(false);
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

    public void HideBGPanel()
    {
        backgroundPanel.SetActive(false);
    }

    public bool OnSelect()
    {
        if (item == null)
        {
            return false;
        }
        backgroundPanel.SetActive(true);
        return true;
    }
   
}
