using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // 카메라 시점 변경
    // 정해둔 포지션으로 메인 카메라가 이동
    // 방을 회전하는 카메라, 줌(아이템 확대 표시)에 사용할 카메라 필요

    [SerializeField] Transform[] mainCameraPositions = default;

    int currentMainPosition;

    // 메인 카메라, 현재 카메라
    Camera mainCamera;
    Camera currentCamera;


    public static CameraManager instance;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        mainCamera = Camera.main;
        currentCamera = Camera.main;

        currentMainPosition = 0;
        currentCamera.transform.position = mainCameraPositions[currentMainPosition].position;
    }

    public void TurnLeft()
    {
        currentMainPosition--;
        if (currentMainPosition < 0)
        {
            currentMainPosition = mainCameraPositions.Length - 1;
        }
        currentCamera.transform.position = mainCameraPositions[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraPositions[currentMainPosition].rotation;
    }

    public void TurnRight()
    {
        currentMainPosition++;
        if (currentMainPosition >= mainCameraPositions.Length)
        {
            currentMainPosition = 0;
        }
        currentCamera.transform.position = mainCameraPositions[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraPositions[currentMainPosition].rotation;
    }

    public void SetZoomCamera(Camera camera)
    {
        currentCamera.gameObject.SetActive(false);
        camera.gameObject.SetActive(true);
        currentCamera = camera;
    }

    public void TurnBack()
    {
        mainCamera.gameObject.SetActive(true);
        currentCamera.gameObject.SetActive(false);
        currentCamera = mainCamera;
    }
}
