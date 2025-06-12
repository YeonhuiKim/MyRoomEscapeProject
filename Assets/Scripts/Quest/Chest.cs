using UnityEngine;

public class Chest : MonoBehaviour
{

    public void Open()
    {
        GetComponent<Animation>().Play();
    }
}
