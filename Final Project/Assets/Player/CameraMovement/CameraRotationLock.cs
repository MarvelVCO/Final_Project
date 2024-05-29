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

    void Update()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Euler(Vector3.up * 30f);

    }
}