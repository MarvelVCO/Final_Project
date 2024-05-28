using UnityEngine;

public class CameraRotationLock : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float offsetAngle;

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + player.rotation * offset;

        // Calculate the desired rotation based on the offset angle and the player's forward direction
        Quaternion desiredRotation = Quaternion.LookRotation(player.forward, Vector3.up) * Quaternion.Euler(offsetAngle, 0f, 0f);

        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 10f);
        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, Time.deltaTime * 10f);
    }
}