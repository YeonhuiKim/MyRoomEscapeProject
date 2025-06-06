using UnityEngine;

public class SetObj : MonoBehaviour
{
    [SerializeField] GameObject setObj;
    [SerializeField] Item.Type keyItemType;

    // 적절한 아이템 선택한 상태에서
    // 이 오브젝트를 클릭할 경우
    public void OnClickThis()
    {
        bool solve = ItemBox.instance.TryUseItem(keyItemType);

        if (solve)
        {
            setObj.SetActive(true);
        }
    }
}
