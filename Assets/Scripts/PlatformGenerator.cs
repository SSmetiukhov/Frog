
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platformPrefab;

    public float xMinRange = -1.7f;
    public float xMaxRange = 1.7f;

    public float yMinRange = 0.8f;
    public float yMaxRange = 2.2f;

    private void Start()
    {
        Instantiate(platformPrefab, new Vector2(1,1), Quaternion.identity );

        
        Vector3 spawnerPos = new Vector3(0,0,0);

        for (int i = 0; i < 10; i++)
        {
            spawnerPos.x = Random.Range(xMinRange, xMaxRange);
            spawnerPos.y += Random.Range(yMinRange, yMaxRange);
            spawnerPos.z = -1;

            Instantiate(platformPrefab, spawnerPos, Quaternion.identity );
        }
    }
}
