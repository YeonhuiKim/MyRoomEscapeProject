using UnityEngine;

public class CameraZoomObj : MonoBehaviour
{
    [SerializeField] Camera zoomCamera;

    public void OnClickThis()
    {
        CameraManager.instance.SetZoomCamera(zoomCamera);
        Debug.Log("카메라 변경");
    }
}
