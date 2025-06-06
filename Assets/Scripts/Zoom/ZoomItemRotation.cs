using UnityEngine;

public class ZoomItemRotation : MonoBehaviour
{
    [SerializeField] Transform parent;
    float k = 500f;
    
    void Update()
    {
        if (Input.GetMouseButton(0)){
            float x = - Input.GetAxis("Mouse X") * Time.deltaTime * k;
            float y = Input.GetAxis("Mouse Y") * Time.deltaTime * k;

            // RotateAround(중심, 축, 회전 각도)
            // Quaternion.Euler(parent.rotation.eulerAngles) : parent만큼 보정을 위함
            transform.RotateAround(transform.position, Quaternion.Euler(parent.rotation.eulerAngles) * Vector3.up, x);
            transform.RotateAround(transform.position, Quaternion.Euler(parent.rotation.eulerAngles) * Vector3.right, y);
        }

    }
}
