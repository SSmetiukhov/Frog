using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformScript : MonoBehaviour
{
    public float xMinRange = -1.7f;
    public float xMaxRange = 1.7f;

    public float yMinRange = 1f;
    public float yMaxRange = 2.7f;

    public float catepillarRate = 0.25f;

    public GameObject catepillarPrefab;

    public void Start()
    {
        if (Random.Range(0f, 1f) > 1 - catepillarRate)
        {
            Instantiate(catepillarPrefab, transform.position, Quaternion.identity);
        }

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "platform_prefab")
        {
            float randX = Random.Range(xMinRange, xMaxRange);
            float randY = Random.Range(transform.position.y + 15f, transform.position.y + 17f);

            transform.position = new Vector3(randX, randY, -1);
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.name == "DeadZone")
        {
            float randX = Random.Range(xMinRange, xMaxRange);
            float randY = Random.Range(transform.position.y + 15f, transform.position.y + 17);

            transform.position = new Vector3(randX, randY, -1);
        }
    }
}
