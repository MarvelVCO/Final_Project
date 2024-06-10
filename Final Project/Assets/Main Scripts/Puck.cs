using UnityEngine;

public class Puck : MonoBehaviour
{
    private Rigidbody rb;
    private Renderer rend;
    private Vector3 startPos;
    public float multiplier;
    public float disappearTime = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

        startPos = transform.position;

        rend.material.color = Random.ColorHSV();

        Invoke("Disappear", disappearTime);
    }

    public void Disappear()
    {
        Destroy(gameObject);
    }

    public float GetMultiplier()
    {
        return multiplier;
    }

    public void SetMultiplier(float value)
    {
        multiplier = value;
    }
}
