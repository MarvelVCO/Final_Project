using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckSpawner : MonoBehaviour
{
    public GameObject puckPrefab;
    public Camera mainCamera;
    private float baseSpawnCheckRadius = 2.5f;
    public string targetTag = "SpawnArea"; 

    void Update()
    {
        float spawnCheckRadius = baseSpawnCheckRadius * Stats.getPuckSize();
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag(targetTag))
                {
                    Vector3 spawnPosition = hit.point;

                    Collider[] colliders = Physics.OverlapSphere(spawnPosition, spawnCheckRadius);
                    bool canSpawn = true;
                    foreach (Collider collider in colliders)
                    {
                        if (collider.gameObject.CompareTag("Puck"))
                        {
                            canSpawn = false;
                            break;
                        }
                    }

                    if (canSpawn)
                    {
                        Quaternion rotation = Quaternion.Euler(-60f, 0f, 0f);

                        GameObject newPuck = Instantiate(puckPrefab, spawnPosition, rotation);

                        newPuck.transform.localScale *= Stats.getPuckSize();
                    }
                }
            }
        }
    }
}
