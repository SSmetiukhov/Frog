using UnityEngine;
using Random = UnityEngine.Random;

public class FlyScript : MonoBehaviour
{
    public float xMinRange = -1.7f;
    public float xMaxRange = 1.7f;

    public float yMinRange = 1f;
    public float yMaxRange = 20f;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "FrogObject")
        {
            var randX = Random.Range(xMinRange, xMaxRange);
            var randY = Random.Range(yMinRange, yMaxRange);

            ScoreDisplay.AddScore(15);
            transform.position = new Vector3(randX, transform.position.y + randY, -1);
        }    
    }
    
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "DeadZone")
        {
            float randX = Random.Range(xMinRange, xMaxRange);
            float randY = Random.Range(yMinRange, yMaxRange);

            transform.position = new Vector3(randX, transform.position.y + randY, -1);
        }
    }
}
