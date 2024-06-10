using UnityEngine;

public class PegPlacer : MonoBehaviour
{
    public GameObject pegPrefab;
    public int rows = 5;
    public int columns = 5;
    public float spacing = 1.0f;

    void Start()
    {
        PlacePegs();
    }

    void PlacePegs()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector3 position = new Vector3(col * spacing, 0, row * spacing);
                Instantiate(pegPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}
