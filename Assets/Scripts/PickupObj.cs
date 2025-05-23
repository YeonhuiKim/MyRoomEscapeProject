using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item item;
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);

        gameObject.SetActive(false);
    }
}
