using UnityEngine;

public class CameraRotationLock : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float offsetAngle;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Euler(Vector3.right * -5f);

    }
}