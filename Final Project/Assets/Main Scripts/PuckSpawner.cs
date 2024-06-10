using UnityEngine;

public class PuckSpawner : MonoBehaviour
{
    public GameObject puckPrefab;
    public Transform spawnPoint;

    public void SpawnPuck(float multiplier)
    {
        float randomX = Random.Range(spawnPoint.position.x - 15f, spawnPoint.position.x + 15f);

        Quaternion rotation = Quaternion.Euler(-70f, 0f, 0f);

        GameObject newPuck = Instantiate(puckPrefab, new Vector3(randomX, spawnPoint.position.y, spawnPoint.position.z), rotation);
        Puck puckScript = newPuck.GetComponent<Puck>();

        if (puckScript != null)
        {
            puckScript.SetMultiplier(multiplier);
        }
    }
}
