using UnityEngine;

public class SampleQuest : MonoBehaviour
{
    // 오브젝트 상호작용 테스트
    // 키 아이템 선택한 상태에서 실린더를 클릭할 경우 -> 실린더가 사라지도록
    // 클릭 판정 + 아이템 선택 여부 판정

    [SerializeField] Item.Type keyItemType;

    public void OnClickObj()
    {
        // cube를 선택한 상태인지
        bool solve = ItemBox.instance.TryUseItem(keyItemType);
        if (solve)
        {
            gameObject.SetActive(false);
        }
    }
}
