using UnityEngine;

public class SampleQuest : MonoBehaviour
{
    // ������Ʈ ��ȣ�ۿ� �׽�Ʈ
    // Ű ������ ������ ���¿��� �Ǹ����� Ŭ���� ��� -> �Ǹ����� ���������
    // Ŭ�� ���� + ������ ���� ���� ����

    [SerializeField] Item.Type keyItemType;

    public void OnClickObj()
    {
        // cube�� ������ ��������
        bool solve = ItemBox.instance.TryUseItem(keyItemType);
        if (solve)
        {
            gameObject.SetActive(false);
        }
    }
}
