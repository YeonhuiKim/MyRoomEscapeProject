using UnityEngine;

public class SetObj : MonoBehaviour
{
    [SerializeField] GameObject setObj;
    [SerializeField] Item.Type keyItemType;

    // ������ ������ ������ ���¿���
    // �� ������Ʈ�� Ŭ���� ���
    public void OnClickThis()
    {
        bool solve = ItemBox.instance.TryUseItem(keyItemType);

        if (solve)
        {
            setObj.SetActive(true);
        }
    }
}
