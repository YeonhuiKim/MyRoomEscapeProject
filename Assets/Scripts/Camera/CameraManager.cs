using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // ī�޶� ���� ����
    // ���ص� ���������� ���� ī�޶� �̵�
    // ���� ȸ���ϴ� ī�޶�, ��(������ Ȯ�� ǥ��)�� ����� ī�޶� �ʿ�

    [SerializeField] Transform[] mainCameraPositions = default;

    int currentMainPosition;

    // ���� ī�޶�, ���� ī�޶�
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
