using UnityEngine;

public class FlyGenerator : MonoBehaviour
{
    public float xMinRange = -1.7f;
    public float xMaxRange = 1.7f;

    public float yMinRange = 1f;
    public float yMaxRange = 20f;
    
    public GameObject flyPrefab;

    
    void Start()
    {
        Vector3 spawnerPos = new Vector3();

        for (int i = 0; i < 3; i++)
        {
            spawnerPos.x = Random.Range(xMinRange, xMaxRange);
            spawnerPos.y = Random.Range(yMinRange, yMaxRange);
            spawnerPos.z = -1;

            Instantiate(flyPrefab, spawnerPos, Quaternion.identity);
        }
    }
    
}
