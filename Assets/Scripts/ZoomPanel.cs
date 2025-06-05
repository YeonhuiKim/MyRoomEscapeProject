using UnityEngine;
using UnityEngine.UI;

public class ZoomPanel : MonoBehaviour
{
    // 아이템 선택한 상태인지 검사

    [SerializeField] GameObject panel;
    [SerializeField] Transform objParent;
    GameObject zoomObj;

    public void ShowPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if (item != null)
        {
            Destroy(zoomObj);
            panel.SetActive(true);
            GameObject zoomObjPrefab = ItemGenerator.instance.GetZoomItem(item.type);
            zoomObj = Instantiate(zoomObjPrefab, objParent);

        }
    }

    public void HidePanel()
    {
        Destroy(zoomObj);
        panel.SetActive(false);
    }
}
